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
        // foreach (var i in list){
        //     i.GetName1();
        //     i.GetName1();
        // }

	}

}

enum Enum{
    A, B, C
}
