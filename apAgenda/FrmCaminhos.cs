using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apMarsRoads
{
  public partial class FrmCaminhos : Form
  {
    public FrmCaminhos()
    {
      InitializeComponent();
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            int indice = 0;
            Caminhos.ImageList = imlBotoes;
            foreach (ToolStripItem item in Caminhos.Items)
                if (item is ToolStripButton)
                    (item as ToolStripButton).ImageIndex = indice++;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
