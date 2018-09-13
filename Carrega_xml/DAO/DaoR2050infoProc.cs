using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2050infoProc : IDAO<R2050infoProc>
	{

		public bool Delete(R2050infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2050infoProc entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2050infoProc]([tpProc],[nrProc],[codSusp],[vlrCPSusp],[vlrRatSusp],[vlrSenarSusp],[R2050tipoCom],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}',{3},{4},{5},{6},'{7}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.codSusp,
					entidade.vlrCPSusp,
					entidade.vlrRatSusp,
					entidade.vlrSenarSusp,
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

		public bool Update(R2050infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

