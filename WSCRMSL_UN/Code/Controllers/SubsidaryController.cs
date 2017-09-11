using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class SubsidaryController
    {
        public static void SaveSubsidary(String fullName, String GuidCorporative, String GuidSubsidary)
        {
            try
            {
                SubsidaryModel.SaveSubsidary(fullName, GuidCorporative, GuidSubsidary);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}