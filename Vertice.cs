using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminho_Minimo
{
    public class Vertice
    {
        private string _id = String.Empty;
        private Dictionary<Vertice, int> arestas = new Dictionary<Vertice, int>();
        private int _metrica = 0;
        private Boolean _visitado = false;
        private Vertice _vertice_anterior = null;

        /* Construtor da Classe Vertice onde se define um ID do vertice*/
        public Vertice(string id)
        {
            _id = id;
        }

        /* Método para buscar a id da vertice */
        public string get_id()
        {
            return _id;
        }

        /* Insere a aresta ligando dois vértices e sua devida métrica */
        public void inserir_vertice_adjacente(Vertice destino, int metrica)
        {
            arestas[destino] = metrica;
        }

        /* Método para buscar os adjacentes ligada ao Vertice corrente (vizinhos)*/
        public Dictionary<Vertice, int> get_adjacentes()
        {
            var dicaux = arestas.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return dicaux;
        }

        /* Método para gravar a métrica relacionada a aresta */
        public void set_metrica(int metrica)
        {
            _metrica = metrica;
        }

        /* Método para buscar a métrica relacionada a aresta */
        public int get_metrica()
        {
            return _metrica;
        }

        /* Método para buscar o salto relacionada ao Vértice */
        public int get_peso(Vertice vertice)
        {
            return arestas[vertice];
        }

        /* Método para informar que aquele caminho já foi visitado, será usado par aimpedir que se percorra caminhos já visitados */
        public void set_visitado(Boolean visitado)
        {
            _visitado = visitado;
        }

        /* Método para verificar que aquele caminho já foi visitado, será usado par aimpedir que se percorra caminhos já visitados */
        public Boolean get_visitado()
        {
            return _visitado;
        }

        /* Método para gravar qual o caminho anterior ao que esta sendo analisado, será usado para que se veja que este caminho é maior, ele pare e votle para onde comecou */
        public void set_vertice_caminho_anterior(Vertice vertice)
        {
            _vertice_anterior = vertice;
        }

        /* Método para buscar qual o caminho anterior ao que esta sendo analisado, será usado para que se veja que este caminho é maior, ele pare e votle para onde comecou */
        public Vertice get_vertice_caminho_anterior()
        {
            return _vertice_anterior;
        }
    }

}
