using System;
using System.IO;
using System.Windows.Forms;

namespace W3DS
{
    public partial class W3DS : Form
    {
        /************************* Global Variables *************************/
        string speakerFolder = "";
        string trainingFile = "";
        string trainingFileTemp = "";
        string validationFile = "";





        /************************* Used to initialise the form. *************************/
        public W3DS()
        {
            InitializeComponent();

            // Hides the labels.
            WAVs_Folder_Label.Text = "";
            Master_Transcript_Label.Text = "";
            Copy_WAVs_Label.Text = "";
            Remove_Lines_Label.Text = "";
            Generate_Validation_Label.Text = "";

            // Disables the lower buttons.
            Copy_WAVs_Button.Enabled = false;
            Remove_Lines_Button.Enabled = false;
            Generate_Validation_Button.Enabled = false;
        }





        /************************* Used to browse for the WAVs folder. *************************/
        private void WAVs_Folder_Button_Click(object sender, EventArgs e)
        {
            // Displays the browser and gets the folder name.
            FolderBrowserDialog fbd = new();
            fbd.ShowDialog();
            try
            {
                WAVs_Folder_Label.Text = Path.GetFullPath(fbd.SelectedPath);
            }
            catch
            {
                WAVs_Folder_Label.Text = "";
            }

            // Updates the output paths and button states.
            Input_Update();
        }





        /************************* Used to browse for the master transcript. *************************/
        private void Master_Transcript_Button_Click(object sender, EventArgs e)
        {
            // Displays the browser and gets the file name.
            OpenFileDialog ofd = new();
            ofd.ShowDialog();
            try
            {
                Master_Transcript_Label.Text = ofd.FileName;
            }
            catch
            {
                Master_Transcript_Label.Text = "";
            }

            // Updates the output paths and button states.
            Input_Update();
        }





        /************************* Used to specify the speaker name. *************************/
        private void Speaker_Name_Text_Changed(object sender, EventArgs e)
        {
            // Updates the output paths and button states.
            Input_Update();
        }





        /************************* Used to update the output paths and button states. *************************/
        private void Input_Update()
        {
            // Updates the output paths.
            speakerFolder = $"{WAVs_Folder_Label.Text}\\{Speaker_Name.Text.Replace(" ", "_")}";
            trainingFile = $"{Path.GetDirectoryName(Master_Transcript_Label.Text)}\\{Speaker_Name.Text.ToLower().Replace(" ", "_")}_train_filelist.txt";
            trainingFileTemp = $"{Path.GetDirectoryName(Master_Transcript_Label.Text)}\\{Speaker_Name.Text.ToLower().Replace(" ", "_")}_train_filelist_temp.txt";
            validationFile = $"{Path.GetDirectoryName(Master_Transcript_Label.Text)}\\{Speaker_Name.Text.ToLower().Replace(" ", "_")}_val_filelist.txt";

            // Enables or disables the lower buttons.
            if (WAVs_Folder_Label.Text != "" && Master_Transcript_Label.Text != "" && Speaker_Name.Text != "")
            {
                Copy_WAVs_Button.Enabled = true;
                Remove_Lines_Button.Enabled = true;
                Generate_Validation_Button.Enabled = true;
            }
            else
            {
                Copy_WAVs_Button.Enabled = false;
                Remove_Lines_Button.Enabled = false;
                Generate_Validation_Button.Enabled = false;
            }
        }





