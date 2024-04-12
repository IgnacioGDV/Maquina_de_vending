using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MáquinaDeVending
{
    internal class Program
    {
        static List<Producto> ListaProductos;
        static List<Usuario> listaUsuarios;

        static void Main(string[] args)
        {
            ListaProductos = new List<Producto>();
            listaUsuarios = new List<Usuario>();
            Admin admin = new Admin(0, "admin", "Admin", "Admin", "Admin", "admin", ListaProductos);
            listaUsuarios.Add(admin);
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Registrarse");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Login();
                            break;
                        case 2:
                            AddUsuario();
                            break;
                        case 3:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida\nVolviendo al menú principal...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Opción inválida. Por favor, Ingrese un número válido.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 3);
        }
        public static void Login()
        {
            Console.Clear();
            Console.Write("Nombre de usuario: ");
            string Apodo = Console.ReadLine();
            Console.Write("Contraseña: ");
            string Contraseña = Console.ReadLine();
            bool usuarioEncontrado = false;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Login(Apodo, Contraseña))
                {
                    usuarioEncontrado = true;
                    usuario.Menu();
                }
            }
            if (!usuarioEncontrado)
            {
                Console.WriteLine("Usuario o contraseña incorrectos");
                Console.ReadKey();
            }
        }
        public static void AddUsuario()
        {
            Console.Clear();
            Console.WriteLine("--- NUEVO CLIENTE ---");
            Console.Write("Nombre de usuario: ");
            string Apodo = Console.ReadLine();
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.Write("Primer apellido: ");
            string Ape1 = Console.ReadLine();
            Console.Write("Segundo apellido: ");
            string Ape2 = Console.ReadLine();
            Console.Write("Contraseña: ");
            string Contraseña = Console.ReadLine();

            Usuario usuarioExistente = listaUsuarios.Find(usuario => usuario.Apodo == Apodo);
            if (usuarioExistente != null)
            {
                Console.WriteLine("El nombre de usuario ya está en uso. Por favor, elige otro.");
                Console.ReadKey();
                return;
            }

            Cliente nuevoUsuario = new Cliente(listaUsuarios.Count, Apodo, Nombre, Ape1, Ape2, Contraseña, ListaProductos);
            listaUsuarios.Add(nuevoUsuario);
            Console.WriteLine("Cliente añadido correctamente.");
            Console.ReadKey();
        }
    }
}
