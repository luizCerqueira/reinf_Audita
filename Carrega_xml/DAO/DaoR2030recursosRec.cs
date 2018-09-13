using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2030recursosRec : IDAO<R2030recursosRec>
	{

		public bool Delete(R2030recursosRec entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2030recursosRec entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2030recursosRec]([cnpjOrigRecurso],[vlrTotalRec],[vlrTotalRet],[vlrTotalNRet],[tpProc],[nrProc],[codSusp],[vlrNRet],[R2030],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},'{5}','{6}',{7},{8},'{9}')",
					entidade.cnpjOrigRecurso,
					entidade.vlrTotalRec,
					entidade.vlrTotalRet,
					entidade.vlrTotalNRet,
					entidade.tpProc,
					entidade.nrProc,
					entidade.codSusp,
					entidade.vlrNRet,
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

		public bool Update(R2030recursosRec entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

