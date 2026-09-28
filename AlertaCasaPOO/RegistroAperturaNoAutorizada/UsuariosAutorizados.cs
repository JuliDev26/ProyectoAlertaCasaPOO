using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AlertaCasaPOO.RegistroAperturaNoAutorizada
{
    public class UsuariosAutorizados
    {
       
        
            public string pin { get; set; }
            public string Nombre { get; set; }
            public bool TienePermiso { get; set; } // Define si está autorizado
         
            public static bool autorizados(bool TienePermiso, string pin)
        {
            bool autorizacion = true;
            return autorizacion;
        }
        
        
    }
}
