using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAutomation.Classes
{
    public abstract class FootballGame
    {
        public Random RandomNumber = new Random();
        protected int JerseyNumber;
        protected int Speed;
        protected int Stamina;
        protected int Passing;
        protected int Shooting;
        protected int Skill;
        protected int Determination;
        protected int NaturalForm;
        protected int luck;
        public abstract bool Pass();

        public abstract bool Goll();
      
    }
    public class Goalkeeper : FootballGame
    { 
        public Goalkeeper(int JerseyNumber)
        {
            this.JerseyNumber = JerseyNumber;
            Speed = RandomNumber.Next(50, 100);
            Stamina = RandomNumber.Next(50, 100);
            Passing = RandomNumber.Next(50, 100);
            Shooting = RandomNumber.Next(50, 100);
            Skill = RandomNumber.Next(50, 100);
            Determination = RandomNumber.Next(50, 100);
            NaturalForm = RandomNumber.Next(50, 100);
            luck = RandomNumber.Next(50, 100);
        }

        public override Boolean Pass()
        {
            int PassScore = Convert.ToInt32(Passing * 0.3 + Skill * 0 * 3 + Stamina * 0.1 + NaturalForm * 0.2 + luck * 0.2);
            if(PassScore>50)
                return true;
            else
                return false;
        }
        public override Boolean Goll()
        {
            int GollScore = Convert.ToInt32(Skill * 0.1 + Shooting*0 + Determination * 0.1 + NaturalForm * 0.1 + Speed*0.1 + luck * 0.1);
            if (GollScore > 100)
                return true;
            else
                return false;
        }
    }
        

    public  class Defender : FootballGame
    {
        private int Positioning;
        private int Head;
        private int jump;
        public Defender(int JerseyNumber)
        {
            this.JerseyNumber = JerseyNumber;
            Speed = RandomNumber.Next(50, 90);
            Stamina = RandomNumber.Next(50, 90);
            Passing = RandomNumber.Next(50, 90);
            Shooting = RandomNumber.Next(50, 90);
            Skill = RandomNumber.Next(50, 90);
            Determination = RandomNumber.Next(50, 90);
            NaturalForm = RandomNumber.Next(50, 90);
            luck = RandomNumber.Next(50, 90);
            Positioning = RandomNumber.Next(50, 90);
            Head = RandomNumber.Next(50, 90);
            jump = RandomNumber.Next(50, 90);
        }
        public override Boolean Pass()
        {
            int PassScore = Convert.ToInt32(Passing * 0.3 + Skill * 0 * 3 + Stamina * 0.2 + NaturalForm * 0.2 + Positioning*0.1 + luck * 0.2);
            if (PassScore > 60)
                return true;
            else
                return false;
        }
        public override Boolean Goll()
        {
            int GollScore = Convert.ToInt32(Skill * 0.2 + Shooting * 0.1 + Determination * 0.1 + NaturalForm * 0.1 + Head*0.1 + jump*0.1+ Speed * 0.1 + luck * 0);
            if (GollScore > 80)
                return true;
            else
                return false;
        }
    }
    public class Midfielder : FootballGame
    {
        private int LongBall;
        private int FirstTouch;
        private int Productivity;
        private int Dribbling;
        private int SpecialTalent;
        public Midfielder(int JerseyNumber)
        {
            this.JerseyNumber = JerseyNumber;
            Stamina = RandomNumber.Next(60, 100);
            Passing = RandomNumber.Next(60, 100);
            Shooting = RandomNumber.Next(60, 100);
            Skill = RandomNumber.Next(60, 100);
            Determination = RandomNumber.Next(60, 100);
            NaturalForm = RandomNumber.Next(60, 100);
            luck = RandomNumber.Next(60, 100);
            LongBall = RandomNumber.Next(60, 100);
            FirstTouch = RandomNumber.Next(60, 100);
            Productivity = RandomNumber.Next(60, 100);
            Dribbling = RandomNumber.Next(60, 100);
            SpecialTalent = RandomNumber.Next(60, 100);
        }
        public override Boolean Pass()
        {
            int PassScore = Convert.ToInt32(Passing * 0.3 + Skill * 0 * 2 + SpecialTalent*0.2 + Stamina * 0.1 + NaturalForm * 0.2 + LongBall * 0.1 + Dribbling*0.1 + luck * 0.2);
            if (PassScore > 80)
                return true;
            else
                return false;
        }
        public override Boolean Goll()
        {
            int GollScore = Convert.ToInt32(Skill * 0.3 + Shooting * 0.2 + SpecialTalent * 0.2 + NaturalForm * 0.1 + FirstTouch * 0.2 + Productivity *0.1+ luck * 0.1);
            if (GollScore > 65)
                return true;
            else
                return false;
        }

    }
    public class Forward : FootballGame
    {
        private int Finishing;
        private int FirstTouch;
        private int Head;
        private int SpecialTalent;
        private int Composure;
        public Forward(int JerseyNumber)
        {
            this.JerseyNumber = JerseyNumber;
            Stamina = RandomNumber.Next(70, 100);
            Passing = RandomNumber.Next(70, 100);
            Shooting = RandomNumber.Next(70, 100);
            Skill = RandomNumber.Next(70, 100);
            Determination = RandomNumber.Next(70, 100);
            NaturalForm = RandomNumber.Next(70, 100);
            luck = RandomNumber.Next(70, 100);
            Finishing = RandomNumber.Next(70, 100);
            FirstTouch = RandomNumber.Next(70, 100);
            Head = RandomNumber.Next(70, 100);
            SpecialTalent = RandomNumber.Next(70, 100);
            Composure = RandomNumber.Next(70, 100);
        }
        public override Boolean Pass()
        {
            int PassScore = Convert.ToInt32(Passing * 0.3 + Skill * 0 * 2 + SpecialTalent * 0.2 + Stamina * 0.1 + NaturalForm * 0.1 + luck * 0.2);
            if (PassScore > 75)
                return true;
            else
                return false;
        }
        public override Boolean Goll()
        {
            int GollScore = Convert.ToInt32(Skill * 0.2 + Shooting * 0.3 + SpecialTalent * 0.3 + Head*0.2 + NaturalForm * 0.1 + Composure*0.1 + Finishing *0.2+ FirstTouch*0.1 + Determination * 0.1 + luck * 0.1);
            if (GollScore >50 )
                return true;
            else
                return false;
        }
    }

}
