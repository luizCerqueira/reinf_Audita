using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010boletim : IDAO<R3010boletim>
	{

		public bool Delete(R3010boletim entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010boletim entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010boletim]([nrBoletim],[tpCompeticao],[categEvento],[modDesportiva],[nomeCompeticao],[cnpjMandante],[cnpjVisitante],[nomeVisitante],[pracaDesportiva],[codMunic],[uf],[qtdePagantes],[qtdeNaoPagantes],[R3010ideEstab],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},{12},{13},'{14}')",
					entidade.nrBoletim,
					entidade.tpCompeticao,
					entidade.categEvento,
					entidade.modDesportiva,
					entidade.nomeCompeticao,
					entidade.cnpjMandante,
					entidade.cnpjVisitante,
					entidade.nomeVisitante,
					entidade.pracaDesportiva,
					entidade.codMunic,
					entidade.uf,
					entidade.qtdePagantes,
					entidade.qtdeNaoPagantes,
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

		public bool Update(R3010boletim entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

