using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminho_Minimo
{
    public class Enlace
    {
        private string _origem;
        private string _destino;
        private int _distancia;
        private int _custo;

        public Enlace(string origem, string destino, int distancia, int custo)
        {
            _origem = origem;
            _destino = destino;
            _distancia = distancia;
            _custo = custo;
        }


        public string get_origem()
        {
            return _origem;
        }

        public void set_origem(string origem)
        {
            _origem = origem;
        }

        public string get_destino()
        {
            return _destino;
        }

        public void set_destino(string destino)
        {
            _destino = destino;
        }

        public int get_distancia()
        {
            return _distancia;
        }

        public void set_distancia(int distancia)
        {
            _distancia = distancia;
        }

        public int get_custo()
        {
            return _custo;
        }

        public void set_custo(int custo)
        {
            _custo = custo;
        }

    }
}
