namespace Species
{
	public class TRex : Dinosaur
	{
		public TRex () : base()
		{
			//these numbers are taken from https://docs.google.com/spreadsheets/d/1iFu6LpLsf9QlxIve1ivWTQ2Rtc8C55LqGwW69TnCPdY
			AddPointsTo_Strength (4);
			AddPointsTo_Energy (1);
			AddPointsTo_Sensory (1);
			AddPointsTo_Survivability (2);
		}
	}
}