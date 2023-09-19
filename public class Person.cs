using System;
using System.Collections.Generic;

// Soyut (abstract) Person sınıfı
public abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    // Method tanımla.
    public abstract void DisplayInfo();
}

// Screenwriter sınıfı da Person sınıfından türetildi. Method kullandı.
public class Screenwriter : Person
{
    public string Screenplay { get; set; }

    public Screenwriter(string name, string screenplay)
        : base(name)
    {
        Screenplay = screenplay;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Senarist Adı: {Name}");
        Console.WriteLine($"Senaryo: {Screenplay}");
    }
}

//  DisplayInfo yöntemini uyguladım. Movie sınıfı Person sınıfından türemedi.
public class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }
    public Person Person { get; set; }

    public Movie(string title, int year, Person person)
    {
        Title = title;
        Year = year;
        Person = person;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Film Adi: {Title}");
        Console.WriteLine($"Yil: {Year}");
        Console.Write("Bağlantili Kişi: ");
        Person.DisplayInfo(); //polymorfism
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Screenwriter("John Doe", "Aksiyon Film Senaryosu");
        Movie movie = new Movie("Aksiyon Macerası", 2023, person);

        movie.DisplayInfo();
    }
}
