using System;

namespace TP2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("MARVELL...");

            var rnd = new Random();

            int poderAtaqueSuperHeroe = rnd.Next(200,500);
            int poderAtaqueVillano = rnd.Next(300,600);

            decimal hitRatioSuperHeroe= (decimal)rnd.NextDouble();
            decimal hitRatioVillano= (decimal)rnd.NextDouble();

            decimal porcentajeDefensa= (decimal)rnd.NextDouble();

            Villano thanos = new Villano(poderAtaqueVillano,hitRatioVillano);

            
            //IronMan
            Superpoder Misil_laser = new Superpoder(true);
            IronMan ironMan = new IronMan(Misil_laser,poderAtaqueSuperHeroe,hitRatioSuperHeroe,porcentajeDefensa);

               
        }
    }
}
