using System.Buffers;
using System;
using Newtonsoft.Json;
global using System;

namespace ConsoleApp;

public class BaseClassImpl : BaseClass
{
    public void GetNameOfBaseClass() => GetName();

    public virtual int GetAge()
    {
        if (base.GetName().Equals("test name"))
        {
            return 1;
        }
        else
        {
            return null;
        }
    }
}

public static class Extensions
{
    public static string GetName(this BaseClass obj)
    {
        return obj.GetName();
    }
}

// TODO: test
internal class Use
{
    public void Test(Enum @enum, List<NewElement> list, int count)
    {
        foreach (var i in list)
        {
            
            i.GetName1();
            i.GetName1();
            i.GetName1();
            this.MemberwiseClone();
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
        d.GetFullPath();

        throw new NotImplementedException();
    }

    public void GetName2(Enum2 enum2)
    {
        switch (enum2)
        {
            case Enum2.A:
                return;
            case Enum2.B:
            case Enum2.C:
            case Enum2.D:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(enum2), enum2, null);
        }
    }
}

enum Enum
{
    A,
    B,
    C
}

enum Enum2
{
    A,
    B,
    C,
    D
}
