using System;
using System.Collections.Generic;

class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Disponible { get; set; }

    public Libro(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        Disponible = true;
    }
}

class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private int contadorId = 1;

    public void AgregarLibro(string titulo)
    {
        libros.Add(new Libro(contadorId++, titulo));
        Console.WriteLine("Libro agregado.");
    }

    public void ListarLibros()
    {
        Console.WriteLine("\n--- LISTA DE LIBROS ---");
        foreach (var l in libros)
        {
            string estado = l.Disponible ? "Disponible" : "Prestado";
            Console.WriteLine($"{l.Id} - {l.Titulo} ({estado})");
        }
    }

    public void PrestarLibro(int id)
    {
        var libro = libros.Find(l => l.Id == id);

        if (libro != null && libro.Disponible)
        {
            libro.Disponible = false;
            Console.WriteLine("Libro prestado.");
        }
        else
        {
            Console.WriteLine("No disponible.");
        }
    }

    public void DevolverLibro(int id)
    {
        var libro = libros.Find(l => l.Id == id);

        if (libro != null && !libro.Disponible)
        {
            libro.Disponible = true;
            Console.WriteLine("Libro devuelto.");
        }
        else
        {
            Console.WriteLine("No se puede devolver.");
        }
    }
}
