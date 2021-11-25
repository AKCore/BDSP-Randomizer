using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using System.IO;
using System.Threading;
namespace BDSP_Randomizer
{
    public partial class MainForm : DarkForm
    {
        private static readonly Random getrandom = new Random();
        private List<int> _gen1 = new List<int>();
        private List<int> _gen2 = new List<int>();
        private List<int> _gen3 = new List<int>();
        private List<int> _gen4 = new List<int>();
        List<int> CurrentPool = new List<int>();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        string resourcesPath = "";
        public MainForm()
        {
            InitializeComponent();
            tbLog.AppendText("BDSP Randomizer Intialized" + Environment.NewLine);

            for(int i = 1; i < 152; i++)
            {
                _gen1.Add(i);
            }
            for (int i = 152; i < 252; i++)
            {
                _gen2.Add(i);
            }
            for (int i = 252; i < 387; i++)
            {
                _gen3.Add(i);
            }
            for (int i = 387; i < 494; i++)
            {
                _gen4.Add(i);
            }
        }

        public bool isCompressed()
        {
            return false;
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            //Load the resources folder that contains the sheets. 
            resourcesPath = AppDomain.CurrentDomain.BaseDirectory + "\\resources";
            tbLog.AppendText("resources loaded" + Environment.NewLine);
        }


        public int PickPokemon()
        {
            lock (getrandom)
            {
                return CurrentPool[getrandom.Next(CurrentPool.Count)];
            }
        }


        public int PickFromAllPokemon()
        {
            int min = 1;
            int max = 493;
            return GetRandomNumber(min, max);
        }
        public int GetNewLevel()
        {
            int min = (int)numMinLevel.Value;
            int max = (int)numMaxLevel.Value;
            return GetRandomNumber(min, max);
        }
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (cbEncounters.Checked )
            {
                RandomizeEncounters();
            }
            if(cbEncLevel.Checked)
            {
                RandomizeEncounterLevels();
            }
        }

        private string[] LoadEncounterSheet()
        {
            string[] retVal = null;
            try
            {
                if (rbDiamond.Checked)
                    retVal = File.ReadAllLines(resourcesPath + "\\FieldEncountTable_d.txt");
                else
                    retVal = File.ReadAllLines(resourcesPath + "\\FieldEncountTable_p.txt");

                tbLog.AppendText("Encounter Sheet Loaded!" + Environment.NewLine);
                return retVal;
            }
            catch
            {
                return null;
            }
        }

        private void SaveEncounterSheet(string[] content)
        {
            if (rbDiamond.Checked)
                File.WriteAllLines(resourcesPath + "\\FieldEncountTable_d_rand.txt", content);
            else
                File.WriteAllLines(resourcesPath + "\\FieldEncountTable_p_rand.txt", content);


            tbLog.AppendText("Encountersheet Saved!" + Environment.NewLine);
        }
        private void RandomizeEncounters()
        {
            string[] encounters = LoadEncounterSheet();
            
            if(encounters == null)
            {
                DarkMessageBox.Show(this, "Unable to load encounter sheet. Make sure you selected the right version and they are in the resources folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrentPool.Count == 0)
            {
                tbLog.AppendText("Apppending Selected Pokemon Gens to pool" + Environment.NewLine);

                if (cbGen1.Checked)
                {
                    foreach (int i in _gen1)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 1 added to pool" + Environment.NewLine);
                }
                if (cbGen2.Checked)
                {
                    foreach (int i in _gen2)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 2 added to pool" + Environment.NewLine);
                }
                if (cbGen3.Checked)
                {
                    foreach (int i in _gen3)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 3 added to pool" + Environment.NewLine);
                }
                if (cbGen4.Checked)
                {
                    foreach (int i in _gen4)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 4 added to pool" + Environment.NewLine);
                }
            }
            else
            {
                CurrentPool.Clear();
                tbLog.AppendText("Apppending Selected Pokemon Gens to pool" + Environment.NewLine);

                if (cbGen1.Checked)
                {
                    foreach (int i in _gen1)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 1 added to pool" + Environment.NewLine);
                }
                if (cbGen2.Checked)
                {
                    foreach (int i in _gen2)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 2 added to pool" + Environment.NewLine);
                }
                if (cbGen3.Checked)
                {
                    foreach (int i in _gen3)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 3 added to pool" + Environment.NewLine);
                }
                if (cbGen4.Checked)
                {
                    foreach (int i in _gen4)
                        CurrentPool.Add(i);
                    tbLog.AppendText("Gen 4 added to pool" + Environment.NewLine);
                }
            }
                
            tbLog.AppendText("Randomizing Encounters!" + Environment.NewLine);
            for (int i = 0; i < encounters.Length; i++)
            {
                //Regular Encounters
                if (encounters[i].Contains("0 int monsNo =") && !encounters[i].Contains("monsNo = 0"))
                {
                    //Find the = character and strip everything after it
                    int index = encounters[i].IndexOf("=");
                    if (index >= 0)
                        //Set the string back to itself and add the = and the new pokemon number
                        encounters[i] = encounters[i].Substring(0, index + 2) + PickPokemon();
                }
                //Safari Encounters
                else if (encounters[i].Contains("0 int MonsNo =") && !encounters[i].Contains("MonsNo = 0"))
                {
                    //Find the = character and strip everything after it
                    int index = encounters[i].IndexOf("=");
                    if (index >= 0)
                        //Set the string back to itself and add the = and the new pokemon number
                        encounters[i] = encounters[i].Substring(0, index + 2) + PickPokemon();
                }
            }
            SaveEncounterSheet(encounters);
            
            Thread.Sleep(300);
        }
        private void RandomizeEncounterLevels()
        {
            string[] encounters = LoadEncounterSheet();
            if (encounters == null)
            {
                DarkMessageBox.Show(this, "Unable to load encounter sheet. Make sure you selected the right version and they are in the resources folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbLog.AppendText("Randomizing Encounter Levels!" + Environment.NewLine);
            for (int i = 0; i < encounters.Length; i++)
            {
                //Max Level Replacement
                if (encounters[i].Contains("0 int maxlv =") && !encounters[i].Contains("maxlv = 0"))
                {
                    //Find the = character and strip everything after it
                    int index = encounters[i].IndexOf("=");
                    if (index >= 0)
                        //Set the string back to itself and add the = and the new pokemon number
                        encounters[i] = encounters[i].Substring(0, index+2)  + GetNewLevel();
                }
                //Min Level Replacement
                else if (encounters[i].Contains("0 int minlv =") && !encounters[i].Contains("minlv = 0"))
                {
                    //Find the = character and strip everything after it
                    int index = encounters[i].IndexOf("=");
                    if (index >= 0)
                        //Set the string back to itself and add the = and the new pokemon number
                        encounters[i] = encounters[i].Substring(0, index+2) +  GetNewLevel();
                }
            }
            SaveEncounterSheet(encounters);

        }

    }
}
