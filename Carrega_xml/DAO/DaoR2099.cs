﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2099 : IDAO<R2099>
	{

		public bool Delete(R2099 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2099 entidade, string Banco, int Codigo, string Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2099]([perApur],[tpAmb],[procEmi],[verProc],[tpInsc],[nrInsc],[nmResp],[cpfResp],[telefone],[email],[evtServTm],[evtServPr],[evtAssDespRec],[evtAssDespRep],[evtComProd],[evtCPRB],[evtPgtos],[compSemMovto],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',{18},'{19}')",
					entidade.perApur,
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.tpInsc,
					entidade.nrInsc,
					entidade.nmResp,
					entidade.cpfResp,
					entidade.telefone,
					entidade.email,
					entidade.evtServTm,
					entidade.evtServPr,
					entidade.evtAssDespRec,
					entidade.evtAssDespRep,
					entidade.evtComProd,
					entidade.evtCPRB,
					entidade.evtPgtos,
					entidade.compSemMovto,
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

		public bool Update(R2099 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
