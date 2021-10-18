using System;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using MongoDB.Bson;  
using MongoDB.Driver;  

namespace DividendProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> hisseler = new List<String>();
            List<String> tarihler = new List<String>();

            /*WebClient wc = new WebClient();
            wc.Headers.Add("Authorization","apikey apikeyiniz");
            var response = wc.DownloadString("https://api.collectapi.com/economy/hisseSenedi");
            Result sonuc = JsonConvert.DeserializeObject<Result>(response);
            foreach (var item in sonuc.result)
            {
                hisseler.Add(item.code);
            }
            hisseler.Sort();*/

            //Yukarıdaki api çağırımı aşağıdaki listeye eklemeyi yapar. Halka arzlarda yukarıdaki alan çağırılabilir.
            #region Hisseler listeye ekleniyor.
            hisseler.Add("ACSEL");
            hisseler.Add("ADEL");
            hisseler.Add("ADESE");
            hisseler.Add("AEFES");
            hisseler.Add("AFYON");
            hisseler.Add("AGHOL");
            hisseler.Add("AGYO");
            hisseler.Add("AKBNK");
            hisseler.Add("AKCNS");
            hisseler.Add("AKENR");
            hisseler.Add("AKFGY");
            hisseler.Add("AKGRT");
            hisseler.Add("AKMGY");
            hisseler.Add("AKSA");
            hisseler.Add("AKSEN");
            hisseler.Add("AKSGY");
            hisseler.Add("AKSUE");
            hisseler.Add("AKYHO");
            hisseler.Add("ALARK");
            hisseler.Add("ALBRK");
            hisseler.Add("ALCAR");
            hisseler.Add("ALCTL");
            hisseler.Add("ALGYO");
            hisseler.Add("ALKA");
            hisseler.Add("ALKIM");
            hisseler.Add("ALMAD");
            hisseler.Add("ANELE");
            hisseler.Add("ANHYT");
            hisseler.Add("ANSGR");
            hisseler.Add("ARCLK");
            hisseler.Add("ARDYZ");
            hisseler.Add("ARENA");
            hisseler.Add("ARMDA");
            hisseler.Add("ARSAN");
            hisseler.Add("ARZUM");
            hisseler.Add("ASELS");
            hisseler.Add("ASUZU");
            hisseler.Add("ATAGY");
            hisseler.Add("ATEKS");
            hisseler.Add("ATLAS");
            hisseler.Add("ATSYH");
            hisseler.Add("AVGYO");
            hisseler.Add("AVHOL");
            hisseler.Add("AVISA");
            hisseler.Add("AVOD");
            hisseler.Add("AVTUR");
            hisseler.Add("AYCES");
            hisseler.Add("AYDEM");
            hisseler.Add("AYEN");
            hisseler.Add("AYES");
            hisseler.Add("AYGAZ");
            hisseler.Add("BAGFS");
            hisseler.Add("BAKAB");
            hisseler.Add("BALAT");
            hisseler.Add("BANVT");
            hisseler.Add("BASCM");
            hisseler.Add("BAYRK");
            hisseler.Add("BERA");
            hisseler.Add("BEYAZ");
            hisseler.Add("BFREN");
            hisseler.Add("BIMAS");
            hisseler.Add("BIOEN");
            hisseler.Add("BIZIM");
            hisseler.Add("BJKAS");
            hisseler.Add("BLCYT");
            hisseler.Add("BNTAS");
            hisseler.Add("BOSSA");
            hisseler.Add("BRISA");
            hisseler.Add("BRKO");
            hisseler.Add("BRKSN");
            hisseler.Add("BRMEN");
            hisseler.Add("BRSAN");
            hisseler.Add("BRYAT");
            hisseler.Add("BSOKE");
            hisseler.Add("BTCIM");
            hisseler.Add("BUCIM");
            hisseler.Add("BURCE");
            hisseler.Add("BURVA");
            hisseler.Add("CANTE");
            hisseler.Add("CASA");
            hisseler.Add("CCOLA");
            hisseler.Add("CELHA");
            hisseler.Add("CEMAS");
            hisseler.Add("CEMTS");
            hisseler.Add("CEOEM");
            hisseler.Add("CIMSA");
            hisseler.Add("CLEBI");
            hisseler.Add("CMBTN");
            hisseler.Add("CMENT");
            hisseler.Add("COSMO");
            hisseler.Add("CRDFA");
            hisseler.Add("CRFSA");
            hisseler.Add("CUSAN");
            hisseler.Add("DAGHL");
            hisseler.Add("DAGI");
            hisseler.Add("DARDL");
            hisseler.Add("DENGE");
            hisseler.Add("DERHL");
            hisseler.Add("DERIM");
            hisseler.Add("DESA");
            hisseler.Add("DESPC");
            hisseler.Add("DEVA");
            hisseler.Add("DGATE");
            hisseler.Add("DGGYO");
            hisseler.Add("DGKLB");
            hisseler.Add("DIRIT");
            hisseler.Add("DITAS");
            hisseler.Add("DMSAS");
            hisseler.Add("DNISI");
            hisseler.Add("DOAS");
            hisseler.Add("DOBUR");
            hisseler.Add("DOCO");
            hisseler.Add("DOGUB");
            hisseler.Add("DOHOL");
            hisseler.Add("DOKTA");
            hisseler.Add("DURDO");
            hisseler.Add("DYOBY");
            hisseler.Add("DZGYO");
            hisseler.Add("ECILC");
            hisseler.Add("ECZYT");
            hisseler.Add("EDIP");
            hisseler.Add("EGEEN");
            hisseler.Add("EGGUB");
            hisseler.Add("EGPRO");
            hisseler.Add("EGSER");
            hisseler.Add("EKGYO");
            hisseler.Add("EKIZ");
            hisseler.Add("EMKEL");
            hisseler.Add("EMNIS");
            hisseler.Add("ENJSA");
            hisseler.Add("ENKAI");
            hisseler.Add("EPLAS");
            hisseler.Add("ERBOS");
            hisseler.Add("EREGL");
            hisseler.Add("ERSU");
            hisseler.Add("ESCOM");
            hisseler.Add("ESEN");
            hisseler.Add("ETILR");
            hisseler.Add("ETYAT");
            hisseler.Add("EUHOL");
            hisseler.Add("EUKYO");
            hisseler.Add("EUYO");
            hisseler.Add("FADE");
            hisseler.Add("FENER");
            hisseler.Add("FLAP");
            hisseler.Add("FMIZP");
            hisseler.Add("FONET");
            hisseler.Add("FORMT");
            hisseler.Add("FRIGO");
            hisseler.Add("FROTO");
            hisseler.Add("GARAN");
            hisseler.Add("GARFA");
            hisseler.Add("GEDIK");
            hisseler.Add("GEDZA");
            hisseler.Add("GENTS");
            hisseler.Add("GEREL");
            hisseler.Add("GLBMD");
            hisseler.Add("GLRYH");
            hisseler.Add("GLYHO");
            hisseler.Add("GOLTS");
            hisseler.Add("GOODY");
            hisseler.Add("GOZDE");
            hisseler.Add("GRNYO");
            hisseler.Add("GSDDE");
            hisseler.Add("GSDHO");
            hisseler.Add("GSRAY");
            hisseler.Add("GUBRF");
            hisseler.Add("GWIND");
            hisseler.Add("HALKB");
            hisseler.Add("HATEK");
            hisseler.Add("HDFGS");
            hisseler.Add("HEKTS");
            hisseler.Add("HLGYO");
            hisseler.Add("HUBVC");
            hisseler.Add("HURGZ");
            hisseler.Add("ICBCT");
            hisseler.Add("IDEAS");
            hisseler.Add("IDGYO");
            hisseler.Add("IEYHO");
            hisseler.Add("IHEVA");
            hisseler.Add("IHGZT");
            hisseler.Add("IHLAS");
            hisseler.Add("IHLGM");
            hisseler.Add("IHYAY");
            hisseler.Add("INDES");
            hisseler.Add("INFO");
            hisseler.Add("INTEM");
            hisseler.Add("INVEO");
            hisseler.Add("IPEKE");
            hisseler.Add("ISBIR");
            hisseler.Add("ISBTR");
            hisseler.Add("ISCTR");
            hisseler.Add("ISDMR");
            hisseler.Add("ISFIN");
            hisseler.Add("ISGSY");
            hisseler.Add("ISGYO");
            hisseler.Add("ISKPL");
            hisseler.Add("ISMEN");
            hisseler.Add("ISYAT");
            hisseler.Add("ITTFH");
            hisseler.Add("IZFAS");
            hisseler.Add("IZMDC");
            hisseler.Add("IZTAR");
            hisseler.Add("JANTS");
            hisseler.Add("KAPLM");
            hisseler.Add("KAREL");
            hisseler.Add("KARSN");
            hisseler.Add("KARTN");
            hisseler.Add("KATMR");
            hisseler.Add("KCHOL");
            hisseler.Add("KENT");
            hisseler.Add("KERVN");
            hisseler.Add("KERVT");
            hisseler.Add("KFEIN");
            hisseler.Add("KLGYO");
            hisseler.Add("KLMSN");
            hisseler.Add("KLNMA");
            hisseler.Add("KNFRT");
            hisseler.Add("KONTR");
            hisseler.Add("KONYA");
            hisseler.Add("KORDS");
            hisseler.Add("KOZAA");
            hisseler.Add("KOZAL");
            hisseler.Add("KRDMA");
            hisseler.Add("KRDMB");
            hisseler.Add("KRDMD");
            hisseler.Add("KRGYO");
            hisseler.Add("KRONT");
            hisseler.Add("KRSTL");
            hisseler.Add("KRTEK");
            hisseler.Add("KRVGD");
            hisseler.Add("KSTUR");
            hisseler.Add("KUTPO");
            hisseler.Add("KUYAS");
            hisseler.Add("LIDFA");
            hisseler.Add("LINK");
            hisseler.Add("LKMNH");
            hisseler.Add("LOGO");
            hisseler.Add("LUKSK");
            hisseler.Add("MAALT");
            hisseler.Add("MAKTK");
            hisseler.Add("MARKA");
            hisseler.Add("MARTI");
            hisseler.Add("MAVI");
            hisseler.Add("MEGAP");
            hisseler.Add("MEPET");
            hisseler.Add("MERIT");
            hisseler.Add("MERKO");
            hisseler.Add("METRO");
            hisseler.Add("METUR");
            hisseler.Add("MGROS");
            hisseler.Add("MIPAZ");
            hisseler.Add("MMCAS");
            hisseler.Add("MNDRS");
            hisseler.Add("MPARK");
            hisseler.Add("MRGYO");
            hisseler.Add("MRSHL");
            hisseler.Add("MSGYO");
            hisseler.Add("MTRKS");
            hisseler.Add("MTRYO");
            hisseler.Add("MZHLD");
            hisseler.Add("NATEN");
            hisseler.Add("NETAS");
            hisseler.Add("NIBAS");
            hisseler.Add("NTGAZ");
            hisseler.Add("NTHOL");
            hisseler.Add("NUGYO");
            hisseler.Add("NUHCM");
            hisseler.Add("ODAS");
            hisseler.Add("OLMIP");
            hisseler.Add("ORGE");
            hisseler.Add("ORMA");
            hisseler.Add("OSMEN");
            hisseler.Add("OSTIM");
            hisseler.Add("OTKAR");
            hisseler.Add("OYAKC");
            hisseler.Add("OYAYO");
            hisseler.Add("OYLUM");
            hisseler.Add("OZBAL");
            hisseler.Add("OZGYO");
            hisseler.Add("OZKGY");
            hisseler.Add("OZRDN");
            hisseler.Add("PAGYO");
            hisseler.Add("PAMEL");
            hisseler.Add("PAPIL");
            hisseler.Add("PARSN");
            hisseler.Add("PEGYO");
            hisseler.Add("PEKGY");
            hisseler.Add("PENGD");
            hisseler.Add("PETKM");
            hisseler.Add("PETUN");
            hisseler.Add("PGSUS");
            hisseler.Add("PINSU");
            hisseler.Add("PKART");
            hisseler.Add("PKENT");
            hisseler.Add("PNSUT");
            hisseler.Add("POLHO");
            hisseler.Add("POLTK");
            hisseler.Add("PRKAB");
            hisseler.Add("PRKME");
            hisseler.Add("PRZMA");
            hisseler.Add("PSDTC");
            hisseler.Add("QNBFB");
            hisseler.Add("QNBFL");
            hisseler.Add("QUAGR");
            hisseler.Add("RALYH");
            hisseler.Add("RAYSG");
            hisseler.Add("RHEAG");
            hisseler.Add("RODRG");
            hisseler.Add("ROYAL");
            hisseler.Add("RTALB");
            hisseler.Add("RYGYO");
            hisseler.Add("RYSAS");
            hisseler.Add("SAFKR");
            hisseler.Add("SAHOL");
            hisseler.Add("SAMAT");
            hisseler.Add("SANEL");
            hisseler.Add("SANFM");
            hisseler.Add("SANKO");
            hisseler.Add("SARKY");
            hisseler.Add("SASA");
            hisseler.Add("SAYAS");
            hisseler.Add("SEKFK");
            hisseler.Add("SEKUR");
            hisseler.Add("SELEC");
            hisseler.Add("SELGD");
            hisseler.Add("SERVE");
            hisseler.Add("SEYKM");
            hisseler.Add("SILVR");
            hisseler.Add("SISE");
            hisseler.Add("SKBNK");
            hisseler.Add("SKTAS");
            hisseler.Add("SMART");
            hisseler.Add("SNGYO");
            hisseler.Add("SNKRN");
            hisseler.Add("SNPAM");
            hisseler.Add("SODSN");
            hisseler.Add("SOKM");
            hisseler.Add("SONME");
            hisseler.Add("SRVGY");
            hisseler.Add("SUMAS");
            hisseler.Add("TACTR");
            hisseler.Add("TATGD");
            hisseler.Add("TAVHL");
            hisseler.Add("TBORG");
            hisseler.Add("TCELL");
            hisseler.Add("TDGYO");
            hisseler.Add("TEKTU");
            hisseler.Add("TGSAS");
            hisseler.Add("THYAO");
            hisseler.Add("TIRE");
            hisseler.Add("TKFEN");
            hisseler.Add("TKNSA");
            hisseler.Add("TKURU");
            hisseler.Add("TLMAN");
            hisseler.Add("TMPOL");
            hisseler.Add("TMSN");
            hisseler.Add("TOASO");
            hisseler.Add("TRCAS");
            hisseler.Add("TRGYO");
            hisseler.Add("TRILC");
            hisseler.Add("TSGYO");
            hisseler.Add("TSKB");
            hisseler.Add("TSPOR");
            hisseler.Add("TTKOM");
            hisseler.Add("TTRAK");
            hisseler.Add("TUCLK");
            hisseler.Add("TUKAS");
            hisseler.Add("TUPRS");
            hisseler.Add("TUREX");
            hisseler.Add("TURGG");
            hisseler.Add("TURSG");
            hisseler.Add("UFUK");
            hisseler.Add("ULAS");
            hisseler.Add("ULKER");
            hisseler.Add("ULUSE");
            hisseler.Add("ULUUN");
            hisseler.Add("UMPAS");
            hisseler.Add("USAK");
            hisseler.Add("UTPYA");
            hisseler.Add("UZERB");
            hisseler.Add("VAKBN");
            hisseler.Add("VAKFN");
            hisseler.Add("VAKKO");
            hisseler.Add("VANGD");
            hisseler.Add("VERTU");
            hisseler.Add("VERUS");
            hisseler.Add("VESBE");
            hisseler.Add("VESTL");
            hisseler.Add("VKFYO");
            hisseler.Add("VKGYO");
            hisseler.Add("VKING");
            hisseler.Add("YAPRK");
            hisseler.Add("YATAS");
            hisseler.Add("YAYLA");
            hisseler.Add("YBTAS");
            hisseler.Add("YESIL");
            hisseler.Add("YGGYO");
            hisseler.Add("YGYO");
            hisseler.Add("YKBNK");
            hisseler.Add("YKGYO");
            hisseler.Add("YKSLN");
            hisseler.Add("YONGA");
            hisseler.Add("YUNSA");
            hisseler.Add("YYAPI");
            hisseler.Add("ZOREN");
            #endregion Hisseler listeye ekleniyor.

            String connectionString ="mongodb+srv://username:password@cluster0.ay0pa.mongodb.net/StocksManagement?retryWrites=true&w=majority";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("StocksManagement");
            var temettuCollection = database.GetCollection<BsonDocument>("Dividend");

           
            int tarihIndex = 9, verimIndex = 10, temettuIndex=11, artis=7;
            StringBuilder sb = new StringBuilder();
            string link = "https://www.isyatirim.com.tr/tr-tr/analiz/hisse/Sayfalar/sirket-karti.aspx?hisse="; 
            
            foreach (var hisse in hisseler)
            {
                int tarih = tarihIndex, verim = verimIndex, temettu = temettuIndex, yil;
                tarihler = new List<String>();

                Console.WriteLine(hisse + " hissesi için işlem yapılıyor.");

                sb = new StringBuilder();
                sb.Append(link);
                sb.Append(hisse);

                HtmlAgilityPack.HtmlWeb hweb = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = hweb.Load(sb.ToString());

                var tableData = document.DocumentNode.SelectNodes("//td[@class='text-right']");              
                var filterDividends = Builders<BsonDocument>.Filter.Eq("Code", hisse);
                var AllDividend = temettuCollection.Find(filterDividends).ToList();

                
                for (int i = 1; i <6; i++)
                {
                    try
                    {
                        String tarihString = tableData[tarih].InnerText.ToString();
                        try
                        {
                            yil = int.Parse(tarihString.Split(".")[2]);
                        }
                        catch (System.Exception ex)
                        {
                            yil = 0;
                        }

                        if(tarihString != "Açıklanmadı" && yil < 2017){
                            break;
                        }
                        
                        String temettuString = tableData[temettu].InnerText.ToString();
                        double temettuDouble = Double.Parse(temettuString);
                        
                        if(temettuDouble == 0){
                            break;
                        }

                        String verimString = tableData[verim].InnerText.ToString();
                        double verimDouble = Double.Parse(verimString);
                        
                        tarih = tarihIndex + i*artis;
                        verim = verimIndex + i*artis;
                        temettu = temettuIndex+ i*artis;

                        if(tarihler.Contains(tarihString)){
                            continue;
                        }else{
                            tarihler.Add(tarihString);
                        }

                        Console.WriteLine(tarihString + " --> " + temettuString + "-->" + verimDouble);

                        if(AllDividend.Count == 0 && temettuDouble != 0 ){
                            //Ekleme işlemi yapılıyor
                            temettuCollection.InsertOne(new BsonDocument
                            {
                                    {"Code", hisse},
                                    {"Date", tarihString},
                                    {"Value", temettuDouble},
                                    {"Yield", verimDouble}
                            });
                        }
                        else if(AllDividend.Where(x=>x["Date"] == tarihString).FirstOrDefault() == null){
                            //Ekleme işlemi yapılıyor
                            temettuCollection.InsertOne(new BsonDocument
                            {
                                    {"Code", hisse},
                                    {"Date", tarihString},
                                    {"Value", temettuDouble},
                                    {"Yield", verimDouble}
                            });
                        }
                        else if(AllDividend.Where(x=>x["Date"] == tarihString).FirstOrDefault()["Value"] != temettuDouble){
                            //Eğer belirtilen tarihdeki temettü miktarı değişmişse veritabanında değer değiştirilecek.
                            ObjectId oid = (ObjectId)AllDividend.Where(x=>x["Date"] == tarihString).FirstOrDefault()["_id"];
                            var filtera = Builders<BsonDocument>.Filter.Eq("_id", oid);
                            var update = Builders<BsonDocument>.Update.Set("Value", temettuDouble);
                            temettuCollection.UpdateOne(filtera, update);

                            AllDividend.Remove(AllDividend.Where(x=>x["Date"] == tarihString).FirstOrDefault());
                        }
                        else{
                            //Eğer herhangi bir değişiklik yoksa tekrardan DB'ye gitmemek için listeden siliniyor.
                            AllDividend.Remove(AllDividend.Where(x=>x["Date"] == tarihString).FirstOrDefault());
                        }


                   }
                   catch (System.Exception ex)
                   {
                        Console.WriteLine(ex + " için temettü yok");
                        break;
                   }
                    
                }  
            
                foreach (var dividend in AllDividend)
                {
                    ObjectId oid = (ObjectId)dividend["_id"];
                    var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", oid);
                    temettuCollection.DeleteOne(deleteFilter);
                }
            }           
        }
    }
}
