using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011 : IDAO<R5011>
	{

		public bool Delete(R5011 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011 entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011]([perApur],[tpInsc],[nrInsc],[cdRetorno],[descRetorno],[tpOcorr],[localErroAviso],[codResp],[dscResp],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},'{10}')",
					entidade.perApur,
					entidade.tpInsc,
					entidade.nrInsc,
					entidade.cdRetorno,
					entidade.descRetorno,
					entidade.tpOcorr,
					entidade.localErroAviso,
					entidade.codResp,
					entidade.dscResp,
					Codigo,
					entidade.Id
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

		public bool Update(R5011 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
