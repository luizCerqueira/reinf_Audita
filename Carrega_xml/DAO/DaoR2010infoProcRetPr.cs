using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class DaoR2010infoProcRetPr : IDAO<R2010infoProcRetPr>
    {
        public bool Delete(R2010infoProcRetPr entidade, string Banco)
        {
            throw new NotImplementedException();
        }

        public bool Save(R2010infoProcRetPr entidade, string Banco, int Id, string Chave)
        {
            try
            {
                string strQuery = "INSERT INTO [dbo].[R2010infoProcRetPr]([tpProcRetPrinc],[nrProcRetPrinc],[codSuspPrinc],[valorPrinc],[R2010],[Chave])";
                strQuery += string.Format("VALUES ({0},'{1}','{2}',{3},{4},'{5}')",
                    entidade.tpProcRetPrinc,
                    entidade.nrProcRetPrinc,
                    entidade.codSuspPrinc,
                    entidade.valorPrinc,
                    Id,
                    Chave);

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

        public bool Update(R2010infoProcRetPr entidade, string Banco)
        {
            throw new NotImplementedException();
        }
    }
}
