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
      model = new HandModel(this);
      view = new HandView(this, isNpc);
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
      model.HandOfChoice = buttonText;
    }
  }
}
