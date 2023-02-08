using System;
using System.Collections.Generic;

namespace Caminho_Minimo
{
    public class Cidade
    {
        private string _sigla;
        private string _nome;

        public Cidade(string sigla, string nome)
        {
            _sigla = sigla;
            _nome = nome;
        }

        public string get_sigla()
        {
            return _sigla;
        }

        public void set_sigla(string sigla)
        {
            _sigla = sigla;
        }

        public string get_nome()
        {
            return _nome;
        }

        public void set_nome(string nome)
        {
            _nome = nome;
        }

    }

}
