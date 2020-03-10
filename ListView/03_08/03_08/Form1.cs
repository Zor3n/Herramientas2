using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_08
{
    public partial class Form1 : Form
    {
        //Creamos grupos
        ListViewGroup group = new ListViewGroup("Frutas", HorizontalAlignment.Left);
        ListViewGroup group2 = new ListViewGroup("Carnes", HorizontalAlignment.Center);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
            Image image = Image.FromFile("pyramid.png");
            pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region 1ra forma de agregar items a los grupos
            ///Frutas
            lvAlimentos.Items.Add(new ListViewItem("Mango",group));
            lvAlimentos.Items.Add(new ListViewItem("Sandia", group));
            lvAlimentos.Items.Add(new ListViewItem("Mora", group));
            lvAlimentos.Items.Add(new ListViewItem("Pera", group));
            lvAlimentos.Items.Add(new ListViewItem("Uva", group));

            ///Carnes
            lvAlimentos.Items.Add(new ListViewItem("Pollo", group2));
            lvAlimentos.Items.Add(new ListViewItem("Cerdo", group2));
            lvAlimentos.Items.Add(new ListViewItem("Res", group2));
            lvAlimentos.Items.Add(new ListViewItem("Rata", group2));
            lvAlimentos.Items.Add(new ListViewItem("Perro", group2));
            #endregion
            #region 2da froma de agregar items
            //ListViewItem item = new ListViewItem("Pollo",group2); //Menos eficiente
            //lvAlimentos.Items.Add(item);
            #endregion

            //Adiccionamos los grupos al listview
            lvAlimentos.Groups.Add(group);
            lvAlimentos.Groups.Add(group2);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtElemento.Text))
            {
                if (!rbtnCarnes.Checked)
                    lvAlimentos.Items.Add(new ListViewItem(txtElemento.Text,group));
                else
                    lvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, group2));
            }
            else
                MessageBox.Show("Elemento");
        }
        private void lvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblElemento.Text = lvAlimentos.SelectedItems[0].Text;
            lblIndice.Text = lvAlimentos.SelectedItems[0].Index.ToString(); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvAlimentos.Clear(); //¿Igual que lvAlimentos.Items.Clear()?
            lblElemento.Text = "";
        }
    }
}
