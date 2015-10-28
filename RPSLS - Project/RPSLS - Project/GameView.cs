using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS___Project
{
    public partial class GameView : Form
    {
        private GameController controller;
        public GameView(GameController c)
        {
            InitializeComponent();
      
            controller = c;
        }

    private void GameView_Load(object sender, EventArgs e)
    {
      RPSLSView rpslsView = controller.GetRPSLSView();
      //ScoreBoardView scoreboardView = controller.GetScoreboardView();
      rpslsView.Width = 1000;
      rpslsView.Height = 1000;
      Controls.Add(rpslsView);
    }
  }
}
