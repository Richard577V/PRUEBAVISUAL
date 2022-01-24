using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Address
    {
        //Atributos 
        public int address_id { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string district { get; set; }
        public int city_id { get; set; }
        public float postal_code { get; set; }
        public float phone { get; set; }
        public string last_update { get; set; }
    }
}
