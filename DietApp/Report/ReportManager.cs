namespace DietApp
{
	public class ReportManager
    {
        private ReportBuilderBase reportBuilderBase;

        public ReportManager(ReportBuilderBase reportBuilder)
        {
            reportBuilderBase = reportBuilder;
        }

        public string BuildOutput()
        {
            return reportBuilderBase.BuildOutput();
        }

        public string BuildUpsideDown()
        {
            string result = "";
            result += reportBuilderBase.BuildDietInfo();
            result += reportBuilderBase.BuildPatientInfo();
            return result;
        }

    }
}