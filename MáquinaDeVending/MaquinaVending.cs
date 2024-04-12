using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    public class MaquinaVending
    {
        private List<Producto> ListaProductos {  get; set; }
        public MaquinaVending() 
        {
            this.ListaProductos = new List<Producto>();
        }
        public void ComprarProductos()
        {

        }
        public void MostrarInfoProductos()
        {
            Console.Clear();
            Console.WriteLine(" --- PRODUCTOS --- ");
            Console.WriteLine();
            foreach (Producto producto in ListaProductos)
            {
                producto.MostrarInfo();
            }
        }
        public void MostrarInfoProducto(Producto producto)
        {
            Console.Clear();
            if (producto != null)
            {
                Console.WriteLine(" --- INFORMACIÓN COMPLETA DEL PRODUCTO --- ");
                Console.WriteLine();
                producto.MostrarInfoCompleta();
            }
            else
            {
                Console.WriteLine("No se ha encontrado ningún contenido con el ID introducido");
            }
        }
        

        public Producto BuscarProducto(int Id)
        {
            Producto productoTemp = null;
            foreach (Producto producto in ListaProductos)
            {
                if (producto.Id == Id)
                {
                    productoTemp = producto;
                }
            }
            return productoTemp;
        }
        public void CargaIndividualProductos()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("1. Añadir existencias a un producto existente");
            Console.WriteLine("2. Añadir un nuevo tipo de producto en las ranuras disponibles");
            Console.Write("Elige una opción: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("ID del producto al cual quieres añadir existencias: ");
                        int idProducto = int.Parse(Console.ReadLine());
                        Producto productoTemp = BuscarProducto(idProducto);
                        Console.Write("Número de existencias a añadir: ");
                        int existencias = int.Parse(Console.ReadLine());
                        productoTemp.Unidades = productoTemp.Unidades + existencias;
                        break;
                    case 2:
                        int opcionProd;
                        Console.Clear();
                        Console.WriteLine("1. Nuevo material precioso");
                        Console.WriteLine("2. Nuevo producto alimenticio");
                        Console.WriteLine("3. Nuevo producto electrónico");
                        Console.WriteLine("4. Volver al menú principal");
                        Console.Write("Elige una opción: ");
                        try
                        {
                            if (ListaProductos.Count < 12)
                            {
                                opcionProd = int.Parse(Console.ReadLine());
                                switch (opcionProd)
                                {
                                    case 1:
                                        MaterialesPreciosos matPrecioso = new MaterialesPreciosos(ListaProductos.Count);
                                        matPrecioso.SolicitarInfo();
                                        ListaProductos.Add(matPrecioso);
                                        matPrecioso.MostrarInfoCompleta();
                                        Console.WriteLine("--- Material precioso añadido correctamente ---");
                                        break;
                                    case 2:
                                        ProductosAlimenticios prodAlimenticio = new ProductosAlimenticios(ListaProductos.Count);
                                        prodAlimenticio.SolicitarInfo();
                                        ListaProductos.Add(prodAlimenticio);
                                        prodAlimenticio.MostrarInfoCompleta();
                                        Console.WriteLine("--- Producto alimenticio añadido correctamente ---");
                                        break;
                                    case 3:
                                        ProductosElectrónicos prodElectrónico = new ProductosElectrónicos(ListaProductos.Count);
                                        prodElectrónico.SolicitarInfo();
                                        ListaProductos.Add(prodElectrónico);
                                        prodElectrónico.MostrarInfoCompleta();
                                        Console.WriteLine("--- Producto electrónico añadido correctamente ---");
                                        break;
                                    case 4:
                                        Console.WriteLine("Volviendo al menú principal...");
                                        break;
                                    default:
                                        Console.WriteLine("Opción no válida\nVolviendo al menú principal...");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("La lista ya tiene el número máximo de elementos (12)");
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
                        break;
                    default:
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
        
        public void CargaCompletaProductos()
        {

        }
    }
}
