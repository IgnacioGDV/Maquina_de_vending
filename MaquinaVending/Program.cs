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
            Admin admin = new Admin(0, "admin", "Admin", "Admin", "Admin", "admin", ListaProductos); // Añadir lo primero el usuario administrador a la lista de usuarios
            listaUsuarios.Add(admin);
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("  ------------------------ ");
                Console.WriteLine(" |   MÁQUINA DE VENDING   | ");
                Console.WriteLine("  ------------------------ ");
                Console.WriteLine(" |     1. Login           |");
                Console.WriteLine(" |     2. Registrarse     |");
                Console.WriteLine(" |     3. Salir           |");
                Console.WriteLine("  ------------------------ ");
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
        public static void Login() // Iniciar sesión con usuario
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
        public static void AddUsuario() // Añadir usuario a la lista de usuarios
        {
            Console.Clear();
            Console.WriteLine("--- NUEVO CLIENTE ---");
            Console.Write("Nombre de usuario: ");
            string Apodo = Console.ReadLine().Trim(); // Trim para eliminar espacios al inicio y al final
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine().Trim();
            Console.Write("Primer apellido: ");
            string Ape1 = Console.ReadLine().Trim();
            Console.Write("Segundo apellido: ");
            string Ape2 = Console.ReadLine().Trim();
            Console.Write("Contraseña: ");
            string Contraseña = Console.ReadLine().Trim();

            if (Apodo != "" && Nombre != "" && Ape1 != "" && Ape2 != "" && Contraseña != "") 
            {
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
            }
            else
            {
                Console.WriteLine("ERROR: Debes ingresar al menos un carácter en cada respuesta y no puedes dejar espacios en blanco");
            }
            Console.ReadKey();        
        }
    }
}
