namespace Species
{
	public class Velociraptor : Dinosaur
	{
		public Velociraptor () : base()
		{
			//these numbers are taken from https://docs.google.com/spreadsheets/d/1iFu6LpLsf9QlxIve1ivWTQ2Rtc8C55LqGwW69TnCPdY
			AddPointsTo_Agility (3);
			AddPointsTo_Sensory (1);
			AddPointsTo_Reproducibility (1);
			AddPointsTo_Intelligence (3);
		}
	}
}