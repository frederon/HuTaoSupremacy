
namespace HuTaoSupremacy
{
    partial class MainWindow
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dropdownAlgorithm = new System.Windows.Forms.ComboBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFilename = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tbDebug = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(307, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(125, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "People You May Know";
            // 
            // dropdownAlgorithm
            // 
            this.dropdownAlgorithm.DisplayMember = "BFS";
            this.dropdownAlgorithm.FormattingEnabled = true;
            this.dropdownAlgorithm.Items.AddRange(new object[] {
            "BFS",
            "DFS"});
            this.dropdownAlgorithm.Location = new System.Drawing.Point(307, 112);
            this.dropdownAlgorithm.Name = "dropdownAlgorithm";
            this.dropdownAlgorithm.Size = new System.Drawing.Size(121, 23);
            this.dropdownAlgorithm.TabIndex = 3;
            this.dropdownAlgorithm.Text = "Select algorithm";
            this.dropdownAlgorithm.ValueMember = "BFS,DFS";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(307, 83);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(388, 87);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(0, 15);
            this.labelFilename.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(307, 142);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(12, 360);
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(100, 96);
            this.tbDebug.TabIndex = 7;
            this.tbDebug.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 632);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.dropdownAlgorithm);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainWindow";
            this.Text = "HuTaoSupremacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox dropdownAlgorithm;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RichTextBox tbDebug;
    }
}

