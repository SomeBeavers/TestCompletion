namespace MyNamespace
{
    public class Concrete
    {
        public int A { get; set; }

        public int B { get; set; }
    }

    public class Usage
    {
        public Usage()
        {
            var concrete = new/*caret*/ Concrete();
            concrete.A = 1;
            concrete.B = 2;
            
        }
    }
}