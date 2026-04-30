using System;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Prestar libro");
            Console.WriteLine("4. Devolver libro");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();
                    biblioteca.AgregarLibro(titulo);
                    break;

                case 2:
                    biblioteca.ListarLibros();
                    break;

                case 3:
                    Console.Write("ID a prestar: ");
                    int idPrestar = int.Parse(Console.ReadLine());
                    biblioteca.PrestarLibro(idPrestar);
                    break;

                case 4:
                    Console.Write("ID a devolver: ");
                    int idDevolver = int.Parse(Console.ReadLine());
                    biblioteca.DevolverLibro(idDevolver);
                    break;
            }

        } while (opcion != 0);

        Console.WriteLine("Programa finalizado.");
    }
}
