using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2030 : IDAO<R2030>
	{

		public bool Delete(R2030 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2030 entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2030]([indRetif],[nrRecibo],[perApur],[tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[tpInscEstab],[nrInscEstab],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},'{11}')",
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

		public bool Update(R2030 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
