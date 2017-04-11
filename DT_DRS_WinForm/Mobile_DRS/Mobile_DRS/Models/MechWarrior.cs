namespace Mobile_DRS.Models
{
    public class MechWarrior : BaseDataObject
	{
		string name = string.Empty;
		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		string callsign = string.Empty;
		public string CallSign
		{
			get { return callsign; }
			set { SetProperty(ref callsign, value); }
		}

        string rank = string.Empty;
        public string Rank
        {
            get { return rank; }
            set { SetProperty(ref rank, value); }
        }

        string affiliation = string.Empty;
        public string Affiliation
        {
            get { return affiliation; }
            set { SetProperty(ref affiliation, value); }
        }

        string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        int pilotingskill = 0;
        public int PilotingSkill
        {
            get { return pilotingskill; }
            set { SetProperty(ref pilotingskill, value); }
        }

        int gunneryskill = 0;
        public int GunnerySkill
        {
            get { return gunneryskill; }
            set { SetProperty(ref gunneryskill, value); }
        }

        int hitpoints = 0;
        public int HitPoints
        {
            get { return hitpoints; }
            set { SetProperty(ref hitpoints, value); }
        }

        int kills = 0;
        public int Kills
        {
            get { return kills; }
            set { SetProperty(ref kills, value); }
        }

        int damagetaken = 0;
        public int DamageTaken
        {
            get { return damagetaken; }
            set { SetProperty(ref damagetaken, value); }
        }
    }
}
