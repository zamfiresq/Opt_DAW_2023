// Enunt problema

// Creati o clasa Student cu nume, prenume, etc. si o alta clasa Materie  cu titlu, durata (string).
// Clasa student o sa aibe o Lista de materii: public List<Materie> Materii. Faceti o lista de studenti cu cateva materii si afisati-le.
// Sa va faceti repository de git


using System;
using System.Collections.Generic;
using System.Text;


public class Materie // clasa de baza 
{
    public string Titlu { get; set; }
    public string Durata { get; set; }
}

public class Student // clasa compusa
{
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public List<Materie> Materii { get; set; }

    public Student(string nume, string prenume)
    {
        Nume = nume;
        Prenume = prenume;
        Materii = new List<Materie>();
    }

    // functie de adaugare a materiei si a duratei in vector
    public void AdaugaMaterie(string titlu, string durata)
    {
        Materii.Add(new Materie { Titlu = titlu, Durata = durata });
    }
}


class Program
{
    static void AfisareStudenti(Student student)
    {
        Console.WriteLine("Nume si Prenume: {0} {1}", student.Nume, student.Prenume);
        Console.WriteLine("Materii:");

        int i = 1;
        foreach (var materie in student.Materii)
        {
            Console.WriteLine("{0}. {1}, Durata: {2}", i, materie.Titlu, materie.Durata);
            i++;

        }

        Console.WriteLine();
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        // cream obiectele de tip Student
        Student student1 = new Student("Zamfirescu", "Alexandra");
        student1.AdaugaMaterie("Analiza 1", "3h");
        student1.AdaugaMaterie("Algebra 2", "2h");
        student1.AdaugaMaterie("Programare Orientata pe Obiecte", "2h");


        Student student2 = new Student("Ionescu", "Cristina");
        student2.AdaugaMaterie("Elemente de Calcul Stiintific", "2h 30'");
        student2.AdaugaMaterie("Arhitectura Sistemelor de Calcul", "5h");
        student2.AdaugaMaterie("Structuri de Date", "4h");
        student2.AdaugaMaterie("Baze de Date", "1h 30'");


        // afisarea informatiilor despre studenti si materii
        AfisareStudenti(student1);
        AfisareStudenti(student2);

    }

}