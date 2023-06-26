using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal class Reg340 : ABaseReg, IReg
	{
		public string? NossoNumeroGuia { get; set; }
		public string GetPrincipalNumber()
		{
			throw new NotImplementedException();
		}
	}
}
