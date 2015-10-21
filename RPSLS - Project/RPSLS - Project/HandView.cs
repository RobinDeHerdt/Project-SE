using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS___Project
{
  public partial class HandView : UserControl
  {
    private HandController controller;

    public HandView(HandController c)
    {
      InitializeComponent();

      controller = c;
    }

    private void btnRock_Click(object sender, EventArgs e)
    {
      controller.PlayerChoice(this.btnRock.Text);
      this.lblNaam.Text = btnRock.Text;
    }

    private void btnPaper_Click(object sender, EventArgs e)
    {
      controller.PlayerChoice(this.btnPaper.Text);
      this.lblNaam.Text = btnPaper.Text;
    }

    private void btnScissors_Click(object sender, EventArgs e)
    {
      controller.PlayerChoice(this.btnScissors.Text);
    }

    private void btnLizard_Click(object sender, EventArgs e)
    {
      controller.PlayerChoice(this.btnLizard.Text);
    }

    private void btnSpock_Click(object sender, EventArgs e)
    {
      controller.PlayerChoice(this.btnSpock.Text);
    }
  }
}
