using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001RTom : IDAO<R5001RTom>
	{

		public bool Delete(R5001RTom entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001RTom entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R5001RTom]([cnpjPrestador],[cno],[vlrTotalBaseRet],[CRTom],[vlrCRTom],[vlrCRTomSusp],[R5001ideEstab],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},'{3}',{4},{5},{6},'{7}')",
					entidade.cnpjPrestador,
					entidade.cno,
					entidade.vlrTotalBaseRet,
					entidade.CRTom,
					entidade.vlrCRTom,
					entidade.vlrCRTomSusp,
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

		public bool Update(R5001RTom entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

