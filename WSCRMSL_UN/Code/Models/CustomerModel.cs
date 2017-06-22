using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class CustomerModel
    {
        public static void SaveCustomer(String fullName, String IDCrm)
        {
            try
            {
                String query = String.Format("execute [XSP_InsertCustomerCRM] '{0}', '{1}'", fullName, IDCrm);
                DataBaseSettings db = new DataBaseSettings();
                db.ExecuteQuery(query);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetCustomerID(String IDCrm)
        {
            try
            {
                String query = String.Format("SELECT * FROM CustomerCRM WHERE GuidCrm = '{0}'", IDCrm);
                DataBaseSettings db = new DataBaseSettings();
                DataTable aux = db.GetDataTable(query);
                if(aux.Rows.Count > 0)
                {
                    return aux.Rows[0]["CustId"].ToString();
                }

                throw new Exception(String.Format("The customer with the ID {0} was not found", IDCrm));

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}