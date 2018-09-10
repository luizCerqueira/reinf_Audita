using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070rendIsento : IDAO<R2070rendIsento>
	{

		public bool Delete(R2070rendIsento entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070rendIsento entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070rendIsento]([tpIsencao],[vlrIsento],[descRendimento],[R2070pgtoResidBR],[Chave])";
				strQuery += string.Format("VALUES ({0},{1},'{2}',{3},'{4}')",
					entidade.tpIsencao,
					entidade.vlrIsento,
					entidade.descRendimento,
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

		public bool Update(R2070rendIsento entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

