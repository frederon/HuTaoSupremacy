
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
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.buttonBrowse = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFilename = new MaterialSkin.Controls.MaterialLabel();
            this.tbDebug = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.dropdownAccount = new MaterialSkin.Controls.MaterialComboBox();
            this.dropdownFriends = new MaterialSkin.Controls.MaterialComboBox();
            this.labelAccount = new MaterialSkin.Controls.MaterialLabel();
            this.labelFriends = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResult = new MaterialSkin.Controls.MaterialButton();
            this.bfsAlgorithm = new MaterialSkin.Controls.MaterialRadioButton();
            this.dfsAlgorithm = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAlgorithm = new MaterialSkin.Controls.MaterialLabel();
            this.labelSelectFile = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(12, 314);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "People You May Know";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowse.Depth = 0;
            this.buttonBrowse.DrawShadows = true;
            this.buttonBrowse.HighEmphasis = true;
            this.buttonBrowse.Icon = null;
            this.buttonBrowse.Location = new System.Drawing.Point(29, 46);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(80, 36);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonBrowse.UseAccentColor = false;
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
            this.labelFilename.Depth = 0;
            this.labelFilename.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilename.Location = new System.Drawing.Point(116, 56);
            this.labelFilename.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(109, 19);
            this.labelFilename.TabIndex = 5;
            this.labelFilename.Text = "No file selected";
            // 
            // tbDebug
            // 
            this.tbDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDebug.Depth = 0;
            this.tbDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbDebug.Hint = "";
            this.tbDebug.Location = new System.Drawing.Point(12, 351);
            this.tbDebug.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.ReadOnly = true;
            this.tbDebug.Size = new System.Drawing.Size(497, 199);
            this.tbDebug.TabIndex = 7;
            this.tbDebug.Text = "";
            // 
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(312, 77);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(376, 247);
            this.panelGraph.TabIndex = 8;
            // 
            // dropdownAccount
            // 
            this.dropdownAccount.AutoResize = false;
            this.dropdownAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dropdownAccount.Depth = 0;
            this.dropdownAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.dropdownAccount.DropDownHeight = 174;
            this.dropdownAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownAccount.DropDownWidth = 121;
            this.dropdownAccount.Enabled = false;
            this.dropdownAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dropdownAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dropdownAccount.FormattingEnabled = true;
            this.dropdownAccount.IntegralHeight = false;
            this.dropdownAccount.ItemHeight = 43;
            this.dropdownAccount.Location = new System.Drawing.Point(546, 374);
            this.dropdownAccount.MaxDropDownItems = 4;
            this.dropdownAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.dropdownAccount.Name = "dropdownAccount";
            this.dropdownAccount.Size = new System.Drawing.Size(121, 49);
            this.dropdownAccount.StartIndex = 0;
            this.dropdownAccount.TabIndex = 9;
            // 
            // dropdownFriends
            // 
            this.dropdownFriends.AutoResize = false;
            this.dropdownFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dropdownFriends.Depth = 0;
            this.dropdownFriends.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.dropdownFriends.DropDownHeight = 174;
            this.dropdownFriends.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownFriends.DropDownWidth = 121;
            this.dropdownFriends.Enabled = false;
            this.dropdownFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dropdownFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dropdownFriends.FormattingEnabled = true;
            this.dropdownFriends.IntegralHeight = false;
            this.dropdownFriends.ItemHeight = 43;
            this.dropdownFriends.Location = new System.Drawing.Point(546, 448);
            this.dropdownFriends.MaxDropDownItems = 4;
            this.dropdownFriends.MouseState = MaterialSkin.MouseState.OUT;
            this.dropdownFriends.Name = "dropdownFriends";
            this.dropdownFriends.Size = new System.Drawing.Size(121, 49);
            this.dropdownFriends.StartIndex = 0;
            this.dropdownFriends.TabIndex = 10;
            this.dropdownFriends.SelectedIndexChanged += new System.EventHandler(this.dropdownFriends_SelectedIndexChanged);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Depth = 0;
            this.labelAccount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAccount.Location = new System.Drawing.Point(546, 352);
            this.labelAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(120, 19);
            this.labelAccount.TabIndex = 11;
            this.labelAccount.Text = "Choose Account:";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Depth = 0;
            this.labelFriends.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFriends.Location = new System.Drawing.Point(546, 426);
            this.labelFriends.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(144, 19);
            this.labelFriends.TabIndex = 12;
            this.labelFriends.Text = "Explore friends with:";
            // 
            // buttonResult
            // 
            this.buttonResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResult.Depth = 0;
            this.buttonResult.DrawShadows = true;
            this.buttonResult.HighEmphasis = true;
            this.buttonResult.Icon = null;
            this.buttonResult.Location = new System.Drawing.Point(546, 504);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(121, 36);
            this.buttonResult.TabIndex = 13;
            this.buttonResult.Text = "Show result";
            this.buttonResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResult.UseAccentColor = false;
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // bfsAlgorithm
            // 
            this.bfsAlgorithm.AutoSize = true;
            this.bfsAlgorithm.Depth = 0;
            this.bfsAlgorithm.Location = new System.Drawing.Point(12, 211);
            this.bfsAlgorithm.Margin = new System.Windows.Forms.Padding(0);
            this.bfsAlgorithm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bfsAlgorithm.MouseState = MaterialSkin.MouseState.HOVER;
            this.bfsAlgorithm.Name = "bfsAlgorithm";
            this.bfsAlgorithm.Ripple = true;
            this.bfsAlgorithm.Size = new System.Drawing.Size(64, 37);
            this.bfsAlgorithm.TabIndex = 14;
            this.bfsAlgorithm.TabStop = true;
            this.bfsAlgorithm.Text = "BFS";
            this.bfsAlgorithm.UseVisualStyleBackColor = true;
            this.bfsAlgorithm.CheckedChanged += new System.EventHandler(this.bfsAlgorithm_CheckedChanged);
            // 
            // dfsAlgorithm
            // 
            this.dfsAlgorithm.AutoSize = true;
            this.dfsAlgorithm.Depth = 0;
            this.dfsAlgorithm.Location = new System.Drawing.Point(107, 211);
            this.dfsAlgorithm.Margin = new System.Windows.Forms.Padding(0);
            this.dfsAlgorithm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dfsAlgorithm.MouseState = MaterialSkin.MouseState.HOVER;
            this.dfsAlgorithm.Name = "dfsAlgorithm";
            this.dfsAlgorithm.Ripple = true;
            this.dfsAlgorithm.Size = new System.Drawing.Size(65, 37);
            this.dfsAlgorithm.TabIndex = 15;
            this.dfsAlgorithm.TabStop = true;
            this.dfsAlgorithm.Text = "DFS";
            this.dfsAlgorithm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSelectFile);
            this.groupBox1.Controls.Add(this.labelFilename);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 107);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Depth = 0;
            this.labelAlgorithm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAlgorithm.Location = new System.Drawing.Point(12, 189);
            this.labelAlgorithm.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(121, 19);
            this.labelAlgorithm.TabIndex = 17;
            this.labelAlgorithm.Text = "Select Algorithm:";
            // 
            // labelSelectFile
            // 
            this.labelSelectFile.AutoSize = true;
            this.labelSelectFile.Location = new System.Drawing.Point(73, 22);
            this.labelSelectFile.Name = "labelSelectFile";
            this.labelSelectFile.Size = new System.Drawing.Size(144, 15);
            this.labelSelectFile.TabIndex = 6;
            this.labelSelectFile.Text = "Select a file or drop it here";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 561);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dfsAlgorithm);
            this.Controls.Add(this.bfsAlgorithm);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.dropdownFriends);
            this.Controls.Add(this.dropdownAccount);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainWindow";
            this.Text = "HuTaoSupremacy";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelGraph;
        private MaterialSkin.Controls.MaterialButton buttonBrowse;
        private MaterialSkin.Controls.MaterialButton buttonResult;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel labelFilename;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbDebug;
        private MaterialSkin.Controls.MaterialComboBox dropdownAccount;
        private MaterialSkin.Controls.MaterialComboBox dropdownFriends;
        private MaterialSkin.Controls.MaterialLabel labelAccount;
        private MaterialSkin.Controls.MaterialLabel labelFriends;
        private MaterialSkin.Controls.MaterialRadioButton bfsAlgorithm;
        private MaterialSkin.Controls.MaterialRadioButton dfsAlgorithm;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel labelAlgorithm;
        private System.Windows.Forms.Label labelSelectFile;
    }
}

