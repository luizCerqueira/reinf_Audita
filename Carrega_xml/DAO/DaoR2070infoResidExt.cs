using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070infoResidExt : IDAO<R2070infoResidExt>
	{

		public bool Delete(R2070infoResidExt entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070infoResidExt entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070infoResidExt]([paisResid],[dscLograd],[nrLograd],[complem],[bairro],[cidade],[codPostal],[indNIF],[nifBenef],[relFontePagad],[R2070],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}',{10},'{11}')",
					entidade.paisResid,
					entidade.dscLograd,
					entidade.nrLograd,
					entidade.complem,
					entidade.bairro,
					entidade.cidade,
					entidade.codPostal,
					entidade.indNIF,
					entidade.nifBenef,
					entidade.relFontePagad,
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

		public bool Update(R2070infoResidExt entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

