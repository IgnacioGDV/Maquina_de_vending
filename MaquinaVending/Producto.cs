using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public abstract class Producto
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public double PrecioUnitario { get; set; }
        public string Descripción { get; set; }
        public Producto()
        {

        }
        public Producto(int Id, string Nombre, int Unidades, double PrecioUnitario, string Descripción)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Unidades = Unidades;
            this.PrecioUnitario = PrecioUnitario;
            this.Descripción = Descripción;
        }
        public Producto(int Id)
        {
            this.Id = Id;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("ID: " + this.Id + " Nombre: " + this.Nombre + "\n\tUnidades: " + this.Unidades + "\n\tPrecio: " + this.PrecioUnitario);
        }
        public virtual void MostrarInfoCompleta()
        {
            Console.Write("\n ID: " + this.Id + " Nombre: " + this.Nombre + "\n\tPrecio: " + this.PrecioUnitario + "\n\tDescripción: " + this.Descripción + "\n\tCantidad disponible: " + this.Unidades);
        }
        public virtual void SolicitarInfo()
        {
            Console.WriteLine("Nombre: ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            this.PrecioUnitario = int.Parse(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            this.Descripción = Console.ReadLine();
            Console.WriteLine("Unidades: ");
            this.Unidades = int.Parse(Console.ReadLine());
        }
    }
}
