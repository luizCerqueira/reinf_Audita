using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2060nfs : IDAO<R2060nfs>
	{

		public bool Delete(R2060nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2060nfs entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060nfs]([serie],[numDocto],[dtEmissaoNF],[vlrBruto],[R2060tipoCod],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}',{3},{4})",
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

		public bool Update(R2060nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

