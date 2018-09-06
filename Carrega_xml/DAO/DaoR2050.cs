using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2050 : IDAO<R2050>
	{

		public bool Delete(R2050 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2050 entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2050]([tpAmb],[procEmi],[verProc],[indRetif],[nrRecibo],[perApur],[tpInscContri],[nrInscContri],[tpInscEstab],[nrInscEstab],[vlrRecBrutaTotal],[vlrCPApur],[vlrRatApur],[vlrSenarApur],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5: yyyy-MM-dd}','{6}','{7}','{8}','{9}',{10},{11},{12},{13},{14},{15})",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.indRetif,
					entidade.nrRecibo,
					entidade.perApur,
					entidade.tpInscContri,
					entidade.nrInscContri,
					entidade.tpInscEstab,
					entidade.nrInscEstab,
					entidade.vlrRecBrutaTotal,
					entidade.vlrCPApur,
					entidade.vlrRatApur,
					entidade.vlrSenarApur,
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

		public bool Update(R2050 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
