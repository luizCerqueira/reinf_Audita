using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2020infoProcRetPr : IDAO<R2020infoProcRetPr>
	{

		public bool Delete(R2020infoProcRetPr entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2020infoProcRetPr entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R2020infoProcRetPr]([tpProcRetPrinc],[nrProcRetPrinc],[codSuspPrinc],[valorPrinc],[R2020ideTomador],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}',{3},{4},'{5}')",
					entidade.tpProcRetPrinc,
					entidade.nrProcRetPrinc,
					entidade.codSuspPrinc,
					entidade.valorPrinc,
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

		public bool Update(R2020infoProcRetPr entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

