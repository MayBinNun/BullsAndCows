using System;
using System.Windows.Forms;

namespace UI
{

    // $G$ CSS-016 (-3) Bad class name - The name of classes derived from Form should start with Form.
    public partial class LogInFormD : Form
    {
        // $G$ CSS-002 (-5) Bad member variable name (should be m_CamelCased)
        int m_clickCounter = 4;

        public LogInFormD()
        {
            InitializeComponent();
            this.buttonChances.Click += new EventHandler(ButtonChances_Click);
            this.buttonStart.Click += new EventHandler(ButtonStart_Click);
        }

        public int GetNumOfGuesses
        {
            get { return m_clickCounter; }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void ButtonChances_Click(object sender, EventArgs e)
        {

            m_clickCounter++;

            if (m_clickCounter > 10)
            {
                m_clickCounter = 4;
            }

            if (buttonChances != null)
            {
                this.buttonChances.Text = "Number of chances : " + m_clickCounter.ToString();
            }
            
        }
    }
}
