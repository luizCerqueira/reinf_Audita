using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1070 : IDAO<R1070>
	{

		public bool Delete(R1070 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1070 entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R1070]([tpAmb],[procEmi],[verProc],[indRetif],[nrRecibo],[perApur],[tpInscContri],[nrInscContri],[tpInscEstab],[nrInscEstab],[R1000],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2: yyyy-MM-dd}','{3: yyyy-MM-dd}','{4}','{5}','{6}','{7}',{8},'{9}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.iniValid,
					entidade.fimValid,
					entidade.indAutoria,
					entidade.ufVara,
					entidade.codMunic,
					entidade.idVara,
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

		public bool Update(R1070 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}