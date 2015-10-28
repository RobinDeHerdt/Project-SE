using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class GameController
  {
    private GameView view;
    private RPSLSController rpsls;
    //private ScoreBoardController scoreboard;

    public GameController()
    {
      view = new GameView(this);
      rpsls = new RPSLSController(this);
      //scoreboard = new ScoreBoardController(this);
    }

    public GameView GetView()
    {
      return view;
    }

    public RPSLSView GetRPSLSView()
    {
      return rpsls.GetView();
    }

    /*public ScoreBoardView GetScoreboardView()
    {
      return scoreboard.GetView();
    }*/
  }
}
