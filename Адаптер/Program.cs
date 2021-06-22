using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адаптер
{
    class Program
    {
        static void Main(string[] args)
        {

            Traveler traveler = new Traveler();
            traveler.Travel(new Car());

            traveler.Travel(new HorseToTransportAdapter(new Horse()));


            Console.Read();
        }
    }


    interface ITranspost
    {
        void Ride();
    }

    interface IAnimal
    {
        void Move();
    }


    class Car : ITranspost
    {
        public void Ride()
        {
            Console.WriteLine("Машина едет по дороге.");
        }
    }

    class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Лошадь идет по песку.");
        }
    }


    class Traveler
    {
        public void Travel(ITranspost transpost)
        {
            transpost.Ride();
        }
    }


    class HorseToTransportAdapter: ITranspost
    {
        Horse horse;
        public HorseToTransportAdapter(Horse h)
        {
            horse = h;
        }

        public void Ride()
        {
            horse.Move();
        }
    }


}
