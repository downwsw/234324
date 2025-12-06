using System;

class Book : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Назва: " + Title);
        Console.WriteLine("Автор: " + Author);
        Console.WriteLine("Рік: " + Year);
        Console.WriteLine("Сторінок: " + Pages);
    }

    ~Book()
    {
        Console.WriteLine("Фіналізатор викликано для книги: " + Title);
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose викликано для книги: " + Title);
        GC.SuppressFinalize(this);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Тест 1: Використання using");
        using (Book book1 = new Book("Кобзар", "Тарас Шевченко", 1840, 200))
        {
            book1.DisplayInfo();
        }

        Console.WriteLine("\nТест 2: Ручний виклик Dispose");
        Book book2 = new Book("Тіні забутих предків", "Михайло Коцюбинський", 1911, 150);
        book2.DisplayInfo();
        book2.Dispose();

        Console.WriteLine("\nТест 3: Без виклику Dispose");
        Book book3 = new Book("Лісова пісня", "Леся Українка", 1912, 100);
        book3.DisplayInfo();

        Console.WriteLine("\nЗбираємо сміття...");
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Програма завершена");
    }
}
