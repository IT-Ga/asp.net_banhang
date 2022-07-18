using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV18T1021002.DataLayer.SQLServer
{
    public class CheckEmail : _BaseDAL
    {
        public CheckEmail(string connectionString) : base(connectionString)
        {
        }

        public bool Check(string email)
        {

            using (SqlConnection cn = OpenConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @" select * from Employees
                                        where Email = @email";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

              
                cmd.Parameters.AddWithValue("@email", email);


               var result = cmd.ExecuteReader();
                if (result.Read())
                    return true;
                else return false;
                
            }
        }
    }
    }
       

