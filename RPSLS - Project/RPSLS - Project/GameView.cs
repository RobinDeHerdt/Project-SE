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
      ScoreBoardView scoreboardView = controller.GetScoreboardView();
      scoreboardView.Width = 100;
      scoreboardView.Height = 100;
      scoreboardView.Location = new Point(0, 200);
      this.Width = rpslsView.Width;
      this.Height = 400;

      // Debugging
      Console.WriteLine("Form Height = RPSLS Height + Scoreboard Height");
      Console.WriteLine("Form Height = " + rpslsView.Height + " + " + scoreboardView.Height);
      Console.WriteLine("RPSLS Location: " + rpslsView.Location);
      Console.WriteLine("RPSLS Height: " + rpslsView.Height);
      Console.WriteLine("Scoreboard Location: " + scoreboardView.Location);
      Console.WriteLine("Scoreboard Height: " + scoreboardView.Height);
      Controls.Add(rpslsView);
      Controls.Add(scoreboardView);
    }
  }
}
