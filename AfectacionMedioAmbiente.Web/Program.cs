using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;


namespace AfectacionMedioAmbiente.Web
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //No borrar
            CreateHostBuilder(args).Build().Run();

            //inicia
            int[] listasPersonas1 = { 1, 5, 3 };
            int[] listaPersonas2 = { 2, 1, 1, 3 };

            claseCamiseta camiseta1 = new claseCamiseta(listasPersonas1, 1);
            claseCamiseta camiseta2 = new claseCamiseta(listaPersonas2, 2);

            // Creo las funciones "hijo" de los Threads y le paso por parametro la funcion que tienen que ejecutar
            ThreadStart threadChild1 = new ThreadStart(camiseta1.Caja);
            ThreadStart threadChild2 = new ThreadStart(camiseta2.Caja);

            // Se crean los Threads y se les asignan los hijos
            Thread childThread1 = new Thread(threadChild1);
            Thread childThread2 = new Thread(threadChild2);

            // Comienza la ejecucion de los dos Threads
            childThread1.Start();
            childThread2.Start();

            Console.ReadKey();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public class claseCamiseta
        {
            int[] personas;
            int numeroCamiseta;

            //Constructor
            public claseCamiseta()
            {
                personas = new int[0];
                numeroCamiseta = 0;
            }
            public claseCamiseta(int[] listaPersonas, int numeroCamisa)
            {
                personas = listaPersonas;
                numeroCamiseta = numeroCamisa;
            }
            //funci�n que ejecuta los threads
            public void Caja()
            {
                for (int i = 0; i < personas.Length; i++)
                {
                    if (numeroCamiseta == 2)
                        Console.WriteLine("\t\t\t\t");
                    Console.WriteLine("-Persona {0} inici� con la persona {1}", numeroCamiseta, (i + 1));
                    Thread.Sleep(personas[i] * 1000);

                    if (numeroCamiseta == 2)
                        Console.WriteLine("\t\t\t\t");
                    Console.WriteLine("-Persona {0} finaliz� con la persona {1}, se demor� {2} segundos.\n", numeroCamiseta, (i + 1), (personas[i]));
                }
            }
        }
    }
}
