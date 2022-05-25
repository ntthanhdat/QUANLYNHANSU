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
        int MaNV=0;
        void LoadData()
        {
            comm=conn.CreateCommand();
            comm.CommandText = "select MaNV, TenNV, ChucVu, NgaySinh, GioiTinh, QueQuan  from ThongTinNhanVien where  IsDeleted  is null ";
            adapter.SelectCommand=comm;
            dttb.Clear();
            adapter.Fill(dttb);
            
            dtgNV.DataSource=dttb;
            
        }
        void LoadNgayCongData()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "select MaNV, TenNV, ChucVu, GioLaoDong, HeSoLuong, HeSoPC, Thuong, GioLaoDong*HeSoLuong+HeSoPC+Thuong as Luong" +
                "  from  ThongTinNhanVien where IsDeleted is null ";
            adapter.SelectCommand = comm;
            DataTable dttb2 = new DataTable();
            dttb2.Clear();
            adapter.Fill(dttb2);

            dtgNC.DataSource = dttb2;
        }

        private void ReLoad(object sender, EventArgs e)
        {
            LoadData();
            LoadNgayCongData();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection(chuoiketnoi);
            conn.Open();
            LoadData();
            LoadNgayCongData();
        }
        void ClearAllText()
        {
            tbChucVuNV.Clear();
            tbNameNV.Clear();
            tbQQNV.Clear();
            MaNV = 0;
        }
        void Action_AddNV( string ten, string ngaysinh, string chucvu, string quequan, string gioitinh)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "Insert into ThongTinNhanVien( TenNV, ChucVu, NgaySinh, GioiTinh, QueQuan, HeSoLuong, HeSoPC) values(N'"   + ten + "',N'" + chucvu + "',N'"+ ngaysinh+ "',N'" + gioitinh + "',N'" + quequan +  "' , 1, 1)";
            comm.ExecuteNonQuery();
            
            LoadData();
            

        }
            void Action_EditNV(int MaNV, string ten, string ngaysinh, string chucvu, string quequan, string gioitinh)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "Update ThongTinNhanVien set TenNV= N'" + ten + "', ChucVu = N'" + chucvu + "', NgaySinh= N'" + ngaysinh + "' , GioiTinh = N'" + gioitinh + "' , QueQuan = N'" + quequan + "' where MaNV = " + MaNV +"";
            //MessageBox.Show("MNV="+MaNV+" sql="+comm.CommandText, "thông báo");         
            
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên Mã số "+MaNV+" chứ?", "Xác Nhận Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comm.ExecuteNonQuery();
                LoadData();
                ClearAllText();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
        void Action_DeleteNV(int MaNV)
        {

            comm = conn.CreateCommand();
            comm.CommandText = "Update ThongTinNhanVien set IsDeleted = N'Y' where MaNV = " + MaNV + "";
            //MessageBox.Show("MNV="+MaNV+" sql="+comm.CommandText, "thông báo");         

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin nhân viên Mã số " + MaNV + " chứ?", "Xác Nhận Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comm.ExecuteNonQuery();
                LoadData();
                ClearAllText();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        /*
       bool CheckEmptyText()
        {
            if (tbMNV.Text = "")
            {

            }
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tbNameNV.Text != "" && tbQQNV.Text != "" && tbChucVuNV.Text != "")
            {
                string gt;
                gt = rbNAM.Checked ? "Nam" : rbNU.Checked ? "Nữ" : "";

                if (gt != "")
                {
                    Action_AddNV( tbNameNV.Text, dtDate_o_NV.Value.ToString(), tbChucVuNV.Text, tbQQNV.Text, gt);
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


        private void dtgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgNV.CurrentCell.RowIndex;

            //MaNV, TenNV, ChucVu, NgaySinh, GioiTinh, QueQuan
            tbNameNV.Text = dtgNV.Rows[i].Cells[1].Value.ToString(); //ten
            tbChucVuNV.Text = dtgNV.Rows[i].Cells[2].Value.ToString(); //chuc vu

            //ngay sinh
            MaNV = (int)dtgNV.Rows[i].Cells[0].Value;

            tbQQNV.Text = dtgNV.Rows[i].Cells[5].Value.ToString(); //que quan
        }

        private void btEditNV_Click(object sender, EventArgs e)
        {
            if (MaNV == 0)
            {
                MessageBox.Show("Mời bạn chọn thông tin muốn sửa", "thông báo");
            }
            else
            {
                if (tbNameNV.Text != "" && tbQQNV.Text != "" && tbChucVuNV.Text != "")
                {
                    string gt;
                    gt = rbNAM.Checked ? "Nam" : rbNU.Checked ? "Nữ" : "";

                    if (gt != "")
                    {
                        Action_EditNV(MaNV, tbNameNV.Text, dtDate_o_NV.Value.ToString(), tbChucVuNV.Text, tbQQNV.Text, gt);
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
            
        }

        private void btDeleteNV_Click(object sender, EventArgs e)
        {
            if (MaNV == 0)
            {
                MessageBox.Show("Mời bạn chọn thông tin muốn sửa", "thông báo");
            }
            else
            {
                Action_DeleteNV(MaNV);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string ten =sbTen.Text.ToString();
            string tuoi = sbTuoi.Text.ToString();
            string que = sbQQ.Text.ToString();
            string cv = sbCV.Text.ToString();
            string gt= sbGT.Text.ToString();

            comm = conn.CreateCommand();
            comm.CommandText = "select MaNV, TenNV, ChucVu, NgaySinh, GioiTinh, QueQuan  from ThongTinNhanVien where IsDeleted is null ";
            if (ten != "")
                comm.CommandText += "and  TenNV like N'%" + ten + "%' ";
            if (tuoi != "")
                comm.CommandText +=
                " and DATEDIFF(year, NgaySinh, CURRENT_TIMESTAMP) = " + tuoi;
            if (que != "")
                comm.CommandText +=
                " and QueQuan like  N'%" + que + "%' ";
            if (cv != "")
                comm.CommandText +=
                " and ChucVu like  N'%" + cv + "%' ";
            if (gt != "")
                comm.CommandText +=
                " and GioiTinh like  N'%" + gt + "%' ;";
            //MessageBox.Show(" sql="+comm.CommandText, "thông báo");
            //Clipboard.SetText(comm.CommandText);
            adapter.SelectCommand = comm;
            DataTable dttb3 = new DataTable();
            dttb3.Clear();
            adapter.Fill(dttb3);

            sdtgNV.DataSource = dttb3;
        }
        //-------------------xong ql thong tin, tim kiem 
        
        private void dtgNC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgNC.CurrentCell.RowIndex;

            //MaNV, TenNV, ChucVu, GioLaoDong, HeSoLuong, HeSoPC, Thuong,
            nctbMaNV.Text = dtgNC.Rows[i].Cells[0].Value.ToString(); //ma
            nctbTen.Text = dtgNC.Rows[i].Cells[1].Value.ToString(); //ten
            tbncGioLaoDong.Text = dtgNC.Rows[i].Cells[3].Value.ToString();
            nctbHeSoLuong.Text = dtgNC.Rows[i].Cells[4].Value.ToString();
            nctbHeSoPC.Text = dtgNC.Rows[i].Cells[5].Value.ToString();
            nctbThuong.Text = dtgNC.Rows[i].Cells[6].Value.ToString();


            MaNV = (int)dtgNV.Rows[i].Cells[0].Value;
            lbLuongTong.Text= dtgNC.Rows[i].Cells[7].Value.ToString()+" đ";


        }
        void Action_EditNC(int MaNV, string hesoluong, string hesopc, string thuong, string giolam)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "update ThongTinNhanVien set  HeSoLuong=" + hesoluong + ",  HeSoPC=  " + hesopc + " , Thuong = " + thuong + ", GioLaoDong = " + giolam + " where MaNV="+MaNV;
            
            //MessageBox.Show(" sql="+comm.CommandText, "thông báo");
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên Mã số " + MaNV + " chứ?", "Xác Nhận Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                comm.ExecuteNonQuery();
                LoadNgayCongData();
                lbLuongTong.Text = dtgNC.CurrentRow.Cells[7].Value.ToString() + " đ";
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
        private void Edit_NgayCong_Click(object sender, EventArgs e)
        {
            if (MaNV == 0)
            {
                MessageBox.Show("Mời bạn chọn thông tin muốn sửa", "thông báo");
            }
            else
            {
                if (nctbTen.Text != "" && nctbHeSoLuong.Text != "" && nctbHeSoPC.Text != "" && nctbThuong.Text != "" && tbncGioLaoDong.Text != "")
                {
                    Action_EditNC(MaNV, nctbHeSoLuong.Text, nctbHeSoPC.Text, nctbThuong.Text, tbncGioLaoDong.Text);
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "thông báo");

                }
            }
        }
    }
   
}
