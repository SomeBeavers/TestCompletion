class A
{
    public int field;
    public int field2;
    public A Test(){
        new Concrete();
        var a = new A();
        a.field = 1;
        this.field = 1;

        // TODO: JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ArrangeObjectCreationFix
        return new();
    }
}