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
        //Corporativo únicamente inserta y no regresa nada
        [WebMethod]
        public String SaveCustomer(String fullName, String IDCrm)
        {
            try
            {
                CustomerController.SaveCustomer(fullName, IDCrm);
                return "Corporativo guardado exitosamente";
                //return CustomerController.GetCustomerID(IDCrm); //CustID del corporativo
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //[WebMethod]
        //[ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        //public String GetCustomerID(String IDCrm)
        //{
        //    try
        //    {
        //        return CustomerController.GetCustomerID(IDCrm);
        //    } catch (Exception ex)
        //    {
        //        return String.Format("Error: '{0}'", ex.Message);
        //    }
        //}

        [WebMethod]
        public String SaveInvoiceInformation(String CustIDInvoice, String GuidInvoice, String GuidCorporate, String userID, Invoice info)
        {
            try
            {
                InvoiceController.SaveInvoice(CustIDInvoice, GuidInvoice, GuidCorporate, userID, info);
                if (CustIDInvoice == " ")
                {
                    CRM.WSUpdateF crm = new CRM.WSUpdateF();
                    String result = crm.UpdateFactura(GuidInvoice.ToUpper().Trim(), InvoiceController.GetCustID(GuidInvoice).Trim());
                }

                return "Información insertada correctamente";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public String SaveShippingInformation(String custID, String GuidShipping, String shipToID, String userID, Shipping info)
        {
            try
            {
                ShippingController.SaveShippingInformation(custID, GuidShipping, shipToID, userID, info);
                if(shipToID == String.Empty) //Update shipToID en CRM
                {
                    CRM.WSUpdateF crm = new CRM.WSUpdateF();
                    crm.UpdateEnvio(GuidShipping, ShippingController.GetShipToID(GuidShipping));
                    
                }
                return "Shipping information was successfully save";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //falta agregar el método get para obtener el ShipToID
    }
}
