using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011infoTotalContrib : IDAO<R5011infoTotalContrib>
	{

		public bool Delete(R5011infoTotalContrib entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011infoTotalContrib entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011infoTotalContrib]([nrRecArqBase],[indExistInfo],[R5001],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},'{3}')",
					entidade.nrRecArqBase,
					entidade.indExistInfo,
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

		public bool Update(R5011infoTotalContrib entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
