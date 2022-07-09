namespace Game._002
{
    public partial class FormStart : Form
    {
        int validate = 0;
        
        public FormStart()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                this.Visible = false;
                FormMain frmain = new FormMain();
                frmain.Show();
            }
            else
            {
                lblErrorValidate.Text = "Îøèáêà Âàëèäàöèè! Çàïîëíèòå ïîëÿ!";
                Task.Run(() => MarkInalid());
            }
        }
        bool ValidateData()
        {
            validate = 0;
            foreach (Control p in this.Controls)
            {
                if (p.Name.StartsWith("panel"))
                {
                    TextBox t = (TextBox)p.Controls[0];
                    if (t.Text.Length == 0)
                    {
                        t.PlaceholderText = "ÇÀÏÎËÍÈÒÅ ÝÒÎ ÏÎËÅ!";
                        validate++;
                    }
                }
            }
            return validate == 0;
        }

        void MarkInalid()
        {
            while(validate > 0)
            {
                Invoke(new Action(() => DoMark()));

                Thread.Sleep(500);
            }
        }
        void DoMark() 
        {
            foreach (Control p in this.Controls)
            {
                if (p.Name.StartsWith("panel"))
                {
                    TextBox t = (TextBox)p.Controls[0];
                    if (t.Text.Length == 0)
                        if (p.BackColor == Color.Transparent)
                            p.BackColor = Color.Red;
                        else
                            p.BackColor = Color.Transparent;
                    else
                        p.BackColor = Color.Transparent;
                }
            }
        }
        private void txtINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !Char.IsDigit(ch) && !Char.IsControl(ch);
        }
    }
   
}