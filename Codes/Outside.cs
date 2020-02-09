namespace Quiz
{
	public interface Interface
	{
		System.Boolean State { get; set; }
		void Mutate();
	}
	public struct StructOrClass:Interface
	{
		public System.Boolean State { get; set; }
		public StructOrClass(System.Boolean State = false) { this.State=State; }
		public void Mutate() { this.State=!this.State; }
	}
	public class ClassOrStruct:Interface
	{
		public System.Boolean State { get; set; }
		public ClassOrStruct(System.Boolean State = false) { this.State=State; }
		public void Mutate() { this.State=!this.State; }
	}
}
