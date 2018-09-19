using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2050tipoCom : IDAO<R2050tipoCom>
	{

		public bool Delete(R2050tipoCom entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2050tipoCom entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2050tipoCom]([indCom],[vlrRecBruta],[R2050],[Id])";
				strQuery += string.Format("VALUES ({0},{1},{2},'{3}')",
					entidade.indCom,
					entidade.vlrRecBruta,
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

		public bool Update(R2050tipoCom entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

