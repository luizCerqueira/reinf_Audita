using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070exclusao : IDAO<R1070exclusao>
	{

		public bool Delete(R1070exclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070exclusao entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1070exclusao]([tpProc],[nrProc],[iniValid],[fimValid],[R1070],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3: yyyy-MM-dd}',{4},'{5}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.iniValid,
					entidade.fimValid,
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

		public bool Update(R1070exclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
