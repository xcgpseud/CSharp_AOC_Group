using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge3 : BaseChallenge
    {
        public Challenge3(int challengeId) : base(challengeId)
        {
        }
        public override string GetPartOneAnswer()
        {
            Challenge3p1 p1 = new Challenge3p1(3);            
            return p1.MathHere().ToString();
        }

        public override string GetPartTwoAnswer()
        {
            return "";
        }
    }
}
