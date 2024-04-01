using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Mobile:Device
    {
        public string[] SimCards;
        public Mobile(decimal width,decimal height, decimal weight,int simCardCount):base(width,height,weight)
        {
              if(simCardCount < 1 || simCardCount > 2 )
            {
                Console.WriteLine("2 den cox simcard olmaz");
            }
              SimCards = new string[simCardCount];
        }
        public void AddNumber(string Number) 
        {
          for(int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] == null) 
                {
                    SimCards[i] = Number;
                    return;
                }
                Console.WriteLine(SimCards[i] + " " + Number);
            }
            
        }
        public void RemoveNumber(string Number)
        {
            for (int i = 0;i < SimCards.Length;i++)
            {
                if (SimCards[i] == Number)
                {
                    SimCards[i] = null; 

                }
                    
            }
            Console.WriteLine("simcard silindi");
        }
        public void GetNumber()
        {
            for( int i = 0; i < SimCards.Length; i++)
            {
                if(SimCards[i] != null)
                {
                    Console.WriteLine($"{i+1} {SimCards[i]}");
                }
            }
        }
    }
}
