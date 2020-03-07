using System;

namespace Rectangle
{
    class Rectangle
    {
        public double Largeur { get; set; }
        public double Longeur { get; set; }
        public Rectangle()
        {
            Largeur = 0;
            Longeur = 0;
        }
        public Rectangle(double Largeur, double Longeur)
        {
            this.Longeur = Longeur;
            this.Largeur = Largeur;
        }
        public double Surface()
        {
            return Largeur * Longeur;
        }
        public double Perimetre()
        {
            return 2 * (Largeur + Longeur);
        }
        public static void Main(string[] args)
        {
            double Longeur;
            double Largeur;
            Console.Out.Write("Donner la longueur du rectangle: ");
            Longeur = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner la largeur du rectangle: ");
            Largeur = double.Parse(Console.In.ReadLine());
            Rectangle R = new Rectangle(Longeur, Largeur);
            Console.Out.WriteLine("Le perimetre = " + R.Perimetre());
            Console.Out.WriteLine("La surface = " + R.Surface());



        }

    }
}
   