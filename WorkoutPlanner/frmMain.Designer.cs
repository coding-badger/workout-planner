namespace WorkoutPlanner
{
    partial class frmMain
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
            this.lbExercises = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSets = new System.Windows.Forms.ListBox();
            this.lbReps = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvExercises = new System.Windows.Forms.DataGridView();
            this.dgvWorkouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMuscleGroups = new System.Windows.Forms.GroupBox();
            this.rbForearms = new System.Windows.Forms.RadioButton();
            this.rbAbs = new System.Windows.Forms.RadioButton();
            this.rbGlutes = new System.Windows.Forms.RadioButton();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.rbLegs = new System.Windows.Forms.RadioButton();
            this.rbTriceps = new System.Windows.Forms.RadioButton();
            this.rbBiceps = new System.Windows.Forms.RadioButton();
            this.rbShoulders = new System.Windows.Forms.RadioButton();
            this.rbChest = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewExercise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).BeginInit();
            this.gbMuscleGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbExercises
            // 
            this.lbExercises.FormattingEnabled = true;
            this.lbExercises.Location = new System.Drawing.Point(15, 38);
            this.lbExercises.Name = "lbExercises";
            this.lbExercises.Size = new System.Drawing.Size(253, 264);
            this.lbExercises.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercise";
            // 
            // lbSets
            // 
            this.lbSets.FormattingEnabled = true;
            this.lbSets.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lbSets.Location = new System.Drawing.Point(285, 38);
            this.lbSets.Name = "lbSets";
            this.lbSets.Size = new System.Drawing.Size(42, 264);
            this.lbSets.TabIndex = 2;
            // 
            // lbReps
            // 
            this.lbReps.FormattingEnabled = true;
            this.lbReps.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lbReps.Location = new System.Drawing.Point(345, 38);
            this.lbReps.Name = "lbReps";
            this.lbReps.Size = new System.Drawing.Size(42, 264);
            this.lbReps.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reps";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(405, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add Workout";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(405, 860);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(405, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 42);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvExercises
            // 
            this.dgvExercises.AllowUserToAddRows = false;
            this.dgvExercises.AllowUserToResizeColumns = false;
            this.dgvExercises.AllowUserToResizeRows = false;
            this.dgvExercises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExercises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvWorkouts,
            this.dgvGroup,
            this.dgvSets,
            this.dgvReps});
            this.dgvExercises.Location = new System.Drawing.Point(15, 413);
            this.dgvExercises.Name = "dgvExercises";
            this.dgvExercises.RowHeadersVisible = false;
            this.dgvExercises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExercises.Size = new System.Drawing.Size(375, 470);
            this.dgvExercises.TabIndex = 20;
            this.dgvExercises.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvExercises_UserDeletingRow);
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvWorkouts.HeaderText = "Workout";
            this.dgvWorkouts.Name = "dgvWorkouts";
            // 
            // dgvGroup
            // 
            this.dgvGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvGroup.HeaderText = "Group";
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Width = 61;
            // 
            // dgvSets
            // 
            this.dgvSets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvSets.HeaderText = "Sets";
            this.dgvSets.Name = "dgvSets";
            this.dgvSets.Width = 53;
            // 
            // dgvReps
            // 
            this.dgvReps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvReps.HeaderText = "Reps";
            this.dgvReps.Name = "dgvReps";
            this.dgvReps.Width = 57;
            // 
            // gbMuscleGroups
            // 
            this.gbMuscleGroups.Controls.Add(this.rbForearms);
            this.gbMuscleGroups.Controls.Add(this.rbAbs);
            this.gbMuscleGroups.Controls.Add(this.rbGlutes);
            this.gbMuscleGroups.Controls.Add(this.rbBack);
            this.gbMuscleGroups.Controls.Add(this.rbLegs);
            this.gbMuscleGroups.Controls.Add(this.rbTriceps);
            this.gbMuscleGroups.Controls.Add(this.rbBiceps);
            this.gbMuscleGroups.Controls.Add(this.rbShoulders);
            this.gbMuscleGroups.Controls.Add(this.rbChest);
            this.gbMuscleGroups.Location = new System.Drawing.Point(15, 308);
            this.gbMuscleGroups.Name = "gbMuscleGroups";
            this.gbMuscleGroups.Size = new System.Drawing.Size(375, 79);
            this.gbMuscleGroups.TabIndex = 21;
            this.gbMuscleGroups.TabStop = false;
            this.gbMuscleGroups.Text = "Muscle Group";
            // 
            // rbForearms
            // 
            this.rbForearms.AutoSize = true;
            this.rbForearms.Location = new System.Drawing.Point(151, 20);
            this.rbForearms.Name = "rbForearms";
            this.rbForearms.Size = new System.Drawing.Size(68, 17);
            this.rbForearms.TabIndex = 8;
            this.rbForearms.Text = "Forearms";
            this.rbForearms.UseVisualStyleBackColor = true;
            this.rbForearms.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbAbs
            // 
            this.rbAbs.AutoSize = true;
            this.rbAbs.Location = new System.Drawing.Point(258, 43);
            this.rbAbs.Name = "rbAbs";
            this.rbAbs.Size = new System.Drawing.Size(43, 17);
            this.rbAbs.TabIndex = 7;
            this.rbAbs.Text = "Abs";
            this.rbAbs.UseVisualStyleBackColor = true;
            this.rbAbs.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbGlutes
            // 
            this.rbGlutes.AutoSize = true;
            this.rbGlutes.Location = new System.Drawing.Point(314, 20);
            this.rbGlutes.Name = "rbGlutes";
            this.rbGlutes.Size = new System.Drawing.Size(55, 17);
            this.rbGlutes.TabIndex = 6;
            this.rbGlutes.Text = "Glutes";
            this.rbGlutes.UseVisualStyleBackColor = true;
            this.rbGlutes.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Location = new System.Drawing.Point(314, 43);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(50, 17);
            this.rbBack.TabIndex = 5;
            this.rbBack.Text = "Back";
            this.rbBack.UseVisualStyleBackColor = true;
            this.rbBack.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbLegs
            // 
            this.rbLegs.AutoSize = true;
            this.rbLegs.Location = new System.Drawing.Point(258, 20);
            this.rbLegs.Name = "rbLegs";
            this.rbLegs.Size = new System.Drawing.Size(48, 17);
            this.rbLegs.TabIndex = 4;
            this.rbLegs.Text = "Legs";
            this.rbLegs.UseVisualStyleBackColor = true;
            this.rbLegs.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbTriceps
            // 
            this.rbTriceps.AutoSize = true;
            this.rbTriceps.Location = new System.Drawing.Point(85, 20);
            this.rbTriceps.Name = "rbTriceps";
            this.rbTriceps.Size = new System.Drawing.Size(60, 17);
            this.rbTriceps.TabIndex = 3;
            this.rbTriceps.Text = "Triceps";
            this.rbTriceps.UseVisualStyleBackColor = true;
            this.rbTriceps.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbBiceps
            // 
            this.rbBiceps.AutoSize = true;
            this.rbBiceps.Location = new System.Drawing.Point(85, 43);
            this.rbBiceps.Name = "rbBiceps";
            this.rbBiceps.Size = new System.Drawing.Size(57, 17);
            this.rbBiceps.TabIndex = 2;
            this.rbBiceps.Text = "Biceps";
            this.rbBiceps.UseVisualStyleBackColor = true;
            this.rbBiceps.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbShoulders
            // 
            this.rbShoulders.AutoSize = true;
            this.rbShoulders.Location = new System.Drawing.Point(7, 43);
            this.rbShoulders.Name = "rbShoulders";
            this.rbShoulders.Size = new System.Drawing.Size(72, 17);
            this.rbShoulders.TabIndex = 1;
            this.rbShoulders.Text = "Shoulders";
            this.rbShoulders.UseVisualStyleBackColor = true;
            this.rbShoulders.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // rbChest
            // 
            this.rbChest.AutoSize = true;
            this.rbChest.Checked = true;
            this.rbChest.Location = new System.Drawing.Point(7, 20);
            this.rbChest.Name = "rbChest";
            this.rbChest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbChest.Size = new System.Drawing.Size(52, 17);
            this.rbChest.TabIndex = 0;
            this.rbChest.TabStop = true;
            this.rbChest.Text = "Chest";
            this.rbChest.UseVisualStyleBackColor = true;
            this.rbChest.CheckedChanged += new System.EventHandler(this.gbMuscleGroups_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(405, 812);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 42);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(405, 461);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 42);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Re&set";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewExercise
            // 
            this.btnNewExercise.Location = new System.Drawing.Point(405, 86);
            this.btnNewExercise.Name = "btnNewExercise";
            this.btnNewExercise.Size = new System.Drawing.Size(75, 42);
            this.btnNewExercise.TabIndex = 24;
            this.btnNewExercise.Text = "&New Exercise";
            this.btnNewExercise.UseVisualStyleBackColor = true;
            this.btnNewExercise.Click += new System.EventHandler(this.btnNewExercise_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 900);
            this.Controls.Add(this.btnNewExercise);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbMuscleGroups);
            this.Controls.Add(this.dgvExercises);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReps);
            this.Controls.Add(this.lbSets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbExercises);
            this.Name = "frmMain";
            this.Tag = "";
            this.Text = "Workout Routine Planner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).EndInit();
            this.gbMuscleGroups.ResumeLayout(false);
            this.gbMuscleGroups.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbExercises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSets;
        private System.Windows.Forms.ListBox lbReps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvExercises;
        private System.Windows.Forms.GroupBox gbMuscleGroups;
        private System.Windows.Forms.RadioButton rbForearms;
        private System.Windows.Forms.RadioButton rbAbs;
        private System.Windows.Forms.RadioButton rbGlutes;
        private System.Windows.Forms.RadioButton rbBack;
        private System.Windows.Forms.RadioButton rbLegs;
        private System.Windows.Forms.RadioButton rbTriceps;
        private System.Windows.Forms.RadioButton rbBiceps;
        private System.Windows.Forms.RadioButton rbShoulders;
        private System.Windows.Forms.RadioButton rbChest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWorkouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReps;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewExercise;
    }
}

