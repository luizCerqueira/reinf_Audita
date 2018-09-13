using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010outrasReceitas : IDAO<R3010outrasReceitas>
	{

		public bool Delete(R3010outrasReceitas entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010outrasReceitas entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010outrasReceitas]([tpReceita],[vlrReceita],[descReceita],[R3010boletim],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')",
					entidade.tpReceita,
					entidade.vlrReceita,
					entidade.descReceita,
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

		public bool Update(R3010outrasReceitas entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

