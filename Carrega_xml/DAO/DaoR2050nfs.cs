using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2050nfs : IDAO<R2050nfs>
	{

		public bool Delete(R2050nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2050nfs entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2050nfs]([serie],[numDocto],[dtEmissaoNF],[vlrBruto],[R2050tipoCom],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}',{3},{4},'{5}')",

					entidade.serie,
					entidade.numDocto,
					entidade.dtEmissaoNF,
					entidade.vlrBruto,
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

		public bool Update(R2050nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

