using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2098 : IDAO<R2098>
	{

		public bool Delete(R2098 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2098 entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2098]([tpAmb],[procEmi],[verProc],[perApur],[tpInsc],[nrInsc],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3: yyyy-MM-dd}','{4}','{5}',{6},'{7}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.perApur,
					entidade.tpInsc,
					entidade.nrInsc,
					Id,
					entidade.Chave
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

		public bool Update(R2098 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
