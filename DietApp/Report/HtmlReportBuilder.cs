namespace DietApp
{
	public class HtmlReportBuilder : ReportBuilderBase
	{
		public HtmlReportBuilder(ReportInfo reportInfo) : base(reportInfo)
		{
		}

		public override string BuildDietInfo()
		{
			return $"<div><h1>Diyet Bilgisi: </h1><h2>Diyet Adı: {reportInfo.dietName}</h2></div>";
		}

		public override string BuildPatientInfo()
		{
			
			return $"<div>" +
				   $"<h1>Hasta Bilgisi: </h1>" +
				   $"<h2>Hasta Adı: {reportInfo.patientName}</h2>" +
				   $"<h2>Hasta TC: {reportInfo.patientTC}</h2>" +
				   $"<h2>Hastalık: {reportInfo.illness}</h2>" +
				   "</div>";
		}
	}
}