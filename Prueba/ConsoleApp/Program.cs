using Modelo;
using ModeloBD;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de address
            Address calzado = new Address() { address = "El calzado y Antonio Rodriguez", address2 = "Oe2J", district = "SUR", phone = 0984370983, postal_code = 1742, city_id = 1 };
            Address Quitumbe = new Address() { address = "Quitumbe y 2", address2 = "rocafuerte", district = "SUR", phone = 0984370984, postal_code = 1743, city_id = 2 };
            Address calderon = new Address() { address = "Calderon y 1", address2 = "manzana", district = "NORTE", phone = 0984370985, postal_code = 1744, city_id = 3 };
            Address Colon = new Address() { address = "Colon y 3", address2 = "aurora", district = "NORTE", phone = 0984370986, postal_code = 1745, city_id = 4 };
            Address recreo = new Address() { address = "Recreo y maldonado", address2 = "Oe3J", district = "SUR", phone = 0984370987, postal_code = 1746, city_id = 5 };
            Address solanda = new Address() { address = "Solanda y ajavi", address2 = "Oe4J", district = "SUR", phone = 0984370983, postal_code = 1747, city_id = 6 };
            Address condado = new Address() { address = "condado y 5", address2 = "Oe5J", district = "NORTE", phone = 0984370988, postal_code = 1748, city_id = 7 };
            Address pomasqui = new Address() { address = "Pomaasqui y mitad del mundo", address2 = "Oe2J", district = "NORTE", phone = 0984370989, postal_code = 1749, city_id = 8 };
            Address valle = new Address() { address = "Valle y puente 4", address2 = "Oe6J", district = "VALLE", phone = 0984370982, postal_code = 1741, city_id = 9 };
            Address marin = new Address() { address = "marin y playon", address2 = "Oe7J", district = "CENTRO", phone = 0984370923, postal_code = 17432, city_id = 10 };

        }
    }
}
