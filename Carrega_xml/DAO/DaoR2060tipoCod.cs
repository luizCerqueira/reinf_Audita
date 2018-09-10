using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2060tipoCod : IDAO<R2060tipoCod>
	{

		public bool Delete(R2060tipoCod entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2060tipoCod entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060tipoCod]([codAtivEcon],[vlrRecBrutaAtiv],[vlrExcRecBruta],[vlrAdicRecBruta],[vlrBcCPRB],[vlrCPRBapur],[codAnaCont],[R2060],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},{5},'{6}',{7},'{8}')",
					entidade.codAtivEcon,
					entidade.vlrRecBrutaAtiv,
					entidade.vlrExcRecBruta,
					entidade.vlrAdicRecBruta,
					entidade.vlrBcCPRB,
					entidade.vlrCPRBapur,
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

		public bool Update(R2060tipoCod entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

