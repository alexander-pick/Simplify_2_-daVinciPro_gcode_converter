/* 
The MIT License (MIT)
Copyright (c) 2016 Alexander Pick

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace DaVinciConvert
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                headerBox.Text = File.ReadAllText(@".\template.txt");
            }
            catch (IOException)
            {
                MessageBox.Show(@"Error opening header.txt");
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();

            fd.InitialDirectory = @".\";
            fd.Filter = @"gCode (.gcode)|*.gcode";

            DialogResult fdRes = fd.ShowDialog();

            if (fdRes == DialogResult.OK)
            {
                string fdFilename = fd.FileName;

                logBox.AppendText("Opening " + fdFilename + Environment.NewLine);

                try
                {
                    // processing file

                    string gCodeFileContent = File.ReadAllText(fdFilename);

                    // strip simplify3d made Header away
                    string[] gCodeFileSections = gCodeFileContent.Split(new[] { @"G28 ; home all axes" }, StringSplitOptions.None);

                    gCodeFileContent = gCodeFileSections[2];

                    // strip simplify3d made Footer away
                    gCodeFileSections = gCodeFileContent.Split(new[] {@"; layer end"}, StringSplitOptions.None);

                    string outputFileName = Path.GetFileNameWithoutExtension(fdFilename) + @"_converted.gcode";

                    string outputFile = Path.GetDirectoryName(fdFilename) + "\\" + outputFileName;

                    logBox.AppendText("Saving File to " + outputFile + Environment.NewLine);

                    string fileContent = headerBox.Text;

                    //replace placeholder with real vars

                    fileContent = fileContent.Replace("###CODE###", gCodeFileSections[0]);

                    fileContent = fileContent.Replace("###FILENAME###", outputFileName);

                    fileContent = fileContent.Replace("###TEMP###", extTempBox.Text);

                    fileContent = fileContent.Replace("###STARTTEMP###", startTempBox.Text);

                    fileContent = fileContent.Replace("###BEDTEMP###", bedTempBox.Text);

                    File.WriteAllText(outputFile, fileContent);

                    logBox.AppendText("Done." + Environment.NewLine);
                }
                catch (IOException)
                {
                    MessageBox.Show(@"Error opening gcode File");
                }
            }
        }

    }
}