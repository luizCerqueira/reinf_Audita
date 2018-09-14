using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2030infoRecurso : IDAO<R2030infoRecurso>
	{

		public bool Delete(R2030infoRecurso entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2030infoRecurso entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2030infoRecurso]([tpRepasse],[descRecurso],[vlrBruto],[vlrRetApur],[R2030recursosRec],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}',{2},{3},{4},'{5}')",
					entidade.tpRepasse,
					entidade.descRecurso,
					entidade.vlrBruto,
					entidade.vlrRetApur,
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

		public bool Update(R2030infoRecurso entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

