using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070ideAdvogado : IDAO<R2070ideAdvogado>
	{

		public bool Delete(R2070ideAdvogado entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070ideAdvogado entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070ideAdvogado]([tpInscAdvogado],[nrInscAdvogado],[vlrAdvogado],[infoProcesso],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},{3},'{4}')",
					entidade.tpInscAdvogado,
					entidade.nrInscAdvogado,
					entidade.vlrAdvogado,
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

		public bool Update(R2070ideAdvogado entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

