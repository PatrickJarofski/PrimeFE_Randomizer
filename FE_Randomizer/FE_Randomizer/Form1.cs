using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE_Randomizer
{
    public partial class MainForm : Form
    {
        Randomizer randomizer;

        public MainForm()
        {
            InitializeComponent();
            randomizeButton.Enabled = false;

            // So that that enabling/disabling events trigger
            statCapsUnmodified.Checked = true;
            itemUnmodifiedRB.Checked = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GBA games (.gba)|*.gba| All files *.*|*.*";
            ofd.RestoreDirectory = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePathBox.Text = ofd.FileName;
                randomizer = new Randomizer(ofd.FileName);
                randomizeButton.Enabled = true;
            }
        }
        
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            runCharacterGrowths();
            runCharacterStats();
            runClassCaps();
            runItemStats();
            runUnitData();

            randomizer.saveChanges();
            MessageBox.Show("Randomization Complete!");
        }
        
        private void runCharacterGrowths()
        {
            if(!growthsUnchangedRB.Checked)
            {
                if(growthShuffleRB.Checked)
                {
                    randomizer.ShuffleCharacterGrowths();
                }

                else if(growthsReasonableRB.Checked)
                {
                    randomizer.RandomizeCharacterGrowths(10, 61);
                }
                else // Unleashed
                {
                    randomizer.RandomizeCharacterGrowths(0, 256);
                }
            }
        }
        
        private void runCharacterStats()
        {
            if (!baseStatsUnmodifiedRB.Checked)
            {
                if (baseStatsShuffleRB.Checked)
                {
                    randomizer.ShuffleCharacterBaseStats();
                }

                else if (baseStatsReasonableRB.Checked)
                {
                    randomizer.RandomizeCharacterStats(0, 13);
                }
                else // Unleashed
                {
                    randomizer.RandomizeCharacterStats(0, 31);
                }
            }

        }
        
        private void runClassCaps()
        {
            if(statCapsUnmodified.Checked == false)
            {
                if(statCapsShuffleRB.Checked == true)
                {
                    randomizer.ShuffleStatCaps();
                }

                else if(statCapsPromoRB.Checked == true)
                {
                    randomizer.RandomizeClassStatCaps(10, 31, true);
                }

                else if(statCapsCompletelyRB.Checked == true)
                {
                    randomizer.RandomizeClassStatCaps(10, 31, false);
                }
            }
        }

        private void runItemStats()
        {
            if(itemUnmodifiedRB.Checked == false)
                randomizer.RandomItemStats(controlledMightCB.Checked, controlledCritCB.Checked);
            
        }

        private void runUnitData()
        {
            if(unitClassRandomRB.Checked)
                randomizer.RandomizeUnitData(Properties.Resources.allFE7Units);
        }

        // ====================================================
        // ------------- Radio Button Event Stuff -------------
        // ====================================================

        #region Radio button Enablers

        private void statCapsUnmodified_CheckedChanged(object sender, EventArgs e)
        {
            if(statCapsUnmodified.Checked == false)
            {
                statCapsShuffleRB.Enabled = true;
                statCapsPromoRB.Enabled = true;
                statCapsCompletelyRB.Enabled = true;
            }
            else
            {
                statCapsShuffleRB.Enabled = false;
                statCapsPromoRB.Enabled = false;
                statCapsCompletelyRB.Enabled = false;
            }

        }

        private void itemUnmodifiedRB_CheckedChanged(object sender, EventArgs e)
        {
            if(itemUnmodifiedRB.Checked == false)
            {
                controlledCritCB.Enabled = true;
                controlledMightCB.Enabled = true;
            }
            else
            {
                controlledCritCB.Enabled = false;
                controlledMightCB.Enabled = false;
            }
        }

        #endregion

        // ====================================================
        // ---------------- Help Button Stuff ----------------
        // ====================================================

        #region Help Button Methods

        private void growthShuffleHelp_Click(object sender, EventArgs e)
        {
            string msg = "Shuffles a character's existing growth rates around.\n"
                        + "\nFor example, say a character had growths 35, 40, 50."
                        + "\nAfter the shuffle the order may be 40, 50, 35."
                        +"\n\nThis operation is done for every character.";
            MessageBox.Show(msg);
        }

        private void growthReasonableHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes all characters' growth rates but "
                        + "\nkeeps the values between 0 and 60% with the "
                        + "\nexception of HP which is between 30 and 90%."
                        + "\n\nThis setting is ideal for creating random growths "
                        + "\nthat don't result in overly broken characters.";
            MessageBox.Show(msg);
        }

        private void growthRandomHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes all characters' growths where any "
                       + "\nparticular growth will be between 0 and 255%."
                       + "\n\nWarning: This will almost certainly result "
                       + "\nin BROKEN characters.";
            MessageBox.Show(msg);
        }

        private void characterBaseShuffleHelp_Click(object sender, EventArgs e)
        {
            string msg = "Similar to growth rate shuffle, this option shuffles "
                        + "\nthe base stat bonuses each character receives."
                        + "\nFor example, if a character has bonuses 4, 3, 6, then "
                        + "\nafter shuffling the bonuses may be 6, 4, 3.";
            MessageBox.Show(msg);
        }

        private void characterBaseReasonableHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes a character's base stat bonuses but "
                        + "\nkeeps the values between 0 and 12. This curbs "
                        + "\nthe tendency for broken characters somewhat."
                        + "\n\nWhile this will increase the starting power of early "
                        + "\ngame units, keep in mind that these randomizations are"
                        + "\nalso applied to enemies...";
            MessageBox.Show(msg);
        }

        private void characterBaseRandomHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes a character's base stat bonuses where "
                      + "\nany particular bonus will be between 0 and 30."
                      +"\n\nBeware: Anything can happen. You might run into "
                      + "\nenemies you just can't kill!"
                      +"\nThe reverse holds true for enemies!";
          
            MessageBox.Show(msg);
        }

        private void itemStatsHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes all items' might, hit, durability, and critical%. "
                        + "\nWith no controls chosen might will be between 0 and 25, "
                        + "\nhit between 50 and 100, durability between 10 and 50, and "
                        + "\ncritical between 0 and 30."
                        + "\n\nOptions are available for controlling the frequency of"
                        + "\nhigh might and high critical values."
                        + "\nItems such as stat boosters and promotion items are"
                        + "\nnot altered.";
            MessageBox.Show(msg);
        }
        
        private void controlledMightHelp_Click(object sender, EventArgs e)
        {
            string msg = "\nChoosing the Controlled Might option decreases the "
                        + "\nfrequency that a might greater than 13 will be chosen "
                        + "\nto around a 20% chance."
                        + "\nThis option is good for decreasing the frequency of "
                        + "\nsuper-powerful values. ";
            MessageBox.Show(msg);
        }

        private void controlledCritHelp_Click(object sender, EventArgs e)
        {
            string msg = "Choosing the Controlled Crit option decreases the "
                        + "\nfrequency that a non-zero crit value will be chosen "
                        + "\nto around a 33% chance."
                        + "\nValid non-zero values for crit are 5, 10, 15, and 30 "
                        + "\nwhen using this setting."
                        + "\nThis option is good for decreasing the frequency of "
                        + "\nhigh-critical values.";
            MessageBox.Show(msg);
        }
        
        private void classCapsRandomHelp_Click(object sender, EventArgs e)
        {
            string msg = "Allows for randomizing the stat caps for all "
                        + "\nclasses in the game."
                        + "\nSelecting different randomization options will "
                        + "\nyield different results.";
            MessageBox.Show(msg);
        }

        private void classCapsShuffleHelp_Click(object sender, EventArgs e)
        {
            string msg = "Shuffles a class's exisiting stat caps around but does"
                        + "\nnot take HP into account when shuffling."
                        + "\n"
                        + "\nFor example, if a class has caps 24, 26, 21, then after "
                        + "\nshuffling the caps may be 21, 26, 24."
                        + "\n\nThis operation is done for every class.";
            MessageBox.Show(msg);
        }

        private void classCapsAdjustHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes all classes' stat caps to each be between"
                        + "\n10 and 30. "
                        + "\nShould a given promoted class's cap be less than "
                        + "\ntheir unpromoted counterpart's, the cap will be"
                        + "\nadjusted to be between the unpromoted cap value and 30.";
            MessageBox.Show(msg);
        }

        private void classCapsCompleteHelp_Click(object sender, EventArgs e)
        {
            string msg = "Randomizes all classes' stat caps to each be between"
                        + "\n10 and 30. "
                        + "\nThis may result in promoted classes having caps"
                        + "\nlower than their unpromoted counterparts.";
            MessageBox.Show(msg);
        }
        #endregion
    }
}
