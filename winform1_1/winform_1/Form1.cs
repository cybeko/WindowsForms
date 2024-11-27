namespace winform_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResume()
        {
            string[] resume = {
                "Hi, I’m John Doe, a software developer with 6 years of experience building scalable, efficient applications.",
                "I thrive on solving problems and collaborating with teams to create impactful software.",
                "Always eager to learn, I stay current with the latest technologies."
            };

            int totalChars = 0;
            foreach (string sentence in resume)
            {
                totalChars += sentence.Length;
            }

            int avgChars = totalChars / resume.Length;

            for (int i = 0; i < resume.Length; i++)
            {
                if (i == resume.Length - 1)
                {
                    MessageBox.Show(resume[i], $"Average characters count: {avgChars}");
                }
                else
                {
                    MessageBox.Show(resume[i], "Resume");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResume();
        }
    }
}
