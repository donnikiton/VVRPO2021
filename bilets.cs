using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DB_Kurs
{
    class bilets
    {
       
            public DB_Kurs() { }

            public DB_Kurs(int ID_bilet, string FIO_user, int price)
            {
                ID_bilet = ID_bilet;
                FIO_user = FIO_user;
                price = price;
            }
            [Key]
            public int ID_bilet { get; set; }
            public string FIO_user { get; set; }
            public int price { get; set; }
        }
    }
}
}
