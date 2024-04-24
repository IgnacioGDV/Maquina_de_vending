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
        public bool InclusiónPilas { get; set; }
        public bool Precargado { get; set; }
        public bool ArgumentoNoValido { get; set; }
        public ProductosElectrónicos() { }
        public ProductosElectrónicos(int Id, string Nombre, int Unidades, double PrecioUnitario, string Descripción, string TipoMaterialesUtilizados, bool InclusiónPilas, bool Precargado) : base(Id, Nombre, Unidades, PrecioUnitario, Descripción)
        {
            this.TipoMaterialesUtilizados = TipoMaterialesUtilizados;
            this.InclusiónPilas = InclusiónPilas;
            this.Precargado = Precargado;
        }
        public ProductosElectrónicos(int Id) : base(Id) { }

        public override void MostrarInfoCompleta()
        {
            base.MostrarInfoCompleta();
            Console.Write("\n\tTipo de producto: Producto Electrónico" + "\n\tTipo de materiales utilizados: " + this.TipoMaterialesUtilizados);
            if (this.InclusiónPilas != true)
            {
                Console.Write("\n\tIncluye pilas: No");
            }
            else
            {
                Console.Write("\n\tIncluye pilas: Si");
            }
            if (this.Precargado != true)
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
            Console.Clear();
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" |   AÑADIENDO NUEVO PRODUCTO   | ");
            Console.WriteLine("  ------------------------------ ");
            Console.WriteLine(" --- NUEVO PRODUCTO ELECTRÓNICO  --- ");
            base.SolicitarInfo();
            Console.WriteLine("Tipo de materiales utilizados: ");
            this.TipoMaterialesUtilizados = Console.ReadLine();
            Console.WriteLine("¿Incluye pilas?(si/no): ");
            try
            {
                opcionPilas = Console.ReadLine().ToLower();
                switch (opcionPilas)
                {
                    case "si":
                        this.InclusiónPilas = true;
                        break;
                    case "no":
                        this.InclusiónPilas = false;
                        break;
                    default:
                        ArgumentoNoValido = true;
                        Console.WriteLine("---Debe introducir un argumento válido(si/no)---\n");
                        break;
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
                opcionPrecargado = Console.ReadLine().ToLower();
                switch (opcionPrecargado)
                {
                    case "si":
                        this.Precargado = true;
                        break;
                    case "no":
                        this.Precargado = false;
                        break;
                    default:
                        ArgumentoNoValido = true;
                        Console.WriteLine("---Debe introducir un argumento válido(si/no)---\n");
                        break;
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
