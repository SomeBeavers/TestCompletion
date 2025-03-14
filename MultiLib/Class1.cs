namespace MultiLib
{
	public class Class1
	{
#if NET9_0
	    public void Test(){}
#endif
#if NET8_0
		public void Test()
		{
			return async;
		}
#endif
	}

	class Program
	{
		static void Main(string[] args)
		{	
			IQueryable<Vehicle> GetSnapshotVehicles1(int page)
				=> Session.UsedVehicles.Where(v => v.SnapshotVehicle != null && v.SnapshotVehicle.SnapshotPage != null);//Apply "Merge into pattern" quick-fix
	
		}

		public bool IsDigit(char c) => '0' <= c && c <= '9';
	}

	internal class Session
	{
		public static IQueryable<Vehicle> UsedVehicles;
	}

	internal  class Vehicle
	{
		public Vehicle SnapshotVehicle { get; set; }
		public object SnapshotPage { get; set; }
	}
}
