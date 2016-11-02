using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        /*
         * public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int GetRandomNumber()
        {
            Random number = new Random();
            return number.Next(1000, 3000);
        }
        */
        public string SayHello(string name)
        {
            return string.Format("Dag meneer of mevrouw {0}!", name);
        }

        public string VergelijkLeeftijdMetRonaldo(int jaar, int maand, int dag)
        {
            DateTime dtRonaldo = new DateTime(1985, 2, 5);
            DateTime dtRequest = new DateTime(jaar, maand, dag);
            string sRetValue = String.Empty;
            int iCompare = DateTime.Compare(dtRonaldo, dtRequest);
            if (iCompare > 0)
            {
                //Ronaldo is younger
                TimeSpan ts = dtRonaldo - dtRequest;
                int iNmbOfDays = Convert.ToInt32(ts.TotalDays);
                sRetValue = "Je bent " + iNmbOfDays + " dag" + (iNmbOfDays > 1 ? "en" : "") + " ouder dan Ronaldo.";
            }
            else if (iCompare==0)
            {
                //Ronaldo is as old as you
                sRetValue = "Je bent precies even oud als Ronaldo.";
            }
            else
            {
                //Ronaldo is older
                TimeSpan ts = dtRequest - dtRonaldo;
                int iNmbOfDays = Convert.ToInt32(ts.TotalDays);
                sRetValue = "Je bent " + iNmbOfDays + " dag" + (iNmbOfDays > 1 ? "en" : "") + " jonger dan Ronaldo.";
            }
            return sRetValue;
        }


        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
}
