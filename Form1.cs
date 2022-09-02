using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList miMueble=new ArrayList(); 
        Form2 venCarga=new Form2();
        Form3 venInfo = new Form3();


        private void button1_Click(object sender, EventArgs e)
        {
            if (venCarga.ShowDialog()== DialogResult.OK)
            {
                int m = venCarga.comboBox2.SelectedIndex + 1;
                string des = venCarga.textBox2.Text;
                double pre = double.Parse(venCarga.textBox3.Text);
                if (venCarga.comboBox1.SelectedIndex == 0)
                {
                    double largo = double.Parse(venCarga.textBox1.Text);
                    Mesa obj=new Mesa(pre, des);
                    obj.Detalle(largo, m);
                    miMueble.Add(obj);
                }else if(venCarga.comboBox1.SelectedIndex == 1)
                {
                    Silla obj =new Silla(des);
                    obj.Detalle(m, pre);
                    miMueble.Add(obj);

                }
                else
                {
                    MessageBox.Show("seleccione un tipo");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            venInfo.listBox1.Items.Clear();

            miMueble.Sort();
            foreach (Producto obj in miMueble)
            {
                venInfo.listBox1.Items.Add(obj.ToString()+" "+obj.precio());
            }
            venInfo.ShowDialog();
        
        }
    }
}
