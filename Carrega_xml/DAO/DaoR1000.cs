using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DaoR1000 : IDAO<R1000>
    {

        public bool Delete(R1000 entidade, string Banco)
        {
            throw new NotImplementedException();
        }

        public bool Save(R1000 entidade, string Banco)
        {
            try
            {
                string strQuery = "INSERT INTO[dbo].[R1000]([iniValid],[fimValid],[tpAmb],[procEmi],[verProc],[tpInsc],[nrInscr],[classTrib],[indEscrituracao],[indDesoneracao],[indAcordoIsenMulta],[indSitPJ],[nmCtt],[cpfCtt],[foneFixo],[foneCel],[email],[ideEFR],[cnpjEFR],[operacao],[pai],[tpAtividade],[indObra],[tpServ],[nrCNO],[infoCPRB])";
                strQuery += string.Format("VALUES ('{0: yyyy-MM-dd}','{1: yyyy-MM-dd}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',{19},{20},'{21}','{22}','{23}','{24}','{25}')",
                    entidade.iniValid
                    , entidade.fimValid
                    , entidade.tpAmb
                    , entidade.procEmi
                    , entidade.verProc
                    , entidade.tpInsc
                    , entidade.nrInscr
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
                    , entidade.ideEFR
                    , entidade.cnpjEFR
                    , entidade.operacao
                    , entidade.pai
                    , entidade.tpAtividade
                    ,entidade.indObra
                    ,entidade.tpServ
                    ,entidade.nrCNO
                    ,entidade.infoCPRB
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

        public bool Update(R1000 entidade, string Banco)
        {
            throw new NotImplementedException();
        }
    }
}
