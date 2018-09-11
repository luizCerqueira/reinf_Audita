﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2050tipoCom : IDAO<R2050tipoCom>
	{

		public bool Delete(R2050tipoCom entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2050tipoCom entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2050tipoCom]([indCom],[vlrRecBruta],[codAnaCont],[R2050],[Chave])";
				strQuery += string.Format("VALUES ({0},{1},'{2}',{3},'{4}')",
					entidade.indCom,
					entidade.vlrRecBruta,
					entidade.codAnaCont,
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

		public bool Update(R2050tipoCom entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
