using AdventOfCode.Enums;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge1 : BaseChallenge
    {
        public Challenge1(int challengeId) : base(challengeId)
        {
        }

        public override string GetPartOneAnswer()
        {
            return Increimdaitent().ToString();

        }

        public override string GetPartTwoAnswer()
        {
            return IncrimentPart2().ToString();
        }


        public int Increimdaitent()
        {
            var input = FileHelper.GetFileLines(GetFileName(Name.Eddie) , int.Parse);
            int increaseCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && input[i] > input[i - 1])
                {
                    increaseCount++;
                }
            }
            return increaseCount;
        }
        public int IncrimentPart2()
        {
            var input = FileHelper.GetFileLines(GetFileName(Name.Eddie) , int.Parse);
            int increaseCount = 0;



            int i = 0;

            var original = input[i] + input[i + 1] + input[i + 2];

            var comparison = input[i + 1] + input[i + 2] + input[i + 3];

            for (int x = 0; i < (input.Length - 3); x++)
            {
                comparison = input[x + 1] + input[x + 2] + input[x + 3];
                if (comparison > original)
                {
                    increaseCount++;
                }
                original = comparison;

                i++;
            }
            return increaseCount;
        }
    }
}