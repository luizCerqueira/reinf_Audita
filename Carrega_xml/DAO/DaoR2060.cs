using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2060 : IDAO<R2060>
	{

		public bool Delete(R2060 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2060 entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2060]([indRetif],[nrRecibo],[perApur],[tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[tpInscEstab],[nrInscEstab],[vlrRecBrutaTotal],[vlrCPApurTotal],[vlrCPRBSuspTotal],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},{11},{12},{13},'{14}')",
					entidade.indRetif,
					entidade.nrRecibo,
					entidade.perApur,
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.tpInsc,
					entidade.nrInsc,
					entidade.tpInscEstab,
					entidade.nrInscEstab,
					entidade.vlrRecBrutaTotal,
					entidade.vlrCPApurTotal,
					entidade.vlrCPRBSuspTotal,
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

		public bool Update(R2060 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
