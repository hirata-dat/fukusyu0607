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
        //疑似乱数
        //ランダムのシード（種）を指定して初期化したら
        //それを使い続ける
        private static Random rand = new Random();
        
        int vx = rand.Next(-50,20);
        int vy = rand.Next(-50,20);
        
        

        public Form1()
        {
            InitializeComponent();

            //以下に、label1.leftとlabel1.Topの座標をランダムで求めよ





        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);
            MessageBox.Show("" + label1.Width + "," + label1.Handle);
            //Width =幅（横）
            //Height =高さ（縦）
            //ClientSize =（フォーム）
        }//マウスの（X.Y）がわかる

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = MousePosition.X + "," + MousePosition.Y;
           // Point p = PointToClient(MousePosition);

            label1.Left += vx;//ラベルが左に行く
            label1.Top  += vy;//ラベルが上に行く
            //結果：左上に行く

            //マウスと重なった時、タイマーが止める
            Point p = PointToClient(MousePosition);
            if(     (p.X>=label1.Left)
                &&  (p.X< label1.Right)
                &&  (p.Y>=label1.Top)
                &&  (p.Y<label1.Bottom)
               )

            {
                timer1.Enabled = false;
            }



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
            if (label1.Bottom > 500)//下に来たら跳ね返す
            {
                vy = -vy;
            }
            if(label1.Left>ClientSize.Width-label1.Width)
            {
                vx = -Math.Abs(vx);//画面に合わせて跳ね返す(左)
            }
            if(label1.Right>ClientSize.Width-label1.Width)
            {
                vx = -Math.Abs(vx);//画面に合わせて跳ね返す(右)
            }






        }//画面上で跳ね返す

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
