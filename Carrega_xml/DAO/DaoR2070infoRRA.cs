﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2070infoRRA : IDAO<R2070infoRRA>
	{

		public bool Delete(R2070infoRRA entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2070infoRRA entidade, string Banco, int Id, string Chave)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2070infoRRA]([tpProcRRA],[nrProcRRA],[codSusp],[natRRA],[qtdMesesRRA],[vlrDespCustas],[vlrDespAdvogados],[R2070pgtoResidBR],[Chave])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}','{3}',{4},{5},{6},{7},'{8}')",
					entidade.tpProcRRA,
					entidade.nrProcRRA,
					entidade.codSusp,
					entidade.natRRA,
					entidade.qtdMesesRRA,
					entidade.vlrDespCustas,
					entidade.vlrDespAdvogados,
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

		public bool Update(R2070infoRRA entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

