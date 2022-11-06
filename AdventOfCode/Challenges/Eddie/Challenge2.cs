namespace AdventOfCode.Challenges.Eddie
{
    public class Challenge2 : BaseChallenge
    {
        public Challenge2(int challengeId) : base(challengeId)
        {
        }

        public override string GetPartOneAnswer()
        { // 90315
            Challenge2p1 p1 = new Challenge2p1(2);
            return p1.Movement().ToString();
        }

        public override string GetPartTwoAnswer()
        {
            Challenge2p2 p2 = new Challenge2p2(2);
            return p2.Movement().ToString();
        }
    }
}