using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Poker_Straight
{
    class _04_Poker_Straight
    {
        static void Main(string[] args)
        {
            int targetWeight = int.Parse(Console.ReadLine());

            char[] separators = ", ".ToCharArray();
            string[] faces = "A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A".Split(separators, StringSplitOptions.RemoveEmptyEntries);
            char[] suits = "CDHS".ToCharArray();
            int countHands = 0;
            //List<string> hands = new List<string>();
            
            for (int face1 = 0; face1 < faces.Length - 4; face1++)
            {
                for (int suit1 = 0; suit1 < suits.Length; suit1++)
                {
                    string card1 = string.Empty + faces[face1] + suits[suit1];
                    int face2 = face1 + 1;
                    int face3 = face2 + 1;
                    int face4 = face3 + 1;
                    int face5 = face4 + 1;
                    for (int suit2 = 0; suit2 < suits.Length; suit2++)
                    {
                        string card2 = string.Empty + faces[face2] + suits[suit2];
                        if (card1 != card2)
                        {
                            for (int suit3 = 0; suit3 < suits.Length; suit3++)
                            {
                                string card3 = string.Empty + faces[face3] + suits[suit3];
                                if (card3 != card1 && card3 != card2)
                                {
                                    for (int suit4 = 0; suit4 < suits.Length; suit4++)
                                    {
                                        string card4 = string.Empty + faces[face4] + suits[suit4];
                                        if (card4 != card1 && card4 != card2 && card4 != card3)
                                        {
                                            for (int suit5 = 0; suit5 < suits.Length; suit5++)
                                            {
                                                string card5 = string.Empty + faces[face5] + suits[suit5];
                                                if (card5 != card1 && card5 != card2 && card5 != card3 && card5 != card4)
                                                {
                                                    int weight = 10 * (face1 + 1) + suit1 + 1 +
                                                                20 * (face2 + 1) + suit2 + 1 +
                                                                30 * (face3 + 1) + suit3 + 1 +
                                                                40 * (face4 + 1) + suit4 + 1 +
                                                                50 * (face5 + 1) + suit5 + 1;
                                                    if (weight == targetWeight)
                                                    {
                                                        countHands++;
                                                        //hands.Add(string.Join(" ", card1, card2, card3, card4, card5)); 
                                                    }
                                                }
                                            }
                                        }                                                    
                                    }
                                }                                        
                            }
                        }                            
                    }
                }
            }
            //Console.WriteLine(string.Join("\n", hands));
            Console.WriteLine(countHands);
        }        
    }
}