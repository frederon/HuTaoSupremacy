﻿using Microsoft.Msagl.Drawing;
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

            try
            {
                string text = System.IO.File.ReadAllText(@openFileDialog.FileName);
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
                this.hasSelectedFile = false;
                labelFilename.Text = "";
            }

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

            if (dropdownAlgorithm.Text == "BFS")
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
            } else if (dropdownAlgorithm.Text == "DFS")
            {
                recommendation = Utilities.recommendationDFS(
                    this.graph,
                    this.graph.getNode(dropdownAccount.Text)
                );
                MessageBox.Show("Not yet implemented!", "Error");
                return;
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

        public string BFSorDFS()
        {
            return dropdownAlgorithm.Items[dropdownAlgorithm.SelectedIndex].ToString();
        }
    }
}
