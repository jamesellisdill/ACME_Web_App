﻿using System;
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

        //methods needs a product from the MPL list to be passed in, in order to return relevant data
        
        public string returnStatus(MasterProductList product) 
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
        

        public string returnID(MasterProductList product) 
        {
            //returns ID no. as string

            return product.ID;
        }
        

        public string returnDesc(MasterProductList product) 
        {
            //returns item description as string

            return product.item_desc;
        }
        

        public string returnSupplier(MasterProductList product) 
        {
            //returns supplier name as string

            return product.supplier;
        }
        

        public string returnBrand(MasterProductList product) 
        {
            //returns brand name as string

            return product.brand;
        }

        
        public static void addProduct(MasterProductList product)
        {
            //adds a new product to the Master Product List
            
            MPL.Add(product);
        }

        
        public static void removeProduct(MasterProductList product)
        {
            //removes a product from the Master Product List

            MPL.Remove(product);
        }
        
       
        //static method that generates the first 300 items
        //this method needs to be ran at the start of the program, and we can do this without creating an instance
        //of the object thanks to the static keyword
        public static void UpdateMPL()
        {
            MasterProductList product;

            //we manually add each item in the List

            MPL.Add(product = new MasterProductList(true, "061010", "3D BLUE 12/16 CAN", "3D ENERGY", "3D ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061014", "3D PURPLE 12/16 CAN", "3D ENERGY", "3D ENERGY"));
            MPL.Add(product = new MasterProductList(true, "301995", "6/750  80 PROOF BLUELAVA TEQ", "80 PROOF IMPORTS", "80 PROOF IMPORTS"));
            MPL.Add(product = new MasterProductList(true, "060098", "AE WITCHSBREW 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "060099", "AE KIMADE 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061000", "AE BLUE SLUSH 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061001", "AE COSMIC STAR 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061002", "AE HAWAIIANICE 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061005", "AE CHERRYSLUSH 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061007", "AE BREEZEBERRY 4/6 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061008", "AE JUICYPEACH 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061009", "AE KIWI GUAVA 4/6C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061036", "AE SLZR BEACH 2/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061037", "AE CAPP COFFEE 12/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061038", "AE MAPLECOFFEE 12/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061039", "AE MOCHACOFFEE 12/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061040", "AE SLTDCARMCOF 12/12", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061041", "AE VAN COFFEE 12/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061053", "AE MIMOSA 12/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061071", "AE COSMIC STAR 6/4 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061074", "AE WTRMLN WAVE 6/4 CANS", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061077", "AE BREEZEBERRY 6/4 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061081", "AE COSMIC STAR 2/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061082", "AE JUICYPEACH 2/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061085", "AE CHERRYSLUSH 2/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061087", "AE BREEZEBERRY 2/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061088", "AE VARIETYPACK 2/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061089", "AE JUICYPEACH 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061090", "AE TROPSICLE 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061091", "AE COSMIC STAR 24/12", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061092", "AE HAWAIIANICE 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061093", "AE MIMOSA 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061094", "AE WTRMLN WAVE 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061095", "AE CHERRYSLUSH 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061096", "AE ARCTICWHITE 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061097", "AE BREEZEBERRY 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "061098", "AE BERRY POP 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061099", "AE ROCKET POP 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061100", "AE WITCHSBREW 24/12 CANS", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061101", "AE BLUE SLUSH 24/12 CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061102", "AE DREAMFLOAT 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061114", "AE KIWI GUAVA 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061115", "AE CHOC FIT 12/12OZ", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061116", "AE VANILLA FIT 12/12OZ CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061117", "AE CKCM & FIT 12/12OZ CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061118", "AE FRTCRL FIT 12/12OZ CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061119", "AE MUNCH FIT 12/12OZ CAN", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(true, "061124", "AE KIMADE 24/12C", "ALANI", "ALANI ENERGY"));
            MPL.Add(product = new MasterProductList(false, "031749", "ALG WHITE BEER 12/19.2C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031752", "ALG WHITE BEER 4/6BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031753", "ALG WHITE BEER 2/12 CANS", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031754", "ALG WHITE BEER 4/6C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031755", "ALG WILDLIFE 6/4C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031758", "ALG WHITE BEER 1/2BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031759", "ALG WHITE BEER 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031773", "ALG TRIPEL 4/6 BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031778", "ALG TRIPEL 1/2BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031779", "ALG TRIPEL 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031791", "ALG BEACH RPT 6/4C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031792", "ALG BEACH RPT 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031800", "ALG CURIEUX 6/4 BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031808", "ALG CURIEUX 1/2BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031809", "ALG CURIEUX 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031810", "ALG BARRELBEAN 6/4 BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031813", "ALG BARRELBEAN 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031817", "ALG STORYTOLD 6/12.7OZ BTLS", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031820", "ALG SNOW REPRT 6/4C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031821", "ALG SNOW REPRT 1/6BB6", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031824", "ALG BLIEVELOVE 6/12.7OZ BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031869", "ALG HRT OF HRT 6/375ML", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031891", "ALG HAUNTED 6/4 CANS", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031893", "ALG HAUNTED 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031896", "ALG SECND SUMR 2/12 CAN", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031915", "ALG MYONE&ONLY 6/12.7OZ BTL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031917", "ALG DAYS END 6/4 BTLS", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031926", "ALG NORTH SKY 24/16 6/4 CAN", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031927", "ALG NORTH SKY 4/6B", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(false, "031928", "ALG NORTH SKY 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031938", "ALG ADVENTURE 2/12C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031954", "ALG HOP REACH 4/6C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031955", "ALG HOP REACH 2/12C", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031956", "ALG HOP REACH 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031965", "ALG GATHERWELL 6/4B", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031966", "ALG GATHERWELL 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031967", "ALG GRANDSEASN 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "031968", "ALG GLDN RASPB 1/6BBL", "ALLAGASH BREWING COMPANY", "ALLAGASH BREWING COMPANY"));
            MPL.Add(product = new MasterProductList(true, "063401", "ALO EXPOSED 12/16.9 BTL", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(true, "063402", "ALO BLUSH 12/16.9", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(true, "063405", "ALO COMFORT 12/16.9", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(true, "063411", "ALO ALLURE 12/16.9 BTL", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(true, "063421", "ALO CRISP 12/16.9 BTL", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(false, "063431", "ALO SPRING 12/16.9 BTL", "ALO DRINK", "ALO DRINK"));
            MPL.Add(product = new MasterProductList(true, "067001", "GW RAINBOWSHRB 12/12C", "ALTERNATIVE BIOLOGICS", "GYM WEED"));
            MPL.Add(product = new MasterProductList(true, "067002", "GW PEARPINAPL 12/12C", "ALTERNATIVE BIOLOGICS", "GYM WEED"));
            MPL.Add(product = new MasterProductList(true, "067003", "GW TANGERINE 12/12C", "ALTERNATIVE BIOLOGICS", "GYM WEED"));
            MPL.Add(product = new MasterProductList(true, "067004", "GW CANDYSHOP 12/12C", "ALTERNATIVE BIOLOGICS", "GYM WEED"));
            MPL.Add(product = new MasterProductList(true, "067005", "GW WATERMELON 12/12C", "ALTERNATIVE BIOLOGICS", "GYM WEED"));
            MPL.Add(product = new MasterProductList(true, "300460", "6/750  BW SPIRITS LONGBALL BOUBN KENTUCKY BOURBON", "AMERICAN SPIRITS EXCHANGE", "BUSHWOOD SPIRITS"));
            MPL.Add(product = new MasterProductList(true, "300461", "6/750  BW SPIRITS STILLWTR RYE   BUSHWOOD STILLWATER", "AMERICAN SPIRITS EXCHANGE", "BUSHWOOD SPIRITS"));
            MPL.Add(product = new MasterProductList(true, "300462", "6/750  BW SPIRITS FRONT 9 BOURBN", "AMERICAN SPIRITS EXCHANGE", "BUSHWOOD SPIRITS"));
            MPL.Add(product = new MasterProductList(true, "102050", "12/750 101N N CAB 12/750ML 101 750ML CABERNET", "ANHEUSER-BUSCH", "101 NORTH WINE"));
            MPL.Add(product = new MasterProductList(true, "102051", "12/750 101N CHARD 12/750M  101 CHARD 750ML", "ANHEUSER-BUSCH", "101 NORTH WINE"));
            MPL.Add(product = new MasterProductList(true, "102052", "12/750 101N MOSC 12/750ML  101 MOSCATO 750ML", "ANHEUSER-BUSCH", "101 NORTH WINE"));
            MPL.Add(product = new MasterProductList(true, "102054", "12/750 101N PGRIG 12/750ML 101 PINOT 750ML", "ANHEUSER-BUSCH", "101 NORTH WINE"));
            MPL.Add(product = new MasterProductList(true, "024209", "REDBRIDGE 4/6 LN BTL", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "079242", "LANDSHARK 6/4TT", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "079244", "LANDSHARK 2/12TT", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "079246", "LANDSHARK 4/6 LN BTL", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "079247", "LANDSHARK 2/12 BTL", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "094928", "LANDSHARK 1/6BBL", "ANHEUSER-BUSCH", "AB CRAFT"));
            MPL.Add(product = new MasterProductList(true, "077246", "KIRIN LT 4/6 LN BTL", "ANHEUSER-BUSCH", "AB IMPORTS"));
            MPL.Add(product = new MasterProductList(true, "078146", "ICHIBAN 4/6 LN BTL", "ANHEUSER-BUSCH", "AB IMPORTS"));
            MPL.Add(product = new MasterProductList(true, "078166", "ICHIBAN 15/22 BTL", "ANHEUSER-BUSCH", "AB IMPORTS"));
            MPL.Add(product = new MasterProductList(true, "090991", "ICHIBAN 1/2BBL", "ANHEUSER-BUSCH", "AB IMPORTS"));
            MPL.Add(product = new MasterProductList(false, "028300", "BVSELZRVARIETY 2/12 CAN", "ANHEUSER-BUSCH", "B&V SPIKED SELTZER"));
            MPL.Add(product = new MasterProductList(false, "028303", "BVSELZRVARIETY SLEEK SC", "ANHEUSER-BUSCH", "B&V SPIKED SELTZER"));
            MPL.Add(product = new MasterProductList(false, "028305", "BV BLEND VAR 2/12 CAN", "ANHEUSER-BUSCH", "B&V SPIKED SELTZER"));
            MPL.Add(product = new MasterProductList(false, "028322", "BVSELZRBLKCHRY 24/16 6/4CAN", "ANHEUSER-BUSCH", "B&V SPIKED SELTZER"));
            MPL.Add(product = new MasterProductList(true, "030902", "BP TOASTED LGR 1/2BBL", "ANHEUSER-BUSCH", "BLUE POINT"));
            MPL.Add(product = new MasterProductList(true, "030906", "BP TOASTED LGR 1/6BBL", "ANHEUSER-BUSCH", "BLUE POINT"));
            MPL.Add(product = new MasterProductList(true, "023547", "BOJANGLES TEA 6/4C", "ANHEUSER-BUSCH", "BOJANGLES TEA"));
            MPL.Add(product = new MasterProductList(true, "023548", "BOJANGLES TEA 2/12C", "ANHEUSER-BUSCH", "BOJANGLES TEA"));
            MPL.Add(product = new MasterProductList(true, "025532", "BR VAN PORTER 4/6 BTL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(false, "025552", "BR OKTOBERFEST 4/6BTL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "025572", "BR CHRISTMAS 24/12 4/6 BTL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "025573", "BR CHRISTMAS 2/169.07OZ CAN", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095804", "BR SUMMRSHANDY 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095820", "BR BD'S AMBER 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095822", "BR BD'S IPA 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095823", "BR BD'S AMBER 1/6BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095825", "BR VAN PORTER 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095826", "BR VAN PORTER 1/6BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095855", "BR CHRISTMAS 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095856", "BR CHRISTMAS 1/6BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095859", "BR MTNBEACH SR 1/6BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "095860", "BR HOP PEAK 1/2BBL", "ANHEUSER-BUSCH", "BRECKENRIDGE"));
            MPL.Add(product = new MasterProductList(true, "010871", "BUD ICE 12/40NR", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010874", "BUD ICE 2/12 CAN", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010876", "BUD ICE 15/25TT", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010877", "BUD ICE 25OZ CLIPS", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010881", "BUD ICE 24/16 3/8 CAN", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010888", "BUD ICE 18/12 CAN", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010894", "BUD ICE 2/12 LNR", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "010163", "BUD LT 2/12C 7.5OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010171", "BUD LT 40 OZ NR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010174", "BUD LT 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010175", "BUD LT 15/16 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010176", "BUD LT 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010177", "BUD LT 15/25 CLIP", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010178", "BUD LT 18/12 NR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010179", "BUD LT 15/16 CALNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010180", "BUD LT 12 OZ CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010184", "BUD LT 24/16 CALNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010188", "BUD LT 18/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010192", "BUD LT SUITCASE", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010194", "BUD LT 2/12 LNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010195", "BUD LT 24/16 STPAT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010196", "BUD LT 4/6 LN BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010199", "BUD LT 24/12 LNNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010268", "BL LIME 18/12NR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010276", "BL LIME 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010283", "BL LIME 3/8 CALNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010284", "BL LIME 2/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010288", "BL LIME 18/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010294", "BL LIME 2/12 LNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010296", "BL LIME 4/6 LN BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010353", "BL NEXT 2/12B", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010354", "BL NEXT 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010355", "BL NEXT 4/6 BTLS", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010356", "BL NEXT 4/6 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010363", "BL PLATINUM 3/8CALNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010364", "BL PLATINUM 2/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010367", "BL PLATINUM 15/25TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010368", "BL PLATINUM 18/12NR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010383", "BL LIMEARITA 6/4 16OZTT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010384", "BL LIMEARITA 24/12 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010385", "BL LIMEARITA 8OZTT 2/12", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010388", "BL LIMEARITA 12/25OZ CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010389", "BL LIMEARITA 2/12 7.5OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010394", "BL PLATINUM 2/12LNNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010396", "BL PLATINUM 4/6LNNR", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010433", "BL WTRMLN RITA 6/4TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010435", "BL WTRMLN RITA 2/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010438", "BL WTRMLN RITA 12/25OZ CANS", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010446", "BL LEMON RITA 15/25TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010450", "BL STRAWBERITA 2/12 7.5OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010463", "BL MANG-O-RITA 6/4TT 16OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010464", "BL MANG-O-RITA 24/12 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010465", "BL MANG-O-RITA 2/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010476", "BL RAZ-BERRITA 15/25TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010483", "BL STRAWBERITA 24/16 6/4TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010484", "BL STRAWBERITA 24/12 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010485", "BL STRAWBERITA 2/12TT 8OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010489", "BL STRAWBERITA 12/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010525", "RITA FALL VAR 24/12 2/12 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010646", "BL CHRYLIMRITA 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010653", "BL GUAVA RITA 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010654", "BL GUAVA RITA 24/12 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010655", "BL GUAVA RITA 2/12TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010656", "BL GUAVA RITA 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010774", "BL ORANGE 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010796", "BL ORANGE 4/6 BTL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "010800", "BL PEELS VAR 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011301", "BL SLTZR VAR 15/25 5/3 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011302", "BL SLTZR VAR 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011304", "BL SLTZR VAR 24/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011307", "BL SLTZR RETRO 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011308", "BL SLTZR RETRO VP2 2/12C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011309", "BL SLTZR VAR UGLY SWEATER", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011312", "BL SLTZRLEMLIM 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011313", "BL SLTZRLEMLIM 24/16 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011316", "BL SLTZR LEMON 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011318", "BL SLTZR LEMON 24/16 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011321", "BL SLTZR MANGO 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011322", "BL SLTZR MANGO 2/12 CANS", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011323", "BL SLTZR MANGO 24/16 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011326", "BL SLTZRSTRBRY 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011328", "BL SZ STRBRLEM 24/16 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011329", "BL SZ STRBRLEM 24/12 CANS", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011332", "BL SLTZRSTRBRY 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011333", "BL SLTZRSTRBRY 24/16 6/4 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011334", "BL SLTZRPNKLMN 15/25C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011337", "BL SZ OOO VP 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011341", "BL SLTZRBLKCHR 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011342", "BL SLTZRBLKCHR 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011357", "BL SLTZR VAR 3 2/12 SLEEK CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011366", "BL SZ COCKTAIL 2/12C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011367", "BL SZ REDHOTVP 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011371", "BL SZ PEACHTEA 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011373", "BL SZ SANGRIA 2/12C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011374", "BL SZ PRIDE VP 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011375", "BL SZ FLANNEL 2/12C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011376", "BL SZ RETROCHR 2/12C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011377", "BL SZ TEA VRTY 2/12 CANS", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "011378", "BL SZ RETRO VP 2/12C", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(false, "011379", "BL SZ SOUR VAR 2/12CAN", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(false, "011380", "BL SZ APLSLICE 2/12 CAN", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "011381", "BL SZ SODA VAR 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "011386", "BL SZ COLA 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011388", "BL SZ COLA 6/4 16OZ CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011390", "BL SZ CHRYCOLA 6/4 16OZ", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011391", "BL SZ CHRYLIME 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "011393", "BL SZ CHRYLIME 6/4 16OZ CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "077114", "BL CHELADA 2/12 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "077116", "BL CHELADA 15/25TT", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "077136", "BL CHLADA MANG 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "077146", "BL CHLADAFUEGO 15/25OZ CANS", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(false, "077156", "BLC LIMONYCHIL 15/25 CAN", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "077160", "BL CHLADATAJIN 15/25C", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "090955", "BUD LT 1/2BBL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "090956", "BUD LT 1/6BBL", "ANHEUSER-BUSCH", "BUD LIGHT"));
            MPL.Add(product = new MasterProductList(true, "010124", "BUD 2/12 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010125", "BUD 15/16 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010126", "BUD 15/25TT", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010127", "BUD 15/25 CLIP", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010128", "BUD 18/12 NR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010129", "BUD 15/16CALNR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010134", "BUD 24/16 CALNR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010138", "BUD 18/12 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010142", "BUD SUITCASE", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010144", "BUD 2/12 LNR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010146", "BUD 4/6 LN BTL", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010149", "BUD 24/12 LNNR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010592", "BUD SELECT SUITCASE", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010692", "SELECT 55 SUITCASE", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "010694", "SELECT 55 2/12LNNR", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "060562", "BUD ZERO 2/12 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(false, "060563", "BUD ZERO 4/6 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "060566", "BUD ZERO 4/6 BTL", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(false, "076115", "CHELADA VP 2/12 CAN", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "076156", "BUD CHLADA PIC 15/25", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "090910", "BUD 1/2BBL", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "090918", "BUD 1/6BBL", "ANHEUSER-BUSCH", "BUDWEISER"));
            MPL.Add(product = new MasterProductList(true, "040424", "BUSCH 2/12 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040425", "BUSCH 24/16 6/4 CANS", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040431", "BUSCH 24/16 3/8 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040442", "BUSCH SUITCASE", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040448", "BSHLT PEACH SC", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040449", "BSHLT PEACH 2/12C", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040452", "BSHLT APPLE SC", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040454", "BSHLT APPLE 2/12 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040466", "BUSCH LT 15/25TT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040474", "BUSCH LT 2/12 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040475", "BUSCH LT 24/16 6/4 CANS", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040476", "BUSCH LT 15/16 CALNR", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040481", "BUSCH LT 24/16 3/8 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040487", "BUSCH LT 18/12LNNR", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040488", "BUSCH LT 18PK TT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040492", "BUSCH LT SUITCASE", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "040499", "BUSCH LT 24/12 PREPRNT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040516", "BUSCH ICE 15/25TT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040524", "BUSCH ICE 2/12 CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040525", "BUSCH ICE 24/16 6/4TT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "040542", "BUSCH ICE SUITCASE", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(false, "060559", "BUSCH N/A 12 OZ CAN", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "060560", "BUSCH N/A 2/12TT", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "090945", "BUSCH LT 1/2BBL", "ANHEUSER-BUSCH", "BUSCH"));
            MPL.Add(product = new MasterProductList(true, "003100", "101CC CHAR12/16.9BOX", "ANHEUSER-BUSCH", "CUPCAKE"));
            MPL.Add(product = new MasterProductList(true, "003101", "101CC PINO 12/16.9BO", "ANHEUSER-BUSCH", "CUPCAKE"));
            MPL.Add(product = new MasterProductList(true, "000300", "CW SPIRITS SPRITPOP 10/12", "ANHEUSER-BUSCH", "CUTWATER"));
        
        }        
    }
}
