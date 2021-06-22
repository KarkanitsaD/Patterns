using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасад
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHouse smartHouse = new SmartHouse();
            smartHouse.StartMorning();

            Console.ReadKey();
        }
    }   

    class SmartHouse
    {
        Multicooker multicooker = new Multicooker();
        RecordPlayer recordPlayer = new RecordPlayer();
        Toilet toilet = new Toilet();
        Bathroom bathroom = new Bathroom();
        public void StartMorning()
        {
            recordPlayer.PlayMorningMusic();
            toilet.LightOn();
            multicooker.CookBreakfast();
            bathroom.FillBathroomWithCoolWater();
        }
    }

    class Multicooker
    {
        public void CookBreakfast()
        {
            Console.WriteLine("Мультиварка готовит на завтрак кашу.");
        }
    }


    class RecordPlayer
    {
        public void PlayMorningMusic()
        {
            Console.WriteLine("Магнитофон играет музыку из леса.");
        }
    }

    class Toilet
    {
        public void LightOn()
        {
            Console.WriteLine("Свет в туалете включился.");
        }
    }

    class Bathroom
    {
        public void FillBathroomWithCoolWater()
        {
            Console.WriteLine("Ванная начала наполняться холодной водой.");
        } 
    }


}
