using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RegoPlatesDatabase
{
    public partial class RegoPlatesDatabase : Form
    {
        public List<string> regoPlate = new List<string>();
        public List<string> flaggedPlates = new List<string>();

        public RegoPlatesDatabase()
        {
            InitializeComponent();
        }

        private bool checkDuplicate(string plate)
        {
            return regoPlate.Contains(plate);
        }

        private void btn_OpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text files (day_*.txt)|day_*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length > 0)
                    {
                        regoPlate.AddRange(lines);
                        DisplayLicensePlates(); // Refresh the display
                        MessageBox.Show("File loaded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: This File is empty. Please choose another file with license plates.");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: File not found. Please try again with different file.");
                }
            }
            else
            {
                MessageBox.Show("ERROR: No Files selected");
            }
        }

        private void DisplayLicensePlates()
        {
            // sorts licenses alphabetically .Sort()
            // clear list box
            // updates the list with sorted rego plates
            regoPlate.Sort();
            RegoPlatesList.Items.Clear();

            foreach (string plate in regoPlate)
            {
                RegoPlatesList.Items.Add(plate);
            }
        }

        private void DisplayFlaggedPlates()
        {
            flaggedPlates.Sort();
            FlaggedListBox.Items.Clear();
            foreach (string plate in flaggedPlates)
            {
                FlaggedListBox.Items.Add(plate);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newPlate = TBRegoPlate.Text.Trim();
            
            if (string.IsNullOrEmpty(newPlate))
            {
                MessageBox.Show("ERROR: Input is empty or invalid, please enter a valid license plate");
                return;
            }
            
            if (checkDuplicate(newPlate)) //todo: create method to check for duplicates
            {
                MessageBox.Show("Duplicate license Plate");
                return;
            }
            
            regoPlate.Add(newPlate);
            TBRegoPlate.Clear();
            TBRegoPlate.Focus();
            DisplayLicensePlates();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (RegoPlatesList.SelectedItem != null)
            {
                string originalPlate = RegoPlatesList.SelectedItem.ToString();
                //show in textbox to edit
                string newPlate = TBRegoPlate.Text.Trim();

                if (string.IsNullOrEmpty(newPlate))
                {
                    MessageBox.Show("ERROR: Input is empty or invalid, please enter a valid license plate");
                    return;
                }
                if (checkDuplicate(newPlate))
                {
                    MessageBox.Show("ERROR: Duplicate License Plate");
                    return;
                }

                int selectedIndex = RegoPlatesList.SelectedIndex;
                regoPlate[selectedIndex] = newPlate;  // Update the plate in the list
                DisplayLicensePlates();  // Reloads the list
                TBRegoPlate.Clear();
                TBRegoPlate.Focus();
                MessageBox.Show("License Plate successfully edited");
            }
            else
            {
                MessageBox.Show("ERROR: Please select a License Plate to edit");
            }
        }

        private void RegoPlatesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegoPlatesList.SelectedItems != null)
            {
                string selectedPlate = RegoPlatesList.SelectedItem.ToString();
                TBRegoPlate.Text = selectedPlate;
            }
            else
            {
                TBRegoPlate.Clear();
                TBRegoPlate.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RegoPlatesList.SelectedItem != null)
            {
                string selectedPlate = RegoPlatesList.SelectedItem.ToString();
                regoPlate.Remove(selectedPlate);
                DisplayLicensePlates();  // Refresh the display
                SearchBar.Clear();
                SearchBar.Focus();
            }
            else
            {
                MessageBox.Show("ERROR: Please select a License Plate to remove.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (day_*.txt)|day_*.txt";
            saveFileDialog.Title = "Save License Plates";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, regoPlate);
                MessageBox.Show("Data saved successfully.");
            }
        }

        private void autoIncrementing()
        {
            string directory = Directory.GetCurrentDirectory();
            string[] existingFiles = Directory.GetFiles(directory, "day_*.txt");

            int fileIndex = existingFiles.Length + 1;
            string fileName = $"day.{fileIndex}";
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            string target = SearchBar.Text.Trim();

            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("ERROR: Please enter a valid license plate to search.");
                return;
            }

            regoPlate.Sort();
            int index = regoPlate.BinarySearch(target);

            if (index >= 0)
            {
                RegoPlatesList.SelectedItem = regoPlate[index];
                MessageBox.Show($"License Plate {target} found.");
            }
            else
            {
                MessageBox.Show($"License Plate {target} not found.");
                SearchBar.Clear();
                SearchBar.Focus();
            }
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)//todo: check if it follow guidelines/meets requirements 
        {
            string target = SearchBar.Text.Trim();

            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("ERROR: Please enter a valid license plate to search.");
                return;
            }

            int index = regoPlate.IndexOf(target);
            if (index >= 0)
            {
                RegoPlatesList.SelectedItem = regoPlate[index];
                MessageBox.Show($"License Plate {target} found.");
            }
            else
            {
                MessageBox.Show($"License Plate {target} not found.");
                SearchBar.Clear();
                SearchBar.Focus();
            }
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            if (RegoPlatesList.SelectedItem != null)
            {
                string tagplate = RegoPlatesList.SelectedItem.ToString();
                regoPlate.Remove(tagplate);
                flaggedPlates.Add(tagplate);
                DisplayLicensePlates();
                DisplayFlaggedPlates();
            }
            else
            {
                MessageBox.Show("ERROR: Select a license to tag");
            }
        }

        private void FlaggedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlaggedListBox.SelectedItems != null)
            {
                string selectedPlate = FlaggedListBox.SelectedItems.ToString();
                TBRegoPlate.Text = selectedPlate;
            }
            else
            {
                TBRegoPlate.Clear();
                TBRegoPlate.Focus();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // list<>
        }

        private void Flagged_SelectedIndexChanged(object sender, EventArgs e)
        {
            // list<> flagged
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e) //todo: or keyboard Enter?
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FlaggedList_DoubleClick(object sender, MouseEventArgs e)
        {
            if (FlaggedListBox.SelectedItem != null)
            {
                string unflag = FlaggedListBox.SelectedItem.ToString();
                flaggedPlates.Remove(unflag);
                regoPlate.Add(unflag);
                DisplayLicensePlates();
                DisplayFlaggedPlates();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            regoPlate.Clear();
            flaggedPlates.Clear();
            DisplayLicensePlates();
            DisplayFlaggedPlates();
            SearchBar.Clear();
            SearchBar.Focus();
        }

        private void TBRegoPlates_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LoadData_Click(object sender, EventArgs e)
        {

        }
    }
}
