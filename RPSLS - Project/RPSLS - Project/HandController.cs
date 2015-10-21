using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class HandController
  {
    private HandModel model;
    private HandView view;

    public HandController(bool isNpc)
    {
      model = new HandModel();
      view = new HandView(this);
      model.IsNpc = isNpc;
    }

    public HandView getView()
    {
      return view;
    }

    public void NpcChoice()
    {
      model.ChooseRandom();
    }

    public void PlayerChoice(string buttonText)
    {
      switch (buttonText)
      {
        case "Rock":
          break;
        case "Scissors":
          break;
        case "Paper":
          break;
        case "Lizard":
          break;
        case "Spock":
          break;
        default:
          break;
      }
    }
  }
}
