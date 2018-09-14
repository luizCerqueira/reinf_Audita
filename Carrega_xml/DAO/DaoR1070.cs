using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070 : IDAO<R1070>
	{

		public bool Delete(R1070 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070 entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1070]([tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
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


				return (entidade.Id != 0 ? true : false);
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public bool Update(R1070 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}