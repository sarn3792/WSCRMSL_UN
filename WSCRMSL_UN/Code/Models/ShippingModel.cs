using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class ShippingModel
    {
        public static void SaveShippingInformation(String custID, String GuidShipping, String shipToID, String userID, Shipping info)
        {
            try
            {
                String query = String.Format(@"execute xsp_InsertAllInformation_Envio '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', 
                                              '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', 
                                              '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', 
                                              '{23}', '{24}', '{25}', '{26}', '{27}'",
                                              custID, userID, String.Empty, info.nombre, info.contacto, String.Empty, String.Empty, String.Empty,
                                              info.direccion1, String.Empty, String.Empty, info.direccion2, info.codigoPostal, info.ciudad, String.Empty, info.estado,
                                              info.pais, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, info.saludo,
                                              String.Empty, String.Empty, GuidShipping, String.Empty, shipToID); //execute procedure
                DataBaseSettings db = new DataBaseSettings();
                db.ExecuteQuery(query);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetShipToID(String GuidShipping)
        {
            try
            {
                String query = String.Format("SELECT * FROM xsoaddress WHERE User6 = '{0}'", GuidShipping);
                DataBaseSettings db = new DataBaseSettings();
                DataTable aux = db.GetDataTable(query);

                if(aux.Rows.Count > 0)
                {
                    return aux.Rows[0]["ShipToId"].ToString();
                }
                
                throw new Exception(String.Format("El ShipToID para el Guid de envío {0} no fue encontrado", GuidShipping));
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}