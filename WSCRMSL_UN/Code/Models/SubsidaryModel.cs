using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class SubsidaryModel
    {
        public static void SaveSubsidary(String fullName, String GuidCorporative, String GuidSubsidary)
        {
            try
            {
                String query = String.Format("execute xsp_InsertSubsidaryCRM '{0}', '{1}', '{2}'", fullName, GuidCorporative, GuidSubsidary);
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