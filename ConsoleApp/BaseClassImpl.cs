using System;
using Newtonsoft.Json;
global using System.Collections.Generic;

namespace ConsoleApp;

public class BaseClassImpl : BaseClass
{
    public void GetNameOfBaseClass() => GetName();
    public override string GetName1()
    {
      throw new NotImplementedException();
    }
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
        foreach (var i in list)
        {
            i.GetName1();
            i.GetName1();
        }

        JsonConvert.SerializeObject(@enum);

    }

}

internal class NewElement
{
	public void GetName1(dynamic d)
	{

        Console.WriteLine();
        d.GetFullPath();
        d.GetFullPath();
		throw new NotImplementedException();
	}
}

enum Enum{
    A, B, C
}
