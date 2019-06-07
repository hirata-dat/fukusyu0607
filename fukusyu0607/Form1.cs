using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);
            MessageBox.Show("" + label1.Width + "," + label1.Handle);
            //Width =幅（横）
            //Height =高さ（縦）
            //ClientSize =（フォーム）
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = MousePosition.X + "," + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            label1.Left += vx;//ラベルが左に行く
            label1.Top  += vy;//ラベルが上に行く
            //結果：左上に行く
            
            if(label1.Left<0)
            {
                vx = Math.Abs(vx);//左に来たら跳ね返す
            }
            if (label1.Top < 0)//上に来たら跳ね返す
            {
                vy = -vy;
            }
            if(label1.Right>500)//右に来たら跳ね返す
            {
                vx = -vx;
            }
            if(label1.Bottom>500)
            {
                vy = -vy;//下に来たら跳ね返す
            }
            if(label1.Left>ClientSize.Width-label1.Width)
            {
                vx = -Math.Abs(vx);//画面に合わせて跳ね返す
            }







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
