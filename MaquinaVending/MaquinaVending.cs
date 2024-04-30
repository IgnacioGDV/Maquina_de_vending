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
        private List<Producto> ListaProductos { get; set; }
        public MaquinaVending(List<Producto> productos)
        {
            this.ListaProductos = productos;
        }
        public double CalcularVuelta(double saldoIntroducido, double saldoaIntroducir, double cambio) // Método para calcular la vuelta al pagar en efectivo
        {
            if (saldoaIntroducir > saldoIntroducido)
            {
                saldoaIntroducir = saldoaIntroducir - saldoIntroducido;
                return Math.Round(saldoaIntroducir, 2);
            }
            else
            {
                cambio = saldoIntroducido - saldoaIntroducir;
                return Math.Round(cambio,2);
            }
        }
        public void ComprarProductos()
        {
            bool salir = false;
            bool salir2 = false;
            do
            {
                Console.Clear();
                MostrarInfoProductos();
                Console.Write("ID del producto que quiere comprar: ");
                try
                {
                    int idProducto = int.Parse(Console.ReadLine());
                    Producto productoTemp = BuscarProducto(idProducto);
                    MostrarInfoProducto(productoTemp);
                    if (productoTemp != null && productoTemp.Unidades > 0) //Si el producto existe y tiene existencias
                    {
                        Console.WriteLine("\nSeleccione la forma de pago:");
                        Console.WriteLine("1. Pago en efectivo");
                        Console.WriteLine("2. Pago con tarjeta");
                        Console.WriteLine("3. Cancelar operación");
                        Console.Write("Elige una opción: ");
                        int formaPago = int.Parse(Console.ReadLine());
        
                        switch (formaPago)
                        {
                            case 1:
                                double opSaldoIntroducido;
                                double saldoIntroducido = 0; //inicializo variables para calcular la vuelta
                                double cambio = 0;
                                double saldoaIntroducir = productoTemp.PrecioUnitario; // el saldo a introducir será el precio del producto
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Seleccione billete/moneda a introducir:");
                                    Console.WriteLine("1. Introducir billete de 10 euros");
                                    Console.WriteLine("2. Introducir billete de 5 euros");
                                    Console.WriteLine("3. Introducir moneda de 2 euros");
                                    Console.WriteLine("4. Introducir moneda de 1 euro");
                                    Console.WriteLine("5. Introducir moneda de 50cts");
                                    Console.WriteLine("6. Introducir moneda de 20cts");
                                    Console.WriteLine("7. Introducir moneda de 10cts");
                                    Console.WriteLine("8. Introducir moneda de 5cts");
                                    Console.WriteLine("9. Introducir moneda de 2cts");
                                    Console.WriteLine("10. Introducir moneda de 1cts");
                                    Console.WriteLine("0. Cancelar operación");
                                    Console.Write("Elige una opción: ");
                                    try
                                    {
                                        opSaldoIntroducido = int.Parse(Console.ReadLine());
                                        switch (opSaldoIntroducido) // Calculo la vuelta para cada billete/moneda introducido
                                        {
                                            case 1:  // Pago con efectivo
                                                if (saldoaIntroducir > 10)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(10, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(10, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 2:
                                                if (saldoaIntroducir > 5)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(5, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(5, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 3:
                                                if (saldoaIntroducir > 2)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(2, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(2, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 4:
                                                if (saldoaIntroducir > 1)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(1, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(1, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 5:
                                                if (saldoaIntroducir > 0.5)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.5, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.5, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 6:
                                                if (saldoaIntroducir > 0.2)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.2, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.2, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 7:
                                                if (saldoaIntroducir > 0.1)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.1, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.1, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 8:
                                                if (saldoaIntroducir > 0.05)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.05, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.05, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 9:
                                                if (saldoaIntroducir > 0.02)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.02, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.02, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 10:
                                                if (saldoaIntroducir > 0.01)
                                                {
                                                    saldoaIntroducir = CalcularVuelta(0.01, saldoaIntroducir, cambio);
                                                    Console.WriteLine("\nEl saldo por introducir es: " + saldoaIntroducir);
        
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    cambio = CalcularVuelta(0.01, saldoaIntroducir, cambio);
                                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                                    Console.WriteLine("\n---Pago en efectivo realizado con éxito---");
                                                    Console.WriteLine("Su cambio es: " + cambio);
                                                    Console.WriteLine("Sacando producto...");
                                                    salir2 = true;
                                                    Console.WriteLine("Presione una tecla para continuar...");
                                                }
                                                break;
                                            case 0:
                                                salir = true;
                                                salir2 = true;
                                                Console.WriteLine("---Operación cancelada---\nSaliendo...");
                                                break;
                                            default:
                                                Console.WriteLine("Debe introducir una opción válida...");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Error: Opción inválida. Por favor, ingrese una opción válida.");
                                        Console.WriteLine("Presione una tecla para continuar...");
                                        Console.ReadKey();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error: " + ex.Message);
                                        Console.WriteLine("Presione una tecla para continuar...");
                                        Console.ReadKey();
                                    }
                                } while (saldoaIntroducir <= saldoIntroducido || salir2 != true);
                                break;
                            case 2: // Pago con tarjeta
                                Tarjeta tarjeta = new Tarjeta();
                                Console.WriteLine("Introduzca los datos de la tarjeta:");
                                Console.Write("Número de tarjeta (16 dígitos): ");
                                tarjeta.Número = Console.ReadLine().Replace(" ", "");
                                if (tarjeta.Número.Length != 16) //Controlar que la tarjeta tenga 16 dígitos
                                {
                                    tarjeta.ArgumentoNoValido = true;
                                    Console.WriteLine("---No has introducido 16 dígitos--- ");
                                }
                                Console.Write("Fecha de caducidad (MM/YY): ");
                                tarjeta.FechaCaducidad = Console.ReadLine();
                                string[] partesFecha = tarjeta.FechaCaducidad.Split('/'); //Dividir en mes y año la fecha de caducidad
                                if (partesFecha.Length == 2)
                                {
                                    int mes = int.Parse(partesFecha[0]);
                                    int año = int.Parse(partesFecha[1]);
                                
                                    if (mes < 1 || mes > 12) // Controlar que el mes sea válido
                                    {
                                        tarjeta.ArgumentoNoValido = true;
                                        Console.WriteLine("--- Mes introducido inválido ---");
                                    }
                                    if (año < 24 || año > 99) // Controlar que el año sea válido
                                    {
                                        tarjeta.ArgumentoNoValido = true;
                                        Console.WriteLine("--- Año introducido inválido ---");
                                    }
                                }
                                else
                                {
                                    tarjeta.ArgumentoNoValido = true;
                                    Console.WriteLine("--- Formato de fecha de caducidad inválido ---");
                                }
                                Console.Write("Código de seguridad: ");
                                tarjeta.CódigoSeguridad = Console.ReadLine();
                                Console.WriteLine("Procesando pago con tarjeta...");
                                if (tarjeta.ArgumentoNoValido != true) // Validar que todos los argumentos sean correctos
                                {
                                    productoTemp.Unidades = productoTemp.Unidades - 1;
                                    Console.WriteLine("--- Producto comprado correctamente ---");
                                    Console.WriteLine("Sacando producto...");
                                    Console.WriteLine("Pulse para continuar...");
                                }
                                else
                                {
                                    Console.WriteLine("--- Imposible comprar el producto, debe escribir argumentos válidos  ---");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Cancelando operación, pulse para continuar...");
                                break;
                            default:
                                Console.WriteLine("Opción inválida, pulse para continuar...");
                                break;
                        }
                        Console.ReadKey();
                        if (salir != true)
                        {
                            Console.Clear();
                            Console.WriteLine("¿Desea comprar otro producto? (si/no): ");
                            string opcion = Console.ReadLine().ToLower();
                            switch (opcion) //opción de comprar otro producto
                            {
                                case "no":
                                    salir = true;
                                    Console.WriteLine("Saliendo, pulse para continuar...");
                                    Console.ReadKey();
                                    break;
                                case "si":
                                    break;
                                default:
                                    Console.WriteLine("Debe introducir un argumento válido...");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("El producto que ha intentado comprar no dispone de existencias o no existe");
                        Console.WriteLine("¿Desea salir? (si/no): "); //Opción de salir
                        string opcionsalir = Console.ReadLine().ToLower();
                        switch (opcionsalir)
                        {
                            case "si":
                                Console.WriteLine("Saliendo, pulse para continuar...");
                                salir = true;
                                break;
                            case "no":
                                Console.WriteLine("Pulse para continuar...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Si desea salir, debe introducir un argumento válido...");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
                catch (FormatException)
                {
                    salir = true;
                    Console.WriteLine("Error: Opción inválida. Por favor, ingrese un ID válido.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    salir = true;
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (salir != true);
        }
        public void MostrarInfoProductos() //Muestra la información de todos los productos en la lista de productos
        {
            Console.Clear();
            Console.WriteLine(" --- PRODUCTOS --- ");
            Console.WriteLine();
            foreach (Producto producto in ListaProductos)
            {
                producto.MostrarInfo();
            }
        }
        public void MostrarInfoProducto(Producto producto) //Muestra la información completa de un producto
        {
            if (producto != null)
            {
                Console.Clear();
                Console.WriteLine(" --- INFORMACIÓN COMPLETA DEL PRODUCTO --- ");
                Console.WriteLine();
                producto.MostrarInfoCompleta();
            }
            else
            {
                Console.WriteLine("\n---No se ha encontrado ningún producto con el ID introducido---");
            }
        }
        public Producto BuscarProducto(int Id) //Busca un producto a partir de su ID
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
        public void CargaIndividualProductos() //Método para cargar productos individualmente
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("1. Añadir existencias a un producto existente");
            Console.WriteLine("2. Añadir un nuevo tipo de producto en las ranuras disponibles");
            Console.WriteLine("3. Reducir a 0 el número de unidades disponibles de un producto existente");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MostrarInfoProductos();
                        Console.Write("ID del producto al cual quieres añadir existencias: ");
                        int idProducto = int.Parse(Console.ReadLine());
                        Producto productoTemp = BuscarProducto(idProducto);
                        if (productoTemp != null)
                        {
                            Console.Write("Número de existencias a añadir: ");
                            int existencias = int.Parse(Console.ReadLine());
                            productoTemp.Unidades = productoTemp.Unidades + existencias; //Añade las existencias
                            Console.WriteLine("--- Existencias añadidas con éxito ---");
                        }
                        else
                        {
                            Console.WriteLine("\n---No se ha encontrado ningún contenido con el ID introducido---");
                        }
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
                            if (ListaProductos.Count < 12) //Controlamos que la lista de productos ya tenga 12 slots
                            {
                                opcionProd = int.Parse(Console.ReadLine());
                                switch (opcionProd) // Opción para añadir el tipo de producto elegido
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
                                        if (prodElectrónico.ArgumentoNoValido == false) //Controlamos que todos los argumentos introducidos al solicitar información sean correctos
                                        {
                                            ListaProductos.Add(prodElectrónico);
                                            prodElectrónico.MostrarInfoCompleta();
                                            Console.WriteLine("--- Producto electrónico añadido correctamente ---");
                                        }
                                        else
                                        {
                                            Console.WriteLine("--- Imposible añadir el producto electrónico, debe escribir argumentos válidos  ---");
                                        }
                                        break;
                                    case 4:
                                        Console.WriteLine("Volviendo al menú principal...");
                                        break;
                                    default:
                                        Console.WriteLine("Opción no válida\nVolviendo al menú principal...");
                                        break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("La lista ya tiene el número máximo de elementos (12)");
                                Console.WriteLine("Presione una tecla para continuar...");
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
                    case 3:
                        MostrarInfoProductos();
                        Console.Write("ID del producto al cual quieres añadir existencias: ");
                        int idProducto2 = int.Parse(Console.ReadLine());
                        Producto productoTemp2 = BuscarProducto(idProducto2);
                        if (productoTemp2 != null)
                        {
                            productoTemp2.Unidades = 0; 
                            Console.WriteLine("--- Existencias reducidas a 0 con éxito ---");
                        }
                        else
                        {
                            Console.WriteLine("\n---No se ha encontrado ningún contenido con el ID introducido---");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saliendo..., pulse para continuar");
                        break;
                    default:
                        Console.WriteLine("Error: Opción inválida. Por favor, Ingrese un número válido.");
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
        public void CargaCompletaProductos() //Método para cargar productos de un archivo
        {
            Console.Write("Introduzca el nombre (con extensión) del fichero de productos a leer: ");
            string fichero = Console.ReadLine();
            try
            {
                if (File.Exists(fichero)) //Si el fichero introducido existe
                {
                    StreamReader sr = new StreamReader(fichero); //Instanciamos un StreamReader del fichero
                    string linea;
                    while ((linea = sr.ReadLine()) != null) //Leemos línea por linea mientras que sea distinto de null 
                    {
                        string[] datos = linea.Split(';'); //Separamos la línea leída en datos
                        if (ListaProductos.Count < 12) //Controlamos que la lista de productos ya tenga 12 slots
                        {
                            if (datos[0] == "1") // Si es material precioso el primer dato del archivo es 1
                            {
                                MaterialesPreciosos matPrecioso = new MaterialesPreciosos(ListaProductos.Count, datos[1], int.Parse(datos[2]), Math.Round(float.Parse(datos[3].Replace(".", ",")),2), datos[4], datos[5], double.Parse(datos[6].Replace("g", "")));
                                ListaProductos.Add(matPrecioso); //Añadimos el material precioso con los datos correspondientes del fichero
                                Console.WriteLine("Añadido correctamente el producto con nombre: " + datos[1] + " del archivo de productos: " + fichero);
                            }
                            if (datos[0] == "2") // Si es producto alimenticio el primer dato del archivo es 2
                            {
                                ProductosAlimenticios prodAlimenticio = new ProductosAlimenticios(ListaProductos.Count, datos[1], int.Parse(datos[2]), Math.Round(float.Parse(datos[3].Replace(".", ",")), 2), datos[4], datos[7]);
                                ListaProductos.Add(prodAlimenticio); //Añadimos el producto alimenticio con los datos correspondientes del fichero
                                Console.WriteLine("Añadido correctamente el producto con nombre: " + datos[1] + " del archivo de productos: " + fichero);
                            }
                            if (datos[0] == "3") // Si es producto electrónico el primer dato del archivo es 3
                            {
                                bool InclusiónPilas;
                                bool Precargado;
                                if (datos[8] == "1")  //Asignamos si tienen pilas o no 
                                {
                                    InclusiónPilas = true;
                                }
                                else
                                {
                                    InclusiónPilas = false;
                                }
                                if (datos[9] == "1") //Asignamos si viene percargado o no 
                                {
                                    Precargado = true;
                                }
                                else
                                {
                                    Precargado = false;
                                }
                                ProductosElectrónicos prodElectrónico = new ProductosElectrónicos(ListaProductos.Count, datos[1], int.Parse(datos[2]), Math.Round(float.Parse(datos[3].Replace(".", ",")), 2), datos[4], datos[6], InclusiónPilas, Precargado);
                                if (datos[8] != "0" && datos[8] != "1") //Controlamos que InclusiónPilas y Precargado sean argumentos 0/1
                                {
                                    prodElectrónico.ArgumentoNoValido = true;
                                }
                                if (datos[9] != "0" && datos[9] != "1")
                                {
                                    prodElectrónico.ArgumentoNoValido = true;
                                }
                                if (prodElectrónico.ArgumentoNoValido != true)
                                {
                                    ListaProductos.Add(prodElectrónico); //Añadimos el producto electrónico con los datos correspondientes del fichero
                                    Console.WriteLine("Añadido correctamente el producto con nombre: " + datos[1] + " del archivo de productos: " + fichero);
                                }
                                else
                                {
                                    Console.WriteLine("--- Imposible añadir el producto electrónico con nombre " + datos[1] + ", no hay argumentos válidos  ---");
                                }
                            }
                        }
                        else
                        {
                            if (datos[0] == "1" || datos[0] == "2" || datos[0] == "3")
                            {
                                Console.WriteLine("Imposible añadir el producto con nombre: " + datos[1] + " del archivo de productos: " + fichero + " debido a que ya hay 12 productos en la máquina");
                            }
                        }
                    }
                    sr.Close();
                }
                else
                {
                    Console.WriteLine("No se encuentra el archivo de productos " + fichero);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No se encuentra el archivo de productos: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de E/S: " + ex.Message);
            }
        }
    }
}
