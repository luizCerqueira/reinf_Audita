using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070detDeducao : IDAO<R2070detDeducao>
	{

		public bool Delete(R2070detDeducao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070detDeducao entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070detDeducao]([indTpDeducao],[vlrDeducao],[R2070pgtoResidBR],[Chave])";
				strQuery += string.Format("VALUES ({0},{1},{2},'{3}')",
					entidade.indTpDeducao,
					entidade.vlrDeducao,
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

		public bool Update(R2070detDeducao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

