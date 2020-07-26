using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            AviaCompany avc = new AviaCompany();

        SH:

            Console.WriteLine("Введите количество самолётов (60-100):");
            string inputNAP = Console.ReadLine();
            int NAP = int.Parse(inputNAP);
            avc.Number_of_airplanes += NAP;

            if (NAP < 60)
            {
                Console.WriteLine("Вы ошиблись. Попробуйте ещё раз!");
                Console.ReadLine();
                Console.Clear();
                goto SH;
            }
            if (NAP > 100)
            {
                Console.WriteLine("Вы ошиблись. Попробуйте ещё раз!");
                Console.ReadLine();
                Console.Clear();
                goto SH;
            }

            Console.WriteLine(NAP + " самолётов");

            Console.WriteLine("Выберите самолёт (1 - пассажирский, 2 - грузовой");
            string ChoosePlane = Console.ReadLine();
            int PassOrFreight = int.Parse(ChoosePlane);

            if (PassOrFreight == 1)
            {
                Console.WriteLine("Введите количество пассажирова:");
                string inputPass = Console.ReadLine();
                int Passengers = int.Parse(inputPass);

                avc.Number_of_passenger += Passengers;

                Console.WriteLine(Passengers + " пассажиров");

            }
            if (PassOrFreight == 2)
            {
                Console.WriteLine("Введите кол-во грузовых:");
                string inputTC = Console.ReadLine();
                int TC = int.Parse(inputTC);

                Console.WriteLine(TC + " грузовых");

                avc.Number_of_freight += TC;

                Console.WriteLine("Введите грузоподъёмность:");
                string inputLC = Console.ReadLine();
                float LC = float.Parse(inputLC.Replace(".",","));

                avc.Total_lifting_capacity += LC;

                Console.WriteLine(LC + " кг/тон");

            }

        }
    }
}
