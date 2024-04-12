using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class ProductosElectrónicos : Producto
    {
        public string TipoMaterialesUtilizados { get; set; }
        public bool InclusiónPilas {  get; set; }
        public bool Precargado { get; set; }
        public ProductosElectrónicos() { }
        public ProductosElectrónicos(int Id, string Nombre, int Unidades, double PrecioUnitario, string Descripción, string TipoMaterialesUtilizdos) : base(Id, Nombre, Unidades, PrecioUnitario, Descripción)
        {
            this.TipoMaterialesUtilizados = TipoMaterialesUtilizdos;
            this.InclusiónPilas = false;
            this.Precargado = false;
        }
        public ProductosElectrónicos(int Id) : base(Id) { }

        public override void MostrarInfoCompleta()
        {
            base.MostrarInfoCompleta();
            Console.WriteLine("\n\tTipo de producto: Producto Electrónico" + "\n\tTipo de materiales utilizados: " + this.TipoMaterialesUtilizados);
            if(this.InclusiónPilas==false) 
            {
                Console.WriteLine("\n\tIncluye pilas: No");
            }
            else 
            {
                Console.WriteLine("\n\tIncluye pilas: Si");
            }
            if (this.Precargado == false)
            {
                Console.WriteLine("\n\tProducto precargado: No");
            }
            else
            {
                Console.WriteLine("\n\tProducto precargado: Si");
            }
        }
        public override void SolicitarInfo()
        {
            string opcionPilas;
            string opcionPrecargado;
            Console.WriteLine("Tipo de materiales utilizados: ");
            this.TipoMaterialesUtilizados = Console.ReadLine();
            Console.WriteLine("¿Incluye pilas?(si/no): ");
            try
            {
                opcionPilas = Console.ReadLine();
                if (opcionPilas == "si")
                {
                    this.InclusiónPilas = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Opción inválida. Por favor, Ingrese una respuesta válida.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            Console.WriteLine("¿Viene precargado?(si/no): ");
            try
            {
                opcionPrecargado = Console.ReadLine();
                if (opcionPrecargado == "si")
                {
                    this.InclusiónPilas = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Opción inválida. Por favor, Ingrese una respuesta válida.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }


        }
    }
}
