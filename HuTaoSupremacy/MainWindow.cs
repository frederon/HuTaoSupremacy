using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuTaoSupremacy
{
    public partial class MainWindow : Form
    {
        private Graph graph;
        private bool hasSelectedFile;
        public MainWindow()
        {
            InitializeComponent();
            this.graph = null;
            this.hasSelectedFile = false;
        }

        private void addNodesToDropdown()
        {
            foreach(Node n in this.graph.getNodes())
            {
                dropdownAccount.Items.Add(n.getName());
                dropdownFriends.Items.Add(n.getName());
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                this.hasSelectedFile = true;
            } else
            {
                this.hasSelectedFile = false;
            }
            labelFilename.Text = openFileDialog.FileName.Split('\\').Last();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!this.hasSelectedFile)
            {
                MessageBox.Show("You need to select a file", "Error");
                return;
            }

            string text = System.IO.File.ReadAllText(@openFileDialog.FileName);
            tbDebug.Text = text;
            this.graph = Utilities.StringToGraph(text);

            dropdownAccount.Items.Clear();
            dropdownFriends.Items.Clear();
            addNodesToDropdown();
            dropdownAccount.Enabled = true;
            dropdownFriends.Enabled = true;

            this.graph.displayInfo();

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = this.graph.generateMSAGL();

            this.panelGraph.SuspendLayout();
            this.panelGraph.Controls.Add(viewer);
            this.panelGraph.ResumeLayout();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Utilities.recommendationBFS(this.graph, this.graph.getNode(dropdownAccount.Text));
        }
    }
}
