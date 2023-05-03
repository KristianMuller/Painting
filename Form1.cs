using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace Painting
{
    public partial class Form1 : Form
    {
        public Color defaultColor = Color.LightGray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gap = 5;
            int buttonSize = 20;
            int x = gap;
            int y = gap;

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.LightGray;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point(x, y);
                    button.Click += new EventHandler(button_Click);
                    Controls.Add(button);

                    x += buttonSize + gap;
                }
                x = gap;
                y += buttonSize + gap;
            }

            btnRed.BackColor = Color.Red;
            btnGreen.BackColor = Color.Green;
            btnBlue.BackColor = Color.Blue;
            btnBlack.BackColor = Color.Black;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            defaultColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            defaultColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            defaultColor = Color.Blue;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            defaultColor = Color.Black;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.BackColor = defaultColor;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                    control.BackColor = defaultColor;
            }
        }
    }
}
