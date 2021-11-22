using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimVIIMPV.Modelo
{
    public class Pessoa
    {
        private string id;
        private string nome;
        private string cpf;

        public string getId() {
            return id;
        }

        public void setId(string idvalue)
        {
            this.id = idvalue;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string Nomevalue)
        {
            this.nome = Nomevalue;
        }

        public string getcpf()
        {
            return cpf;
        }
        public void setcpf(string cpfvalue)
        {
            this.cpf = cpfvalue;
        }
    }
}