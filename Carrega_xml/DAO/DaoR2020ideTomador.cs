﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2020ideTomador : IDAO<R2020ideTomador>
	{

		public bool Delete(R2020ideTomador entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2020ideTomador entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R2020ideTomador]([tpInscTomador],[nrInscTomador],[indObra],[vlrTotalBruto],[vlrTotalBaseRet],[vlrTotalRetPrinc],[vlrTotalRetAdic],[vlrTotalNRetPrinc],[vlrTotalNRetAdic],[R2020],[Id])";
				strQuery += string.Format("VALUES ('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},{9},'{10}')",
					entidade.tpInscTomador,
					entidade.nrInscTomador,
					entidade.indObra,
					entidade.vlrTotalBruto,
					entidade.vlrTotalBaseRet,
					entidade.vlrTotalRetPrinc,
					entidade.vlrTotalRetAdic,
					entidade.vlrTotalNRetPrinc,
					entidade.vlrTotalNRetAdic,
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

		public bool Update(R2020ideTomador entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

