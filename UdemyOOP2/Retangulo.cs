namespace UdemyOOP2 {
    internal class Retangulo {
        public double Largura {  get; set; }
        public double Altura {  get; set; }

        public double Area() {
            return Largura*Altura;
        }
        public double Perimetro() {
            return( (2*+Altura)+(2*Largura));
        }
        public double Diagonal() {
            return (Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
        }
    }
}
