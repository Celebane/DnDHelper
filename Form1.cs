using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace DndHelper
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            TypesComboBox.Text = "All";
            TypesComboBox.Items.Add("All");
            ReadZip("Master");
            string[] list = ReadCSV("Master");
            foreach (var item in list)
            {
                TypesComboBox.Items.Add(BreakCamelCase().Replace(item.Replace("^", ""), " $1").Trim());
            }
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            string BreadCrumbs = "DnDHelper - ";
            string Item = TypesComboBox.Text;
            if (Item == "All")
            {
                Item = "Master";
            }
            string[] ItemBreadCrumbs = GetItem(Item.Replace(" ", ""), BreadCrumbs);
            ItemTextBox.Clear();
            ItemTextBox.Text = ItemBreadCrumbs[0];
            this.Text = ItemBreadCrumbs[1];
            this.Update();
        }

        public string[] GetItem(string TopTable, string BreadCrumbs)
        {
            string[] ReturnValues = new string[2];
            if (BreadCrumbs == "DnDHelper - ")
            {
                BreadCrumbs += TopTable;
            }

            string[] list = ReadCSV(TopTable);
            var random = new Random();
            int index = random.Next(list.Length);
            string Item = list[index];

            while (Item.Contains('^'))
            {
                string file = Item.Substring(Item.IndexOf("^"), (Item.IndexOf("^", Item.IndexOf("^") + 1) - Item.IndexOf("^")) + 1);
                BreadCrumbs = BreadCrumbs + " > " + file.Replace("^", "");
                string[] Additional = GetItem(file.Replace("^", ""), BreadCrumbs);
                BreadCrumbs = Additional[1];
                Item = Item.Replace(file, Additional[0]);
            }

            if (Item.Contains("::"))
            {
                Item = Item.Replace("::", Environment.NewLine + Environment.NewLine);
            }

            while (Item.Contains("##"))
            {
                string D = Item.Substring(Item.IndexOf("##"), (Item.IndexOf("##", Item.IndexOf("##") + 3) - Item.IndexOf("##")) + 2);
                string Die = Roll(D.Replace("#", ""));
                Item = Item.Replace(D, Die);
            }

            ReturnValues[0] = Item;
            ReturnValues[1] = BreadCrumbs;
            return ReturnValues;
        }
        public static string Roll(string Dice)
        {
            int rolls = 0;
            int modifier = 0;
            String[] Die;

            if (Dice.Contains('+') == true)
            {
                Die = Dice.Split('+');
                modifier += Int32.Parse(Die[1]);
                Dice = Die[0];
            }

            if (Dice.Contains('-') == true)
            {
                Die = Dice.Split('-');
                modifier += -Int32.Parse(Die[1]);
                Dice = Die[0];
            }

            var random = new Random();
            Die = Dice.Split('d');

            for (global::System.Int32 i = 0; i < Int32.Parse(Die[0]); i++)
            {
                int cast = random.Next(1, Int32.Parse(Die[1]) + 1);
                rolls += cast;
            }

            rolls += modifier;
            return rolls.ToString();
        }

        public static string[] ReadCSV(string FileName)
        {
            var list = new List<string>();
            ReadZip(@FileName);
            using (TextFieldParser parser = new(@".\" + @FileName + ".csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    list.Add(fields[1]);
                }
            }
            File.Delete(@".\" + FileName + ".csv");
            return list.ToArray();
        }

        public static void ReadZip(string Filename)
        {
            string Zip = @".\Tables.zip";
            string File = Filename + ".csv";
            FastZip fastZip = new()
            {
                Password = "blackstaff"
            };
            try
            {
                fastZip.ExtractZip(Zip, ".", @File);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        [GeneratedRegexAttribute("([A-Z+])", RegexOptions.Compiled)]
        private static partial System.Text.RegularExpressions.Regex BreakCamelCase();

        private void RandomBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                RandomBtn.PerformClick();
                e.Handled = true;
            }
        }

        private void D4NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d4ModNumUpDn.Value)
            {
                case 0: d4Label.Text = d4NumUpDn.Value.ToString() + "d4"; break;
                case > 0: d4Label.Text = d4NumUpDn.Value.ToString() + "d4+" + Math.Abs(d4ModNumUpDn.Value).ToString(); break;
                case < 0: d4Label.Text = d4NumUpDn.Value.ToString() + "d4-" + Math.Abs(d4ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D6NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d6ModNumUpDn.Value)
            {
                case 0: d6Label.Text = d6NumUpDn.Value.ToString() + "d6"; break;
                case > 0: d6Label.Text = d6NumUpDn.Value.ToString() + "d6+" + Math.Abs(d6ModNumUpDn.Value).ToString(); break;
                case < 0: d6Label.Text = d6NumUpDn.Value.ToString() + "d6-" + Math.Abs(d6ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D8NumUpDn_VisibleChanged(object sender, EventArgs e)
        {
            switch (d8ModNumUpDn.Value)
            {
                case 0: d8Label.Text = d8NumUpDn.Value.ToString() + "d8"; break;
                case > 0: d8Label.Text = d8NumUpDn.Value.ToString() + "d8+" + Math.Abs(d8ModNumUpDn.Value).ToString(); break;
                case < 0: d8Label.Text = d8NumUpDn.Value.ToString() + "d8-" + Math.Abs(d8ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D10NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d10ModNumUpDn.Value)
            {
                case 0: d10Label.Text = d10NumUpDn.Value.ToString() + "d10"; break;
                case > 0: d10Label.Text = d10NumUpDn.Value.ToString() + "d10+" + Math.Abs(d10ModNumUpDn.Value).ToString(); break;
                case < 0: d10Label.Text = d10NumUpDn.Value.ToString() + "d10-" + Math.Abs(d10ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D12NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d12ModNumUpDn.Value)
            {
                case 0: d12Label.Text = d12NumUpDn.Value.ToString() + "d12"; break;
                case > 0: d12Label.Text = d12NumUpDn.Value.ToString() + "d12+" + Math.Abs(d12ModNumUpDn.Value).ToString(); break;
                case < 0: d12Label.Text = d12NumUpDn.Value.ToString() + "d12-" + Math.Abs(d12ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D20NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d20ModNumUpDn.Value)
            {
                case 0: d20Label.Text = d20NumUpDn.Value.ToString() + "d20"; break;
                case > 0: d20Label.Text = d20NumUpDn.Value.ToString() + "d20+" + Math.Abs(d20ModNumUpDn.Value).ToString(); break;
                case < 0: d20Label.Text = d20NumUpDn.Value.ToString() + "d20-" + Math.Abs(d20ModNumUpDn.Value).ToString(); break;
            }
        }

        private void D100NumUpDn_ValueChanged(object sender, EventArgs e)
        {
            switch (d100ModNumUpDn.Value)
            {
                case 0: d100Label.Text = d100NumUpDn.Value.ToString() + "d100"; break;
                case > 0: d100Label.Text = d100NumUpDn.Value.ToString() + "d100+" + Math.Abs(d100ModNumUpDn.Value).ToString(); break;
                case < 0: d100Label.Text = d100NumUpDn.Value.ToString() + "d100-" + Math.Abs(d100ModNumUpDn.Value).ToString(); break;
            }
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            string dice = "";

            if ((d4Label.Text[..1] != "0") && (d4Label.Text[..1] != "d"))
            {
                dice += d4Label.Text;
            }

            if ((d6Label.Text[..1] != "0") && (d6Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d6Label.Text;
                }
                else
                {
                    dice += "," + d6Label.Text;
                }
            }

            if ((d8Label.Text[..1] != "0") && (d8Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d8Label.Text;
                }
                else
                {
                    dice += "," + d8Label.Text;
                }
            }

            if ((d10Label.Text[..1] != "0") && (d10Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d10Label.Text;
                }
                else
                {
                    dice += "," + d10Label.Text;
                }
            }

            if ((d12Label.Text[..1] != "0") && (d12Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d12Label.Text;
                }
                else
                {
                    dice += "," + d12Label.Text;
                }
            }

            if ((d20Label.Text[..1] != "0") && (d20Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d20Label.Text;
                }
                else
                {
                    dice += "," + d20Label.Text;
                }
            }

            if ((d100Label.Text[..1] != "0") && (d100Label.Text[..1] != "d"))
            {
                if (dice == "")
                {
                    dice = d100Label.Text;
                }
                else
                {
                    dice += "," + d100Label.Text;
                }
            }

            if (dice.Trim() != "")
            {
                if (dice.Contains(','))
                {
                    string[] d = dice.Split(',');
                    int result = 0;
                    foreach (var die in d)
                    {
                        result += Int32.Parse(Roll(die));
                    }
                    ResultTextBox.Text = dice + ": " + result.ToString();
                }
                else
                {
                    ResultTextBox.Text = dice + ": " + Int32.Parse(Roll(dice)).ToString();
                }
            }

        }
    }
}
