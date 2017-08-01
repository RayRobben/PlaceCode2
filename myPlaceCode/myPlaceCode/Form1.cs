using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPlaceCode
{
    public partial class Form1 : Form
    {
        // 秒以下的单位值的倒数，将秒以下数值转换为二进制，需要先乘以该值
        // 2048=2^11，对应11位二进制；
        long subsec = 2048;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenCode_Click(object sender, EventArgs e)
        {
            //地名地址时空编码，输入为球面坐标（度小数），经度与纬度用半角逗号隔开
            string[] xys = txtCoor.Text.Split(',');
            int n = xys.GetLength(0);
            if (n != 2)
            {
                MessageBox.Show("输入坐标格式有问题，请顺序输入坐标的xy值，用,连接");
                return;
            }

            double x = double.Parse(xys[0]), y = double.Parse(xys[1]);
            string code = trandxy2code(x,y);
            lblCodeExp.Text = code;

        }

        //将坐标转换为时空编码，
        //具体编码方法参照文献：《地球空间参考网格系统建设初探》程承旗
        private string trandxy2code(double x,double y)
        {
            //编码共32级，64位，每一级纬向和经向编码各占一位，
            //因此，在一个方向上位数分布为，度（9位），分（6位），秒（6位），秒以下（11位）；
            //经度和纬度分别转为度分秒，以及秒以下的
            string xcd,ycd,code,xbu,ybu;
            xcd = du2bin(x);
            ycd = du2bin(y);
            if (x >= 0)
                xbu = "1";
            else
                xbu = "0";
            if (y >= 0)
                ybu = "1";
            else
                ybu = "0";

            xcd = xbu + xcd;
            ycd = ybu + ycd;
            code = CrossString(xcd,ycd);
            return code;
        }
        //字符串交叉，纬向在前，经向在后，每一位交叉组合
        private string CrossString(string xcd, string ycd)
        {
            int nx, ny;
            nx = xcd.Length;
            ny = ycd.Length;
            if (nx != ny)
            {
                MessageBox.Show("经向和纬向编码长度不一致，请检查程序问题");
                return "";
            }
            string code="";
            for (int i = 0; i < nx; ++i)
            {
                code = code + ycd.Substring(i, 1) + xcd.Substring(i, 1);
            }
            return code;
        }

        private string du2bin(double x)
        {
            int d=0, m=0, s=0,subs=0;
            string d2, m2, s2, subs2;
            //将度小数，转换为度，分，秒，和秒以下
            du2dms(x, ref d, ref m, ref s, ref subs);
            //分别将度分秒秒下转换为二进制的字符串
            d2=Convert.ToString(d, 2);
            m2 = Convert.ToString(m, 2);
            s2 = Convert.ToString(s, 2);
            subs2 = Convert.ToString(subs, 2);
            //按照实际位数补位，在一个方向上位数分布为，度（9位），分（6位），秒（6位），秒以下（11位）；
            //注意，此处度先补够8位，剩余一位根据经纬度的正负号确定
            d2 = d2.PadLeft(8, '0');
            m2 = m2.PadLeft(6, '0');
            s2 = s2.PadLeft(6, '0');
            subs2 = subs2.PadRight(11, '0');
            string code = d2 + m2 + s2 + subs2;
            return code;
        }

        private void du2dms(double x, ref int d, ref int m, ref int s, ref int subs)
        {
//             d = Convert.ToInt32(x);
//             m = Convert.ToInt32((x - d)*60);
//             s = Convert.ToInt32(((x - d) * 60 - m) * 60);
//             subs = Convert.ToInt32((((x - d) * 60 - m) * 60 - s) * subsec);


             d = Convert.ToInt32(Math.Floor(x));
             m = Convert.ToInt32(Math.Floor((x - d) * 60));
             s = Convert.ToInt32(Math.Floor(((x - d) * 60 - m) * 60));
             subs = Convert.ToInt32(Math.Floor((((x - d) * 60 - m) * 60 - s) * subsec));
            return;
        }
    }
}
