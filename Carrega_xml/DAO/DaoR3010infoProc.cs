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

		public bool Save(R3010infoProc entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010infoProc]([tpProc],[nrProc],[codSusp],[vlrCPSusp],[R3010ideEstab],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
					entidade.tpProc,
					entidade.nrProc,
					entidade.codSusp,
					entidade.vlrCPSusp,
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

		public bool Update(R3010infoProc entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

