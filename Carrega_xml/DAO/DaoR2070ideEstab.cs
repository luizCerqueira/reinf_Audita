using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070ideEstab : IDAO<R2070ideEstab>
	{

		public bool Delete(R2070ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070ideEstab entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070ideEstab]([tpInsc],[nrInsc],[R2070],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},'{3}')",
					entidade.tpInsc,
					entidade.nrInsc,
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

		public bool Update(R2070ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

