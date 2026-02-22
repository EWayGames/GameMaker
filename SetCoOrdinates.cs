
namespace DS_Game_Maker
{

    public partial class SetCoOrdinates
    {

        public short X;
        public short Y;

        public SetCoOrdinates()
        {
            InitializeComponent();
        }

        private void DAcceptButton_Click(object sender, EventArgs e)
        {
            X = Convert.ToInt16(XTextBox.Text.ToString());
            Y = Convert.ToInt16(YTextBox.Text.ToString());
            Close();
        }

        private void SetCoOrdinates_Load(object sender, EventArgs e)
        {
            XTextBox.Text = X.ToString();
            YTextBox.Text = Y.ToString();
        }

        private void TextBoxs_TextChanged(object sender, EventArgs e)
        {
            bool Enabled = true;
            if (XTextBox.Text.Length == 0 | YTextBox.Text.Length == 0)
                return;
            byte XCount = 0;
            byte YCount = 0;
            foreach (string X in DSGMlib.Numbers)
                XCount = (byte)(XCount + DSGMlib.HowManyChar(XTextBox.Text, X));
            foreach (string Y in DSGMlib.Numbers)
                YCount = (byte)(YCount + DSGMlib.HowManyChar(YTextBox.Text, Y));
            if (!(XCount == XTextBox.Text.Length))
                Enabled = false;
            if (!(YCount == YTextBox.Text.Length))
                Enabled = false;
            DAcceptButton.Enabled = Enabled;
        }

        private void SetCoOrdinates_Shown(object sender, EventArgs e)
        {
            XTextBox.Focus();
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                DAcceptButton_Click(new object(), new EventArgs());
            }
        }
    }
}