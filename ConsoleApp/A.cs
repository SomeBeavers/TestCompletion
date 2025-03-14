class A
{
	public int field;
	public int field2;

	public A Test()
	{
		new Concrete();
		var a = new A();
		a.field = 1;
		this.field = 1;
		var logger = new Logger();
		// TODO: JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ArrangeObjectCreationFix
		
		

		return new();
	}

	public class Logger
	{
		private readonly int a;
	}
}