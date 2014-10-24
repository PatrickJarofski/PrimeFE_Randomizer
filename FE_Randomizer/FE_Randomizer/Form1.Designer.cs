namespace FE_Randomizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.romTypeLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.romNameLabel = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.ItemOptionsGB = new System.Windows.Forms.GroupBox();
            this.controlledCritHelp = new System.Windows.Forms.Button();
            this.controlledMightHelp = new System.Windows.Forms.Button();
            this.itemStatsHelp = new System.Windows.Forms.Button();
            this.controlledCritCB = new System.Windows.Forms.CheckBox();
            this.controlledMightCB = new System.Windows.Forms.CheckBox();
            this.itemRandom = new System.Windows.Forms.RadioButton();
            this.itemUnmodifiedRB = new System.Windows.Forms.RadioButton();
            this.characterGrowthsGroupBox = new System.Windows.Forms.GroupBox();
            this.growthRandomHelp = new System.Windows.Forms.Button();
            this.growthReasonableHelp = new System.Windows.Forms.Button();
            this.growthShuffleHelp = new System.Windows.Forms.Button();
            this.growthsReasonableRB = new System.Windows.Forms.RadioButton();
            this.growthsUnleashedRB = new System.Windows.Forms.RadioButton();
            this.growthShuffleRB = new System.Windows.Forms.RadioButton();
            this.growthsUnchangedRB = new System.Windows.Forms.RadioButton();
            this.characterStatsGB = new System.Windows.Forms.GroupBox();
            this.characterBaseRandomHelp = new System.Windows.Forms.Button();
            this.characterBaseReasonableHelp = new System.Windows.Forms.Button();
            this.characterBaseShuffleHelp = new System.Windows.Forms.Button();
            this.baseStatsUnleashedRB = new System.Windows.Forms.RadioButton();
            this.baseStatsReasonableRB = new System.Windows.Forms.RadioButton();
            this.baseStatsShuffleRB = new System.Windows.Forms.RadioButton();
            this.baseStatsUnmodifiedRB = new System.Windows.Forms.RadioButton();
            this.unitClassGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unitClassRandomRB = new System.Windows.Forms.RadioButton();
            this.unitClassSameTierRB = new System.Windows.Forms.RadioButton();
            this.unitClassSameWepRB = new System.Windows.Forms.RadioButton();
            this.charClassUnmodifiedRB = new System.Windows.Forms.RadioButton();
            this.classStatCapsGB = new System.Windows.Forms.GroupBox();
            this.classCapsCompleteHelp = new System.Windows.Forms.Button();
            this.classCapsAdjustHelp = new System.Windows.Forms.Button();
            this.classCapsShuffleHelp = new System.Windows.Forms.Button();
            this.classCapsRandomHelp = new System.Windows.Forms.Button();
            this.statCapsOptionsGB = new System.Windows.Forms.GroupBox();
            this.statCapsCompletelyRB = new System.Windows.Forms.RadioButton();
            this.statCapsShuffleRB = new System.Windows.Forms.RadioButton();
            this.statCapsPromoRB = new System.Windows.Forms.RadioButton();
            this.statCapsRandomRB = new System.Windows.Forms.RadioButton();
            this.statCapsUnmodified = new System.Windows.Forms.RadioButton();
            this.ClassBaseStatsGB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classBaseOptionsGB = new System.Windows.Forms.GroupBox();
            this.classBasesAdjustRB = new System.Windows.Forms.RadioButton();
            this.classBasesShuffleRB = new System.Windows.Forms.RadioButton();
            this.classBasesRandomRB = new System.Windows.Forms.RadioButton();
            this.classBasesUnmodifiedRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemOptionsGB.SuspendLayout();
            this.characterGrowthsGroupBox.SuspendLayout();
            this.characterStatsGB.SuspendLayout();
            this.unitClassGB.SuspendLayout();
            this.classStatCapsGB.SuspendLayout();
            this.statCapsOptionsGB.SuspendLayout();
            this.ClassBaseStatsGB.SuspendLayout();
            this.classBaseOptionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(165, 11);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(155, 20);
            this.filePathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROM:";
            // 
            // romTypeLabel
            // 
            this.romTypeLabel.AutoSize = true;
            this.romTypeLabel.Location = new System.Drawing.Point(53, 28);
            this.romTypeLabel.Name = "romTypeLabel";
            this.romTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.romTypeLabel.TabIndex = 2;
            this.romTypeLabel.Text = "some game";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(326, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game:";
            // 
            // romNameLabel
            // 
            this.romNameLabel.AutoEllipsis = true;
            this.romNameLabel.AutoSize = true;
            this.romNameLabel.Location = new System.Drawing.Point(53, 15);
            this.romNameLabel.Name = "romNameLabel";
            this.romNameLabel.Size = new System.Drawing.Size(58, 13);
            this.romNameLabel.TabIndex = 5;
            this.romNameLabel.Text = "Imp. Name";
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(605, 9);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(75, 23);
            this.randomizeButton.TabIndex = 6;
            this.randomizeButton.Text = "Randomize!";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // ItemOptionsGB
            // 
            this.ItemOptionsGB.Controls.Add(this.controlledCritHelp);
            this.ItemOptionsGB.Controls.Add(this.controlledMightHelp);
            this.ItemOptionsGB.Controls.Add(this.itemStatsHelp);
            this.ItemOptionsGB.Controls.Add(this.controlledCritCB);
            this.ItemOptionsGB.Controls.Add(this.controlledMightCB);
            this.ItemOptionsGB.Controls.Add(this.itemRandom);
            this.ItemOptionsGB.Controls.Add(this.itemUnmodifiedRB);
            this.ItemOptionsGB.Location = new System.Drawing.Point(15, 198);
            this.ItemOptionsGB.Name = "ItemOptionsGB";
            this.ItemOptionsGB.Size = new System.Drawing.Size(200, 136);
            this.ItemOptionsGB.TabIndex = 9;
            this.ItemOptionsGB.TabStop = false;
            this.ItemOptionsGB.Text = "Item Options";
            // 
            // controlledCritHelp
            // 
            this.controlledCritHelp.Location = new System.Drawing.Point(174, 90);
            this.controlledCritHelp.Name = "controlledCritHelp";
            this.controlledCritHelp.Size = new System.Drawing.Size(20, 20);
            this.controlledCritHelp.TabIndex = 9;
            this.controlledCritHelp.Text = "?";
            this.controlledCritHelp.UseVisualStyleBackColor = true;
            this.controlledCritHelp.Click += new System.EventHandler(this.controlledCritHelp_Click);
            // 
            // controlledMightHelp
            // 
            this.controlledMightHelp.Location = new System.Drawing.Point(174, 67);
            this.controlledMightHelp.Name = "controlledMightHelp";
            this.controlledMightHelp.Size = new System.Drawing.Size(20, 20);
            this.controlledMightHelp.TabIndex = 8;
            this.controlledMightHelp.Text = "?";
            this.controlledMightHelp.UseVisualStyleBackColor = true;
            this.controlledMightHelp.Click += new System.EventHandler(this.controlledMightHelp_Click);
            // 
            // itemStatsHelp
            // 
            this.itemStatsHelp.Location = new System.Drawing.Point(174, 45);
            this.itemStatsHelp.Name = "itemStatsHelp";
            this.itemStatsHelp.Size = new System.Drawing.Size(20, 20);
            this.itemStatsHelp.TabIndex = 7;
            this.itemStatsHelp.Text = "?";
            this.itemStatsHelp.UseVisualStyleBackColor = true;
            this.itemStatsHelp.Click += new System.EventHandler(this.itemStatsHelp_Click);
            // 
            // controlledCritCB
            // 
            this.controlledCritCB.AutoSize = true;
            this.controlledCritCB.Location = new System.Drawing.Point(41, 93);
            this.controlledCritCB.Name = "controlledCritCB";
            this.controlledCritCB.Size = new System.Drawing.Size(91, 17);
            this.controlledCritCB.TabIndex = 3;
            this.controlledCritCB.Text = "Controlled Crit";
            this.controlledCritCB.UseVisualStyleBackColor = true;
            // 
            // controlledMightCB
            // 
            this.controlledMightCB.AutoSize = true;
            this.controlledMightCB.Location = new System.Drawing.Point(41, 70);
            this.controlledMightCB.Name = "controlledMightCB";
            this.controlledMightCB.Size = new System.Drawing.Size(102, 17);
            this.controlledMightCB.TabIndex = 2;
            this.controlledMightCB.Text = "Controlled Might";
            this.controlledMightCB.UseVisualStyleBackColor = true;
            // 
            // itemRandom
            // 
            this.itemRandom.AutoSize = true;
            this.itemRandom.Location = new System.Drawing.Point(6, 47);
            this.itemRandom.Name = "itemRandom";
            this.itemRandom.Size = new System.Drawing.Size(165, 17);
            this.itemRandom.TabIndex = 1;
            this.itemRandom.Text = "Random (Can Select Options)";
            this.itemRandom.UseVisualStyleBackColor = true;
            // 
            // itemUnmodifiedRB
            // 
            this.itemUnmodifiedRB.AutoSize = true;
            this.itemUnmodifiedRB.Location = new System.Drawing.Point(6, 24);
            this.itemUnmodifiedRB.Name = "itemUnmodifiedRB";
            this.itemUnmodifiedRB.Size = new System.Drawing.Size(78, 17);
            this.itemUnmodifiedRB.TabIndex = 0;
            this.itemUnmodifiedRB.Text = "Unmodified";
            this.itemUnmodifiedRB.UseVisualStyleBackColor = true;
            this.itemUnmodifiedRB.CheckedChanged += new System.EventHandler(this.itemUnmodifiedRB_CheckedChanged);
            // 
            // characterGrowthsGroupBox
            // 
            this.characterGrowthsGroupBox.Controls.Add(this.growthRandomHelp);
            this.characterGrowthsGroupBox.Controls.Add(this.growthReasonableHelp);
            this.characterGrowthsGroupBox.Controls.Add(this.growthShuffleHelp);
            this.characterGrowthsGroupBox.Controls.Add(this.growthsReasonableRB);
            this.characterGrowthsGroupBox.Controls.Add(this.growthsUnleashedRB);
            this.characterGrowthsGroupBox.Controls.Add(this.growthShuffleRB);
            this.characterGrowthsGroupBox.Controls.Add(this.growthsUnchangedRB);
            this.characterGrowthsGroupBox.Location = new System.Drawing.Point(15, 60);
            this.characterGrowthsGroupBox.Name = "characterGrowthsGroupBox";
            this.characterGrowthsGroupBox.Size = new System.Drawing.Size(200, 117);
            this.characterGrowthsGroupBox.TabIndex = 3;
            this.characterGrowthsGroupBox.TabStop = false;
            this.characterGrowthsGroupBox.Text = "Character Growths";
            // 
            // growthRandomHelp
            // 
            this.growthRandomHelp.Location = new System.Drawing.Point(174, 90);
            this.growthRandomHelp.Name = "growthRandomHelp";
            this.growthRandomHelp.Size = new System.Drawing.Size(20, 20);
            this.growthRandomHelp.TabIndex = 6;
            this.growthRandomHelp.Text = "?";
            this.growthRandomHelp.UseVisualStyleBackColor = true;
            this.growthRandomHelp.Click += new System.EventHandler(this.growthRandomHelp_Click);
            // 
            // growthReasonableHelp
            // 
            this.growthReasonableHelp.Location = new System.Drawing.Point(174, 65);
            this.growthReasonableHelp.Name = "growthReasonableHelp";
            this.growthReasonableHelp.Size = new System.Drawing.Size(20, 20);
            this.growthReasonableHelp.TabIndex = 5;
            this.growthReasonableHelp.Text = "?";
            this.growthReasonableHelp.UseVisualStyleBackColor = true;
            this.growthReasonableHelp.Click += new System.EventHandler(this.growthReasonableHelp_Click);
            // 
            // growthShuffleHelp
            // 
            this.growthShuffleHelp.Location = new System.Drawing.Point(174, 39);
            this.growthShuffleHelp.Name = "growthShuffleHelp";
            this.growthShuffleHelp.Size = new System.Drawing.Size(20, 20);
            this.growthShuffleHelp.TabIndex = 4;
            this.growthShuffleHelp.Text = "?";
            this.growthShuffleHelp.UseVisualStyleBackColor = true;
            this.growthShuffleHelp.Click += new System.EventHandler(this.growthShuffleHelp_Click);
            // 
            // growthsReasonableRB
            // 
            this.growthsReasonableRB.AutoSize = true;
            this.growthsReasonableRB.Location = new System.Drawing.Point(6, 67);
            this.growthsReasonableRB.Name = "growthsReasonableRB";
            this.growthsReasonableRB.Size = new System.Drawing.Size(131, 17);
            this.growthsReasonableRB.TabIndex = 3;
            this.growthsReasonableRB.Text = "Random (Reasonable)";
            this.growthsReasonableRB.UseVisualStyleBackColor = true;
            // 
            // growthsUnleashedRB
            // 
            this.growthsUnleashedRB.AutoSize = true;
            this.growthsUnleashedRB.Location = new System.Drawing.Point(6, 90);
            this.growthsUnleashedRB.Name = "growthsUnleashedRB";
            this.growthsUnleashedRB.Size = new System.Drawing.Size(125, 17);
            this.growthsUnleashedRB.TabIndex = 2;
            this.growthsUnleashedRB.Text = "Random (Unleashed)";
            this.growthsUnleashedRB.UseVisualStyleBackColor = true;
            // 
            // growthShuffleRB
            // 
            this.growthShuffleRB.AutoSize = true;
            this.growthShuffleRB.Location = new System.Drawing.Point(6, 44);
            this.growthShuffleRB.Name = "growthShuffleRB";
            this.growthShuffleRB.Size = new System.Drawing.Size(58, 17);
            this.growthShuffleRB.TabIndex = 1;
            this.growthShuffleRB.Text = "Shuffle";
            this.growthShuffleRB.UseVisualStyleBackColor = true;
            // 
            // growthsUnchangedRB
            // 
            this.growthsUnchangedRB.AutoSize = true;
            this.growthsUnchangedRB.Checked = true;
            this.growthsUnchangedRB.Location = new System.Drawing.Point(6, 21);
            this.growthsUnchangedRB.Name = "growthsUnchangedRB";
            this.growthsUnchangedRB.Size = new System.Drawing.Size(78, 17);
            this.growthsUnchangedRB.TabIndex = 0;
            this.growthsUnchangedRB.TabStop = true;
            this.growthsUnchangedRB.Text = "Unmodified";
            this.growthsUnchangedRB.UseVisualStyleBackColor = true;
            // 
            // characterStatsGB
            // 
            this.characterStatsGB.Controls.Add(this.characterBaseRandomHelp);
            this.characterStatsGB.Controls.Add(this.characterBaseReasonableHelp);
            this.characterStatsGB.Controls.Add(this.characterBaseShuffleHelp);
            this.characterStatsGB.Controls.Add(this.baseStatsUnleashedRB);
            this.characterStatsGB.Controls.Add(this.baseStatsReasonableRB);
            this.characterStatsGB.Controls.Add(this.baseStatsShuffleRB);
            this.characterStatsGB.Controls.Add(this.baseStatsUnmodifiedRB);
            this.characterStatsGB.Location = new System.Drawing.Point(254, 60);
            this.characterStatsGB.Name = "characterStatsGB";
            this.characterStatsGB.Size = new System.Drawing.Size(200, 117);
            this.characterStatsGB.TabIndex = 10;
            this.characterStatsGB.TabStop = false;
            this.characterStatsGB.Text = "Character Base Stats";
            // 
            // characterBaseRandomHelp
            // 
            this.characterBaseRandomHelp.Location = new System.Drawing.Point(174, 90);
            this.characterBaseRandomHelp.Name = "characterBaseRandomHelp";
            this.characterBaseRandomHelp.Size = new System.Drawing.Size(20, 20);
            this.characterBaseRandomHelp.TabIndex = 7;
            this.characterBaseRandomHelp.Text = "?";
            this.characterBaseRandomHelp.UseVisualStyleBackColor = true;
            this.characterBaseRandomHelp.Click += new System.EventHandler(this.characterBaseRandomHelp_Click);
            // 
            // characterBaseReasonableHelp
            // 
            this.characterBaseReasonableHelp.Location = new System.Drawing.Point(174, 65);
            this.characterBaseReasonableHelp.Name = "characterBaseReasonableHelp";
            this.characterBaseReasonableHelp.Size = new System.Drawing.Size(20, 20);
            this.characterBaseReasonableHelp.TabIndex = 6;
            this.characterBaseReasonableHelp.Text = "?";
            this.characterBaseReasonableHelp.UseVisualStyleBackColor = true;
            this.characterBaseReasonableHelp.Click += new System.EventHandler(this.characterBaseReasonableHelp_Click);
            // 
            // characterBaseShuffleHelp
            // 
            this.characterBaseShuffleHelp.Location = new System.Drawing.Point(174, 42);
            this.characterBaseShuffleHelp.Name = "characterBaseShuffleHelp";
            this.characterBaseShuffleHelp.Size = new System.Drawing.Size(20, 20);
            this.characterBaseShuffleHelp.TabIndex = 5;
            this.characterBaseShuffleHelp.Text = "?";
            this.characterBaseShuffleHelp.UseVisualStyleBackColor = true;
            this.characterBaseShuffleHelp.Click += new System.EventHandler(this.characterBaseShuffleHelp_Click);
            // 
            // baseStatsUnleashedRB
            // 
            this.baseStatsUnleashedRB.AutoSize = true;
            this.baseStatsUnleashedRB.Location = new System.Drawing.Point(6, 90);
            this.baseStatsUnleashedRB.Name = "baseStatsUnleashedRB";
            this.baseStatsUnleashedRB.Size = new System.Drawing.Size(125, 17);
            this.baseStatsUnleashedRB.TabIndex = 3;
            this.baseStatsUnleashedRB.Text = "Random (Unleashed)";
            this.baseStatsUnleashedRB.UseVisualStyleBackColor = true;
            // 
            // baseStatsReasonableRB
            // 
            this.baseStatsReasonableRB.AutoSize = true;
            this.baseStatsReasonableRB.Location = new System.Drawing.Point(6, 67);
            this.baseStatsReasonableRB.Name = "baseStatsReasonableRB";
            this.baseStatsReasonableRB.Size = new System.Drawing.Size(131, 17);
            this.baseStatsReasonableRB.TabIndex = 2;
            this.baseStatsReasonableRB.Text = "Random (Reasonable)";
            this.baseStatsReasonableRB.UseVisualStyleBackColor = true;
            // 
            // baseStatsShuffleRB
            // 
            this.baseStatsShuffleRB.AutoSize = true;
            this.baseStatsShuffleRB.Location = new System.Drawing.Point(6, 44);
            this.baseStatsShuffleRB.Name = "baseStatsShuffleRB";
            this.baseStatsShuffleRB.Size = new System.Drawing.Size(58, 17);
            this.baseStatsShuffleRB.TabIndex = 1;
            this.baseStatsShuffleRB.Text = "Shuffle";
            this.baseStatsShuffleRB.UseVisualStyleBackColor = true;
            // 
            // baseStatsUnmodifiedRB
            // 
            this.baseStatsUnmodifiedRB.AutoSize = true;
            this.baseStatsUnmodifiedRB.Checked = true;
            this.baseStatsUnmodifiedRB.Location = new System.Drawing.Point(6, 21);
            this.baseStatsUnmodifiedRB.Name = "baseStatsUnmodifiedRB";
            this.baseStatsUnmodifiedRB.Size = new System.Drawing.Size(78, 17);
            this.baseStatsUnmodifiedRB.TabIndex = 0;
            this.baseStatsUnmodifiedRB.TabStop = true;
            this.baseStatsUnmodifiedRB.Text = "Unmodified";
            this.baseStatsUnmodifiedRB.UseVisualStyleBackColor = true;
            // 
            // unitClassGB
            // 
            this.unitClassGB.Controls.Add(this.label5);
            this.unitClassGB.Controls.Add(this.label3);
            this.unitClassGB.Controls.Add(this.unitClassRandomRB);
            this.unitClassGB.Controls.Add(this.unitClassSameTierRB);
            this.unitClassGB.Controls.Add(this.unitClassSameWepRB);
            this.unitClassGB.Controls.Add(this.charClassUnmodifiedRB);
            this.unitClassGB.Location = new System.Drawing.Point(480, 60);
            this.unitClassGB.Name = "unitClassGB";
            this.unitClassGB.Size = new System.Drawing.Size(220, 117);
            this.unitClassGB.TabIndex = 11;
            this.unitClassGB.TabStop = false;
            this.unitClassGB.Text = "Character Starting Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Not Ready";
            // 
            // unitClassRandomRB
            // 
            this.unitClassRandomRB.AutoSize = true;
            this.unitClassRandomRB.Location = new System.Drawing.Point(6, 90);
            this.unitClassRandomRB.Name = "unitClassRandomRB";
            this.unitClassRandomRB.Size = new System.Drawing.Size(125, 17);
            this.unitClassRandomRB.TabIndex = 4;
            this.unitClassRandomRB.TabStop = true;
            this.unitClassRandomRB.Text = "Random (Completely)";
            this.unitClassRandomRB.UseVisualStyleBackColor = true;
            // 
            // unitClassSameTierRB
            // 
            this.unitClassSameTierRB.AutoSize = true;
            this.unitClassSameTierRB.Location = new System.Drawing.Point(6, 67);
            this.unitClassSameTierRB.Name = "unitClassSameTierRB";
            this.unitClassSameTierRB.Size = new System.Drawing.Size(122, 17);
            this.unitClassSameTierRB.TabIndex = 3;
            this.unitClassSameTierRB.Text = "Random (Same Tier)";
            this.unitClassSameTierRB.UseVisualStyleBackColor = true;
            // 
            // unitClassSameWepRB
            // 
            this.unitClassSameWepRB.AutoSize = true;
            this.unitClassSameWepRB.Location = new System.Drawing.Point(6, 44);
            this.unitClassSameWepRB.Name = "unitClassSameWepRB";
            this.unitClassSameWepRB.Size = new System.Drawing.Size(123, 17);
            this.unitClassSameWepRB.TabIndex = 1;
            this.unitClassSameWepRB.Text = "Same Weapon Type";
            this.unitClassSameWepRB.UseVisualStyleBackColor = true;
            // 
            // charClassUnmodifiedRB
            // 
            this.charClassUnmodifiedRB.AutoSize = true;
            this.charClassUnmodifiedRB.Checked = true;
            this.charClassUnmodifiedRB.Location = new System.Drawing.Point(6, 21);
            this.charClassUnmodifiedRB.Name = "charClassUnmodifiedRB";
            this.charClassUnmodifiedRB.Size = new System.Drawing.Size(78, 17);
            this.charClassUnmodifiedRB.TabIndex = 0;
            this.charClassUnmodifiedRB.TabStop = true;
            this.charClassUnmodifiedRB.Text = "Unmodified";
            this.charClassUnmodifiedRB.UseVisualStyleBackColor = true;
            // 
            // classStatCapsGB
            // 
            this.classStatCapsGB.Controls.Add(this.classCapsCompleteHelp);
            this.classStatCapsGB.Controls.Add(this.classCapsAdjustHelp);
            this.classStatCapsGB.Controls.Add(this.classCapsShuffleHelp);
            this.classStatCapsGB.Controls.Add(this.classCapsRandomHelp);
            this.classStatCapsGB.Controls.Add(this.statCapsOptionsGB);
            this.classStatCapsGB.Controls.Add(this.statCapsRandomRB);
            this.classStatCapsGB.Controls.Add(this.statCapsUnmodified);
            this.classStatCapsGB.Location = new System.Drawing.Point(254, 198);
            this.classStatCapsGB.Name = "classStatCapsGB";
            this.classStatCapsGB.Size = new System.Drawing.Size(200, 161);
            this.classStatCapsGB.TabIndex = 12;
            this.classStatCapsGB.TabStop = false;
            this.classStatCapsGB.Text = "Class Stat Caps";
            // 
            // classCapsCompleteHelp
            // 
            this.classCapsCompleteHelp.Location = new System.Drawing.Point(174, 127);
            this.classCapsCompleteHelp.Name = "classCapsCompleteHelp";
            this.classCapsCompleteHelp.Size = new System.Drawing.Size(20, 20);
            this.classCapsCompleteHelp.TabIndex = 17;
            this.classCapsCompleteHelp.Text = "?";
            this.classCapsCompleteHelp.UseVisualStyleBackColor = true;
            this.classCapsCompleteHelp.Click += new System.EventHandler(this.classCapsCompleteHelp_Click);
            // 
            // classCapsAdjustHelp
            // 
            this.classCapsAdjustHelp.Location = new System.Drawing.Point(174, 104);
            this.classCapsAdjustHelp.Name = "classCapsAdjustHelp";
            this.classCapsAdjustHelp.Size = new System.Drawing.Size(20, 20);
            this.classCapsAdjustHelp.TabIndex = 16;
            this.classCapsAdjustHelp.Text = "?";
            this.classCapsAdjustHelp.UseVisualStyleBackColor = true;
            this.classCapsAdjustHelp.Click += new System.EventHandler(this.classCapsAdjustHelp_Click);
            // 
            // classCapsShuffleHelp
            // 
            this.classCapsShuffleHelp.Location = new System.Drawing.Point(174, 82);
            this.classCapsShuffleHelp.Name = "classCapsShuffleHelp";
            this.classCapsShuffleHelp.Size = new System.Drawing.Size(20, 20);
            this.classCapsShuffleHelp.TabIndex = 15;
            this.classCapsShuffleHelp.Text = "?";
            this.classCapsShuffleHelp.UseVisualStyleBackColor = true;
            this.classCapsShuffleHelp.Click += new System.EventHandler(this.classCapsShuffleHelp_Click);
            // 
            // classCapsRandomHelp
            // 
            this.classCapsRandomHelp.Location = new System.Drawing.Point(174, 45);
            this.classCapsRandomHelp.Name = "classCapsRandomHelp";
            this.classCapsRandomHelp.Size = new System.Drawing.Size(20, 20);
            this.classCapsRandomHelp.TabIndex = 14;
            this.classCapsRandomHelp.Text = "?";
            this.classCapsRandomHelp.UseVisualStyleBackColor = true;
            this.classCapsRandomHelp.Click += new System.EventHandler(this.classCapsRandomHelp_Click);
            // 
            // statCapsOptionsGB
            // 
            this.statCapsOptionsGB.Controls.Add(this.statCapsCompletelyRB);
            this.statCapsOptionsGB.Controls.Add(this.statCapsShuffleRB);
            this.statCapsOptionsGB.Controls.Add(this.statCapsPromoRB);
            this.statCapsOptionsGB.Location = new System.Drawing.Point(6, 65);
            this.statCapsOptionsGB.Name = "statCapsOptionsGB";
            this.statCapsOptionsGB.Size = new System.Drawing.Size(165, 86);
            this.statCapsOptionsGB.TabIndex = 13;
            this.statCapsOptionsGB.TabStop = false;
            this.statCapsOptionsGB.Text = "(Choose Option)";
            // 
            // statCapsCompletelyRB
            // 
            this.statCapsCompletelyRB.AutoSize = true;
            this.statCapsCompletelyRB.Location = new System.Drawing.Point(35, 65);
            this.statCapsCompletelyRB.Name = "statCapsCompletelyRB";
            this.statCapsCompletelyRB.Size = new System.Drawing.Size(125, 17);
            this.statCapsCompletelyRB.TabIndex = 3;
            this.statCapsCompletelyRB.Text = "Random (Completely)";
            this.statCapsCompletelyRB.UseVisualStyleBackColor = true;
            // 
            // statCapsShuffleRB
            // 
            this.statCapsShuffleRB.AutoSize = true;
            this.statCapsShuffleRB.Checked = true;
            this.statCapsShuffleRB.Location = new System.Drawing.Point(35, 19);
            this.statCapsShuffleRB.Name = "statCapsShuffleRB";
            this.statCapsShuffleRB.Size = new System.Drawing.Size(58, 17);
            this.statCapsShuffleRB.TabIndex = 4;
            this.statCapsShuffleRB.TabStop = true;
            this.statCapsShuffleRB.Text = "Shuffle";
            this.statCapsShuffleRB.UseVisualStyleBackColor = true;
            // 
            // statCapsPromoRB
            // 
            this.statCapsPromoRB.AutoSize = true;
            this.statCapsPromoRB.Location = new System.Drawing.Point(35, 42);
            this.statCapsPromoRB.Name = "statCapsPromoRB";
            this.statCapsPromoRB.Size = new System.Drawing.Size(118, 17);
            this.statCapsPromoRB.TabIndex = 2;
            this.statCapsPromoRB.Text = "Adjust for promotion";
            this.statCapsPromoRB.UseVisualStyleBackColor = true;
            // 
            // statCapsRandomRB
            // 
            this.statCapsRandomRB.AutoSize = true;
            this.statCapsRandomRB.Location = new System.Drawing.Point(6, 42);
            this.statCapsRandomRB.Name = "statCapsRandomRB";
            this.statCapsRandomRB.Size = new System.Drawing.Size(65, 17);
            this.statCapsRandomRB.TabIndex = 1;
            this.statCapsRandomRB.Text = "Random";
            this.statCapsRandomRB.UseVisualStyleBackColor = true;
            // 
            // statCapsUnmodified
            // 
            this.statCapsUnmodified.AutoSize = true;
            this.statCapsUnmodified.Location = new System.Drawing.Point(6, 19);
            this.statCapsUnmodified.Name = "statCapsUnmodified";
            this.statCapsUnmodified.Size = new System.Drawing.Size(78, 17);
            this.statCapsUnmodified.TabIndex = 0;
            this.statCapsUnmodified.Text = "Unmodified";
            this.statCapsUnmodified.UseVisualStyleBackColor = true;
            this.statCapsUnmodified.CheckedChanged += new System.EventHandler(this.statCapsUnmodified_CheckedChanged);
            // 
            // ClassBaseStatsGB
            // 
            this.ClassBaseStatsGB.Controls.Add(this.label4);
            this.ClassBaseStatsGB.Controls.Add(this.classBaseOptionsGB);
            this.ClassBaseStatsGB.Controls.Add(this.classBasesRandomRB);
            this.ClassBaseStatsGB.Controls.Add(this.classBasesUnmodifiedRB);
            this.ClassBaseStatsGB.Enabled = false;
            this.ClassBaseStatsGB.Location = new System.Drawing.Point(480, 198);
            this.ClassBaseStatsGB.Name = "ClassBaseStatsGB";
            this.ClassBaseStatsGB.Size = new System.Drawing.Size(200, 161);
            this.ClassBaseStatsGB.TabIndex = 13;
            this.ClassBaseStatsGB.TabStop = false;
            this.ClassBaseStatsGB.Text = "Class Base Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Not Ready";
            // 
            // classBaseOptionsGB
            // 
            this.classBaseOptionsGB.Controls.Add(this.classBasesAdjustRB);
            this.classBaseOptionsGB.Controls.Add(this.classBasesShuffleRB);
            this.classBaseOptionsGB.Location = new System.Drawing.Point(17, 65);
            this.classBaseOptionsGB.Name = "classBaseOptionsGB";
            this.classBaseOptionsGB.Size = new System.Drawing.Size(155, 82);
            this.classBaseOptionsGB.TabIndex = 2;
            this.classBaseOptionsGB.TabStop = false;
            this.classBaseOptionsGB.Text = "(Choose Options)";
            // 
            // classBasesAdjustRB
            // 
            this.classBasesAdjustRB.AutoSize = true;
            this.classBasesAdjustRB.Location = new System.Drawing.Point(6, 42);
            this.classBasesAdjustRB.Name = "classBasesAdjustRB";
            this.classBasesAdjustRB.Size = new System.Drawing.Size(65, 17);
            this.classBasesAdjustRB.TabIndex = 1;
            this.classBasesAdjustRB.TabStop = true;
            this.classBasesAdjustRB.Text = "Random";
            this.classBasesAdjustRB.UseVisualStyleBackColor = true;
            // 
            // classBasesShuffleRB
            // 
            this.classBasesShuffleRB.AutoSize = true;
            this.classBasesShuffleRB.Location = new System.Drawing.Point(6, 19);
            this.classBasesShuffleRB.Name = "classBasesShuffleRB";
            this.classBasesShuffleRB.Size = new System.Drawing.Size(58, 17);
            this.classBasesShuffleRB.TabIndex = 0;
            this.classBasesShuffleRB.TabStop = true;
            this.classBasesShuffleRB.Text = "Shuffle";
            this.classBasesShuffleRB.UseVisualStyleBackColor = true;
            // 
            // classBasesRandomRB
            // 
            this.classBasesRandomRB.AutoSize = true;
            this.classBasesRandomRB.Location = new System.Drawing.Point(6, 42);
            this.classBasesRandomRB.Name = "classBasesRandomRB";
            this.classBasesRandomRB.Size = new System.Drawing.Size(65, 17);
            this.classBasesRandomRB.TabIndex = 1;
            this.classBasesRandomRB.TabStop = true;
            this.classBasesRandomRB.Text = "Random";
            this.classBasesRandomRB.UseVisualStyleBackColor = true;
            // 
            // classBasesUnmodifiedRB
            // 
            this.classBasesUnmodifiedRB.AutoSize = true;
            this.classBasesUnmodifiedRB.Location = new System.Drawing.Point(6, 19);
            this.classBasesUnmodifiedRB.Name = "classBasesUnmodifiedRB";
            this.classBasesUnmodifiedRB.Size = new System.Drawing.Size(78, 17);
            this.classBasesUnmodifiedRB.TabIndex = 0;
            this.classBasesUnmodifiedRB.TabStop = true;
            this.classBasesUnmodifiedRB.Text = "Unmodified";
            this.classBasesUnmodifiedRB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Not Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 371);
            this.Controls.Add(this.ClassBaseStatsGB);
            this.Controls.Add(this.classStatCapsGB);
            this.Controls.Add(this.unitClassGB);
            this.Controls.Add(this.characterStatsGB);
            this.Controls.Add(this.characterGrowthsGroupBox);
            this.Controls.Add(this.ItemOptionsGB);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.romNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.romTypeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Name = "MainForm";
            this.Text = "Fire Emblem Randomizer";
            this.ItemOptionsGB.ResumeLayout(false);
            this.ItemOptionsGB.PerformLayout();
            this.characterGrowthsGroupBox.ResumeLayout(false);
            this.characterGrowthsGroupBox.PerformLayout();
            this.characterStatsGB.ResumeLayout(false);
            this.characterStatsGB.PerformLayout();
            this.unitClassGB.ResumeLayout(false);
            this.unitClassGB.PerformLayout();
            this.classStatCapsGB.ResumeLayout(false);
            this.classStatCapsGB.PerformLayout();
            this.statCapsOptionsGB.ResumeLayout(false);
            this.statCapsOptionsGB.PerformLayout();
            this.ClassBaseStatsGB.ResumeLayout(false);
            this.ClassBaseStatsGB.PerformLayout();
            this.classBaseOptionsGB.ResumeLayout(false);
            this.classBaseOptionsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label romTypeLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label romNameLabel;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.GroupBox ItemOptionsGB;
        private System.Windows.Forms.GroupBox characterGrowthsGroupBox;
        private System.Windows.Forms.RadioButton growthsUnchangedRB;
        private System.Windows.Forms.RadioButton growthsUnleashedRB;
        private System.Windows.Forms.RadioButton growthShuffleRB;
        private System.Windows.Forms.RadioButton growthsReasonableRB;
        private System.Windows.Forms.RadioButton itemRandom;
        private System.Windows.Forms.RadioButton itemUnmodifiedRB;
        private System.Windows.Forms.GroupBox characterStatsGB;
        private System.Windows.Forms.RadioButton baseStatsUnleashedRB;
        private System.Windows.Forms.RadioButton baseStatsReasonableRB;
        private System.Windows.Forms.RadioButton baseStatsShuffleRB;
        private System.Windows.Forms.RadioButton baseStatsUnmodifiedRB;
        private System.Windows.Forms.GroupBox unitClassGB;
        private System.Windows.Forms.RadioButton unitClassSameTierRB;
        private System.Windows.Forms.RadioButton unitClassSameWepRB;
        private System.Windows.Forms.RadioButton charClassUnmodifiedRB;
        private System.Windows.Forms.GroupBox classStatCapsGB;
        private System.Windows.Forms.GroupBox statCapsOptionsGB;
        private System.Windows.Forms.RadioButton statCapsCompletelyRB;
        private System.Windows.Forms.RadioButton statCapsShuffleRB;
        private System.Windows.Forms.RadioButton statCapsPromoRB;
        private System.Windows.Forms.RadioButton statCapsRandomRB;
        private System.Windows.Forms.RadioButton statCapsUnmodified;
        private System.Windows.Forms.RadioButton unitClassRandomRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox controlledCritCB;
        private System.Windows.Forms.CheckBox controlledMightCB;
        private System.Windows.Forms.Button growthRandomHelp;
        private System.Windows.Forms.Button growthReasonableHelp;
        private System.Windows.Forms.Button growthShuffleHelp;
        private System.Windows.Forms.Button characterBaseRandomHelp;
        private System.Windows.Forms.Button characterBaseReasonableHelp;
        private System.Windows.Forms.Button characterBaseShuffleHelp;
        private System.Windows.Forms.Button itemStatsHelp;
        private System.Windows.Forms.Button classCapsCompleteHelp;
        private System.Windows.Forms.Button classCapsAdjustHelp;
        private System.Windows.Forms.Button classCapsShuffleHelp;
        private System.Windows.Forms.Button classCapsRandomHelp;
        private System.Windows.Forms.Button controlledCritHelp;
        private System.Windows.Forms.Button controlledMightHelp;
        private System.Windows.Forms.GroupBox ClassBaseStatsGB;
        private System.Windows.Forms.GroupBox classBaseOptionsGB;
        private System.Windows.Forms.RadioButton classBasesAdjustRB;
        private System.Windows.Forms.RadioButton classBasesShuffleRB;
        private System.Windows.Forms.RadioButton classBasesRandomRB;
        private System.Windows.Forms.RadioButton classBasesUnmodifiedRB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

