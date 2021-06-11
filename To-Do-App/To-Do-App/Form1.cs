using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_App
{
    public partial class ToDoApp : Form
    {
        
        public ToDoApp()
        {
            InitializeComponent();
            this.Text = "ToDo App";
        }

        private void ToDoApp_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Works as an Add button for new todos
        private void button1_Click(object sender, EventArgs e)
        {
            chklstTodos.Items.Add(txtAdd.Text);
            txtAdd.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chklstTodos.Items.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            chklstTodos.ClearSelected();
        }
    }
}
