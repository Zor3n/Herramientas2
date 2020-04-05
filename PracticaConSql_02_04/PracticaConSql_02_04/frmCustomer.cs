using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaConSql_02_04
{
    public partial class frmCustomer : Form
    {
        SqlConnection _connection;
        SqlCommand _command; //Commando to do in the data base
        string _idValue; 
        public frmCustomer()
        {
            InitializeComponent();
            //stabling connection with the server and opening.
            _connection = new SqlConnection("server=DESKTOP-B09E8T2\\SQLEXPRESS;database=DBConection;integrated security = true;MultipleActiveResultSets=True");
            _connection.Open();

            addToList();
            addIdTo_cbIdCustomer();            
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connection.Close(); //Closing the connection with the server
        }

        //Button add
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _command = new SqlCommand();
            string genderLetter;
            if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtHood.Text))
            {
                if (rbnFemale.Checked)
                    genderLetter = "F";
                else
                    genderLetter = "M";

                _command.Connection = _connection;
                _command.CommandText = "insert into Customer values('"+ txtID.Text + "','"+ txtName.Text + "','"+ txtSurname.Text + "','"+dtpBornDate.Text+"','"+genderLetter+"','"+ txtHood.Text + "');";
                MessageBox.Show("Customer correctly add!\n"+_command.ExecuteNonQuery()+" table's row added.");

                addToList();
                addIdTo_cbIdCustomer();

                txtID.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtHood.Clear();

                clearField();
            }
            else
                MessageBox.Show("Por favor, ingrese todos los campos");
        }

        /// <summary>
        ///     This method will add every customer into the listview.
        /// </summary>
        private void addToList()
        {
            lvCustomerList.Items.Clear();

            _command = new SqlCommand();    //Start the new command
            _command.Connection = _connection;
            _command.CommandText = "select * from Customer";

            SqlDataReader log;
            log = _command.ExecuteReader();

            while (log.Read())
            {
                ListViewItem item = new ListViewItem(log["id_c"].ToString());
                item.SubItems.Add(log["name_c"].ToString());
                item.SubItems.Add(log["surname_c"].ToString());
                item.SubItems.Add(log["date_c"].ToString());
                item.SubItems.Add(log["gender"].ToString());
                item.SubItems.Add(log["neighborhood"].ToString());
                lvCustomerList.Items.Add(item);
            }
        }

        /// <summary>
        ///     This method will help us to add the already list of id's customer into the combo box
        /// </summary>
        private void addIdTo_cbIdCustomer()
        {
            cbIdCustomer.Items.Clear(); //Firt of all the cb must to be empty.

            _command = new SqlCommand();    //Start the new command
            _command.Connection = _connection;
            _command.CommandText = "select id_c from Customer;";

            SqlDataReader log;  //The reader of the comand
            log = _command.ExecuteReader();

            while (log.Read())  //Loop for add the items.
                cbIdCustomer.Items.Add(log["id_c"].ToString());
        }

        // This event will find the fields from the customer's id
        private void cbIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idValue = cbIdCustomer.Items[cbIdCustomer.SelectedIndex].ToString();

            _command = new SqlCommand();
            _command.Connection = _connection;
            _command.CommandText = "select * from Customer where id_c = '"+ _idValue+ "';";
            

            SqlDataReader log;
            log = _command.ExecuteReader();

            if (log.Read())
            {
                lblNameResult.Text = log["name_c"].ToString();
                lblSurResult.Text = log["surname_c"].ToString();
                lblBornResult.Text = log["date_c"].ToString(); 
                lblGenResult.Text = log["gender"].ToString();
                lblHoodResult.Text = log["neighborhood"].ToString();

                btnDeleteCustomer.Enabled = true;
            }
        }

        //Delete customer
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ID: "+ _idValue + "\n" +
                "Do you really want to delete this customer?","Borrar",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _command = new SqlCommand();
                _command.Connection = _connection;
                _command.CommandText = "delete from Customer where id_c = '" + _idValue + "';";

                MessageBox.Show("Deleting sucefully ended!\n"+_command.ExecuteNonQuery()+" row deleted");

                clearField();

                addIdTo_cbIdCustomer();
                addToList();

                btnDeleteCustomer.Enabled = false;
            }            
        }

        //Help
        private void clearField()
        {
            lblNameResult.Text = null;
            lblSurResult.Text = null;
            lblHoodResult.Text = null;
            lblBornResult.Text = null;
            lblGenResult.Text = null;
        }
    }
}
