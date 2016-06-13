using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tic_Tac_Toe_Power
{
    class Tic_Tac_Toe_Power
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int value0 = int.Parse(Console.ReadLine());

            // XY 			{00,01,02; 10,11,12; 20,21,22}  
            // indexXY		{1,2,3; 4,5,6; 7,8,9}  
            // valueXY		[value1,... value9]
            // value[i+1] 	= value(i) + 1

            // => index[i]	{0,1,2; 3,4,5; 6,7,8}	
            // => i = 		3 * y + x		
            // => value[i]	{value0, ... value8} 
            // => value[i] 	= value[0] + i

            int indexI = 3 * y + x;
            int valueI = value0 + indexI;
            long powerValueIndex = (long)Math.Pow(valueI, indexI + 1);
            Console.WriteLine(powerValueIndex);
        }
    }
}
