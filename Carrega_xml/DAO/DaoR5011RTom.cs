using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011RTom : IDAO<R5011RTom>
	{

		public bool Delete(R5011RTom entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011RTom entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011RTom]([cnpjPrestador],[cno],[vlrTotalBaseRet],[CRTom],[vlrCRTom],[vlrCRTomSusp],[R5011infoTotalContrib],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},'{3}',{4},{5},{6},'{7}')",
					entidade.cnpjPrestador,
					entidade.cno,
					entidade.vlrTotalBaseRet,
					entidade.CRTom,
					entidade.vlrCRTom,
					entidade.vlrCRTomSusp,
					Codigo,
					Id
				);


				using (ConexaoBD _BD = new ConexaoBD(Banco))
				{
					var Ide = _BD.InserirDado(strQuery);
					entidade.Codigo = Convert.ToInt32(Ide);
				}


				return (entidade.Codigo != 0 ? true : false);

			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool Update(R5011RTom entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
