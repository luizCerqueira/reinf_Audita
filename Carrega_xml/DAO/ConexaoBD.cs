using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConexaoBD : IDisposable
    {
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        SqlCommand DataCommand;
        SqlTransaction DataTransaction;
        public string Erro;

        private SqlConnection _conexao;
        private string Database;
        private string User;
        private string Passoword;
        private string Porta;
        private string Server;

        public ConexaoBD(string Database)
        {
            this.Database = "REINF_" + Database;
            this.User = "lucaslima";
            this.Passoword = "lima123";
            this.Porta = "1433";
            this.Server = "srvaca01";
            _conexao = new SqlConnection("Server = " + Server + ";Database=" + this.Database + ";User Id=" + User + ";Password=" + Passoword + ";");
            _conexao.Open();







        }

        public object InserirDado(string sql, bool transaction = false)
        {
            if (!sql.Contains("*SCOPE_IDENTITY*"))
                sql = sql + "; SELECT SCOPE_IDENTITY();";

            if (transaction)
            {
                if (DataTransaction == null)
                    DataTransaction = _conexao.BeginTransaction("DataTransaction");
                DataCommand = new SqlCommand(sql, _conexao, DataTransaction);
            }
            else
                DataCommand = new SqlCommand(sql, _conexao);

            Erro = "";
            DataCommand.CommandTimeout = 120;

            try
            {
                return DataCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Erro = "Ocorreu um erro ao tentar executar a instrução: " + ex.Message;
                if (transaction)
                    DataTransaction.Rollback();
                return null;
            }

        }




        public void Dispose()
        {
            if (_conexao.State == ConnectionState.Open)
                _conexao.Close();
        }
    }
}
