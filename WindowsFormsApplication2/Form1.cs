using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //button1เราใช้เป็นปุ่มคำนวณ
        {

            try
            {
                if (comboBox1.Text == "วงกรมเส้นรอบวง")     //ในช่อง comboBox1จะมีเงื่อนไขเส้นรอบวงให้เราเลือก             
                {
                    try                                              //ไว้กันเมื่อลืมใส่ตัวเลข หรือความยาวของเส้นรอบวง
                    {
                        double t = double.Parse(textBox1.Text);  //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลt มา
                        double m =Math.PI;                        //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปล mมา แล้วให้เท่ากับMath.pi เพราะจะเป็นสูตรทางคนิตศาสตร์ซึ่งในเส้นรอบวงนี้เราใช้22/7 เเต่กลัวค่าไม่ตรงตัวเลยใช้Math.pi 
                        double d =  t*m ;   //เป็นสูตรเส้นรอบวงกลม
                        MessageBox.Show("เส้นรอบวงกลม = " + d.ToString());  //เมื่อจะเเสดงค่าที่คำนวณแล้ว จะมีกล่องข้อความเเสดงโชว์บอกเราค่ะ
                    }
                    catch { }

                }
                if (comboBox1.Text == "พื้นที่สามเหลี่ยม")   //ในช่อง comboBox1จะมีเงื่อนไขพื้นที่สามเหลี่ยมให้เราเลือก
                {
                    try                               //ไว้กันเมื่อลืมใส่ตัวเลข หรือความยาวของเส้นรอบวง
                    {
                        double a = double.Parse(textBox1.Text);  //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลa มา
                        double b = double.Parse(textBox2.Text);   //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลb มา
                        double pass = 0.5;                           //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลpass มา
                        double c = pass*(a*b);  //สูตร(1/2)ฐ*ส
                        MessageBox.Show("พื้นที่สามเหลี่ยม = " + c);        //เมื่อจะเเสดงค่าที่คำนวณแล้วจะมีกล่องข้อความเเสดงโชว์
                    }
                    catch { }
                }
                if (comboBox1.Text == "พื้นที่สี่เหลี่ยมผืนผ้า")   //ในช่อง comboBox1จะมีเงื่อนไขพื้นที่สี่เหลี่ยมผืนผ้าให้เราเลือก
                {
                    try                                 //ไว้กันเมื่อลืมใส่ตัวเลข หรือความยาวของเส้นรอบวง
                    {
                        double go = double.Parse(textBox1.Text);    //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลgo มา
                        double dog = double.Parse(textBox2.Text);     // ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลdog มา
                        double cat = (go * dog);                //สูตรพื้นที่สี่เหลี่ยมผืนผ้า

                        MessageBox.Show("พื้นที่สี่เหลี่ยมผืนผ้า = " + cat.ToString());    //เมื่อจะเเสดงค่าที่คำนวณแล้วจะมีกล่องข้อความเเสดงโชว์
                    }
                    catch { }
                }

                if (comboBox1.Text == "สี่เหลี่ยมจัตุรัส")                   //ในช่อง comboBox1จะมีเงื่อนไขพื้นที่สี่เหลี่ยมจัตุรัสให้เราเลือก
                {
                    try                                              //ไว้กันเมื่อลืมใส่ตัวเลข หรือความยาวของเส้นรอบวง
                    {
                        double app = double.Parse(textBox1.Text);     //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลapp มา
                        double ppap = double.Parse(textBox2.Text);      //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลppap มา
                        double c = (app * ppap);                       //สูตรพื้นที่สี่เหลี่ยมจัตุรัส

                        MessageBox.Show("สี่เหลี่ยมจัตุรัส = " + c.ToString());   //เมื่อจะเเสดงค่าที่คำนวณแล้วจะมีกล่องข้อความเเสดงโชว์
                    }
                    catch { }
                }

                if (comboBox1.Text == "พื้นที่สี่เหลี่ยมด้านขนาน")   //ในช่อง comboBox1จะมีเงื่อนไขพื้นที่สี่เหลี่ยมด้านขนานให้เราเลือก
                {
                    try                                   //ไว้กันเมื่อลืมใส่ตัวเลข หรือความยาวของเส้นรอบวง
                    {
                        double apa = double.Parse(textBox1.Text);                 //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลapa มา
                        double bpb = double.Parse(textBox2.Text);                //ใช้ doubleเพราะมันสามารถรับตำเเหน่งเลขได้เยอะแล้วประกาศตัวแปลbpb มา
                        double coc = (apa * bpb);                                    //สูตรพื้นที่ด้านขนาน

                        MessageBox.Show("พื้นที่สี่เหลี่ยมด้านขนาน = " + coc.ToString());      //เมื่อจะเเสดงค่าที่คำนวณแล้ว จะมีกล่องข้อความเเสดงโชว์บอก
                    }
                    catch { }
                }


            }

            catch
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)    //ปุ่ม  button2ใช้เป็นปุ่มออก
        {
            this.Close();                                          //ใช้เพื่อที่จะออกจากโปรแกรมทุกอย่าง 
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)  
        {
            if (comboBox1.Text == "วงกรมเส้นรอบวง")   //.ในเงื่อนไข comboBox1 เส้นรอบวง
            {
                label2.Hide();                      //ในlabel2 ปิดไว้
                textBox2.Hide();                     //ในtextBox2 ปิดไว้เพราะค่าที่จะใส่เราใส่ได้เเค่ ค่าเดียว
            }

            if (comboBox1.Text == "พื้นที่สามเหลี่ยม")     //ในเงื่อนไข comboBox1 พื้นที่สามเหลี่ยม
            {
                label2.Show();                       //จะเเสดงความยาวด้านที่1. ในlabel2 
                textBox2.Show();                       //ในtextBox2 เปิดไว้ เเละเราสามารถใส่ค่าเท่าไหร่ก็ไได้ค่ะหรือเปิดเพื่อให้เราสามารถใส่ตัวเลขได้
            }

            if (comboBox1.Text == "พื้นที่สี่เหลี่ยมผืนผ้า")      //ในเงื่อนไข comboBox1 พื้นที่สามเหลี่ยม
            {
                label2.Show();                        //จะเเสดงความยาวด้านที่1. ในlabel2 
                textBox2.Show();                      //ในtextBox2 เปิดไว้ เเละเราสามารถใส่ค่าเท่าไหร่ก็ไได้ค่ะหรือเปิดเพื่อให้เราสามารถใส่ตัวเลขได้
            }

            if (comboBox1.Text == "สี่เหลี่ยมจัตุรัส")        //ในเงื่อนไข comboBox1 พื้นที่สามเหลี่ยม
            {
                label2.Show();                          //จะเเสดงความยาวด้านที่1. ในlabel2  
                textBox2.Show();                   //ในtextBox2 เปิดไว้ เเละเราสามารถใส่ค่าเท่าไหร่ก็ไได้ค่ะหรือเปิดเพื่อให้เราสามารถใส่ตัวเลขได้
            }
                if (comboBox1.Text == "พื้นที่สี่เหลี่ยมด้านขนาน")         //ในเงื่อนไข comboBox1 พื้นที่สามเหลี่ยม      
            {
                label2.Show();                          //จะเเสดงความยาวด้านที่1. ในlabel2     
                textBox2.Show();                     //ในtextBox2 เปิดไว้ เเละเราสามารถใส่ค่าเท่าไหร่ก็ไได้ค่ะหรือเปิดเพื่อให้เราสามารถใส่ตัวเลขได้          
                }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)               //ใช้button3 เป็นปุ่มล้าง 
        {
            textBox1.Clear();                                                  //เพื่อที่จะล้างค่า ตัวเลขต่างๆในtextBox1
            textBox2.Clear();                                          //เพื่อที่จะล้างค่า ตัวเลขต่างๆในtextBox2
        }
    }
}
