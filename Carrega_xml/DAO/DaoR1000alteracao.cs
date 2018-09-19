using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR1000alteracao : IDAO<R1000alteracao>
	{

		public bool Delete(R1000alteracao entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R1000alteracao entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R1000alteracao]([iniValid],[fimValid],[classTrib],[indEscrituracao],[indDesoneracao],[indAcordoIsenMulta],[indSitPJ],[nmCtt],[cpfCtt],[foneFixo],[foneCel],[email],[cnpjSoftHouse],[nmRazao],[nmCont],[telefone],[emailSoft],[ideEFR],[cnpjEFR],[iniValidN],[fimValidN],[R1000],[Id])";
				strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}','{1: yyyy-MM-dd}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19: yyyy-MM-dd}','{20: yyyy-MM-dd}',{21},'{22}')",
					entidade.iniValid,
					entidade.fimValid,
					entidade.classTrib,
					entidade.indEscrituracao,
					entidade.indDesoneracao,
					entidade.indAcordoIsenMulta,
					entidade.indSitPJ,
					entidade.nmCtt,
					entidade.cpfCtt,
					entidade.foneFixo,
					entidade.foneCel,
					entidade.email,
					entidade.cnpjSoftHouse,
					entidade.nmRazao,
					entidade.nmCont,
					entidade.telefone,
					entidade.emailSoft,
					entidade.ideEFR,
					entidade.cnpjEFR,
					entidade.iniValidN,
					entidade.fimValidN,
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

		public bool Update(R1000alteracao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
