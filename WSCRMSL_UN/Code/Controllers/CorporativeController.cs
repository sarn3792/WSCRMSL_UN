using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class CorporativeController
    {
        public static void SaveCorporative(String fullName, String GuidCorporative)
        {
            try
            {
                CorporativeModel.SaveCorporative(fullName, GuidCorporative);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}