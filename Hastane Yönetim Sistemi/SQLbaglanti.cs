using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hastane_Yönetim_Sistemi;
    internal class SQLbaglanti
    {
    
    public SqlConnection Baglanti()
    {
        SqlConnection connect = new("Data Source=localhost;Initial Catalog=DBHastane;Integrated Security=True;TrustServerCertificate=True;");
        connect.Open();
        return connect;
    }
    }
