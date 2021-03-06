﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR9000 : IDAO<R9000>
	{

		public bool Delete(R9000 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R9000 entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R9000]([tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[tpEvento],[nrRecEvt],[perApur],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7: yyyy-MM-dd}',{8},'{9}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.tpInsc,
					entidade.nrInsc,
					entidade.tpEvento,
					entidade.nrRecEvt,
					entidade.perApur,
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

		public bool Update(R9000 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

