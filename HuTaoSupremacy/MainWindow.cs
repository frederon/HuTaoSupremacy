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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                this.hasSelectedFile = true;
            } else
            {
                this.hasSelectedFile = false;
            }
            labelFilename.Text = openFileDialog.FileName;
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

            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            var a = graph.AddEdge("A", "B");
            a.Attr.ArrowheadAtTarget = ArrowStyle.None;
            a.Attr.ArrowheadAtSource = ArrowStyle.None;
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            this.panelGraph.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            //viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Controls.Add(viewer);
            this.panelGraph.ResumeLayout();
        }
    }
}
