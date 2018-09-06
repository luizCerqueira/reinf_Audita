using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070infoSusp : IDAO<R1070infoSusp>
	{

		public bool Delete(R1070infoSusp entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070infoSusp entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R1070infoSusp]([tpAmb],[procEmi],[verProc],[indRetif],[nrRecibo],[perApur],[tpInscContri],[nrInscContri],[tpInscEstab],[nrInscEstab],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3}',{4},'{5}')",
					entidade.codSusp,
					entidade.indSusp,
					entidade.dtDecisao,
					entidade.indDeposito,
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

		public bool Update(R1070infoSusp entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

