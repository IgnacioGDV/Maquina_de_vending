using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public abstract class Usuario
    {
        public int Id { get; private set; }
        public string Apodo { get; private set; }
        public string Nombre { get; private set; }
        public string Ape1 { get; private set; }
        public string Ape2 { get; private set; }
        private string Contraseña { get; set; }
        public List<Producto> ListaProductos;
        public Usuario(List<Producto> productos)
        {
            ListaProductos = productos;
        }
        public Usuario(int Id, string Apodo, string Nombre, string Ape1, string Ape2, string Contraseña, List<Producto> productos)
        {
            this.Id = Id;
            this.Apodo = Apodo;
            this.Nombre = Nombre;
            this.Ape1 = Ape1;
            this.Ape2 = Ape2;
            this.Contraseña = Contraseña;
            this.ListaProductos = productos;
        }

        public virtual void Menu()
        {
            Console.WriteLine("1. Comprar productos");
            Console.WriteLine("2. Mostrar información de producto");
        }
        public bool Login(string Apodo, string Contraseña) // Validar encontrar el usuario
        {
            return this.Apodo == Apodo && this.Contraseña == Contraseña;
        }
    }
}
