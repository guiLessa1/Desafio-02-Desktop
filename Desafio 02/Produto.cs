using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_02
{
    internal class Produto
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }

    }
}
