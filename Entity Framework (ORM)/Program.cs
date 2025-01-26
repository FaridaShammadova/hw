namespace Entity_Framework__ORM_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService();

            IGenreService genreService = new GenreService();

            bool check = false;

            while(!check)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Create new genre");
                Console.WriteLine("2 - Get genre by id");
                Console.WriteLine("3 - Get all genres");
                Console.WriteLine("4 - Update genre");
                Console.WriteLine("5 - Delete genre by id");
                Console.WriteLine("6 - Create new book");
                Console.WriteLine("7 - Get book by id");
                Console.WriteLine("8 - Get all books");
                Console.WriteLine("9 - Update book");
                Console.WriteLine("10 - Delete book by id");
                Console.WriteLine("0 - Exit");

                int input = Convert.ToInt32(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        Console.WriteLine("Enter genre name: ");
                        string? genre = Console.ReadLine();
                        genreService.Create(new Genre() { Name = genre });
                        break;

                    case 2:
                        Console.WriteLine("Enter id:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(genreService.GetById(id));
                        break;

                    case 3:
                        Console.WriteLine("All genres:");

                        foreach (var item in genreService.GetAll())
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter id:");
                        int idForUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter new genre name:");
                        string? genreName = Console.ReadLine();
                        genreService.Update(idForUpdate, new Genre() {Name = genreName});
                        break;

                    case 5:
                        Console.WriteLine("Enter id:");
                        int idForDelete = Convert.ToInt32(Console.ReadLine());

                        genreService.Delete(idForDelete);
                        break;

                    case 6:
                        Console.WriteLine("Enter book name:");
                        string? book = Console.ReadLine();

                        Console.WriteLine("Enter sale price:");
                        double salePrice = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter cost price:");
                        double costPrice = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter genre id:");
                        int genreId = Convert.ToInt32(Console.ReadLine());

                        bookService.Create(new Book() { Name = book, SalePrice = salePrice,
                            CostPrice = costPrice, GenreId = genreId });
                        break;

                    case 7:
                        Console.WriteLine("Enter id:");
                        int bookId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(bookService.GetById(bookId));
                        break;

                    case 8:
                        Console.WriteLine("All books:");

                        foreach (var item in bookService.GetAll())
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 9:
                        Console.WriteLine("Enter id:");
                        int idForUpdateBook = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter new book name:");
                        string? bookName = Console.ReadLine();

                        Console.WriteLine("Enter new sale price:");
                        double newSalePrice = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter new cost price:");
                        double newCostPrice = Convert.ToDouble(Console.ReadLine());

                        bookService.Update(idForUpdateBook, new Book() { Name = bookName, SalePrice = newSalePrice, CostPrice = newCostPrice });
                        break;

                    case 10:
                        Console.WriteLine("Enter id:");
                        int idForDeleteBook = Convert.ToInt32(Console.ReadLine());
                        bookService.Delete(idForDeleteBook);
                        break;

                    case 0:
                        check = true;
                        Console.WriteLine("Process has ended.");
                        break;
                }
            }


        }
    }
}