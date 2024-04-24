using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class Cliente : Usuario // Hereda de la clase Usuario
    {
        public Cliente(List<Producto> productos) : base(productos)
        {
        }
        public Cliente(int Id, string Apodo, string Nombre, string Ape1, string Ape2, string Contraseña, List<Producto> productos) : base(Id, Apodo, Nombre, Ape1, Ape2, Contraseña, productos)
        {
        }
        public override void Menu() // Menú del Cliente
        {
            MaquinaVending Máquina = new MaquinaVending(ListaProductos);
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("  ------------- ");
                Console.WriteLine(" |   CLIENTE   | ");
                Console.WriteLine("  ------------- ");
                base.Menu();
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Máquina.ComprarProductos();
                            break;
                        case 2:
                            Máquina.MostrarInfoProductos();
                            Console.Write("ID del producto del que quiere conocer más información: ");
                            try
                            {
                                int idProducto = int.Parse(Console.ReadLine());
                                Producto productoTemp = Máquina.BuscarProducto(idProducto);
                                Máquina.MostrarInfoProducto(productoTemp);
                                Console.ReadKey();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Opción inválida. Por favor, Ingrese un ID válido.");
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...");
                                Console.ReadKey();
                            }
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
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.ReadKey();
                }
            } while (opcion != 3);
        }
    }
}
