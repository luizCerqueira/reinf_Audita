using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070detCompet : IDAO<R2070detCompet>
	{

		public bool Delete(R2070detCompet entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070detCompet entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070detCompet]([indPerReferencia],[perRefPagto],[vlrRendTributavel],[R2070pgtoResidBR],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}',{2},{3},'{4}')",
					entidade.indPerReferencia,
					entidade.perRefPagto,
					entidade.vlrRendTributavel,
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

		public bool Update(R2070detCompet entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

