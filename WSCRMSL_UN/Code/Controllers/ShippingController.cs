using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSCRMSL_UN
{
    public class ShippingController
    {
        public static void SaveShippingInformation(String custID, String GuidShipping, String shipToID, String userID, Shipping info)
        {
            try
            {
                ShippingModel.SaveShippingInformation(custID, GuidShipping, shipToID, userID, info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String GetShipToID(String GuidShipping)
        {
            try
            {
                return ShippingModel.GetShipToID(GuidShipping);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}