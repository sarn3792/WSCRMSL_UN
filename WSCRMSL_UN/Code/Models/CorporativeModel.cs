using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class CorporativeModel
    {
        public static void SaveCorporative(String fullName, String GuidCorporative)
        {
            try
            {
                String query = String.Format("execute xsp_InsertCorporativeCRM '{0}', '{1}'", fullName, GuidCorporative);
                DataBaseSettings db = new DataBaseSettings();
                db.ExecuteQuery(query);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}