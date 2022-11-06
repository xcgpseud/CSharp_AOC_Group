using AdventOfCode.Enums;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge2p1 : BaseChallenge
    {
        public Challenge2p1(int challengeId) : base(challengeId)
        {
        }

        public override string GetPartOneAnswer()
        { // 90315
            return Movement()
                   .ToString();
        }

        public override string GetPartTwoAnswer()
        {
            return "XYZ";
        }

        int x = 0;
        int y = 0;
        string forward = "forward";
        string up = "up";
        string down = "down";
        int nextSplit = 0;
        public int Movement()
        {
            string[] input = FileHelper
                            .GetFileLines
                            (GetFileName
                            (Name.Eddie));

            foreach (var x in input)
            {

                string[] splitting = input[nextSplit]
                                    .Split(' ');

                var direction = splitting[0];
                var counter = Int32.Parse
                              (splitting[1]);

                if (direction == forward)
                {
                    Forward(counter);
                }
                else if (direction == up)
                {
                    Up(counter);
                }
                else if (direction == down)
                {
                    Down(counter);
                }
                nextSplit++;
            }
            return (x * y);
        }

        public void Forward(int input)
        {
            x += input;
        }
        public void Up(int input)
        {
            y -= input;
        }
        public void Down(int input)
        {
            y += input;
        }
    }
}
