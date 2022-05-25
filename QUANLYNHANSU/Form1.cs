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
using System.Data;

namespace QUANLYNHANSU
{
    public partial class Form1 : Form
    {
        //DESKTOP-D5NGO3I\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=;Password=

        string chuoiketnoi = @"Data Source=DESKTOP-D5NGO3I\SQLEXPRESS;Initial Catalog=Nhanvien;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dttb= new DataTable();

        void LoadData()
        {
            comm=conn.CreateCommand();
            comm.CommandText = "select * from ThongTinNhanVien";
            adapter.SelectCommand=comm;
            dttb.Clear();
            adapter.Fill(dttb);
            dtgNV.DataSource=dttb;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
        }

        //void Action_AddNV(string ma, string ten, string chucvu, string quequan, string gioitinh);

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbMNV.Text !="" && tbNameNV.Text !="" && tbQQNV.Text != "" )
            {
                string gt;
                gt = rbNAM.Checked ? "Nam" : rbNU.Checked ? "Nữ" : "";
           
                if(gt != "")
                {
                    dtgNV.Rows.Add(tbMNV.Text, tbNameNV.Text,  dtDate_o_NV.Value, gt, tbQQNV.Text);
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập giới tinh", "thông báo");

                }
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtngaycong.Rows.Add(cbMCB.Text, cbNameCB.Text, dtTimeStart.Value, dtTimeEnd.Value);
        }

    }
}
