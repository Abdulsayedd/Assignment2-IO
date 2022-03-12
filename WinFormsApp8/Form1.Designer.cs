namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathtxtbx = new System.Windows.Forms.TextBox();
            this.pathlbl = new System.Windows.Forms.Label();
            this.f5ltxt = new System.Windows.Forms.RichTextBox();
            this.l5ltxt = new System.Windows.Forms.RichTextBox();
            this.l5lbtn = new System.Windows.Forms.Button();
            this.f5lbtn = new System.Windows.Forms.Button();
            this.setpath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathtxtbx
            // 
            this.pathtxtbx.Location = new System.Drawing.Point(150, 50);
            this.pathtxtbx.Name = "pathtxtbx";
            this.pathtxtbx.Size = new System.Drawing.Size(394, 23);
            this.pathtxtbx.TabIndex = 0;
            // 
            // pathlbl
            // 
            this.pathlbl.AutoSize = true;
            this.pathlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathlbl.Location = new System.Drawing.Point(306, 9);
            this.pathlbl.Name = "pathlbl";
            this.pathlbl.Size = new System.Drawing.Size(75, 37);
            this.pathlbl.TabIndex = 1;
            this.pathlbl.Text = "Path:";
            this.pathlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // f5ltxt
            // 
            this.f5ltxt.Location = new System.Drawing.Point(25, 126);
            this.f5ltxt.Name = "f5ltxt";
            this.f5ltxt.Size = new System.Drawing.Size(261, 252);
            this.f5ltxt.TabIndex = 2;
            this.f5ltxt.Text = "";
            // 
            // l5ltxt
            // 
            this.l5ltxt.Location = new System.Drawing.Point(410, 126);
            this.l5ltxt.Name = "l5ltxt";
            this.l5ltxt.Size = new System.Drawing.Size(261, 252);
            this.l5ltxt.TabIndex = 2;
            this.l5ltxt.Text = "";
            // 
            // l5lbtn
            // 
            this.l5lbtn.Location = new System.Drawing.Point(478, 394);
            this.l5lbtn.Name = "l5lbtn";
            this.l5lbtn.Size = new System.Drawing.Size(137, 66);
            this.l5lbtn.TabIndex = 3;
            this.l5lbtn.Text = "button1";
            this.l5lbtn.UseVisualStyleBackColor = true;
            this.l5lbtn.Click += new System.EventHandler(this.l5lbtn_Click);
            // 
            // f5lbtn
            // 
            this.f5lbtn.Location = new System.Drawing.Point(86, 394);
            this.f5lbtn.Name = "f5lbtn";
            this.f5lbtn.Size = new System.Drawing.Size(137, 66);
            this.f5lbtn.TabIndex = 3;
            this.f5lbtn.Text = "button1";
            this.f5lbtn.UseVisualStyleBackColor = true;
            this.f5lbtn.Click += new System.EventHandler(this.f5lbtn_Click);
            // 
            // setpath
            // 
            this.setpath.Location = new System.Drawing.Point(283, 79);
            this.setpath.Name = "setpath";
            this.setpath.Size = new System.Drawing.Size(121, 33);
            this.setpath.TabIndex = 3;
            this.setpath.Text = "Set Path";
            this.setpath.UseVisualStyleBackColor = true;
            this.setpath.Click += new System.EventHandler(this.setpath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 516);
            this.Controls.Add(this.f5lbtn);
            this.Controls.Add(this.setpath);
            this.Controls.Add(this.l5lbtn);
            this.Controls.Add(this.l5ltxt);
            this.Controls.Add(this.f5ltxt);
            this.Controls.Add(this.pathlbl);
            this.Controls.Add(this.pathtxtbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox pathtxtbx;
        private Label pathlbl;
        private RichTextBox f5ltxt;
        private RichTextBox l5ltxt;
        private Button l5lbtn;
        private Button f5lbtn;
        private Button setpath;
    }
}