﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR3010ideEstab : IDAO<R3010ideEstab>
	{

		public bool Delete(R3010ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R3010ideEstab entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R3010ideEstab]([tpInscEstab],[nrInscEstab],[vlrReceitaTotal],[vlrCP],[vlrCPSuspTotal],[vlrReceitaClubes],[vlrRetParc],[R3010],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},{3},{4},{5},{6},{7},'{8}')",
					entidade.tpInscEstab,
					entidade.nrInscEstab,
					entidade.vlrReceitaTotal,
					entidade.vlrCP,
					entidade.vlrCPSuspTotal,
					entidade.vlrReceitaClubes,
					entidade.vlrRetParc,
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

		public bool Update(R3010ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

