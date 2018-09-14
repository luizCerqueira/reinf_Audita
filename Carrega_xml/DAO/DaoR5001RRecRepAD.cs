using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001RRecRepAD : IDAO<R5001RRecRepAD>
	{

		public bool Delete(R5001RRecRepAD entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001RRecRepAD entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R5001RRecRepAD]([cnpjAssocDesp],[vlrTotalRep],[CRRecRepAD],[vlrCRRecRepAD],[vlrCRRecRepADSusp],[R5001ideEstab],[Chave])";
				strQuery += string.Format("VALUES ('{0}',{1},'{2}',{3},{4},{5},'{6}')",
					entidade.cnpjAssocDesp,
					entidade.vlrTotalRep,
					entidade.CRRecRepAD,
					entidade.vlrCRRecRepAD,
					entidade.vlrCRRecRepADSusp,
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

		public bool Update(R5001RRecRepAD entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

