using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	//A classe "Entidade" é herdada por todas as classes no projeto "Entidades", pois ela possuí atributos comuns à todas elas
	public class Entidade
    {

		public int Codigo { get; set; }//O atributo "Codigo" é utilizado como identificador único e automático para cada um dos registros de classe

		public string Id { get; set; }// O atributo "Id" é utilizado para identificar os cadastros filhos em relação à seus cadastros pais, portanto pode ser repetido em mais de um registro
	}
}
