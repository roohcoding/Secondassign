using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinAssignment
{
	internal class FlipCoin
	{
		
		
			public static void randomMethod()
			{

				// INITIALIZATION
				int coinNum, Head_Count = 0, Tail_Count = 0;
				int heads, tails;
				Random obj = new Random();

				// INPUT DATA
				Console.WriteLine("enter no. of times you want to flip the coin: ");
			     coinNum = int.Parse(Console.ReadLine());
			    

				// COMPUTATION
				for (int j = 0; j < coinNum; j++)
				{
					 
					if (coinNum < 0.5)
						Tail_Count++;
					else
						Head_Count++;
				}

				heads = Head_Count / coinNum * 100;
				tails = Tail_Count / coinNum * 100;
				Console.WriteLine("Percentage of heads: " + heads + "%");
				Console.WriteLine("Percentage of tails: " + tails + "%");

			}
		}
	}