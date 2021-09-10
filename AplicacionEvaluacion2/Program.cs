using System;
using System.Threading;
using System.Collections.Generic;
using ClasesEvaluacion2;

namespace AplicacionEvaluacion2
{
    class Program
    {
        private static ThreadStart threadIngresarCliente = new ThreadStart(ingresarCliente);
        private static Thread hiloIngresarCliente = new Thread(threadIngresarCliente);
        private static ThreadStart threadIngresarUsuario = new ThreadStart(ingresarUsuario);
        private static Thread hiloIngresarUsuario = new Thread(threadIngresarUsuario);
        private static ThreadStart threadMostrarCliente = new ThreadStart(mostrarCliente);
        private static Thread hiloMostrarCliente = new Thread(threadMostrarCliente);
        private static ThreadStart threadMostrarUsuario = new ThreadStart(mostrarUsuario);
        private static Thread hiloMostrarUsuario = new Thread(threadMostrarUsuario);
        private static List<ClienteEmpresa> clientes = new List<ClienteEmpresa>();
        private static int id = 0;
        private static List<Usuario> usuarios = new List<Usuario>();
        private static int identificador = 0;

        static void Main(string[] args)
        {
            char opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar usuario de tipo usuario");
                Console.WriteLine("2. Ingresar usuario de tipo cliente");
                Console.WriteLine("3. Mostrar usuarios de tipo usuario");
                Console.WriteLine("4. Mostrar usuarios de tipo cliente");
                Console.WriteLine("\n\t0. Salir");
                opcion = Console.ReadKey().KeyChar;
                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        if (hiloIngresarUsuario.ThreadState == ThreadState.Unstarted)
                        {
                            hiloIngresarUsuario.Start();
                            hiloIngresarUsuario.Join();
                        }
                        else
                        {
                            hiloIngresarUsuario.Abort();
                            hiloIngresarUsuario = new Thread(threadIngresarUsuario);
                            hiloIngresarUsuario.Start();
                            hiloIngresarUsuario.Join();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        if (hiloIngresarCliente.ThreadState == ThreadState.Unstarted)
                        {
                            hiloIngresarCliente.Start();
                            hiloIngresarCliente.Join();
                        }
                        else
                        {
                            hiloIngresarCliente.Abort(); 
                            hiloIngresarCliente = new Thread(threadIngresarCliente);
                            hiloIngresarCliente.Start();
                            hiloIngresarCliente.Join();
                        }
                        break;
                    case '3':
                        Console.Clear();
                        if (hiloMostrarUsuario.ThreadState == ThreadState.Unstarted)
                        {
                            hiloMostrarUsuario.Start();
                            hiloMostrarUsuario.Join();
                        }
                        else
                        {
                            hiloMostrarUsuario.Abort();
                            hiloMostrarUsuario = new Thread(threadMostrarUsuario);
                            hiloMostrarUsuario.Start();
                            hiloMostrarUsuario.Join();
                        }
                        break;
                    case '4':
                        Console.Clear();
                        if (hiloMostrarCliente.ThreadState == ThreadState.Unstarted)
                        {
                            hiloMostrarCliente.Start();
                            hiloMostrarCliente.Join();
                        }
                        else
                        {
                            hiloMostrarCliente.Abort();
                            hiloMostrarCliente = new Thread(threadMostrarCliente);
                            hiloMostrarCliente.Start();
                            hiloMostrarCliente.Join();
                        }
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                }
            } while (opcion != '0');
        }

        private static void ingresarCliente()
        {
            string comuna, direccion, region, nombreFantasia, razonSocial, rut;
            Console.WriteLine("Ingresar rut");
            rut = Console.ReadLine();
            Console.WriteLine("Ingresar nombre");
            nombreFantasia = Console.ReadLine();
            Console.WriteLine("Ingresar razón social");
            razonSocial = Console.ReadLine();
            Console.WriteLine("Ingresar dirección");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingresar comuna");
            comuna = Console.ReadLine();
            Console.WriteLine("Ingresar región");
            region = Console.ReadLine();
            ClienteEmpresa cliente = new ClienteEmpresa()
            {
                NombreFantasia = nombreFantasia,
                Rut = rut,
                RazonSocial = razonSocial,
                Direccion = direccion,
                Comuna = comuna,
                Region = region,
                Id = id
            };
            clientes.Add(cliente);
            id++;
            Console.WriteLine("\nCliente ingresado...");
            Console.ReadKey();
        }

        private static void ingresarUsuario()
        {
            string nombreUsuario, password, tipoUsuarioTexto;
            int tipoUsuario;
            Console.WriteLine("Ingresar username");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingresar password");
            password = Console.ReadLine();
            Console.WriteLine("Ingresar tipo de usuario \n\t0. basico\n\t1. administrador");
            tipoUsuarioTexto = Console.ReadLine();
            int.TryParse(tipoUsuarioTexto, out tipoUsuario);
            Usuario usuario = new Usuario()
            {
                NombreUsuario = nombreUsuario,
                Password = password,
                TipoUsuario = (Privilegio) tipoUsuario,
                Identificador = identificador
            };
            usuarios.Add(usuario);
            identificador++;
            Console.WriteLine("\nUsuario ingresado...");
            Console.ReadKey();
        }

        private static void mostrarCliente()
        {
            clientes.ForEach(delegate (ClienteEmpresa cliente)
            {
                Console.WriteLine(cliente.MostrarDatos());
            }
            );
            Console.WriteLine("\nPresionar tecla para continuar...");
            Console.ReadKey();
        }

        private static void mostrarUsuario()
        {
            usuarios.ForEach(delegate (Usuario usuario)
            {
                Console.WriteLine(usuario.MostrarDatos());
            }
            );
            Console.WriteLine("\nPresionar tecla para continuar...");
            Console.ReadKey();
        }
    }
}
