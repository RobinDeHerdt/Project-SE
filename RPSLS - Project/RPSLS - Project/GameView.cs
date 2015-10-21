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
        private HandController controller;
        public GameView()
        {
            InitializeComponent();
      
            controller = new HandController(false);
            
        }

    private void GameView_Load(object sender, EventArgs e)
    {
      HandView hView = controller.getView();
      Controls.Add(hView);
    }
  }
}
