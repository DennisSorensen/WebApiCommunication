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
        static void Main(string[] args)
        {
            //Gå ind og hent RestSharp til applicationen, og slet den i packages i solution mappen for din application.

            RestClient client = new RestClient("https://dawa.aws.dk/adresser"); //Lav en client til dit api
            RestRequest request = new RestRequest("?vejnavn=<indsætVejnavn>&husnr=<indsætHusnr>&struktur=mini", Method.GET); //Lav et request til api'en

        }
    }
}
