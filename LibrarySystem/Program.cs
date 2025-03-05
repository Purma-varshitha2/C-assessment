using System;
class Program
{
    static void Main()
    {
        Book book1 = new Book("Harry Potter", "J. K. Rowling","908-0435678532");
        book1.DisplayInfo();
        Book book2 = new Book("1984", "George Orwell", "978-0451524935");
        book2.DisplayInfo();
        Book book3 = new Book("The Alchemist", "Paulo Coelho","789-098763423");
        book3.DisplayInfo();
    }
}
