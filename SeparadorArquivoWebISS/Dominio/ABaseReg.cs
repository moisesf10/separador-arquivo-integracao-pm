using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal abstract class ABaseReg
	{
		public string? CodRegistro { get; set; }
		public int? NumLinha { get; set; }
		public int? NumLinhaOriginal { get; set; }
		public string? Registro { get; set; }
	}
}
