using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminho_Minimo
{
    public class Grafo
    {
        /* Cria uma  lista ordenada dos vertices */
        private SortedDictionary<string, Vertice> vertices = new SortedDictionary<string, Vertice>();

        /* Método para Inserir Vertices*/
        public void inserir_vertice(string id)
        {
            Vertice vertice = new Vertice(id);
            vertices[id] = vertice;
        }

        /* Método para inserir arestas e sua devida métrica */
        public void inserir_aresta(string de, string para, int metrica)
        {
            /* Busca a vertice de origem e de destino da Lista*/
            Vertice p = vertices[para];
            Vertice d = vertices[de];

            /* Informa qual é a vertice adjacente a vertice "de" e sua devida metrica */

            vertices[de].inserir_vertice_adjacente(p, metrica);
            /* Se o grafpo não é direcionado, já faz o direcionamento inverso */
            /* Exemplo: Se estamos fazendo da vertice Santo André para Maua com métrica 2, se não é direcionado já faz que de Maua para Santo André também é métrica2 */
            vertices[para].inserir_vertice_adjacente(d, metrica);
        }

        /* Método para buscar na lista determinada vertice */
        public Vertice get_vertice(string id)
        {
            if (vertices.ContainsKey(id))
            {
                return vertices[id];
            }
            else
            {
                return null;
            }
        }

        /* Método para retornar a lista de vertices ordenadas */
        public SortedDictionary<string, Vertice> get_vertices()
        {
            return vertices;
        }

        /* Método para gravar as vertices na lista ordenada */
        public void set_vertices(SortedDictionary<string, Vertice> cid)
        {
            vertices = cid;
        }
    }


}
