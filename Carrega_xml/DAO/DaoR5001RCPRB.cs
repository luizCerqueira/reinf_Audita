using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001RCPRB : IDAO<R5001RCPRB>
	{

		public bool Delete(R5001RCPRB entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001RCPRB entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5001RCPRB]([CRCPRB],[vlrCRCPRB],[vlrCRCPRBSusp],[R5001ideEstab],[Id])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},'{3}','{4}')",
					entidade.CRCPRB,
					entidade.vlrCRCPRB,
					entidade.vlrCRCPRBSusp,
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

		public bool Update(R5001RCPRB entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

