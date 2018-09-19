using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5011RRecRepAD : IDAO<R5011RRecRepAD>
	{

		public bool Delete(R5011RRecRepAD entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5011RRecRepAD entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5011RRecRepAD]([CRRecRepAD],[vlrCRRecRepAD],[vlrCRRecRepADSusp],[R5011infoTotalContrib],[Id])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},'{4}')",
					entidade.CRRecRepAD,
					entidade.vlrCRRecRepAD,
					entidade.vlrCRRecRepADSusp,
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

		public bool Update(R5011RRecRepAD entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
