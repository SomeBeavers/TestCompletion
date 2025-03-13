namespace ConsoleApp;

public abstract class BaseClass
{
	public string GetName()
	{
		return "BaseClass";
	}

	public abstract string GetName1();
}

public class _BaseClass : BaseClass
{
  public override string GetName1()
  {
    throw new NotImplementedException();
  }

  public override string GetName2(){
    var t = 1;
  }
}
