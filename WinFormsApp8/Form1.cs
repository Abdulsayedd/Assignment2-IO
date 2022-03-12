namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string x, textfile;
        string[] lines;
        FileStream fs;
        StreamReader sr;
        private bool existt(string m)
        {
            if(File.Exists(m))
            {
                return true;
            }
            else
                return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lowerthan5(int x)
        {
            if(x<=5)
            {
                for(int i = 0; i < x; i++)
                {
                    f5ltxt.Text += lines[i]+"\n";
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    f5ltxt.Text += lines[i] + "\n";
                }
            }
        }
        private void llowerthan5(int x)
        {
            if (x <= 5)
            {
                for (int i = 0; i < x; i++)
                {
                    l5ltxt.Text += lines[i] + "\n";
                }
            }
            else
            {
                for (int i = x-5; i < x; i++)
                {
                   l5ltxt.Text += lines[i] + "\n";
                }
            }
        }
        private void f5lbtn_Click(object sender, EventArgs e)
        {
            if(existt(x))
            {
                fs = new FileStream(x, FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(fs);
                textfile = sr.ReadToEnd();
                lines = textfile.Split('\n');
                lowerthan5(lines.Length);
            }
            else
            {
                MessageBox.Show("No Path - File Not Found!");
            }
            fs.Close();
            sr.Close();
        }

        private void l5lbtn_Click(object sender, EventArgs e)
        {
            if (existt(x))
            {
                fs= new FileStream(x, FileMode.Open, FileAccess.ReadWrite);
                sr= new StreamReader(fs);
                textfile = sr.ReadToEnd();
                lines = textfile.Split('\n');
                llowerthan5(lines.Length);
            }
            else
            {
                MessageBox.Show("No Path - File Not Found!");
            }
            fs.Close();
            sr.Close();
        }

        private void setpath_Click(object sender, EventArgs e)
        {
            x = pathtxtbx.Text;
        }
    }
}