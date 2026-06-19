using C_Homework7.Models;

//Book book = new Book("Crime and Punishment", "Fyodor Dostoevsky", 450, new DateOnly(1867, 5, 8));
//Movie movie = new Movie("The Shawshank Redemption", "Films is about two imprisoned man", "Drama", new TimeSpan(2, 22, 0));


Product product = Product.CreateProduct();
product.PrintProduct();

Book book = Book.CreateBook();
book.PrintBook();

Movie movie = Movie.EnterMovie();
movie.PrintMovie();

