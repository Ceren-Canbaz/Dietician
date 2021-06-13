using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietApp
{
	public class JsonReportBuilder : ReportBuilderBase
    {
        public JsonReportBuilder(ReportInfo reportInfo) : base(reportInfo)
        {
        }

        public override string BuildDietInfo()
        {
            return "{'Diyet Bilgisi:' {'Diyet Adı: '" + reportInfo.dietName + "' }}";


        }

        public override string BuildPatientInfo()
        {
            return "{'Hasta Bilgisi:' {'Hasta Adı: '" + reportInfo.patientName + "','Hastalık: '" + reportInfo.illness + "','HastaTC: '" + reportInfo.patientTC + "' }}";
            
        }
    }
}