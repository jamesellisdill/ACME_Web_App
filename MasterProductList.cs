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

        //methods needs a product from the MPL list to be passed in, in order to return relevant data
        
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

        //start here
        
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
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", "BUD ICE"));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(true, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
            MPL.Add(product = new MasterProductList(, "", "", "ANHEUSER-BUSCH", ""));
        
        }        
    }
}
