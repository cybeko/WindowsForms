namespace winform2
{
    public partial class Form1 : Form
    {
        private Label label;

        public Form1()
        {
            InitializeComponent();

            label = new Label();
            label.Text = "Label";
            label.Location = new Point(10, 10);
            label.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BorderStyle = BorderStyle.FixedSingle;

            label.MouseClick += ShowSizeOnClick;
            this.MouseClick += ShowSizeOnClick;

            this.MouseMove += Form1_MouseMove;
            label.MouseMove += Label_MouseMove;

            this.Controls.Add(label);
        }

        private void ShowSizeOnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                this.Text = $"[Width: {width}, Height: {height}]";
            }

            if (e.Button == MouseButtons.Right && sender is Label label)
            {
                if (IsClickOnBorder(label, e.Location))
                {
                    MessageBox.Show("Clicked on the border of the label");
                }
                else
                {
                    MessageBox.Show("Clicked inside the label");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Clicked outside the label");
            }
        }
        private bool IsClickOnBorder(Label label, Point clickLocation)
        {
            int borderPx = 1;
            Rectangle rect = label.ClientRectangle;
            rect.Inflate(-borderPx, -borderPx);
            return !rect.Contains(clickLocation);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ClientRectangle.Contains(e.Location))
            {
                this.Text = $"X:{e.X}, Y:{e.Y}";
            }
        }
        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Point labelLocationInForm = this.PointToClient(label.Parent.PointToScreen(label.Location));

            int formX = e.X + labelLocationInForm.X;
            int formY = e.Y + labelLocationInForm.Y;

            this.Text = $"X:{formX}, Y:{formY}";
        }
    }
}
