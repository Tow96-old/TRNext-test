using System;
using System.Windows.Forms;
using TRNext.Classes;

namespace TRNext
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Properties
        private Manager manager;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            manager = new Manager("pepe", 45, 222);
            MessageBox.Show(manager.Clothing.Buttons.ToString());
        }
    }
}
