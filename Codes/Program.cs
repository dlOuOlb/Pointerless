namespace Root
{
	public class Program
	{
		private static void Mutate(Quiz.Interface Who) { Who.State=!Who.State; }
		public static void Main()
		{
			var ValOrRef = new Quiz.StructOrClass();	//ValOrRef.State==false
			var RefOrVal = new Quiz.ClassOrStruct();	//RefOrVal.State==false

			Mutate(Who: ValOrRef);						//ValOrRef.State==false
			Mutate(Who: RefOrVal);						//RefOrVal.State==true

			ValOrRef.Mutate();							//ValOrRef.State==true
			RefOrVal.Mutate();							//RefOrVal.State==false

			(ValOrRef as Quiz.Interface).Mutate();		//ValOrRef.State==true
			(RefOrVal as Quiz.Interface).Mutate();      //RefOrVal.State==true
			
			System.Console.WriteLine(value: "lol dude");
		}
	}
}
