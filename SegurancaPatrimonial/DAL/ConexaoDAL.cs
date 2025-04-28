using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SegurancaPatrimonial.DAL
{
    class ConexaoDAL
    {
        OleDbConnection conn = new OleDbConnection();
	
	    static public string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\seris\OneDrive\= DESENVOLVIMENTO =\= SISTEMA SEGPAT =\SegurancaPatrimonial\SegurancaPatrimonial\db_gestao_segpat.accdb";

        public ConexaoDAL()
        {
            conn.ConnectionString = strConn;
        }

        public OleDbConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
