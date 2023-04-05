using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Reflection;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Policy;

namespace WorkoutPlanner
{
    public partial class frmMain : Form
    {
        List<string> muscleFileNames = new List<string> {"data/abs.txt", "data/back.txt", "data/biceps.txt", "data/chest.txt", "data/forearms.txt", "data/glutes.txt", "data/legs.txt", "data/shoulders.txt", "data/triceps.txt"};
        Dictionary<string, List<string>> dictMuscleGroups;

        List<Exercise> listExercise = new List<Exercise>();
        private void GetExerciseData(Exercise exercise)
        {
            exercise.name = lbExercises.SelectedItem.ToString();
            exercise.muscleGroup = gbMuscleGroups.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;
            exercise.sets = int.Parse(lbSets.SelectedItem.ToString());
            exercise.reps = int.Parse(lbReps.SelectedItem.ToString());
        }

        private void ReadList(List<string> muscleGroup)
        {
            foreach (string exercise in muscleGroup)
            {
                lbExercises.Items.Add(exercise);
            }
        }

        public Dictionary<string, List<string>> PopulateExerciseLists(List<string> fileNames)
        {
            var dictMuscleGroups = new Dictionary<string, List<string>>();

            foreach (var fileName in fileNames)
            {
                var fileContent = new List<string>();
                var fileLines = File.ReadAllLines(fileName);

                foreach (var line in fileLines)
                {
                    fileContent.Add(line);
                }

                dictMuscleGroups[fileName] = fileContent;
            }

            return dictMuscleGroups;
        }

        private void SaveFile(List<string> muscleGroup)
        {
            foreach (string exercise in muscleGroup)
            {
                lbExercises.Items.Add(exercise);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if string exists in DataGridView
            bool exists = false;
            foreach (DataGridViewRow row in dgvExercises.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == lbExercises.SelectedItem.ToString())
                {
                    exists = true;
                    break;
                }
            }

            try
            {
                Exercise exercise = new Exercise();
                GetExerciseData(exercise);
                if (!exists)
                {
                    dgvExercises.Rows.Add(exercise.name, exercise.muscleGroup, exercise.sets, exercise.reps);
                    listExercise.Add(exercise);
                }
                else
                {
                    MessageBox.Show("This exercise already exists in your workout.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make a full selection.");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dictMuscleGroups = PopulateExerciseLists(muscleFileNames);
            ReadList(dictMuscleGroups["data/chest.txt"]);
            dgvExercises.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void gbMuscleGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChest.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/chest.txt"]);
            }
            else if (rbShoulders.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/shoulders.txt"]);
            }
            else if (rbBiceps.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/biceps.txt"]);
            }
            else if (rbTriceps.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/triceps.txt"]);
            }
            else if (rbForearms.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/forearms.txt"]);
            }
            else if (rbLegs.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/legs.txt"]);
            }
            else if (rbAbs.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/abs.txt"]);
            }
            else if (rbGlutes.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/glutes.txt"]);
            }
            else if (rbBack.Checked)
            {
                lbExercises.Items.Clear();
                ReadList(dictMuscleGroups["data/back.txt"]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvExercises.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvExercises.SelectedRows)
                {

                    dgvExercises.Rows.Remove(row);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvExercises.Rows.Clear();
            listExercise.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Sort the list of exercises by muscle group then name
            var sortedListExercise = listExercise.OrderBy(x => x.muscleGroup).ThenBy(x => x.name).ToList();

            // Show a save file dialog to get the destination file path
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Export to Text File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a StringBuilder to store the data
                StringBuilder sb = new StringBuilder();


                // Set the muscle group to the first muscle group in list and write at top of file
                string muscleGroup = sortedListExercise.ElementAt(0).muscleGroup;
                sb.AppendLine($"{muscleGroup}\n-----");

                // iterate through the list of objects and append each one to the text
                foreach (Exercise obj in sortedListExercise)
                {

                    // Check if muscleGroup has changed
                    if (obj.muscleGroup == muscleGroup)
                    {
                        sb.AppendLine($"{obj.name.PadRight(40, '-')} {obj.sets} sets of {obj.reps} reps");
                    }
                    else
                    {
                        sb.AppendLine($"\n\n\n{obj.muscleGroup}\n-----");
                        sb.AppendLine($"{obj.name.PadRight(40, '-')} {obj.sets} sets of {obj.reps} reps");
                        muscleGroup = obj.muscleGroup;
                    }

                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }
        }

        private void dgvExercises_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Remove exercise from hidden stored list of exercise objects if a row is removed from dgvExercises
            Exercise exercise = listExercise.Find(p => p.name == e.Row.Cells["Workout"].Value.ToString() && p.muscleGroup == e.Row.Cells["Group"].Value.ToString() && p.sets == (int)e.Row.Cells["sets"].Value && p.reps == (int)e.Row.Cells["reps"].Value);
            listExercise.Remove(exercise);
        }

        private void btnNewExercise_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Current directory: {0}", Application.StartupPath);
        }
    }
}