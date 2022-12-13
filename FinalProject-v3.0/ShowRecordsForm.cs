using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinalProject
{
    public partial class ShowRecordsForm : Form
    {
        static List<String> files = new List<String>();
        BindingSource filesBindingSource = new BindingSource();

        List<String> idS = new List<String>();
        
        public ShowRecordsForm()
        {
            InitializeComponent();
           // files.Add("Luis");
           // files.Add("paola");
        }
        //update list method
        internal void receiveRecords( string record)
        {
            files.Add(record);
        }

        private void ShowRecordsForm_Load(object sender, EventArgs e)
        {
            filesBindingSource.DataSource = files;
            listBoxnames.DataSource = filesBindingSource;

        }
        private void ShowForm_Activated(object sender, EventArgs e)
        {
            //form comes back
            filesBindingSource.ResetBindings(false);
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //open the add records form when clicking button "Add"

            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int item = listBoxnames.SelectedIndex;
            if (item >=0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete item " + files[item] +
                    "?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    files.RemoveAt(item);
  
                    filesBindingSource.ResetBindings(false);
                }
            }
        }

        private void comboBox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == "Ascendent")
            {
                files.Sort();

            } else
            {
                files.Sort();
                files.Reverse();
            }
            filesBindingSource.ResetBindings(false);
        }

        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\yarelis.trinidad\\source\\repos\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file;
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        file = inputFile.ReadLine();

                        files.Add(file);
                    }
                    inputFile.Close();

                    filesBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Users\\yarelis.trinidad\\source\\repos\\";

            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    StreamWriter outputFile;
                    outputFile = File.CreateText(saveFileDialog1.FileName); 

                    foreach (string file in files)
                    {
                        outputFile.WriteLine(file);

                    }
                    outputFile.Close();
                    MessageBox.Show("Saved to file");

                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
            }else {
                MessageBox.Show("Operation Canceled"); 
            }
        }


        //CHECK
        private void listBoxnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = listBoxnames.SelectedIndex;
            MessageBox.Show("File Information " + files.ElementAt(item));
            



        }

        private void btnGetRecords_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\yarelis.trinidad\\source\\repos\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file;
                    StreamReader inputFile;
                    inputFile = File.OpenText(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        file = inputFile.ReadLine();

                        files.Add(file);
                    }
                    inputFile.Close();

                    filesBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }
            }

        public List<String> retrieveiDs()
        {
            return idS;
        }
        internal void addIdS( string id)
        {
            idS.Add(id);
        }
    }
}
