using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010 : IDAO<R3010>
	{

		public bool Delete(R3010 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010 entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010]([tpAmb],[procEmi],[verProc],[indRetif],[nrRecibo],[dtApuracao],[tpInsc],[nrInsc],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5: yyyy-MM-dd}','{6}','{7}',{8},'{9}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.indRetif,
					entidade.nrRecibo,
					entidade.dtApuracao,
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

		public bool Update(R3010 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
