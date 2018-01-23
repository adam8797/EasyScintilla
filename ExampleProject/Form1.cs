using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyScintilla.Stylers;

namespace ExampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            editor.Styler = new BatchStyler();
        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            editor.Styler = new CSharpStyler();
        }

        private void btnCsDark_Click(object sender, EventArgs e)
        {
            editor.Styler = new DarkCSharpStyler();
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            editor.Styler = new HtmlStyler();
        }

        private void btnPowerShell_Click(object sender, EventArgs e)
        {
            editor.Styler = new PowerShellStyler();
        }

        private void btnPython_Click(object sender, EventArgs e)
        {
            editor.Styler = new PythonStyler();
        }

        private void btnRuby_Click(object sender, EventArgs e)
        {
            editor.Styler = new RubyStyler();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            editor.Styler = new SqlStyler();
        }

        private void btnTpt_Click(object sender, EventArgs e)
        {
            editor.Styler = new TptStyler();
        }
    }
}