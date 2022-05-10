namespace MAUI__Calculator_App;

public partial class MainPage : ContentPage
{

    private string val1, val2, omath, press;

    public MainPage()
    {
        InitializeComponent();
    }

    void Clear(object sender, EventArgs e)
    {
        val1 = null;
        val2 = null;
        historyView.Text = "";
        resultView.Text = "0";
    }

    void NumberSelect(object sender, EventArgs e)
    {

        Button button = sender as Button;
        press = button.Text;

        historyView.Text += press;
        resultView.Text = press;

        if (!System.Text.RegularExpressions.Regex.IsMatch(historyView.Text, @"[^0-9]"))
        {
            val1 += press;

        }
        else
        {

            val2 += press;

        }

    }

    void OperatorSelect(object sender, EventArgs e)
    {
        Button button = sender as Button;

        omath = button.Text;
        resultView.Text = omath;
        historyView.Text += omath;
    }

    void Calculate(object sender, EventArgs e)
    {
        historyView.Text = "=" + resultView.Text;

        resultView.Text = Calc.Do(Convert.ToDouble(val1), Convert.ToDouble(val2), omath).ToString();

        historyView.Text = resultView.Text;

        val1 = resultView.Text;
        val2 = "";

    }
}

