using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  class RPSLSController
  {
    private HandController[] playerArray;
    private HandController player, npc;
    private RPSLSModel model;
    private RPSLSView view;

    public RPSLSController()
    {
      int playerCount = 0;
      player = new HandController(false);
      playerArray[playerCount] = player;
      playerCount++;

      npc = new HandController(true);
      playerArray[playerCount] = npc;
      playerCount++;

      model = new RPSLSModel(playerCount);
      view = new RPSLSView();
    }

    private void StartGame()
    {
      playerArray[model.PlayerTurn].
    }
  }
}
