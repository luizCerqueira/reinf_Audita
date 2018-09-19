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

		public bool Save(R5011infoTotalContrib entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011infoTotalContrib]([nrRecArqBase],[indExistInfo],[R5001],[Id])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},'{3}')",
					entidade.nrRecArqBase,
					entidade.indExistInfo,
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

		public bool Update(R5011infoTotalContrib entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
