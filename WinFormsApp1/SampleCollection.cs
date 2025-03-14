namespace WinFormsApp1
{
    class SampleCollection<T>(int count)
    {
        private readonly T[] arr;

        public int Count { get; set; } = count;

        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public bool IfCountIsBig()
        {
            bool a;
            if (this.Count > 10)
            {
                a = false;
            }
            else
            {
                a = true;
            }
        }
    }

    public class UseCollection
    {
        private readonly int field;

        public UseCollection()
        {
            field = 12;
        }

        public void Use(string? parameter)
        {
            string s = parameter;
            new SampleCollection<int>(1);
        }

        static void Test(int i, bool cond)
        {
            switch (i)
            {
                case 42:
                {
                    if (cond) // #1
                        return;

                    var b = 2;
                    break;
                }
            }
        }

        public class Test11
        {
            private Dictionary<string, (int, int?)[]> testDict = new()
            {
                {
                    "Foo",
                    new (int, int?)[]
                    {
                        (1, 2),
                        (2, 3)
                    }
                }
            };
        }

        private Func<int, int> Foo(int a)
        {
            bool _bar, _baz;

            void Foo()
            {
                if (_bar)
                {
                    if (_baz)
                    {
                        _bar = false;
                    }

                    throw new Exception();
                }
            }

            return i =>
            {
                var lst = Enumerable.Repeat(0, 100).ToList();
                foreach (var x in lst)
                {
                    var dbl = 2 * x;
                }

                return 100;
            };
        }
    }
}