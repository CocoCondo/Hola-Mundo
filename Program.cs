namespace CosoAmazon
{
    class MainApp
    {
        public static void Main()
        {
            Review r1 = new Review(5, "Buen producto, excelente.");
            Review r2 = new Review(4, "No es lo que esperaba, bien igual.");
            List<Review> ListaReviews = new List<Review>();
            ListaReviews.Add(r1);
            ListaReviews.Add(r2);
            Producto p1 = new Producto("Tu Viega", 250, ListaReviews);
            Console.WriteLine(p1);
        }
    }
}