namespace MAUI__Calculator_App;

public partial class MainPage : ContentPage
{
	private int current = 1;
	private string val1, val2;
	string omath, press;
	public MainPage()
	{
		InitializeComponent();
	}

	void Clear(object sender, EventArgs e)
	{
		val1 = "0";
		val2 = "0";
		current = 1;
		this.result.Text = "0";
	}
	void AddZero(object sender, EventArgs e)
	{
		Button button = sender as Button;
		press = press + button.Text;

		if (val1 != "0")
			val1 = val1 + button.Text;
		else
			val2 = val2 + button.Text;

		this.result.Text = press;
	}
	void NumberSelect(object sender, EventArgs e)
	{

		Button button = sender as Button;


		press = button.Text;
		this.result.Text = press;



		if (current == 1)
		{
			val1 = press;
			current++;
		}
		else
		{
			val2 = press;
			current--;
		}

	}

	void OperatorSelect(object sender, EventArgs e)
	{
		Button button = sender as Button;

		omath = button.Text;
	}

	void Calculate(object sender, EventArgs e)
	{
		this.result.Text = Calc.Do(Convert.ToDouble(val1), Convert.ToDouble(val2), omath).ToString();
	}
}

