using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class Cliente : Usuario
    {
        private List<Producto> ListaProductosCLiente;
        public Cliente(List<Producto> productos) : base(productos) 
        {
            ListaProductosCLiente = new List<Producto>();
        }
        public Cliente(int Id, string Apodo, string Nombre, string Ape1, string Ape2, string Contraseña, List<Producto> productos) : base(Id, Apodo, Nombre, Ape1, Ape2, Contraseña, productos)
        {
            ListaProductosCLiente = new List<Producto>();
        }
        public override void Menu()
        {
            MaquinaVending Máquina = new MaquinaVending();
            int opcion;
            base.Menu();
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Máquina.MostrarInfoProductos();
                        break;
                    case 2:
                        Máquina.MostrarInfoProductos();
                        Console.Write("ID del producto del que quiere conocer más información: ");
                        int idProducto = int.Parse(Console.ReadLine());
                        Producto productoTemp = Máquina.BuscarProducto(idProducto);
                        Máquina.MostrarInfoProducto(productoTemp);
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida\nInténtelo de nuevo");
                        Console.ReadKey();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Opción inválida. Por favor, Ingrese un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
