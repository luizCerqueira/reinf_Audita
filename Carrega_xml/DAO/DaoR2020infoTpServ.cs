using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
	public class DaoR2020infoTpServ : IDAO<R2020infoTpServ>
	{

		public bool Delete(R2020infoTpServ entidade, string Banco)
		{
			throw new NotImplementedException();
		}

		public bool Save(R2020infoTpServ entidade, string Banco, int Codigo, string Id)
		{
			try
			{
				string strQuery = "INSERT INTO [dbo].[R2020infoTpServ]([tpServico],[vlrBaseRet],[vlrRetencao],[vlrRetSub],[vlrNRetPrinc],[vlrServico15],[vlrServico20],[vlrServico25],[vlrAdicional],[vlrNRetAdic],[R2020nfs],[Id])";
				strQuery += string.Format("VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},'{11}')",
					entidade.tpServico,
					entidade.vlrBaseRet,
					entidade.vlrRetencao,
					entidade.vlrRetSub,
					entidade.vlrNRetPrinc,
					entidade.vlrServico15,
					entidade.vlrServico20,
					entidade.vlrServico25,
					entidade.vlrAdicional,
					entidade.vlrNRetAdic,
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

		public bool Update(R2020infoTpServ entidade, string Banco)
		{
			throw new NotImplementedException();
		}
	}
}

