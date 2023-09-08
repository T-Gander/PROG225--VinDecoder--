using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinDecoder
{
    internal static class VINDecoder225
    {
        private static string yearCodeCharacters = "ABCDEFGHJKLMNPRSTUVWXYZ123456789";

        private static bool illegal = false;

        private static List<string> illegalCharacters = new List<string> { "I", "O", "Q" };

        private static List<Tuple<string, List<string>>> countryCodes = new List<Tuple<string, List<string>>>();

        static VINDecoder225()
        {
            GenerateCountryCodes();
        }

        static internal string GenerateVIN()
        {
            string allCountryCodes = "1245J";
            Random rand1 = new Random();
            int allCodesIndex = rand1.Next(allCountryCodes.Length);

            StringBuilder sb = new StringBuilder();

            sb.Append(allCountryCodes[allCodesIndex]);

            for(int i = 0; i<16; i++)
            {
                sb.Append(yearCodeCharacters[rand1.Next(31)]);
            }

            return sb.ToString();
        }
        
        static internal void Decode(string vin)
        {
            foreach(string s in illegalCharacters) 
            {
                if(vin.Contains(s)) illegal = true;
            }

            if (vin.Length == 17 && !illegal)
            {
                string countryCode = vin.Substring(0, 1);
                SetCountryAndRegionTextBoxes(countryCode);

                Form1.MainForm.txtVDS.Text = vin.Substring(3, 5);
                Form1.MainForm.txtVIS.Text = vin.Substring(9, 8);

                string mainYearCode = vin.Substring(9, 1);
                string yearChecker = vin.Substring(6, 1);

                int finalYear = 1980 + yearCodeCharacters.IndexOf(mainYearCode);

                if(!int.TryParse(yearChecker, out int i))
                {
                    finalYear += 20;
                }

                Form1.MainForm.txtYear.Text = finalYear.ToString();
            }
            else
            {
                MessageBox.Show("An illegal VIN number was entered. Please try again.");
            }
        }

        static private void SetCountryAndRegionTextBoxes(string cr)
        {
            foreach (Tuple<string, List<string>> t in countryCodes)
            {
                if (t.Item2.Contains(cr))
                {
                    Form1.MainForm.txtCountry.Text = t.Item1;

                    switch (t.Item1)
                    {
                        case "Canada":
                        case "USA":
                            Form1.MainForm.txtRegion.Text = "North America";
                            break;

                        case "Japan":
                            Form1.MainForm.txtRegion.Text = "East Asia";
                            break;
                    }
                }
            }
        }

        static private void GenerateCountryCodes()
        {
            List<string> countryStrings = new List<string> { "Canada", "USA", "Japan" };

            List<string> canadaCodes = new List<string> { "2" };

            List<string> usaCodes = new List<string> { "1","4","5" };

            List<string> japanCodes = new List<string> { "J" };

            for(int i = 0; i < 2; i++)
            {
                switch (countryStrings[i])
                {
                    case "Canada":
                        countryCodes.Add(Tuple.Create(countryStrings[i], canadaCodes));
                        break;

                    case "USA":
                        countryCodes.Add(Tuple.Create(countryStrings[i], usaCodes));
                        break;

                    case "Japan":
                        countryCodes.Add(Tuple.Create(countryStrings[i], japanCodes));
                        break;
                }
            }
        }
    }
}
