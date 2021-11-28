using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Datos.AdminBD;
using System.Data;
using System.Data.SqlClient;
using Common;
using Common.Cache;

namespace Datos.Admin
{
    public   class AdminUsuario
    {

        

        public  int InsertarUsuario(string email,string user,string pass)
        {
            


            string Insert = "INSERT INTO dbo.Usuarios( Email, Username, Password, Position) VALUES ( @Email, @Username, @Password, @Position)";
            SqlCommand cmd = new SqlCommand(Insert, BaseDatos.ConectarDB());

          
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 150).Value = email;
            cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = user;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value = pass;
            cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 100).Value = "";


            



            int FilasAfectadas = cmd.ExecuteNonQuery();
            BaseDatos.ConectarDB().Close();
            return FilasAfectadas;


        }

        


        public  bool TraerUsuario(string user,string pass)
        {
            
            string select = "SELECT Username, Position, Email  FROM  dbo.Usuarios  WHERE UserName = @Username AND Password = @Password";
            
            SqlCommand cmd = new SqlCommand(select, BaseDatos.ConectarDB());
            cmd.Parameters.AddWithValue("Username", user);
            cmd.Parameters.AddWithValue("Password", pass);
         
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserCache.Username = reader.GetString(0);
                    UserCache.Email = reader.GetString(2);
                    UserCache.Position = reader.GetString(1);


                }
                return true;
            }
            else
            {
                return false;
            }




        }

        public string RecuperarContraseña(string recuperarUsuario)
        {
            ;
            string select = "SELECT Password From dbo.Usuarios where  Email = @Email ";
            SqlCommand cmd = new SqlCommand(select, BaseDatos.ConectarDB());
           
            cmd.Parameters.AddWithValue("@Email", recuperarUsuario);

        
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
             
                MailMessage msg = new MailMessage();
                msg.To.Add(recuperarUsuario);
                msg.Subject = "Recuperacion de Contraseña";
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = "Su contraseña es: 1234 ";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new MailAddress(recuperarUsuario);
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("facucarollo@gmail.com","compumundo25" );
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.@gmail.com";
                try
                {
                    smtp.Send(msg);
                }
                catch(Exception )
                {
                
                     msg.Dispose();
                    smtp.Dispose();
                
                }
                  

               
               
               
                   
               
            }
            return "Por favor revice su Email";
        }









    }
}
