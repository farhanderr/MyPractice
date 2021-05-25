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


namespace MyPractice
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@" data source = DESKTOP-4OL84HG\SQLEXPRESS; initial catalog = MyPractice;Integrated Security=True; ");
        public Form1()
        {
            InitializeComponent();
        }
        BelajarDataContext db = new BelajarDataContext();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductID.Text);
            string item = txtItem2.Text;
            string design = txtDesign2.Text;
            string color = cbColor.Text;
            DateTime expiredDate = DateTime.Parse(dtExpired.Text);
            var data = new TB_M_PRODUCT
            {
                ID = id,
                itemName = item,
                color = color,
                design = design,
                expireddate = expiredDate
            };
            db.TB_M_PRODUCTs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtDesign.Clear();
            txtItem.Clear();
            cbColor.Items.Clear();
            LoadData();
        }
        void LoadData()
        {
            var st = from tb in db.TB_M_PRODUCTs select tb;
            dgView.DataSource = st;
        }
        private void MasterProduct_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (ID as int)),0) +1 from TB_M_PRODUCT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtProductID.Text = dt.Rows[0][0].ToString();
            LoadData();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
