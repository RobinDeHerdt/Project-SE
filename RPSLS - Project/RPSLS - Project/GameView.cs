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
        //private HandController controller, npc;
        public GameView()
        {
            InitializeComponent();
      
            //controller = new HandController(false);
            //npc = new HandController(true);
        }

    private void GameView_Load(object sender, EventArgs e)
    {
      //HandView hView = controller.getView();
      //HandView npcView = npc.getView();

      //npcView.Location = new Point(npcView.Width, 0);

      //Controls.Add(hView);
      //Controls.Add(npcView);
    }
  }
}
