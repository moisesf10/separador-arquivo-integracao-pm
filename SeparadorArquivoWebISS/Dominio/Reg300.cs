using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal class Reg300 : ABaseReg, IReg
	{
		public string? NumDocumento { get; set; }
		public string? Inscricao { get; set; }
		public string? TributoId { get; set; }
		public string? SituacaoDebito { get; set; }
		public string? NumDocumentoUsuarioCriacao { get; set; }
		public string? MoedaId { get; set; }
		public string? NumeroOrigemLancamento { get; set; }
		public string? IdOrigemLancamento { get; set; }
		public string? DtCriacao { get; set; }
		public string? DtVencimento { get; set; }
		public string? AnoCompetencia { get; set; }
		public string? AnoLancamento { get; set; }
		public string? MesCompetencia { get; set; }
		public string? VlrOriginal { get; set; }
		public string? VlrResidual { get; set; }
		public string? OrigemLancamento { get; set; }
		public string? IndicaInscritoDat { get; set; }
		public string? ObservacaoDebito { get; set; }
		public string? IdDebito { get; set; }
		public string? DtCancelamento { get; set; }
		public string? JustificativaCancelamento { get; set; }
		public string? NumDocumentoUsuarioCancelamento { get; set; }
		public string? IdLancamentoLegado { get; set; }



		
		public string GetPrincipalNumber()
		{
			return IdDebito;
		}

		public override string ToString()
		{
			string line = String.Concat(
				Convert.ToString(NumLinha), "|", CodRegistro, "|", NumDocumento, "|", Inscricao, "|", TributoId, "|", SituacaoDebito, "|",
				NumDocumentoUsuarioCriacao, "|", MoedaId, "|", NumeroOrigemLancamento, "|", IdOrigemLancamento, "|",
				DtCriacao, "|", DtVencimento, "|", AnoCompetencia, "|", AnoLancamento, "|", MesCompetencia, "|", VlrOriginal, "|",
				VlrResidual, "|",  OrigemLancamento, "|", IndicaInscritoDat, "|", ObservacaoDebito, "|",
				IdDebito, "|", DtCancelamento, "|", JustificativaCancelamento, "|", NumDocumentoUsuarioCancelamento, "|", IdLancamentoLegado
			);

			return base.ToString();
		}

	}
}
