using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2060tipoAjuste : IDAO<R2060tipoAjuste>
	{

		public bool Delete(R2060tipoAjuste entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2060tipoAjuste entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060tipoAjuste]([tpAjuste],[codAjuste],[vlrAjuste],[descAjuste],[dtAjuste],[R2060tipoCod],[Id])";
				strQuery += string.Format("VALUES ({0},{1},{2},'{3}','{4: yyyy-MM-dd}',{5},'{6}')",
					entidade.tpAjuste,
					entidade.codAjuste,
					entidade.vlrAjuste,
					entidade.descAjuste,
					entidade.dtAjuste,
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

		public bool Update(R2060tipoAjuste entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

