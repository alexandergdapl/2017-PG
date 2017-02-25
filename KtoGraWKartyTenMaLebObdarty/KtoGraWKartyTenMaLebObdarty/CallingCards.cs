namespace KtoGraWKartyTenMaLebObdarty
{
    class CallingCards
    {
        string NameOfBigCards;

        public void CallingBigCards()
        {
            for (int i = 11; i < 15; i++)
            {
                switch (i)
                {
                    case 14:
                        NameOfBigCards = "As";
                        break;
                    case 13:
                        NameOfBigCards = "Król";
                        break;
                    case 12:
                        NameOfBigCards = "Dama";
                        break;
                    case 11:
                        NameOfBigCards = "Walet";
                        break;
                }
            }
        }
    }
}
