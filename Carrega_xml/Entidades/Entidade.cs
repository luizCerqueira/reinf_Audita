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

		public int Id { get; set; }//O atributo "Id" é utilizado como identificador único e automático para cada um dos registros de classe
		//Mudar nome da Id para codigo, e da chave para id;
		public string Chave { get; set; }// O atributo "Chave" é utilizado para identificar os cadastros filhos em relação à seus cadastros pais, portanto pode ser repetido em mais de um registro
	}
}
