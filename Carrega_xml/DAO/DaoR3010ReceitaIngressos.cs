using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010ReceitaIngressos : IDAO<R3010ReceitaIngressos>
	{

		public bool Delete(R3010ReceitaIngressos entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010ReceitaIngressos entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010ReceitaIngressos]([tpIngresso],[descIngr],[qtdeIngrVenda],[qtdeIngrVendidos],[qtdeIngrDev],[precoIndiv],[vlrTotal],[R3010boletim],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},{3},{4},{5},{6},{7},'{8}')",
					entidade.tpIngresso,
					entidade.descIngr,
					entidade.qtdeIngrVenda,
					entidade.qtdeIngrVendidos,
					entidade.qtdeIngrDev,
					entidade.precoIndiv,
					entidade.vlrTotal,
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

		public bool Update(R3010ReceitaIngressos entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

