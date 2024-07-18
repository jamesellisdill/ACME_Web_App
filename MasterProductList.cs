using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public class MasterProductList
    {
      //these are what we felt were the most important to attributes to have for the prototype MPL

      private bool status;
      private string ID, item_desc, supplier, brand;
      public static List<MasterProductList> MPL = new List<MasterProductList>();

        //overloaded constructor
        public MasterProductList(bool status, string ID, string item_desc, string supplier, string brand)
        {
            this.status = status;
            this.ID = ID;
            this.item_desc = item_desc;
            this.supplier = supplier;
            this.brand = brand;
        }

        //static method that generates the first 300 items
        public static void UpdateMPL()
        {
            MasterProductList product;

            //we manually add each item in the List

            MPL.Add(product = new MasterProductList(true, "061010", "3D BLUE 12/16 CAN", "3D ENERGY", "3D ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061014", "3D PURPLE 12/16 CAN", "3D ENERGY", "3D ENERGY"));
            MPL.Add(product = new MasterProductList(true, "301995", "6/750  80 PROOF BLUELAVA TEQ", "80 PROOF IMPORTS", "80 PROOF IMPORTS"));
            MPL.Add(product = new MasterProductList(true, "060098", "AE WITCHSBREW 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "60099", "AE KIMADE 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "61000", "AE BLUE SLUSH 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "61001", "AE COSMIC STAR 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "61002", "AE HAWAIIANICE 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
            MPL.Add(product = new MasterProductList(, "", "", "", ""));
    
        }

        public static string returnStatus(MasterProductList product) 
        {
            //since status is a boolean value, we want to return something tangible
            //if true, we return active
            //if false, we reutrn restricted

            string status;

            if (product.status == true)
            {
                status = "Active";
            }
            else
            {
                status = "Restricted";
            }

            return status;
        }
        
    }
}
