using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public interface IView
    {
        void Show();
        void Close();
        event EventHandler ContinueClick;
    }

    public partial class MainView : Form, IView
    {
        public MainView()
        {
            InitializeComponent();
            btnContinue.Click += BtnContinue_Click;
        }

        public void BtnContinue_Click(object sender, EventArgs e)
        {
            ContinueClick?.Invoke(this, EventArgs.Empty);
        }
    
        public event EventHandler ContinueClick;

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
