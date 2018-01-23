namespace ExampleProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnBatch = new System.Windows.Forms.Button();
			this.btnCs = new System.Windows.Forms.Button();
			this.btnHtml = new System.Windows.Forms.Button();
			this.btnPowerShell = new System.Windows.Forms.Button();
			this.btnPython = new System.Windows.Forms.Button();
			this.btnRuby = new System.Windows.Forms.Button();
			this.btnSql = new System.Windows.Forms.Button();
			this.btnTpt = new System.Windows.Forms.Button();
			this.btnCsDark = new System.Windows.Forms.Button();
			this.editor = new EasyScintilla.SimpleEditor();
			this.SuspendLayout();
			// 
			// btnBatch
			// 
			this.btnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBatch.Location = new System.Drawing.Point(16, 764);
			this.btnBatch.Margin = new System.Windows.Forms.Padding(4);
			this.btnBatch.Name = "btnBatch";
			this.btnBatch.Size = new System.Drawing.Size(100, 28);
			this.btnBatch.TabIndex = 1;
			this.btnBatch.Text = "Batch";
			this.btnBatch.UseVisualStyleBackColor = true;
			this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
			// 
			// btnCs
			// 
			this.btnCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCs.Location = new System.Drawing.Point(124, 764);
			this.btnCs.Margin = new System.Windows.Forms.Padding(4);
			this.btnCs.Name = "btnCs";
			this.btnCs.Size = new System.Drawing.Size(100, 28);
			this.btnCs.TabIndex = 2;
			this.btnCs.Text = "C#";
			this.btnCs.UseVisualStyleBackColor = true;
			this.btnCs.Click += new System.EventHandler(this.btnCs_Click);
			// 
			// btnHtml
			// 
			this.btnHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHtml.Location = new System.Drawing.Point(340, 764);
			this.btnHtml.Margin = new System.Windows.Forms.Padding(4);
			this.btnHtml.Name = "btnHtml";
			this.btnHtml.Size = new System.Drawing.Size(100, 28);
			this.btnHtml.TabIndex = 3;
			this.btnHtml.Text = "HTML";
			this.btnHtml.UseVisualStyleBackColor = true;
			this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
			// 
			// btnPowerShell
			// 
			this.btnPowerShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPowerShell.Location = new System.Drawing.Point(448, 764);
			this.btnPowerShell.Margin = new System.Windows.Forms.Padding(4);
			this.btnPowerShell.Name = "btnPowerShell";
			this.btnPowerShell.Size = new System.Drawing.Size(100, 28);
			this.btnPowerShell.TabIndex = 4;
			this.btnPowerShell.Text = "PowerShell";
			this.btnPowerShell.UseVisualStyleBackColor = true;
			this.btnPowerShell.Click += new System.EventHandler(this.btnPowerShell_Click);
			// 
			// btnPython
			// 
			this.btnPython.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPython.Location = new System.Drawing.Point(556, 764);
			this.btnPython.Margin = new System.Windows.Forms.Padding(4);
			this.btnPython.Name = "btnPython";
			this.btnPython.Size = new System.Drawing.Size(100, 28);
			this.btnPython.TabIndex = 5;
			this.btnPython.Text = "Python";
			this.btnPython.UseVisualStyleBackColor = true;
			this.btnPython.Click += new System.EventHandler(this.btnPython_Click);
			// 
			// btnRuby
			// 
			this.btnRuby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRuby.Location = new System.Drawing.Point(664, 764);
			this.btnRuby.Margin = new System.Windows.Forms.Padding(4);
			this.btnRuby.Name = "btnRuby";
			this.btnRuby.Size = new System.Drawing.Size(100, 28);
			this.btnRuby.TabIndex = 6;
			this.btnRuby.Text = "Ruby";
			this.btnRuby.UseVisualStyleBackColor = true;
			this.btnRuby.Click += new System.EventHandler(this.btnRuby_Click);
			// 
			// btnSql
			// 
			this.btnSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSql.Location = new System.Drawing.Point(772, 764);
			this.btnSql.Margin = new System.Windows.Forms.Padding(4);
			this.btnSql.Name = "btnSql";
			this.btnSql.Size = new System.Drawing.Size(100, 28);
			this.btnSql.TabIndex = 7;
			this.btnSql.Text = "SQL";
			this.btnSql.UseVisualStyleBackColor = true;
			this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
			// 
			// btnTpt
			// 
			this.btnTpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTpt.Location = new System.Drawing.Point(880, 764);
			this.btnTpt.Margin = new System.Windows.Forms.Padding(4);
			this.btnTpt.Name = "btnTpt";
			this.btnTpt.Size = new System.Drawing.Size(100, 28);
			this.btnTpt.TabIndex = 8;
			this.btnTpt.Text = "TPT";
			this.btnTpt.UseVisualStyleBackColor = true;
			this.btnTpt.Click += new System.EventHandler(this.btnTpt_Click);
			// 
			// btnCsDark
			// 
			this.btnCsDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCsDark.Location = new System.Drawing.Point(232, 764);
			this.btnCsDark.Margin = new System.Windows.Forms.Padding(4);
			this.btnCsDark.Name = "btnCsDark";
			this.btnCsDark.Size = new System.Drawing.Size(100, 28);
			this.btnCsDark.TabIndex = 2;
			this.btnCsDark.Text = "Dark C#";
			this.btnCsDark.UseVisualStyleBackColor = true;
			this.btnCsDark.Click += new System.EventHandler(this.btnCsDark_Click);
			// 
			// editor
			// 
			this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editor.IndentationGuides = ScintillaNET.IndentView.LookBoth;
			this.editor.Location = new System.Drawing.Point(16, 15);
			this.editor.Margin = new System.Windows.Forms.Padding(4);
			this.editor.Name = "editor";
			this.editor.Size = new System.Drawing.Size(1138, 741);
			this.editor.Styler = null;
			this.editor.TabIndex = 0;
			this.editor.Text = resources.GetString("editor.Text");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 807);
			this.Controls.Add(this.btnTpt);
			this.Controls.Add(this.btnSql);
			this.Controls.Add(this.btnRuby);
			this.Controls.Add(this.btnPython);
			this.Controls.Add(this.btnPowerShell);
			this.Controls.Add(this.btnHtml);
			this.Controls.Add(this.btnCsDark);
			this.Controls.Add(this.btnCs);
			this.Controls.Add(this.btnBatch);
			this.Controls.Add(this.editor);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "EasyScintilla Test App";
			this.ResumeLayout(false);

        }

        #endregion

        private EasyScintilla.SimpleEditor editor;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Button btnCs;
        private System.Windows.Forms.Button btnHtml;
        private System.Windows.Forms.Button btnPowerShell;
        private System.Windows.Forms.Button btnPython;
        private System.Windows.Forms.Button btnRuby;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnTpt;
		private System.Windows.Forms.Button btnCsDark;
	}
}

