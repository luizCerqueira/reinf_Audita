﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010infoProc : IDAO<R3010infoProc>
	{

		public bool Delete(R3010infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010infoProc entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010infoProc]([vlrCPSusp],[tpProcesso],[nrProcesso],[codSusp],[R3010ideEstab],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
					entidade.vlrCPSusp,
					entidade.tpProcesso,
					entidade.nrProcesso,
					entidade.codSusp,
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

		public bool Update(R3010infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
