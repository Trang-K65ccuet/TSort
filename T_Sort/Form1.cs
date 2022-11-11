using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace T_Sort
{
    public partial class Form1 : Form
    {
        //Khai báo các biến chính
        int sophantu = 0; //Số phần tử hiện tại của mảng
        int vitri = 0; // Vị trí hiện tại của mảng khi thêm bằng tay
        int tocdo = 31; //Tốc độ
        int muctocdo = 1; //Mức tốc độ
        int dau = 1; //Sử dụng để quyết định sắp xếp tăng-giảm, giá trị ban đầu =1
        int luachon = 0; //Kiểm tra lựa chọn thuật toán sắp xếp trước đó là gì
        Random rd = new Random(); //Mảng sinh số ngẫu nhiên
        Label[] lb = new Label[30]; //Khai báo mảng label
        Point[] pnt = new Point[30]; //Khai báo mảng tọa độ label
        sapXep sapxep1; //Khai báo 1 đối tượng thuộc lớp sắp xếp
        Thread luong1, luong2; //Luồng thứ 1,2

        public Form1()
        {
            InitializeComponent();
            //Khởi tạo
            Control.CheckForIllegalCrossThreadCalls = false;
            rbTuDong.Checked = true;
            rbTang.Checked = true;
            btnTamDung.Enabled = false;
            btnDatLai.Enabled = false;
            tbTocDo.Text = muctocdo.ToString();
        }

        //Khởi tạo khi "Tự động"
        private void rbTuDong_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTuDong.Checked == true)
            {
                lbSoLuong.Enabled = true;
                tbSoLuong.Enabled = true;
                lbNhapMang.Enabled = true;
                tbNhapMang.Enabled = false;
            }
        }

        //Khởi tạo khi chọn "Thủ công"
        private void rbThuCong_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThuCong.Checked == true)
            {
                btnThem.Enabled = true;
                lbSoLuong.Enabled = true;
                tbSoLuong.Enabled = false;
                lbNhapMang.Enabled = true;
                tbNhapMang.Enabled = true;
            }
        }

        //Sắp xếp tăng
        private void rbTang_CheckedChanged(object sender, EventArgs e)
        {
            dau = 1;
        }

        //Sắp xếp giảm
        private void rbGiam_CheckedChanged(object sender, EventArgs e)
        {
            dau = -1;
        }

        

        //Giảm tốc độ
        private void btnGiamToc_Click(object sender, EventArgs e)
        {
            if (tocdo < 31)
            {
                tocdo += 5;
                tbTocDo.Text = (--muctocdo).ToString();
            }
        }

        //Tăng tốc độ
        private void btnTangToc_Click(object sender, EventArgs e)
        {
            if (tocdo > 1)
            {
                tocdo -= 5;
                tbTocDo.Text = (++muctocdo).ToString();
            }
        }

        //Click button "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra đầu vào
            if (rbTuDong.Checked == true && tbSoLuong.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng phần tử!", "Thông báo");
                tbSoLuong.Focus();
                return;
            }
            if (rbThuCong.Checked == true && tbNhapMang.Text == "")
            {
                MessageBox.Show("Hãy nhập phần tử!", "Thông báo");
                tbNhapMang.Focus();
                return;
            }

            try
            {
                if (rbTuDong.Checked == true)
                {
                    //Xóa các phần tử cũ khi nhập mảng tự động mới
                    if (lb[0] != null)
                    {
                        for (int i = 0; i < sophantu; i++)
                        {
                            grChinh.Controls.Remove(lb[i]);
                        }
                    }

                    sophantu = int.Parse(tbSoLuong.Text);
                    if (sophantu > 19)
                    {
                        MessageBox.Show("Số lượng phần tử lớn gây tràn màn hình, hãy nhập số nhỏ hơn", "Thông báo");
                        return;
                    }
                    if (sophantu < 2)
                    {
                        MessageBox.Show("Không nhập số phần tử nhỏ hơn 2", "Thông báo");
                        return;
                    }
                    sapxep1 = new sapXep();

                    for (int i = 0; i < sophantu; i++)
                    {
                        sapxep1.khoiTaoNhan(ref lb[i], ref pnt[i], ref rd, i);
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.grChinh.Controls.Add(lb[i]);
                        });
                    }
                    vitri = sophantu;
                }
                else if (rbThuCong.Checked == true)
                { 
                    int tam = int.Parse(tbNhapMang.Text);
                    if (tam > 99)
                    {
                        MessageBox.Show("Số bạn nhập quá lớn, vui lòng nhập số khác!", "Thông báo");
                        return;
                    }
                    if(tam < 0)
                    {
                        MessageBox.Show("Số bạn nhập quá nhỏ, vui lòng nhập số khác!", "Thông báo");
                        return;
                    }
                    if (sophantu > 19)
                    {
                        MessageBox.Show("Thêm phần tử gây tràn màn hình!", "Thông báo");
                        return;
                    }
                    sapxep1 = new sapXep();
 
                    sapxep1.khoiTaoNhan(ref lb[vitri], ref pnt[vitri], tam.ToString(), vitri);
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.grChinh.Controls.Add(lb[vitri]);
                    });
                    vitri++;
                    sophantu++;
                }
                btnDatLai.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu, hãy nhập lại!", "Thông báo");
                return;
            }
        }

        //hàm tạo luồng
        public void taoLuong()
        {
            if (rbLuaChon.Checked == true)
                luong1 = new Thread(luaChon);
            else if (rbNoiBot.Checked == true)
                luong1 = new Thread(noiBot);
            else if (rbChen.Checked == true)
                luong1 = new Thread(chen);
        }

        //Button "Bắt đầu" được click
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu đầu vào
            if (lb[0] == null)
            {
                MessageBox.Show("Chưa có dữ liệu, hãy khởi tạo dữ liệu trước khi bắt đầu!", "Thông báo");
                return;
            }
            if (rbLuaChon.Checked == false && rbNoiBot.Checked == false && rbChen.Checked == false)
            {
                MessageBox.Show("Hãy lựa chọn thuật toán sắp xếp!", "Thông báo");
                return;
            }
            btnThem.Enabled = false;

            //tạo luồng
            taoLuong();
            luong1.IsBackground = true;
            luong1.Start();

            //
            btnBatDau.Enabled = false;
            btnTamDung.Enabled = true;

            //kiểm tra luồng 1 đã kết thúc chưa
            luong2 = new Thread(kiemTraLuong1);
            luong2.IsBackground = true;
            luong2.Start();
        }

        //Button "Đặt lại" được click
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            //kiểm tra trạng thái của từng luồng
            if (luong1 != null)
            {
                if ((luong1.ThreadState & ThreadState.SuspendRequested) == ThreadState.SuspendRequested)
                {
                    luong1.Resume();
                    luong1.Abort();
                }
                else if ((luong1.ThreadState & ThreadState.Suspended) == ThreadState.Suspended)
                {
                    luong1.Resume();
                    luong1.Abort();
                }
                else
                {
                    luong1.Abort();
                }
            }

            //đặt lại dữ liệu
            lb = new Label[30];
            pnt = new Point[30];
            sophantu = 0;
            vitri = 0;
            tocdo = 31;
            muctocdo = 1;
            dau = 1;

            //đặt lại giao diện
            grChinh.Controls.Clear();
            tbTocDo.Text = muctocdo.ToString();
            btnTamDung.Text = "TẠM DỪNG";
            btnTamDung.Enabled = false;
            btnDatLai.Enabled = btnTamDung.Enabled = false;
            btnBatDau.Enabled = true;
            rbTang.Enabled = true;
            rbGiam.Enabled = true;
            rbTang.Checked = true;
            rbGiam.Checked = false;
            rbTuDong.Checked = true;
            rbLuaChon.Checked = true;
            rbChen.Checked = false;
            rbNoiBot.Checked = false;
            tbNhapMang.ResetText();
            tbSoLuong.ResetText();
        }


        //Button "Tạm dừng" được click
        private void btnTamDung_Click(object sender, EventArgs e)
        {
            if(btnTamDung.Text == "TẠM DỪNG")
            {
                luong1.Suspend();
                btnTamDung.Text = "TIẾP TỤC";
            }
            else
            {
                luong1.Resume();
                btnTamDung.Text = "TẠM DỪNG";
            }
        }

        //kiểm tra xem thread 1 đã kết thúc chưa
        public void kiemTraLuong1()
        {
            while (true)
            {
                if ((luong1.ThreadState & ThreadState.Aborted) == ThreadState.Aborted
                    || (luong1.ThreadState & ThreadState.Stopped) == ThreadState.Stopped)
                {
                    btnBatDau.Enabled = true;
                    btnTamDung.Enabled = false;
                    btnThem.Enabled = true;
                    rbTang.Enabled = true;
                    rbGiam.Enabled = true;
                    break;
                }
            }
        }

        //Sắp xếp lựa chọn
        public void luaChon()
        {
            //Đặt lại vị trí cho dãy label
            for (int i = 0; i < sophantu; i++)
            {
                pnt[i].Y = 235 - int.Parse(lb[i].Text) * 2;
                lb[i].Location = pnt[i];
            }
            //Sắp xếp
            for (int i = 0; i < sophantu - 1; i++)
            {
                int min = i;
                lb[min].BackColor = Color.IndianRed;
                lb[min].ForeColor = Color.WhiteSmoke;
                Thread.Sleep(tocdo * 40);
                for (int j = i + 1; j < sophantu; j++)
                {
                    lb[j].BackColor = Color.DarkCyan;
                    lb[j].ForeColor = Color.AntiqueWhite;
                    Thread.Sleep(tocdo * 40);
                    if (int.Parse(lb[j].Text) * dau < int.Parse(lb[min].Text) * dau)
                    {

                        lb[min].BackColor = Color.White;
                        lb[min].ForeColor = Color.Black;
                        lb[j].BackColor = Color.IndianRed;
                        lb[j].ForeColor = Color.WhiteSmoke;
                        min = j;
                        Thread.Sleep(tocdo * 40);

                    } else {
                        lb[j].BackColor = Color.White;
                        lb[j].ForeColor = Color.Black;
                    }

                }
                if (i != min)
                {
                    sapxep1.moPhongDaoNhan(ref lb[i], ref lb[min], ref pnt[i], ref pnt[min], ref tocdo);
                    sapxep1.daoNhan(ref lb[i], ref lb[min]);
                    sapxep1.daoDiem(ref pnt[i], ref pnt[min]);
                    Thread.Sleep(tocdo * 40);
                }
                lb[min].BackColor = Color.White;
                lb[min].ForeColor = Color.Black;
                lb[i].BackColor = Color.GreenYellow;
                lb[i].ForeColor = Color.Black;

            }
            lb[sophantu - 1].BackColor = Color.GreenYellow;
            lb[sophantu - 1].ForeColor = Color.Black;
            MessageBox.Show("Dãy đã được sắp xếp!", "Thông báo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNhapMang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTocDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTocDo_Click(object sender, EventArgs e)
        {

        }

        private void lbNhapMang_Click(object sender, EventArgs e)
        {

        }

        private void lbSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void grThucHien_Enter(object sender, EventArgs e)
        {

        }

        //Sắp xếp nổi bọt
        public void noiBot()
        {
            //đặt lại vị trí cho dãy label
            for (int i = 0; i < sophantu; i++)
            {
                pnt[i].Y = 235 - int.Parse(lb[i].Text) * 2;
                lb[i].Location = pnt[i];
            }
            //sắp xếp
            for (int i = 0; i < sophantu - 1; i++)
            {
                Thread.Sleep(tocdo * 40);
                for (int j = 0; j < sophantu - i - 1; j++)
                {

                    lb[j].BackColor = Color.DarkCyan;
                    lb[j].ForeColor = Color.AntiqueWhite;
                    lb[j + 1].BackColor = Color.DarkCyan;
                    lb[j + 1].ForeColor = Color.AntiqueWhite;
                    Thread.Sleep(tocdo * 40);
                    if (int.Parse(lb[j].Text) * dau > int.Parse(lb[j + 1].Text) * dau)
                    {
                        sapxep1.moPhongDaoNhan(ref lb[j], ref lb[j + 1], ref pnt[j], ref pnt[j + 1], ref tocdo);
                        sapxep1.daoNhan(ref lb[j], ref lb[j + 1]);
                        sapxep1.daoDiem(ref pnt[j], ref pnt[j + 1]);
                        Thread.Sleep(tocdo * 40);
                    }
                    lb[j].BackColor = Color.White;
                    lb[j].ForeColor = Color.Black;

                }
                lb[sophantu - i - 1].BackColor = Color.GreenYellow;
                lb[sophantu - i - 1].ForeColor = Color.Black;
            }
            lb[0].BackColor = Color.GreenYellow;
            lb[0].ForeColor = Color.Black;
            MessageBox.Show("Dãy đã được sắp xếp!", "Thông báo");
        }

        //Sắp xếp chèn
        public void chen()
        {
            //đặt lại vị trí cho dãy label
            for (int i = 0; i < sophantu; i++)
            {
                pnt[i].Y = 235 - int.Parse(lb[i].Text) * 2;
                lb[i].Location = pnt[i];
            }
            //sắp xếp
            Label lbTam = new Label();
            Point ptTam = new Point();
            lb[0].BackColor = Color.GreenYellow;
            lb[0].ForeColor = Color.Black;

            for (int i = 1; i < sophantu; i++)
            {
                lb[i].BackColor = Color.IndianRed;
                lb[i].ForeColor = Color.WhiteSmoke;
                Thread.Sleep(tocdo * 40);
                int ix = int.Parse(lb[i].Text);
                int pos = i;
                Thread.Sleep(tocdo * 40);

                sapxep1.diChuyen(ref lb[pos], ref pnt[pos], lb[pos].Location.X, 450 - int.Parse(lb[i].Text) * 2, ref tocdo);
                lb[i].BackColor = Color.IndianRed;
                lb[i].ForeColor = Color.WhiteSmoke;
                lbTam = lb[pos];
                ptTam = pnt[pos];
                Thread.Sleep(tocdo * 40);


                while (pos > 0 && int.Parse(lb[pos - 1].Text) * dau > ix * dau)
                {

                    lb[pos - 1].BackColor = Color.DarkCyan;
                    lb[pos - 1].ForeColor = Color.AntiqueWhite;

                    Thread.Sleep(tocdo * 40);

                    sapxep1.diChuyen(ref lb[pos - 1], ref pnt[pos - 1], pos * 60, lb[pos - 1].Location.Y, ref tocdo);
                    lb[pos] = lb[pos - 1];
                    pnt[pos] = pnt[pos - 1];
                    lb[pos - 1].BackColor = Color.Yellow;
                    lb[pos - 1].ForeColor = Color.Black;
                    Thread.Sleep(tocdo * 40);

                    pos--;
                    lb[pos].BackColor = Color.GreenYellow;
                    lb[pos].ForeColor = Color.Black;

                    lb[pos] = lbTam;
                    pnt[pos] = ptTam;
                    sapxep1.diChuyen(ref lb[pos], ref pnt[pos], (pos) * 60, lb[pos].Location.Y, ref tocdo);
                    lb[pos].BackColor = Color.IndianRed;
                    lb[pos].ForeColor = Color.WhiteSmoke;
                    Thread.Sleep(tocdo * 40);
                    lbTam = lb[pos];
                    ptTam = pnt[pos];
                }
                if(pos >= 1)
                {
                    lb[pos - 1].BackColor = Color.DarkCyan;
                    lb[pos - 1].ForeColor = Color.AntiqueWhite;
                    Thread.Sleep(tocdo * 40);
                    lb[pos - 1].BackColor = Color.GreenYellow;
                    lb[pos - 1].ForeColor = Color.Black;
                    Thread.Sleep(tocdo * 40);
                }

                sapxep1.diChuyen(ref lb[pos], ref pnt[pos], lb[pos].Location.X, 235 - int.Parse(lb[pos].Text) * 2, ref tocdo);
                Thread.Sleep(tocdo * 40);
            } 

                MessageBox.Show("Dãy đã được sắp xếp!", "Thông báo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grChinh_Enter(object sender, EventArgs e)
        {

        }
    }
}
