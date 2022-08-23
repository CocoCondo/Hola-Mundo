namespace CosoAmazon
{
    class Review
    {
        int Calificacion {get; set;}
        string Comentarios {get; set;}

        public Review(int calificacion, string comentarios)
        {
            this.Calificacion = calificacion;
            this.Comentarios = comentarios;
        }

        public override string ToString()
        {
            return $"Calificación: {this.Calificacion}; Comentario: {this.Comentarios}\n";
        }
    }
}