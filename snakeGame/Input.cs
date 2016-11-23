using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace snakeGame
{
    class Input
    {

         private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private static Hashtable keys = new Hashtable();

        public static void ChangeState(Keys key, bool stste)
            {
                keys[key] = state;
             }

        public static bool Pressed(Keys key)
            {
                if (keys[key] == null)
                    return false;
                 return (bool) keys[key];
            }

        private void Update(object sender, EventArgs e)
        {
            if (Input.Pressed(Keys.Right))
                square_x += 4;
            if (Input.Pressed(Keys.Left))
                square_x -= 4;
            if (Input.Pressed(Keys.Up))
                square_y -= 4;
            if (Input.Pressed(Keys.Down))
                square_y += 4;
            pbCanvas.Invalidate();
        }

   

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            canvas.FillRectangle(Brushes.Red, new Rectangle(square_x, square_y, 16, 16));
        }

        



    }
}
