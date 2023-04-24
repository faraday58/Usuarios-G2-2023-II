using System;
using System.Collections;

namespace Usuarios_G2_2023_II
{
    public class Persona
    {
        private string usuario;
        private string password;

        public string Usuario {
            get => usuario;
            set {
                if( value == "")
                {
                    usuario = "invitado";
                }
                else
                {
                    usuario = value;
                }               
                          
            } 
        }
        public string Password { 
            get => password;
            set
            {
                if( value == "")
                {
                    password = "12345";
                }
                else
                {
                    password = value;
                }                
            }
        }

    }

    public class GeneraUsuario
    {
        public ArrayList usuarios;

        public GeneraUsuario()
        {
            usuarios = new ArrayList();
        }

        public void Generar()
        {
           // usuarios.Add(new   );
        }

    }
}
