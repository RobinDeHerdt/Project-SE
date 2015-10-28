using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class RPSLSController
  {
    private HandController[] playerArray;
    private HandController player, npc;
    private RPSLSModel model;
    private RPSLSView view;
    private GameController gameController;

    public RPSLSController(GameController c)
    {
      int playerCount = 0;
      playerArray = new HandController[2];
      player = new HandController(false, this);
      playerArray[playerCount] = player;
      playerCount++;

      npc = new HandController(true, this);
      playerArray[playerCount] = npc;
      playerCount++;

      model = new RPSLSModel(playerCount);
      view = new RPSLSView(this);

      gameController = c;
    }

    public RPSLSView GetView()
    {
      return view;
    }

    public List<HandView> GetViewHands()
    {
      List<HandView> viewOfHands = new List<HandView>();
      foreach (HandController hand in playerArray)
      {
        HandView handView = hand.getView();
        viewOfHands.Add(handView);
      }
      return viewOfHands;
    }

    private void StartTurn()
    {
      playerArray[model.PlayerTurn].ChooseHand();
    }

    public void NextTurn()
    {
      if (model.PlayerTurn == playerArray.Length - 1)
      {
        CalculateWinner();
        model.PlayerTurn = 0;
      }
      model.PlayerTurn++;
      StartTurn();
    }

    private void CalculateWinner()
    {
      string[] handsOfChoice = new string[playerArray.Length];
      int[] tempPoints = new int[playerArray.Length];
      for (int i = 0; i < playerArray.Length; i++)      //  Get all handsOfChoice
      {
        handsOfChoice[i] = playerArray[i].GetHand();
      }

      for (int i = 0; i < handsOfChoice.Length; i++)    //  Vergelijkt alle handsOfChoice met de rest
      {
        for (int j = i + 1; j < handsOfChoice.Length; j++)
        {
          tempPoints[i] += CalculateHands(handsOfChoice[i], handsOfChoice[j]);
        }
      }

      int winningPlayerNumber = 0;
      for (int i = 1; i <= tempPoints.Length; i++)   // i = 1 omdat Draw = 0
      {
        int highestPoints = 0;

        if (tempPoints[i] > highestPoints)
        {
          highestPoints = tempPoints[i];
          winningPlayerNumber = i;
        }
      }
    }

    private int CalculateHands(string s, string t)
    {
      switch (s)
      {
        case "Rock":
          {
            if (t == "Rock" || t == "Paper" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Scissors" || t == "Lizard")
            {
              return 1;
            }
            return 0;
          }
        case "Paper":
          {
            if (t == "Lizard" || t == "Paper" || t == "Scissors")
            {
              return 0;
            }
            else if (t == "Rock" || t == "Spock")
            {
              return 1;
            }
            return 0;
          }
        case "Scissors":
          {
            if (t == "Rock" || t == "Scissors" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Paper" || t == "Lizard")
            {
              return 1;
            }
            return 0;
          }
        case "Lizard":
          {
            if (t == "Rock" || t == "Scissors" || t == "Lizard")
            {
              return 0;
            }
            else if (t == "Spock" || t == "Paper")
            {
              return 1;
            }
            return 0;
          }
        case "Spock":
          {
            if (t == "Lizard" || t == "Paper" || t == "Spock")
            {
              return 0;
            }
            else if (t == "Scissors" || t == "Rock")
            {
              return 1;
            }
            return 0;
          }
        default: return 0;
      }
    }
  }
}
