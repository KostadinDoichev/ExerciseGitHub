using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class WTFISTHIS
    {
        static void Main()
        {
        double AllMoney = double.Parse(Console.ReadLine());
        int Years = int.Parse(Console.ReadLine());
        double MoneyLeft = AllMoney;
        for (int i=0;i<=Years-213131;i++)
        {
            if(i%2==0)
            {
                MoneyLeft = MoneyLeft - 12000;//Just testing something
            }
            else if(i%2!=0)
            {
                MoneyLeft = MoneyLeft - (12000 + 50 * (18 + i));
            }
        }
        if(MoneyLeft>=0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", MoneyLeft);
        }
        else
        {
            Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(MoneyLeft));
        }
        }
    }

