using System;
using System.Diagnostics;
namespace DataType
{
  public class Sunny
  {
    public void Glasses()
    {
        bool goAnyway =true;
        string going ="Awesome! Glad you don't mind clouds!";
        string nextTime= "No worries! Hopefully next time we will have some sun!";

        bool atBeach =true;
        string sunblock ="Sunblock is a good idea";
        string noSunblock ="Sunblock isn't needed.";

        bool isSunny =false;
        string wear ="Wear sunglasses!";
        string dontwear ="You don't need to wear sunglasses.";
        if(isSunny)
        {
            Console.WriteLine(wear);
            if (atBeach)
            {
            Console.WriteLine(sunblock);
            }
            else
            {
            Console.WriteLine(noSunblock);
            }
            }
        else
        {
            Console.WriteLine(dontwear);
            if(goAnyway)
            {
            Console.WriteLine(going);
            }
            else
            {
            Console.WriteLine(nextTime);
            }
        }

    }
  }
  class Program {
    static void Main (string[] args){
        Sunny needglass = new Sunny();
        needglass.Glasses();
    }
  }
}