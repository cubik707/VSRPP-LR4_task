// Добавление
using LR4_task;

using (StudentLibraryContext db = new ())
{
    Book warAndPeace = new () { Title = "War and Peace", Author = "Leo Tolstoy" };
    Book crimeAndPunishment = new() { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky" };

    // Добавление
    db.Books.Add(warAndPeace);
    db.Books.Add(crimeAndPunishment);
    db.SaveChanges();
}

// Получение
using (StudentLibraryContext db = new ())
{
    // Получаем объекты из БД и выводим на консоль
    var books = db.Books.ToList();
    Console.WriteLine("Данные после добавления:");
    foreach (Book b in books)
    {
        Console.WriteLine($"{b.BookId}. {b.Title} - {b.Author}");
    }
}

// Редактирование
using (StudentLibraryContext db = new ())
{
    // Получаем первую книгу
    Book? book = db.Books.FirstOrDefault();
    if (book != null)
    {
        book.Title = "Anna Karenina";
        book.Author = "Leo Tolstoy";
        // Обновляем объект
        db.SaveChanges();
    }
    // Выводим данные после редактирования
    Console.WriteLine("\nДанные после редактирования:");
    var books = db.Books.ToList();
    foreach (Book b in books)
    {
        Console.WriteLine($"{b.BookId}. {b.Title} - {b.Author}");
    }
}

// Удаление
using (StudentLibraryContext db = new ())
{
    // Получаем первую книгу
    Book? book = db.Books.FirstOrDefault();
    if (book != null)
    {
        // Удаляем объект
        db.Books.Remove(book);
        db.SaveChanges();
    }
    // Выводим данные после удаления
    Console.WriteLine("\nДанные после удаления:");
    var books = db.Books.ToList();
    foreach (Book b in books)
    {
        Console.WriteLine($"{b.BookId}. {b.Title} - {b.Author}");
    }
}
