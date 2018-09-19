using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070inclusao : IDAO<R1070inclusao>
	{

		public bool Delete(R1070inclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070inclusao entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1070inclusao]([tpProc],[nrProc],[iniValid],[fimValid],[indAutoria],[codSusp],[indSusp],[dtDecisao],[indDeposito],[ufVara],[codMunic],[idVara],[R1070],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3: yyyy-MM-dd}','{4}','{5}','{6}','{7: yyyy-MM-dd}','{8}','{9}','{10}','{11}',{12},'{13}')",
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

		public bool Update(R1070inclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
