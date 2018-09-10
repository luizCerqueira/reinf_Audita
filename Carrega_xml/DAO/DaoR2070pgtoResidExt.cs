using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070pgtoResidExt : IDAO<R2070pgtoResidExt>
	{

		public bool Delete(R2070pgtoResidExt entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070pgtoResidExt entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070pgtoResidExt]([dtPagto],[tpRendimento],[formaTributacao],[vlrPgto],[vlrRet],[R2070ideEstab],[Chave])";
				strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}',{1},'{2}',{3},{4},{5},'{6}')",
					entidade.dtPagto,
					entidade.tpRendimento,
					entidade.formaTributacao,
					entidade.vlrPgto,
					entidade.vlrRet,
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

		public bool Update(R2070pgtoResidExt entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

