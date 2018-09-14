using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2010nfs : IDAO<R2010nfs>
	{

		public bool Delete(R2010nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2010nfs entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2010nfs]([serie],[numDocto],[dtEmissaoNF],[vlrBruto],[obs],[R2010],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}',{3},'{4}',{5},'{6}')",
					entidade.serie,
					entidade.numDocto,
					entidade.dtEmissaoNF,
					entidade.vlrBruto,
					entidade.obs,
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

		public bool Update(R2010nfs entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

