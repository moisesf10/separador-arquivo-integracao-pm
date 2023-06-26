using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal class Reg000 : ABaseReg
	{
		public string? Nome { get; set; }
		public string? CodigoMunicipioIbge { get; set; }
		public string? DataInicialColeta { get; set; }
		public string? DataFinalColeta { get; set; }
		public string? DataGeracaoArquivo { get; set; }

		public override string ToString()
		{
			string line = String.Concat(
				Convert.ToString(NumLinha), "|", CodRegistro, "|", Nome, "|", CodigoMunicipioIbge, "|",
				DataInicialColeta, "|", DataFinalColeta, "|", DataGeracaoArquivo
			);

			return line;
		}
	}
}
