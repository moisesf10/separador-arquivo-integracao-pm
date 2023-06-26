using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal class Financeiro
	{
		public Reg000 Reg000 { get; set; }
		public List<Reg300> Reg300 { get; set; } = new List<Reg300>();
		public List<Reg330> Reg330 { get; set; } = new List<Reg330>();
		public List<Reg340> Reg340 { get; set; } = new List<Reg340>();

		
	}
}
