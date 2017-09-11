using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class ProjectModel
    {
        public static void Save(String projectID, String projectName, String GuidProjectCRM)
        {
            try
            {
                String query = String.Format(@"EXEC xsp_InsertProjectCRM '{0}', '{1}', '{2}'", projectID, projectName, GuidProjectCRM);
                DataBaseSettings db = new DataBaseSettings();
                db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}