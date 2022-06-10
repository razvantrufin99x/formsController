namespace formsController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                formsController.Program.forms.Add(new frm());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                formsController.Program.forms[i].Left = i * 10 + 1;
                formsController.Program.forms[i].Top = 200 ;
                formsController.Program.forms[i].Visible = true;
                formsController.Program.forms[i].ws(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int j = 0; j<10; j++)
            {
                for (int i = 0; i < 10; i++)
                {

                    formsController.Program.forms[i].ws(j.ToString());
                    formsController.Program.forms[i].Refresh();
                }
                    Thread.Sleep(1000);
            }
        }
    }
}