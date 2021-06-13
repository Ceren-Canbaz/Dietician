namespace DietApp
{
	public abstract class ReportBuilderBase
    {
        protected ReportInfo reportInfo;

        public ReportBuilderBase(ReportInfo reportInfo)
        {
            this.reportInfo = reportInfo;
        }

        public abstract string BuildPatientInfo();
        public abstract string BuildDietInfo();

        public string BuildOutput()
        {
            string result = "";
            result += BuildPatientInfo();
            result += BuildDietInfo();
            return result;
        }

    }
}