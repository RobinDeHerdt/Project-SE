using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS___Project
{

  public class ScoreBoardController
  {
        private GameController container;

        private ScoreBoardView view;
        private ScoreBoardModel model;

        public ScoreBoardController( GameController controller)
        {
            container = controller;
        }

        public ScoreBoardView GetView()
        {
            return view;
        }
        public void updateView()
        {
            view.updateView();
        }
  }
}
