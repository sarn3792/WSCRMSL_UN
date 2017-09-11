using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WSCRMSL_UN
{
    /// <summary>
    /// Summary description for Default
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Default : System.Web.Services.WebService
    {
        //Corporativo o Subsidiaria
        [WebMethod]
        public String Save(String fullName, String GuidCorporative, String GuidSubsidary)
        {
            try
            {
                if(GuidSubsidary == null || GuidSubsidary.Trim() == string.Empty) //si no viene subsidiaria es un corporativo
                {
                    CorporativeController.SaveCorporative(fullName, GuidCorporative);
                }
                else
                {
                    System.Threading.Thread.Sleep(10000);
                    SubsidaryController.SaveSubsidary(fullName, GuidCorporative, GuidSubsidary);
                }

                return "Registro guardado exitosamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public String SaveProject(String projectID, String projectName, String GuidProjectCRM)
        {
            try
            {
                ProjectController.Save(projectID, projectName, GuidProjectCRM);
                return "Registro guardado exitosamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
