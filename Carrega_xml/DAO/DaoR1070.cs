﻿using System;
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

		public bool Save(R1070 entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1070]([tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.tpInsc,
					entidade.nrInsc,
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

		public bool Update(R1070 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}