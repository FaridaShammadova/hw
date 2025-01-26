namespace Entity_Framework__ORM_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGenreService genreService = new GenreService();
            IBookService bookService = new BookService();

            //genreService.Create(new Genre() { Name = "qorxu"});
            //genreService.Create(new Genre() { Name = "macera"});
            //genreService.Create(new Genre() { Name = "detektiv"});

            //Console.WriteLine(genreService.GetById(4));

            //foreach (var item in genreService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //genreService.Update(2, new Genre() { Name = "roman"});

            //foreach (var item in genreService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //genreService.Delete(4);

            //foreach (var item in genreService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}


            //bookService.Create(new Book() { Name = "Mavi qatarin sirri", CostPrice = 7, SalePrice = 10, GenreId = 3});
            //bookService.Create(new Book() { Name = "Harry Pooter", CostPrice = 15, SalePrice = 20, GenreId = 2});
            //bookService.Create(new Book() { Name = "Psixiatr", CostPrice = 5, SalePrice = 8, GenreId = 1});

            //Console.WriteLine(bookService.GetById(7));

            //foreach (var item in bookService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //bookService.Update(8, new Book() { Name = "Harry Pooter", CostPrice = 18, SalePrice = 25, GenreId = 2 });


            //foreach (var item in bookService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //bookService.Delete(9);

            //foreach (var item in bookService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}