using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070alteracao : IDAO<R1070alteracao>
	{

		public bool Delete(R1070alteracao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070alteracao entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1070alteracao]([tpProc],[nrProc],[iniValid],[fimValid],[indAutoria],[codSusp],[indSusp],[dtDecisao],[indDeposito],[ufVara],[codMunic],[idVara],[iniValidN],[fimValidN],[R1070],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3: yyyy-MM-dd}','{4}','{5}','{6}','{7: yyyy-MM-dd}','{8}','{9}','{10}','{11}','{12: yyyy-MM-dd}','{13: yyyy-MM-dd}',{14},'{15}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.iniValid,
					entidade.fimValid,
					entidade.indAutoria,
					entidade.codSusp,
					entidade.indSusp,
					entidade.dtDecisao,
					entidade.indDeposito,
					entidade.ufVara,
					entidade.codMunic,
					entidade.idVara,
					entidade.iniValidN,
					entidade.fimValidN,
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

		public bool Update(R1070alteracao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
