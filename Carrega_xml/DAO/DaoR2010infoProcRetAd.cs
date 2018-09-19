﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DaoR2010infoProcRetAd : IDAO<R2010infoProcRetAd>
    {
        public bool Delete(R2010infoProcRetAd entidade, string Banco)
        {
            throw new NotImplementedException();
        }

		public bool Save(R2010infoProcRetAd entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R2010infoProcRetAd]([tpProcRetAdic],[nrProcRetAdic],[codSuspAdic],[valorAdic],[R1000],[Id])";
				strQuery += string.Format("VALUES ({0},'{1}','{2}',{3},{4},'{5}')",
					entidade.tpProcRetAdic,
					entidade.nrProcRetAdic,
					entidade.codSuspAdic,
					entidade.valorAdic,
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

        public bool Update(R2010infoProcRetAd entidade, string Banco)
        {
            throw new NotImplementedException();
        }
    }
}
