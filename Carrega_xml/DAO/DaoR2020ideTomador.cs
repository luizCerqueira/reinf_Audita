using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2020ideTomador : IDAO<R2020ideTomador>
	{

		public bool Delete(R2020ideTomador entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2020ideTomador entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2020ideTomador]([tpInscTomador],[nrInscTomador],[indObra],[vlrTotalBruto],[vlrTotalBaseRet],[vlrTotalRetPrinc],[vlrTotalRetAdic],[vlrTotalNRetPrinc],[vlrTotalNRetAdic],[codAnaCont],[R2020],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},'{9}',{10},'{11}')",
					entidade.tpInscTomador,
					entidade.nrInscTomador,
					entidade.indObra,
					entidade.vlrTotalBruto,
					entidade.vlrTotalBaseRet,
					entidade.vlrTotalRetPrinc,
					entidade.vlrTotalRetAdic,
					entidade.vlrTotalNRetPrinc,
					entidade.vlrTotalNRetAdic,
					entidade.codAnaCont,
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

		public bool Update(R2020ideTomador entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

