using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Admin;

using Common.Cache;
namespace Dominio
{
    public class ModeloUsuario
    {

        AdminUsuario usuario = new AdminUsuario();
                      
        public bool LoginUsuario(string user, string pass)
        {
            return usuario.TraerUsuario(user,pass);
        }
        
      public  int NuevoUser(string email,string user, string pass)
      {
            int filasAfectadas  = usuario.InsertarUsuario(email, user, pass);
            
                return filasAfectadas;




       }
      
       
      

     














    }
        
        
        
        
        
        
        
        




    
}
