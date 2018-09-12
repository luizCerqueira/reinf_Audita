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

		public bool Save(R1000alteracao entidade, string Banco, int Id, string Chave)
		{
			try
			{
				Id = 0;
				string strQuery = "INSERT INTO[dbo].[R1000alteracao]([tpAmb],[procEmi],[verProc],[tpInsc],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
					entidade.iniValid
					, entidade.fimValid
					, entidade.classTrib
					, entidade.indEscrituracao
					, entidade.indDesoneracao
					, entidade.indAcordoIsenMulta
					, entidade.indSitPJ
					, entidade.nmCtt
					, entidade.cpfCtt
					, entidade.foneFixo
					, entidade.foneCel
					, entidade.email
					, entidade.cnpjSoftHouse
					, entidade.nmRazao
					, entidade.nmCont
					, entidade.telefone
					, entidade.emailSoft
					, entidade.ideEFR
					, entidade.cnpjEFR
					, entidade.iniValidN
					, entidade.fimValidN
					, Id
					, Chave
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

		public bool Update(R1000alteracao entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
