using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal interface IReg
	{
		// Retorna o número principal do registro. Pode ser o IdDebito ou o NossoNomero quando houver
		public string GetPrincipalNumber(); 
	}
}
