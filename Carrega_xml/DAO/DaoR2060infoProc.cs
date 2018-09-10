using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2060infoProc : IDAO<R2060infoProc>
	{

		public bool Delete(R2060infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2060infoProc entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060infoProc](,[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}',{3},{4},'{5}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.codSusp,
					entidade.vlrCPRBSusp,
					Id,
					Chave
					);

				using (ConexaoBD _BD = new ConexaoBD(Banco))
				{
					var Ide = _BD.InserirDado(strQuery);
					entidade.Id = Convert.ToInt32(Ide);
				}


				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool Update(R2060infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

