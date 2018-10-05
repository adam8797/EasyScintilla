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
            this.editor = new EasyScintilla.SimpleEditor();
            this.stylerPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.editor.Location = new System.Drawing.Point(12, 12);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(854, 603);
            this.editor.Styler = null;
            this.editor.TabIndex = 0;
            // 
            // stylerPicker
            // 
            this.stylerPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stylerPicker.FormattingEnabled = true;
            this.stylerPicker.Location = new System.Drawing.Point(12, 621);
            this.stylerPicker.Name = "stylerPicker";
            this.stylerPicker.Size = new System.Drawing.Size(854, 21);
            this.stylerPicker.TabIndex = 1;
            this.stylerPicker.SelectedIndexChanged += new System.EventHandler(this.stylerPicker_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 656);
            this.Controls.Add(this.stylerPicker);
            this.Controls.Add(this.editor);
            this.Name = "Form1";
            this.Text = "EasyScintilla Test App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EasyScintilla.SimpleEditor editor;
        private System.Windows.Forms.ComboBox stylerPicker;
    }
}

