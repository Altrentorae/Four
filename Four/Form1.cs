using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        public bool andInSentence;
        private void Form1_Load(object sender, EventArgs e)
        {
            updateLabels();
            cLettering.Text = "Zero";
            cCount.Text = "4";
        }
        Struct Previous = new Struct();
        Struct Current = new Struct();
        Struct Pr2 = new Struct();
        Struct Pr3 = new Struct();
        Struct Pr4 = new Struct();
        Struct Pr5 = new Struct();
        Struct Pr6 = new Struct();
        
        
        private void updateLabels()
        {

            pLettering.Text = Previous.words;
            pNum.Text = Previous.num.ToString();
            pCount.Text = Previous.count.ToString();
            p2Lettering.Text = Pr2.words;
            p2Num.Text = Pr2.num.ToString();
            p2Count.Text = Pr2.count.ToString();
            p3Lettering.Text = Pr3.words;
            p3Num.Text = Pr3.num.ToString();
            p3Count.Text = Pr3.count.ToString();
            p4Lettering.Text = Pr4.words;
            p4Num.Text = Pr4.num.ToString();
            p4Count.Text = Pr4.count.ToString();
            p5Lettering.Text = Pr5.words;
            p5Num.Text = Pr5.num.ToString();
            p5Count.Text = Pr5.count.ToString();
            p6Lettering.Text = Pr6.words;
            p6Num.Text = Pr6.num.ToString();
            p6Count.Text = Pr6.count.ToString();

        }
        private void cNum_ValueChanged(object sender, EventArgs e)
        {
            Current.calculate(Convert.ToInt32(Math.Round(cNum.Value, 0)));
            //cNum.Value doesn't need to be set in Current, as it's an adjustable field
            cLettering.Text = Current.words;
            cCount.Text = Current.count.ToString();
            //--//
            if (instantCalc.Checked)
            {
                CALC_MAIN();                
            }
            

        }
        
        private void Next_Click(object sender, EventArgs e)
        {
            CALC_MAIN();
        }
        private void CALC_MAIN()
        {
            Previous.calculate(Current.count);
            Pr2.calculate(Previous.count);
            Pr3.calculate(Pr2.count);
            Pr4.calculate(Pr3.count);
            Pr5.calculate(Pr4.count);
            Pr6.calculate(Pr5.count);
            updateLabels();
        }

        private void instantCalc_CheckedChanged(object sender, EventArgs e)
        {
            if (instantCalc.Checked)
            {
                Next.Enabled = false;
                Next.BackColor = Color.SlateGray;
            }
            else
            {
                Next.Enabled = true;
                Next.BackColor = Color.LightGray;
            }
        }
    }

    public class Struct
    {
        public string words;
        public int num;
        public int count;


        public void calculate(int NUMVAL)
        {
            this.num = NUMVAL;
            this.words = HumanFriendlyInteger.IntegerToWritten(this.num);
            this.count = this.words.Count(char.IsLetter);
        }     
    }
    public static class HumanFriendlyInteger //Thanks Stackoverflow
    {

        static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] thousandsGroups = { "", " Thousand", " Million", " Billion" };

        private static string FriendlyInteger(int n, string leftDigits, int thousands)
        {
            if (n == 0)
            {
                return leftDigits;
            }

            string friendlyInt = leftDigits;

            if (friendlyInt.Length > 0)
            {
                friendlyInt += " ";
            }

            if (n < 10)
            {
                friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                friendlyInt += teens[n - 10];
            }
            else if (n < 100)
            {
                friendlyInt += FriendlyInteger(n % 10, tens[n / 10 - 2], 0);
            }
            else if (n < 1000)
            {
                friendlyInt += FriendlyInteger(n % 100, (ones[n / 100] + " Hundred"), 0);
            }
            else
            {
                friendlyInt += FriendlyInteger(n % 1000, FriendlyInteger(n / 1000, "", thousands + 1), 0);
                if (n % 1000 == 0)
                {
                    return friendlyInt;
                }
            }
            
                return friendlyInt + thousandsGroups[thousands];

        }

        public static string IntegerToWritten(int n)
        {
            if (n == 0)
            {
                return "Zero";
            }
            else if (n < 0)
            {
                return "Negative " + IntegerToWritten(-n);
            }

            return FriendlyInteger(n, "", 0);
        }
    }
}
