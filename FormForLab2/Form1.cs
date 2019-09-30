using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LabWork;
namespace FormForLab2
{
    public partial class Form1 : Form
    {
        static string format;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(chBCsv.Enabled)
            {
                chBDoc.Enabled = false;
                chBXls.Enabled = false;
                format = ".csv";
            }
           else if(chBDoc.Enabled)
            {
                chBCsv.Enabled = false;
                chBXls.Enabled = false;
                format = ".doc";
            }
           else if(chBXls.Enabled)
            {
                chBDoc.Enabled = false;
                chBCsv.Enabled = false;
                format = ".xls";
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            label1.Text="Ви вибрали файл "+  dialog.FileName.Split('\\').Last();
            
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {               
                Main.TryParseFile(dialog.FileName,textBox1.Text,textBox2.Text,textBox3.Text,format);                
            }
            else
            {

            }
            MessageBox.Show(Main.complete, "Результат", MessageBoxButtons.OKCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            this.BackgroundImage = Image.FromFile(open.FileName);
        }

        
    }
}
