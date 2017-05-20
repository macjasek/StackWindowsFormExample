using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStackExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PushVisibility(true);
        }

        private void PushVisibility(bool vis)
        {
            btnPushOK.Visible = vis;
            labelPush.Visible = vis;
            pushValue.Visible = vis;
        }

        private void btnPushOK_Click(object sender, EventArgs e)
        {
            if (pushValue.Text != "")
            {
                MyStack._myStack.Push(pushValue.Text);
                pushValue.Text = "";
            }
            else
            {
                MessageBox.Show("Błąd. Nie wpisano żadnej wartości!");
            }
            PushVisibility(false);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (MyStack._myStack.Count > 0)
            {
                var stackElement = MyStack._myStack.Pop();
                MessageBox.Show($"Usunięto ze stosu element {stackElement}");
            }
            else
            {
                MessageBox.Show("Błąd. Stos pusty nie można usunąć elementu");
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (MyStack._myStack.Count > 0)
            {
                MessageBox.Show($"Element na górze stosu: {MyStack._myStack.Peek()}");
            }
            else
            {
                MessageBox.Show("Stos pusty.");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            var stackList = string.Join("\n", MyStack._myStack);
            MessageBox.Show(stackList, "Lista elementów na stosie");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
