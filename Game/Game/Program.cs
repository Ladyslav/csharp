using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int height = 10;
        int width = 10;
        int distanceBetweenButtons = 35;

        public Form1()
        {
            InitializeComponent();
        }

        private void  Form1_Load(object sender, EventArgs e)
        {
            for (int x = 10; (x-10) < width * distanceBetweenButtons; x+= distanceBetweenButtons)
            {
                for (int y = 10; (y-10) < height * distanceBetweenButtons; y+= distanceBetweenButtons)
                {
                    Button button = new Button();
                    button.Location = new Point(10, 10);
                    button.Size = new Size(30, 30);
                    Controls.Add(button);
                }
            }
       

        }
    }


}