        /************************* Used to copy the speaker's WAVs and generate their training filelist. *************************/
        private void Copy_WAVs_Button_Click(object sender, EventArgs e)
        {
            // Initialises the counter.
            int counter = 0;

            // Creates the speaker's output folder.
            Directory.CreateDirectory(speakerFolder);

            // Creates a writer for the training filelist (overwrite mode).
            StreamWriter sw = new(trainingFile, false);

            // Reads and iterates through every line in the master transcript.
            string[] lines = File.ReadAllLines(Master_Transcript_Label.Text);
            foreach (string i in lines)
            {
                string line = i;

                // If the line contains the speaker, begin the sorting process.
                if (line.Contains($"{Speaker_Name.Text}: ") || line.Contains($"{Speaker_Name.Text} choice: "))
                {
                    // Deletes everything prior to the "0x".
                    line = line[line.IndexOf("0x")..];

                    // Prepends the proper path.
                    line = $"drive/MyDrive/Dialogue/{Speaker_Name.Text.Replace(" ", "_")}/{line}";

                    // Deletes the speaker string and applies the proper syntax.
                    int pos = line.IndexOf(" ");
                    line = line.Remove(pos, line.IndexOf(": ") + 2 - pos).Insert(pos, ".wav|");

                    // Deletes the stuff at the end of the line, if necessary.
                    if (line.IndexOf("  ") != -1)
                    {
                        line = line[..line.IndexOf("  ")];
                    }

                    // Corrects the punctuation.
                    line = line.Replace("--", ".");
                    line = line.Replace("…", ".");
                    line = line.Replace(".?", "?");
                    line = line.Replace("\"", "");

                    // Gets the name of the WAV.
                    string name = line[line.IndexOf("0x")..line.IndexOf("|")];

                    // Prevents duplicate entries in the training filelist.
                    if (!File.Exists($"{speakerFolder}\\{name}"))
                    {
                        // If the file exists, copy it (overwrite mode) and write to the training filelist.
                        try
                        {
                            File.Copy($"{WAVs_Folder_Label.Text}\\{name}", $"{speakerFolder}\\{name}", true);
                            sw.WriteLine(line);
                            ++counter;
                        }
                        catch
                        {

                        }
                    }
                }
            }

            // Closes the writer and outputs statistics.
            sw.Close();
            Copy_WAVs_Label.Text = $"{counter} lines added to training filelist. WAVs copied.";

            // If no files were copied, delete the empty speaker folder and filelist.
            if (counter == 0)
            {
                Directory.Delete(speakerFolder);
                File.Delete(trainingFile);
            }
        }





        /************************* Used to remove user-deleted lines from the training filelist. *************************/
        private void Remove_Lines_Button_Click(object sender, EventArgs e)
        {
            // Initialises the counters.
            int counter1 = 0;
            int counter2 = 0;

            // Creates a writer for the temporary training filelist (overwrite mode).
            StreamWriter sw = new(trainingFileTemp, false);

            // Reads and iterates through every line in the original training filelist.
            string[] lines = File.ReadAllLines(trainingFile);
            foreach (string i in lines)
            {
                string line = i;

                // Gets the name of the WAV.
                string name = line[line.IndexOf("0x")..line.IndexOf("|")];

                // If the file still exists, write it to the temporary training filelist.
                if (File.Exists($"{speakerFolder}\\{name}"))
                {
                    sw.WriteLine(line);
                    ++counter1;
                }
                else
                {
                    ++counter2;
                }
            }

            // Closes the writer and outputs statistics.
            sw.Close();
            Remove_Lines_Label.Text = $"{counter1} lines preserved. {counter2} lines removed from training filelist.";

            // Replaces the training filelist.
            File.Delete(trainingFile);
            File.Move(trainingFileTemp, trainingFile);
            File.Delete(trainingFileTemp);
        }





        /************************* Used to generate the validation filelist. *************************/
        private void Generate_Validation_Button_Click(object sender, EventArgs e)
        {
            // Initialises the counters.
            int counter1 = 0;
            int counter2 = 0;

            // Creates writers for the temporary training and validation filelist (overwrite mode).
            StreamWriter sw1 = new(trainingFileTemp, false);
            StreamWriter sw2 = new(validationFile, false);

            // Reads and iterates through every line in the original training filelist.
            string[] lines = File.ReadAllLines(trainingFile);
            foreach (string i in lines)
            {
                string line = i;

                // Gets the name of the WAV.
                string name = line[line.IndexOf("0x")..line.IndexOf("|")];

                // If the file still exists, write it to the temporary training filelist, otherwise write to the validation filelist.
                if (File.Exists($"{speakerFolder}\\{name}"))
                {
                    sw1.WriteLine(line);
                    ++counter1;
                }
                else
                {
                    sw2.WriteLine(line);
                    ++counter2;
                }
            }

            // Closes the writers and outputs statistics.
            sw1.Close();
            sw2.Close();
            Generate_Validation_Label.Text = $"{counter1} files for training. {counter2} files for validation.";

            // Replaces the training filelist.
            File.Delete(trainingFile);
            File.Move(trainingFileTemp, trainingFile);
            File.Delete(trainingFileTemp);
        }
    }
}
