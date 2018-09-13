using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011RComl : IDAO<R5011RComl>
	{

		public bool Delete(R5011RComl entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011RComl entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011RComl]([CRComl],[vlrCRComl],[vlrCRComlSusp],[R5011infoTotalContrib],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},'{4}')",
					entidade.CRComl,
					entidade.vlrCRComl,
					entidade.vlrCRComlSusp,
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

		public bool Update(R5011RComl entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
