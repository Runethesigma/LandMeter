namespace LandMeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*==========Analyse==========
1.Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        een hoek a - double
        een hoek c - double 

2.Bewerking: Welke formule heb je nodig om de afstand AB te bepalen? Noteer deze en vermeld welke ingebouwde methodes je hiervoor nodig hebt.
        |AB| = |AC |* sin(C)/sin(A+C)
        10 * Math.Sin(HoekC)/Math.Sin(HoekA + HoekC)

3.Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        de astand tussen A en B - double

==========Testdata=========

4.Testdata: Verzin en noteer testgegevens, en bereken met je rekenmachine de juiste oplossing. Zo weet je of je oefening klopt.
        als hoek a 40 is en hoek c 50 is de afstand tussen a en b 7.660... m

===========================*/
        private void BerekenButton_Click(object sender, EventArgs e)
        {
            double HoekA = Convert.ToDouble(HoekATextBox.Text);
            double HoekC = Convert.ToDouble(HoekCTextBox.Text);
            double Hoek1 = HoekA * Math.PI / 180;
            double Hoek2 = HoekC * Math.PI / 180;
            double AfstandAB = 10 * Math.Sin(Hoek2) / Math.Sin(Hoek1 + Hoek2);
            MessageBox.Show("De astand van punt A tot punt B is " + AfstandAB + "m.", "Landmeter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
