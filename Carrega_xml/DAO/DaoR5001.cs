using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001 : IDAO<R5001>
	{

		public bool Delete(R5001 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001 entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R5001]([perApur],[tpInsc],[nrInsc],[cdRetorno],[descRetorno],[dhProcess],[tpEv],[idEv],[HASH],[nrRecArqBase],[indExistInfo],[indEscrituracao],[indDesoneracao],[indAcordoIsenMulta],[vlrCPApur],[vlrTotalRet],[vlrRatApur],[vlrSenarApur],[vlrCPSusp],[vlrRatSusp],[vlrSenarSusp],[vlrTotalNRet],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5: yyyy-MM-dd}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},{15},{16},{17},{18},{19},{20},{21},{22},'{23}')",
					entidade.perApur,
					entidade.tpInsc,
					entidade.nrInsc,
					entidade.cdRetorno,
					entidade.descRetorno,
					entidade.dhProcess,
					entidade.tpEv,
					entidade.idEv,
					entidade.HASH,
					entidade.nrRecArqBase,
					entidade.indExistInfo,
					entidade.indEscrituracao,
					entidade.indDesoneracao,
					entidade.indAcordoIsenMulta,
					entidade.vlrCPApur,
					entidade.vlrTotalRet,
					entidade.vlrRatApur,
					entidade.vlrSenarApur,
					entidade.vlrCPSusp,
					entidade.vlrRatSusp,
					entidade.vlrSenarSusp,
					entidade.vlrTotalNRet,
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

		public bool Update(R5001 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
