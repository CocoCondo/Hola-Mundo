namespace CosoAmazon
{
    class Producto
    {
        string Nombre {get; set;}
        int Precio {get; set;}
        List<Review> Reviews {get; set;} = new List<Review>();

        public Producto(string nombre, int precio, List<Review> reviews)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Reviews = reviews;
        }

        public void AgregarReview(Review reviews)
        {
            this.Reviews.Add(reviews);
        }

        public override string ToString()
        {
            return $"Publicación: {this.Nombre} - Valor: {this.Precio} - Comentarios:\n {string.Join(" ", this.Reviews)}";
        }
    }
}