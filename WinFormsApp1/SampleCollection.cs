namespace WinFormsApp1
{
    class SampleCollection<T>
    {
        private T[] arr = new T[100];

        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public bool IfCountIsBig(){
            IfCountIsBig()
        }
    }
}

#if NET6_0
	    public void Test(){}
#endif