using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Caminho_Minimo
{
    public partial class frmGrafo : Form
    {
        // variavel de lista de cidades;
        List<Cidade> lista_cidades;
        // variavel de lista de enlaces
        List<Enlace> lista_enlaces = new List<Enlace>();


        static void inicializar(Grafo g, Vertice vertice)
        {
            foreach (KeyValuePair<string, Vertice> v in g.get_vertices())
            {
                v.Value.set_metrica(int.MaxValue);
            }
            vertice.set_metrica(0);
        }

        /* pegar o menor valor entre os caminhos adjacentes */
        static Vertice minimo(SortedDictionary<string, Vertice> Q)
        {
            var key = Q.Keys.ToList()[0];
            Vertice min = Q[key];
            foreach (KeyValuePair<string, Vertice> v in Q)
            {
                if (v.Value.get_metrica() < min.get_metrica())
                {
                    min = v.Value;
                }
            }
            Q.Remove(min.get_id());
            return min;
        }

        /* Compara se a metrica entre as duas vertices e armazenaa a metrica ate aquela vertice, caso o caminho seja menor */
        static void relax(Vertice u, Vertice v)
        {

            int metrica = u.get_metrica() + u.get_peso(v);

            if (v.get_metrica() > metrica)
            {
                v.set_metrica(metrica);
                v.set_vertice_caminho_anterior(u);

            }
        }

        static void add_S(Vertice u, SortedDictionary<string, Vertice> S)
        {
            Vertice vertice;
            if (S.TryGetValue(u.get_id(), out vertice))
            {
                vertice = u;
            }
            else
            {
                S.Add(u.get_id(), u);
            }
        }

        /* Busca o caminho para se chegar até determinado destino */
        static void calcula_caminho(Vertice destino, ArrayList caminho)
        {
            if (caminho.Count == 0)
            {
                caminho.Add(destino);
            }
            while (destino.get_vertice_caminho_anterior() != null)
            {
                caminho.Add(destino.get_vertice_caminho_anterior());
                destino = destino.get_vertice_caminho_anterior();
            }
        }

        /* Imprme o caminho até determinado vertice e seu peso */
        public void imprime_caminho(ArrayList caminho, Vertice origem, Vertice destino, string escolha_metrica)
        {
            txtResultado.Text = null;
            txtResultado.AppendText("Caminho Mínimo considerando: " + escolha_metrica + "\r\n");
            txtResultado.AppendText("O caminho mínimo é: \r\n");

            for (int i = caminho.Count - 1; i >= 0; i--)
            {
                Vertice vertice = (Vertice)caminho[i];
                txtResultado.AppendText(vertice.get_id() + " (Custo Acumulado: " + vertice.get_metrica() + ") \r\n");
            }
            txtResultado.AppendText("Custo Total:  " + destino.get_metrica()+"\r\n");
        }


        /* Algoritmo Dijkstra */
        public static void Dijkstra(Grafo g, Vertice s)
        {
            SortedDictionary<string, Vertice> Q = new SortedDictionary<string, Vertice>();

            inicializar(g, s);

            Q = g.get_vertices();

            SortedDictionary<string, Vertice> S = new SortedDictionary<string, Vertice>();

            while (Q.Count > 0)
            {

                Vertice u = minimo(Q);

                u.set_visitado(true);

                foreach (KeyValuePair<Vertice, int> v in u.get_adjacentes())
                {
                    if (v.Key.get_visitado() == true)
                    {
                        continue;
                    }
                    relax(u, v.Key);
                }
                add_S(u, S);
            }

            /* S tem os pesos finais de caminho mínimos a partir da fonte determinada, assim atualiza o grafo 
             * com os vértices atualizados*/
            g.set_vertices(S);
        }

        public frmGrafo()
        {
            InitializeComponent();
        }

        private void FrmGrafo_Load(object sender, EventArgs e)
        {
            // neste ponto será populaldo a lista de cidades via banco de dados, por enquanto virá fixo
            lista_cidades = new List<Cidade>();
            lista_cidades.Add(new Cidade("SP", "São Paulo"));
            lista_cidades.Add(new Cidade("RJ", "Rio de Janeiro"));
            lista_cidades.Add(new Cidade("MG", "Minas Gerais"));
            lista_cidades.Add(new Cidade("BA", "Bahia"));
            lista_cidades.Add(new Cidade("CE", "Ceará"));

            // populando os combo de Cidade de Origem e Destino
            foreach (var lista in lista_cidades)
                cmbOrigem.Items.Add(lista.get_sigla());

            foreach (var lista in lista_cidades)
                cmbDestino.Items.Add(lista.get_sigla());

            foreach (var lista in lista_cidades)
                cmbFalha.Items.Add(lista.get_sigla());

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = null;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if ((cmbOrigem.Text == "") || (cmbDestino.Text == ""))
            {
                MessageBox.Show("É preciso selecionar uma Origem/Destino!", "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return;
            }
            if (cmbOrigem.Text == cmbDestino.Text )
            {
                MessageBox.Show("A origem e Destino devem ser diferentes!", "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return;
            }

            if (ckFalha.Checked && cmbFalha.Text =="")
            {
                MessageBox.Show("Deve ser selecionado um local de falha!", "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                return;
            }


            Grafo grafo = new Grafo();

            // Cria uma lista para gravar o caminho
            ArrayList caminho = new ArrayList();
            // Cria um obejto para armazenar a vertice de origem e Destino
            Vertice origem;
            Vertice vertice_alvo;

            string escolha_metrica;
            if ((rdDistancia.Checked) == true)
            {
                escolha_metrica = "DISTANCIA";
            }
            else
            {
                escolha_metrica = "CUSTO";
            }

            // neste ponto será populaldo a lista de enlace via banco de dados, por enquanto virá fixo
            lista_enlaces.Add(new Enlace("SP", "RJ", 10, 2));
            lista_enlaces.Add(new Enlace("SP", "MG", 3, 1));
            lista_enlaces.Add(new Enlace("RJ", "MG", 1, 4));
            lista_enlaces.Add(new Enlace("RJ", "BA", 2, 1));
            lista_enlaces.Add(new Enlace("MG", "RJ", 4, 1));
            lista_enlaces.Add(new Enlace("MG", "BA", 8, 6));
            lista_enlaces.Add(new Enlace("MG", "CE", 30, 1));
            lista_enlaces.Add(new Enlace("BA", "CE", 7, 3));

            // usa o foreach para pegar cada Cidade contida na lista de Cidades e insere o vertice
            foreach (Cidade cidade in lista_cidades)
            {

                grafo.inserir_vertice(cidade.get_sigla());
            }
            // pega cada uma das enlaces e joga no grafo
            foreach (Enlace enlace in lista_enlaces)
            {
                // se a metrica escolhida for ditancia, insere na metrica a distancia, caso contratio insere custo 
                // no trabalho tem tres,, precisa colocar a outra ainda na classse enlace mudar este if
                if ((ckFalha.Checked == false) || ((ckFalha.Checked == true && (enlace.get_origem() != cmbFalha.Text && enlace.get_destino() != cmbFalha.Text))))
                {
                    if (escolha_metrica == "DISTANCIA")
                    {
                        grafo.inserir_aresta(enlace.get_origem(), enlace.get_destino(), enlace.get_distancia());
                    }
                    else
                    {
                        grafo.inserir_aresta(enlace.get_origem(), enlace.get_destino(), enlace.get_custo());
                    }
                }

            }

            // Inicializa o caminho como em branco
            caminho = new ArrayList();
            // Define a origem e destino a ser avaliado
            origem = grafo.get_vertice(cmbOrigem.Text);
            vertice_alvo = grafo.get_vertice(cmbDestino.Text);

            // Chama o algoritimo que vai gravar o caminho
            Dijkstra(grafo, origem);

            // Com base no algorito que gravou na variavel caminho, calcula o custo para chegar a tal local (de acordo com a metrica)
            calcula_caminho(vertice_alvo, caminho);

            // Se for maior que zero o custo imprime o caminho encontrado
            if (caminho.Count > 0)
            {
                imprime_caminho(caminho, origem, vertice_alvo, escolha_metrica);
            }





        }

        private void CkFalha_CheckedChanged(object sender, EventArgs e)
        {
            cmbFalha.Enabled = (ckFalha.Checked);
        }
    }
}
