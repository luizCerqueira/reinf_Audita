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

		public bool Save(R2060tipoCod entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060tipoCod]([codAtivEcon],[vlrRecBrutaAtiv],[vlrExcRecBruta],[vlrAdicRecBruta],[vlrBcCPRB],[vlrCPRBapur],[R2060],[Id])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},{5},{6},'{7}')",
					entidade.codAtivEcon,
					entidade.vlrRecBrutaAtiv,
					entidade.vlrExcRecBruta,
					entidade.vlrAdicRecBruta,
					entidade.vlrBcCPRB,
					entidade.vlrCPRBapur,
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

		public bool Update(R2060tipoCod entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

