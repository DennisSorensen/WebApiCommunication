using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCommunication
{
    class Program
    {
        private static string vejNavn = "";
        private static string husNr = "";
        private static List<RootObject> content;

        static void Main(string[] args)
        {
            Console.Write("Skriv et vejnavn: ");

            string tempVejNavn = Console.ReadLine();

            vejNavn = tempVejNavn.First().ToString().ToUpper(); //Laver det første bogstav om til stort
            vejNavn += tempVejNavn.Substring(1); //Sletter det første bogstav i variablen, og indstter resten efter det første bogstav (lavet ovenfor)
            
            Console.Write("Skriv husnr: ");
            husNr = Console.ReadLine();
            Console.WriteLine(" ");

            CallApi(vejNavn,husNr); //Kalder metode som kalder api

            PrintAllAddresses();

        }

        public static void CallApi(string vejNavn,string husNr)
        {
            //Gå ind og hent RestSharp til applicationen, og slet den i packages i solution mappen for din application.

            RestClient client = new RestClient("https://dawa.aws.dk/adresser"); //Lav en client til dit api
            RestRequest request = new RestRequest("?vejnavn=" + vejNavn + "&husnr=" + husNr + "&struktur=mini", Method.GET); //Lav et request til api'en

            //Tester requesten i en browser, og laver json dataen om til en klasse, og indsætter den i projektet

            IRestResponse<List<RootObject>> response = client.Execute<List<RootObject>>(request); //Vi laver en liste af RootObjects som vi får fra api'en
            
            content = response.Data; //Variabel som indeholder det data vi får retur


            
        }

        public static void PrintAllAddresses()
        {
            Console.WriteLine("Der er fundet {0} adresser på {1} {2}", content.Count, vejNavn, husNr);
            Console.WriteLine(" ");

            foreach (var entity in content)
            {
                Console.WriteLine(entity.vejnavn + " " + entity.husnr + " " + entity.etage + " " + entity.dør);
                Console.WriteLine(entity.postnr + " " + entity.postnrnavn);

                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }
}
