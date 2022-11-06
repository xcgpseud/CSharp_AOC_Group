using AdventOfCode.Enums;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge2p2 : BaseChallenge
    {
        public Challenge2p2(int challengeId) : base(challengeId)
        {
        }
        public override string GetPartOneAnswer()
        {
            return "";
        }

        public override string GetPartTwoAnswer()
        {
            return Movement().ToString() + " zzzzz";
        }


        int x = 0;
        int y = 0;
        int aim = 0;

        string forward = "forward";
        string up = "up";
        string down = "down";
        int nextSplit = 0;

        public int Movement()
        {
            string[] input = FileHelper.GetFileLines(GetFileName(Name.Eddie));

            foreach (var x in input)
            {
                string[] splitting = input[nextSplit].Split(' ');
                var direction = splitting[0];
                var counter = Int32.Parse(splitting[1]);

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
            y += (aim * input);
        }
        public void Up(int input)
        {
            aim -= input;
        }
        public void Down(int input)
        {
            aim += input;
        }

        
    }
}
