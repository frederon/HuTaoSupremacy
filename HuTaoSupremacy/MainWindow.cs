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
using MaterialSkin;
using MaterialSkin.Controls;

namespace HuTaoSupremacy
{
    public partial class MainWindow : MaterialForm
    {
        private Graph graph;
        private string selectedFilePath;
        private string selectedAlgorithm;

        public MainWindow()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MainWindow_DragEnter);
            this.DragDrop += new DragEventHandler(MainWindow_DragDrop);

            this.graph = null;
            this.selectedAlgorithm = "BFS";
            this.selectedFilePath = "";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.bfsAlgorithm.Checked = this.selectedAlgorithm == "BFS";
            this.dfsAlgorithm.Checked = this.selectedAlgorithm == "DFS";
        }

        void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.selectedFilePath = files.Last();
            labelFilename.Text = this.selectedFilePath.Split('\\').Last();
            generateGraph();
        }

        private void addNodesToDropdown()
        {
            foreach(Node n in this.graph.getNodes())
            {
                dropdownAccount.Items.Add(n.getName());
                dropdownFriends.Items.Add(n.getName());
            }
        }

        private void generateGraph()
        {
            if (this.selectedFilePath == "")
            {
                MessageBox.Show("You need to select a file", "Error");
                return;
            }

            try
            {
                string text = System.IO.File.ReadAllText(@selectedFilePath);
                this.graph = Utilities.StringToGraph(text);

                dropdownAccount.Items.Clear();
                dropdownFriends.Items.Clear();
                addNodesToDropdown();
                dropdownAccount.Enabled = true;
                dropdownFriends.Enabled = true;

                this.graph.displayInfo();

                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = this.graph.generateMSAGL();

                this.panelGraph.Controls.Clear();
                this.panelGraph.SuspendLayout();
                this.panelGraph.Controls.Add(viewer);
                this.panelGraph.ResumeLayout();
            }
            catch (Exception err)
            {
                MessageBox.Show("Wrong format", "Error");
                this.selectedFilePath = "";
                labelFilename.Text = "";
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                this.selectedFilePath = openFileDialog.FileName;
            } else
            {
                this.selectedFilePath = "";
            }
            labelFilename.Text = openFileDialog.FileName.Split('\\').Last();
            generateGraph();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (dropdownAccount.Text == "" || dropdownFriends.Text == "")
            {
                MessageBox.Show("You need to select account and explore friends field", "Error");
                return;
            }
            if (!this.graph.hasNode(dropdownAccount.Text) || !this.graph.hasNode(dropdownFriends.Text))
            {
                MessageBox.Show("Account or explore friends field is not valid", "Error");
                return;
            }
            
            Dictionary<string, List<string>> recommendation = null;
            Dictionary<string, List<string>> explore = null;

            if (this.selectedAlgorithm == "BFS")
            {
                recommendation = Utilities.recommendationBFS(
                    this.graph, 
                    this.graph.getNode(dropdownAccount.Text)
                );
                explore = Utilities.exploreBFS(
                    this.graph, 
                    this.graph.getNode(dropdownAccount.Text), 
                    this.graph.getNode(dropdownFriends.Text)
                );
            } else if (this.selectedAlgorithm == "DFS")
            {
                recommendation = Utilities.recommendationDFS(
                    this.graph,
                    this.graph.getNode(dropdownAccount.Text)
                );
                explore = Utilities.exploreDFS(
                    this.graph,
                    this.graph.getNode(dropdownAccount.Text),
                    this.graph.getNode(dropdownFriends.Text)
                );
            } else
            {
                MessageBox.Show("Please select an algorithm", "Error");
                return;
            }

            List<Node> explorePath = new List<Node>();
            Node node;
            foreach(string path in explore[dropdownFriends.Text])
            {
                node = this.graph.getNode(path);
                explorePath.Add(node);
            }
            node = this.graph.getNode(dropdownFriends.Text);
            explorePath.Add(node);

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = this.graph.generateMSAGL(explorePath);

            this.panelGraph.Controls.Clear();
            this.panelGraph.SuspendLayout();
            this.panelGraph.Controls.Add(viewer);
            this.panelGraph.ResumeLayout();

            tbDebug.Text = Utilities.formatResult(
                dropdownAccount.Text,
                dropdownFriends.Text,
                recommendation,
                explore
            );
        }

        private void bfsAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            if (bfsAlgorithm.Checked)
            {
                this.selectedAlgorithm = "BFS";
            } else
            {
                this.selectedAlgorithm = "DFS";
            }
        }

        private void dropdownFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bfsAlgorithm.Checked)
            {
                this.selectedAlgorithm = "BFS";
            }
            else
            {
                this.selectedAlgorithm = "DFS";
            }
        }
    }
}
