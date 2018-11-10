using System;
using System.Linq;

namespace BallsWeight

{
    public class Program
    {
        private static int[] balls = new int[8] { 5, 5, 5, 5, 5, 5, 5, 10 };

        static void Main(string[] args)
        {
            int[] randomisedBalls = balls.OrderBy(b => Guid.NewGuid()).ToArray();

            var firstThree = randomisedBalls.Take(3).ToArray();
            var secondThree = randomisedBalls.Skip(3).Take(3).ToArray();

            int ballIndex;
            
            if (firstThree.Sum() == secondThree.Sum())
            {
                var lastTwo = randomisedBalls.Skip(6).Take(2);
                ballIndex = Array.FindIndex(randomisedBalls, x => x == lastTwo.Max());
            }
            else
            {
                if (firstThree.Sum() > secondThree.Sum())
                {
                    if (firstThree[0] == firstThree[1])
                    {
                        ballIndex = Array.FindIndex(randomisedBalls, x => x == firstThree[2]);
                    }
                    else
                    {
                        ballIndex = Array.FindIndex(randomisedBalls, x => x == firstThree.Max());
                    }
                }
                else
                {
                    if (secondThree[0] == secondThree[1])
                    {
                        ballIndex = Array.FindIndex(randomisedBalls, x => x == secondThree[2]);
                    }
                    else
                    {
                        ballIndex = Array.FindIndex(randomisedBalls, x => x == secondThree.Max());
                    }
                }
            }
         
            //for (int i = 0; i < randomisedBalls.Length; i++)
            //{
            //    if (i != ballIndex)
            //    {
            //        Console.WriteLine(string.Format("array[{0}] = {1}", i, randomisedBalls[i]));
            //    }
            //    else
            //    {
            //        Console.WriteLine(string.Format("array[{0}] = {1} * different value", i, randomisedBalls[i]));
            //    }
            //}
        }
    }    
}
