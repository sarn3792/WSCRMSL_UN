using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class CustomerController
    {
        public static void SaveCustomer(String fullName, String IDCrm)
        {
            try
            {
                CustomerModel.SaveCustomer(fullName, IDCrm);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetCustomerID(String IDCrm)
        {
            try
            {
                return CustomerModel.GetCustomerID(IDCrm);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}