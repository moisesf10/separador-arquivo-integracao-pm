using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal class ReportProgress
	{
		public int? TotalReg { get; set; }
		public int AtualReg { get; set; }
		public string? Message { get; set; }
		public bool IsComputed {get; set;} = true;
	}
}
