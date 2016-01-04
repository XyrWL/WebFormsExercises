using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise1
{
    public partial class Default : System.Web.UI.Page
    {
        const double SEKtoEURO = 0.108843055;
        const double SEKtoDOLLAR = 0.118209;
        const double SEKtoPOUND = 0.080003384;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConvertInputToSEK_Event(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(TextBoxInput.Text, out input))
            {
                switch (DropDownInputType.SelectedValue)
                {
                    case "sek":
                        ConvertSEKToOutput(input);
                        break;
                    case "euro":
                        ConvertSEKToOutput(input / SEKtoEURO);
                        break;
                    case "dollar":
                        ConvertSEKToOutput(input / SEKtoDOLLAR);
                        break;
                    case "pound":
                        ConvertSEKToOutput(input / SEKtoPOUND);
                        break;
                }
            }
        }
        private void ConvertSEKToOutput(double input)
        {
            switch (DropDownOutputType.SelectedValue)
            {
                case "sek":
                    TextboxOutput.Text = input.ToString();
                    break;
                case "euro":
                    TextboxOutput.Text = (input * SEKtoEURO).ToString();
                    break;
                case "dollar":
                    TextboxOutput.Text = (input * SEKtoDOLLAR).ToString();
                    break;
                case "pound":
                    TextboxOutput.Text = (input * SEKtoPOUND).ToString();
                    break;
            }
        }
    }
}