using System.Collections;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private new void OnClick()
		{

		}

		
	}

	public partial class MyEnumerable: IEnumerable<int>{
    public IEnumerator<int> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

	
  }

  public class SamleCollection<T>
  {
	private T[] arr = new T[100];
  }
}
