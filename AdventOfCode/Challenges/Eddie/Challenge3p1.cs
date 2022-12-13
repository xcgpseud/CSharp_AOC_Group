using AdventOfCode.Enums;
using Helpers;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge3p1 : BaseChallenge
    {
        public Challenge3p1(int challengeId) : base(challengeId)
        {
        }
        public override string GetPartOneAnswer()
        {

            return "";
        }

        public override string GetPartTwoAnswer()
        {
            return "";
        }


        public int MathHere()
        {
            string[] input = FileHelper.GetFileLines(
                            GetFileName(
                            Name.Eddie)).ToArray();

            int[] output = new int[11];
            //input is each line of value
            //item is each actual line of inputs

            foreach (var item in input)
            {
                for (int i = 0; i < input.Count(); i++)
                {
                    int count = 0;
                    var currentNumber = 0;
                    output.SetValue(value: currentNumber , index: count);
                    
                }
            }
            return -1;
        }
    }
}
