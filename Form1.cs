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
            File.Delete(@".\Master.csv");
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
            int rolls = 0;
            for (global::System.Int32 i = 0; i < Int32.Parse(Die[0]); i++)
            {
                int cast = random.Next(Int32.Parse(Die[1]));
                rolls += cast;
            }
            rolls += modifier;
            return rolls.ToString();
        }

        public static string[] ReadCSV(string FileName)
        {
            var list = new List<string>();
            ReadZip(FileName);
            using (TextFieldParser parser = new(@".\" + FileName + ".csv"))
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
            fastZip.ExtractZip(Zip, ".", File);
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
    }
}
