using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int player1Points;
        private int player2Points;

        private string player1res = "";
        private string player2res = "";
        private string player1Name;
        private string player2Name;

        public TennisGameManager(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            player1Points = 0;
            this.player2Name = player2Name;
        }

        public string Score_Getter()
        {
            var score = "";
            if (player1Points == player2Points && player1Points < 3)
            {
                if (player1Points == 0) { score = "Love"; }

                if (player1Points == 1) { score = "Fifteen"; }

                if (player1Points == 2) { score = "Thirty"; }
                score += "-All";
            }

            if (player1Points == player2Points && player1Points > 2) { score = "Deuce"; }

            if (player1Points > 0 && player2Points == 0)
            {
                if (player1Points == 1) { player1res = "Fifteen"; }
                    
                if (player1Points == 2) { player1res = "Thirty"; }

                if (player1Points == 3) { player1res = "Forty"; }

                player2res = "Love";
                score = player1res + "-" + player2res;
            }
            if (player2Points > 0 && player1Points == 0)
            {
                var temp = player2Points;
                if (temp == 1) { player2res = "Fifteen"; }
                    
                if (temp == 2) { player2res = "Thirty"; }
                    
                if (temp == 3) { player2res = "Forty"; }
 
                player1res = "Love";
                score = player1res + "-" + player2res;
            }
            if (player1Points > player2Points && player1Points < 4)
            {
                if (player1Points == 2) { player1res = "Thirty"; }

                if (player1Points == 3) { player1res = "Forty"; }

                if (player2Points == 1) { player2res = "Fifteen"; }
                 
                if (player2Points == 2) { player2res = "Thirty"; }
                    
                score = player1res + "-" + player2res;
            }

            if (player2Points > player1Points && player2Points < 4)
            {
                if (player2Points == 2) { player2res = "Thirty"; }
                    
                if (player2Points == 3) { player2res = "Forty"; }
                    
                if (player1Points == 1) { player1res = "Fifteen"; }
                    
                if (player1Points == 2) { player1res = "Thirty"; }
                    
                score = player1res + "-" + player2res;
            }

            if (player1Points > player2Points && player2Points >= 3)
            {
                score = "Advantage player1";
            }

            if (player2Points > player1Points && player1Points >= 3)
            {
                score = generatePlayer2Name();
            }

            if (player1Points >= 4 && player2Points >= 0 && (player1Points - player2Points) >= 2)
            {
                score = "Win for player1";
            }
            score = getWinForPlayer1(score, player1Points, player2Points);
            return score;
        }
        private static string generatePlayer2Name()
        {
            return "Advantage player2";
        }

        public string getWinForPlayer1(string score, int player1Points, int player2Points)
        {
            if (player2Points >= 4 && player1Points >= 0 && (player2Points - player1Points) >= 2)
            {
                return "Win for player2";
            }
            return score; 
        }

        private void IncreasePlayer1Score()
        {
            player1Points++;
        }

        private void IncreasePlayer2Score()
        {
            player2Points++;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1") { IncreasePlayer1Score(); }
            else { IncreasePlayer2Score(); }
        }
    }
}

