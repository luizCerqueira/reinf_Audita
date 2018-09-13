using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2040infoRecurso : IDAO<R2040infoRecurso>
	{

		public bool Delete(R2040infoRecurso entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2040infoRecurso entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2040infoRecurso]([tpRepasse],[descRecurso],[vlrBruto],[vlrRetApur],[R2040recursosRep],[Chave])";
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


				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool Update(R2040infoRecurso entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

