using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class InvoiceController
    {
        public static void SaveInvoice(String CustIDInvoice, String GuidInvoice, String GuidCorporate, String userID, Invoice info)
        {
            try
            {
                InvoiceModel.SaveInvoice(CustIDInvoice, GuidInvoice, GuidCorporate, userID, info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetCustID(String GuidInvoice)
        {
            try
            {
                return InvoiceModel.GetCustID(GuidInvoice);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}