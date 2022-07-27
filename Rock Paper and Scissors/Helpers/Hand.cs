namespace Rock_Paper_and_Scissors.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand oppenentHand)
        {
            if(Selection == oppenentHand.Selection)
            {
                return GameStatus.Draw;
            }

            if(LosesAgainst == oppenentHand.Selection)
            {
                return GameStatus.Loss;
            }

            return GameStatus.Victory;
        }
    }
}
