using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001regOcorrs : IDAO<R5001regOcorrs>
	{

		public bool Delete(R5001regOcorrs entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001regOcorrs entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R5001regOcorrs]([tpOcorr],[localErroAviso],[codResp],[dscResp],[R5001],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}',{4},'{5}')",
					entidade.tpOcorr,
					entidade.localErroAviso,
					entidade.codResp,
					entidade.dscResp,
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

		public bool Update(R5001regOcorrs entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

