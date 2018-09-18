﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR5001ideEstab : IDAO<R5001ideEstab>
	{

		public bool Delete(R5001ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R5001ideEstab entidade, string Banco, int Id, string Chave)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R5001ideEstab]([tpInsc],[nrInsc],[R5001],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},'{3}')",
					entidade.tpInsc,
					entidade.nrInsc,
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

		public bool Update(R5001ideEstab entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
