using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011infoRecEv : IDAO<R5011infoRecEv>
	{

		public bool Delete(R5011infoRecEv entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011infoRecEv entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R5011infoRecEv]([nrProtEntr],[dhProcess],[tpEv],[idEv],[hash],[R5011],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1: yyyy-MM-dd}','{2}','{3}','{4}',{5},'{6}')",
					entidade.nrProtEntr,
					entidade.dhProcess,
					entidade.tpEv,
					entidade.idEv,
					entidade.hash,
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

		public bool Update(R5011infoRecEv entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
