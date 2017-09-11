using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class ProjectController
    {
        public static void Save(String projectID, String projectName, String GuidProjectCRM)
        {
            try
            {
                ProjectModel.Save(projectID, projectName, GuidProjectCRM);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}