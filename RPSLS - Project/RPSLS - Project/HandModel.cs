using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{
  public class HandModel
  {
    private static Random randomNumber;
    private int numberOfChoice;
    private bool isNpc;

    public int NumberOfChoice
    {
      get
      {
        return numberOfChoice;
      }
      set
      {
        numberOfChoice = value;
      }
    }

    public bool IsNpc
    {
      get
      {
        return isNpc;
      }
      set
      {
        isNpc = value;
      }
    }

    public HandModel()
    {
      randomNumber = new Random();
    }

    public void ChooseRandom()
    {
      numberOfChoice = randomNumber.Next(1,6);
    }
  }
}
