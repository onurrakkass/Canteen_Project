using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KantinProje2
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-ELLTLFB;Initial Catalog=Kantin;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
