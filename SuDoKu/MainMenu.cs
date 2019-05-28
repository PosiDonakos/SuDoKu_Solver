using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDoKu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnEz_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Game Game = new Game();
            Game.Show( this );
            GameConfig.NewGame(1);
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Game Game = new Game();
            Game.Show( this );
            GameConfig.NewGame(2);
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Game Game = new Game();
            Game.Show( this );
            GameConfig.NewGame(3);
        }
    }
}
