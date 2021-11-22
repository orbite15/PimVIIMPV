using PimVIIMPV.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;
using System.Windows;
using MySql.Data.MySqlClient;

namespace PimVIIMPV.Dao
{
    public class PessoaDAO
    {
        //==================================================================================
        //Classe - Conexão com banco MySQL
        //==================================================================================
        public void inserePessoa(string nome, string cpf,string logradouro, string numero,string cep, string bairro, string cidade, string estado) { 
        
        string myConnectionString;

        myConnectionString = "server=localhost;uid=root;" +
                "pwd=13052013;database=db_pessoa";

            try
            {
                MySqlConnection myConnectionend = new MySqlConnection(myConnectionString);
                string myInsertQueryend = $"INSERT INTO tb_endereco (logradouro,numero,cep,bairro,cidade,estado) Values('{logradouro}',{numero},{cep},'{bairro}','{cidade}','{estado}');";
                MySqlCommand myCommandend = new MySqlCommand(myInsertQueryend);
                myCommandend.Connection = myConnectionend;
                myConnectionend.Open();
                myCommandend.ExecuteNonQuery();
                myCommandend.Connection.Close();

                MySqlConnection myConnectionpes = new MySqlConnection(myConnectionString);
                string myInsertQuerypes = $"INSERT INTO tb_pessoa (nome,cpf,FK_id_end) Values('{nome}',{cpf},(select max(ID) from tb_endereco))";
                MySqlCommand myCommandpes = new MySqlCommand(myInsertQuerypes);
                myCommandpes.Connection = myConnectionpes;
                myConnectionpes.Open();
                myCommandpes.ExecuteNonQuery();
                myCommandpes.Connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }
        //==================================================================================
        //Classe - Deleta dados
        //==================================================================================
        public void deletaPessoa(string id)
        {

            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;" +
                    "pwd=13052013;database=db_pessoa";

            try
            {
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myDeleteQuery =  $"DELETE FROM db_pessoa.tb_endereco, db_pessoa.tb_pessoa " +
                    $"USING db_pessoa.tb_pessoa " +
                    $"INNER JOIN db_pessoa.tb_endereco " +
                    $"WHERE tb_endereco.ID = tb_pessoa.FK_id_end " +
                    $"AND tb_pessoa.ID = {id}";
                MySqlCommand myCommand = new MySqlCommand(myDeleteQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }
        public void alteraPessoa(string id,string nome, string cpf, string logradouro, string numero, string cep, string bairro, string cidade, string estado)
        {

            string myConnectionString;

            myConnectionString = "server=localhost;uid=root;" +
                    "pwd=13052013;database=db_pessoa";

            try
            {
                MySqlConnection myConnectionend = new MySqlConnection(myConnectionString);
                string myUpdateQueryend = $"UPDATE db_pessoa.tb_pessoa a INNER JOIN db_pessoa.tb_endereco b ON (a.FK_id_end = b.id) " +
                    $"SET a.nome = '{nome}',a.cpf = {cpf}, b.logradouro = '{logradouro}', b.numero = {numero},b.cep = '{cep}',b.bairro = '{bairro}',b.cidade = '{cidade}',b.estado = '{estado}' " +
                    $"where a.id = {id}; ";
                MySqlCommand myCommandend = new MySqlCommand(myUpdateQueryend);
                myCommandend.Connection = myConnectionend;
                myConnectionend.Open();
                myCommandend.ExecuteNonQuery();
                myCommandend.Connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }
    }
}