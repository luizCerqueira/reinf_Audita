using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2010 : IDAO<R2010>
	{

		public bool Delete(R2010 entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2010 entidade, string Banco, int Id)
		{
			try
			{

				string strQuery = "INSERT INTO [dbo].[R2010]([iniValid],[fimValid],[tpAmb],[procEmi],[verProc],[tpInsc],[nrInscr],[classTrib],[indEscrituracao],[indDesoneracao],[indAcordoIsenMulta],[indSitPJ],[nmCtt],[cpfCtt],[foneFixo],[foneCel],[email],[ideEFR],[cnpjEFR],[operacao],[pai],[tpAtividade],[indObra],[tpServ],[nrCNO],[infoCPRB],[Chave])";
				strQuery += string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5: yyyy-MM-dd}','{6}','{7}','{8}','{9}','{10}','{11}',{12},{13},{14},{15},{16},{17},'{18}',{19},{20},'{21}')",
					entidade.tpAmb,
					entidade.procEmi,
					entidade.verProc,
					entidade.indRetif,
					entidade.nrRecibo,
					entidade.perApur,
					entidade.tpInscContri,
					entidade.nrInscContri,
					entidade.tpInscEstab,
					entidade.nrInscEstab,
					entidade.indObra,
					entidade.cnpjPrestador,
					entidade.vlrTotalBruto,
					entidade.vlrTotalBaseRet,
					entidade.vlrTotalRetPrinc,
					entidade.vlrTotalRetAdic,
					entidade.vlrTotalNRetPrinc,
					entidade.vlrTotalNRetAdic,
					entidade.codAnaCont,
					entidade.indCPRB,
					Id,
					entidade.Chave
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

		public bool Update(R2010 entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}
