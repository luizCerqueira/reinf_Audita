using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2040recursosRep : IDAO<R2040recursosRep>
	{

		public bool Delete(R2040recursosRep entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2040recursosRep entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2040recursosRep]([cnpjAssocDesp],[vlrTotalRep],[vlrTotalRet],[vlrTotalNRet],[tpProc],[nrProc],[codSusp],[vlrNRet],[R2040],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},'{5}','{6}',{7},{8},'{9}')",
					entidade.cnpjAssocDesp,
					entidade.vlrTotalRep,
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


				return (entidade.Id != 0 ? true : false);
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool Update(R2040recursosRep entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

