using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimVIIMPV.Modelo
{
    public class Endereco
    {
        private string IDend;
        private string logradouro;
        private string numero;
        private string cep;
        private string bairro;
        private string cidade;
        private string estado;

        //====================================================
        //Getters
        //====================================================
        public string getIDend()
        {
            return IDend;
        }

        public string getlogradouro()
        {
            return logradouro;
        }

        public string getnumero()
        {
            return numero;
        }

        public string getcep()
        {
            return cep;
        }
        public string getbairro()
        {
            return bairro;
        }
        public string getcidade()
        {
            return cidade;
        }
        public string getestado()
        {
            return estado;
        }

        //====================================================
        //Setters
        //====================================================
        public void setIDend(string IDendvalue)
        {
            this.IDend = IDendvalue;
        }
        public void setlogradouro(string logradourovalue)
        {
            this.logradouro = logradourovalue;
        }
        public void setnumero(string numerovalue)
        {
            this.numero = numerovalue;
        }
        public void setcep(string cepvalue)
        {
            this.cep = cepvalue;
        }
        public void setbairro(string bairrovalue)
        {
            this.bairro = bairrovalue;
        }

        public void setcidade(string cidadevalue)
        {
            this.cidade = cidadevalue;
        }

        public void setestado(string estadovalue)
        {
            this.estado = estadovalue;
        }
    }
}