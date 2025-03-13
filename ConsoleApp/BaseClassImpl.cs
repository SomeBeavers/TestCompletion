namespace ConsoleApp;

public class BaseClassImpl : BaseClass
{
    public void GetNameOfBaseClass() => GetName();
}

public static class Extensions{
    public static string GetName(this BaseClass obj){
        return obj.GetName();
    }
}

// TODO: test
internal class Use{
	public void Test(Enum @enum, List<NewElement> list)
	{
        foreach (i in list)
	}
}

enum Enum{
    A, B, C
}
