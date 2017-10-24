using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCommunication
{
    public class RootObject
    {
        //Her er atrubutter fra dat data vi får fra api'en
        public string id { get; set; }
        public int status { get; set; }
        public string vejkode { get; set; }
        public string vejnavn { get; set; }
        public string adresseringsvejnavn { get; set; }
        public string husnr { get; set; }
        public string etage { get; set; }
        public string dør { get; set; }
        public object supplerendebynavn { get; set; }
        public string postnr { get; set; }
        public string postnrnavn { get; set; }
        public string kommunekode { get; set; }
        public string adgangsadresseid { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }
}
