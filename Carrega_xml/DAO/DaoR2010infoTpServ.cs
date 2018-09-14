using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DaoR2010infoTpServ : IDAO<R2010infoTpServ>
    {
        public bool Delete(R2010infoTpServ entidade, string Banco)
        {
            throw new NotImplementedException();
        }

        public bool Save(R2010infoTpServ entidade, string Banco, int Id, string Chave)
        {
            try
            {
				string strQuery = "INSERT INTO [dbo].[R2010infoTpServ]([tpServico],[vlrBaseRet],[vlrRetencao],[vlrRetSub],[vlrNRetPrinc],[vlrServicos15],[vlrServicos20],[vlrServicos25],[vlrAdicional],[vlrNRetAdic],[R2010nfs],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},'{11}')",
					entidade.tpServico,
					entidade.vlrBaseRet,
					entidade.vlrRetencao,
					entidade.vlrRetSub,
					entidade.vlrNRetPrinc,
					entidade.vlrServicos15,
					entidade.vlrServicos20,
					entidade.vlrServicos25,
					entidade.vlrAdicional,
					entidade.vlrNRetAdic,
					Id,
					Chave
				);

				using (ConexaoBD _BD = new ConexaoBD(Banco))
                {
                    var Ide = _BD.InserirDado(strQuery);
                    entidade.Id = Convert.ToInt32(Ide);
                }

				return (entidade.Id != 0 ? true : false);
			}
            catch (Exception ex)
            {
                return false;
            }

            
        }

        public bool Update(R2010infoTpServ entidade, string Banco)
        {
            throw new NotImplementedException();
        }
    }
}
