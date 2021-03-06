﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1000exclusao : IDAO<R1000exclusao>
	{

		public bool Delete(R1000exclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1000exclusao entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1000exclusao]([iniValid],[fimValid],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}','{1: yyyy-MM-dd}',{2},'{3}')",
					entidade.iniValid,
					entidade.fimValid,
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

		public bool Update(R1000exclusao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
