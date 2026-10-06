using Library;

Book book = new Book("C# for beginners", "Bill Gates", 12345678);

// This is info for the book class

book.DisplayBookInfo();

// Add another book
Book book1 = new Book(); 

book1.Title = "C# for advanced";
book1.Author = "Steve Jobs";
book1.ISBN = 87654321;
book1.DisplayBookInfo();