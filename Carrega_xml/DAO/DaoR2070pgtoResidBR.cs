using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070pgtoResidBR : IDAO<R2070pgtoResidBR>
	{

		public bool Delete(R2070pgtoResidBR entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070pgtoResidBR entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070pgtoResidBR]([tipoPgtoResidBR],[dtPagto],[vlrRendTributavel],[vlrRet],[indSuspExig],[indDecTerceiro],[vlrIRRF],[vlrCompAnoCalend],[vlrCompAnoAnt],[R2070ideEstab],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1: yyyy-MM-dd}',{2},{3},'{4}','{5}',{6},{7},{8},{9},'{10}')",
					entidade.tipoPgtoResidBR,
					entidade.dtPagto,
					entidade.vlrRendTributavel,
					entidade.vlrRet,
					entidade.indSuspExig,
					entidade.indDecTerceiro,
					entidade.vlrIRRF,
					entidade.vlrCompAnoCalend,
					entidade.vlrCompAnoAnt,
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

		public bool Update(R2070pgtoResidBR entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

