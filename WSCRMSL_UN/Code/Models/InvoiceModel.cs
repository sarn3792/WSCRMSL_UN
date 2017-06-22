using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class InvoiceModel
    {
        public static void SaveInvoice(String CustIDInvoice, String GuidInvoice, String GuidCorporate, String userID, Invoice info)
        {
            try
            {
                //CustIDInvoice = CustIDInvoice == null ? String.Empty : CustIDInvoice;

                String query = String.Format(@"execute xsp_InsertAllInformation '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 
                                              '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', 
                                              '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', 
                                              '{23}', '{24}', '{25}', '{26}'", 
                                              CustIDInvoice, userID, GuidCorporate, info.razonSocial, info.nombre, info.apellidoPaterno, info.apellidoMaterno, info.email, 
                                              info.calle, info.numero, info.numeroInterior, info.colonia, info.CP, info.ciudad, info.municipio, info.estado, 
                                              info.pais, info.fax, info.telefono, info.metodoPago, info.numeroCuenta, info.codigoImpuesto1, info.RFC, 
                                              info.tipoCliente, info.condicionesPago, GuidInvoice, info.tipoPersona); //execute procedure
                DataBaseSettings db = new DataBaseSettings();
                db.ExecuteQuery(query);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetCustID(String GuidInvoice)
        {
            try
            {
                String query = String.Format("SELECT * FROM xCustomerAdic WHERE User6 = '{0}'", GuidInvoice);
                DataBaseSettings db = new DataBaseSettings();
                DataTable aux = db.GetDataTable(query);

                if(aux.Rows.Count > 0)
                {
                    return aux.Rows[0]["CustID"].ToString(); //CustID 
                }
                else
                {
                    throw new Exception(String.Format("CustID en SL con el Guid de facturación {0} en CRM no fue encontrado", GuidInvoice));
                }

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}