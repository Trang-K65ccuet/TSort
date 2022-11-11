using System;
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
    //Tạo lớp sapXep kế thừa lớp Form1
    class sapXep: Form1
    {
        //Đối với thêm tự động
        //Khởi tạo nhãn nhan có tọa độ toado, giá trị ngẫu nhiên rd và vị trí i
        public void khoiTaoNhan(ref Label nhan, ref Point toado, ref Random rd, int i)
        {
            toado = new Point(); //Khởi tạo 1 điểm
            nhan = new Label(); //Khởi tạo nhãn
            nhan.Name = "lb" + i.ToString(); //Đặt tên cho nhãn
            nhan.Text = rd.Next(0, 99).ToString(); //gán giá trị cho nhãn
            toado.X = i * 60; //Hoành độ điểm
            toado.Y = 235 - int.Parse(nhan.Text) * 2; //Tung độ điểm
            nhan.Location = toado; //Đặt vị trí cho nhãn là điểm vừa tạo
            nhan.Size = new System.Drawing.Size(40, 20 + int.Parse(nhan.Text) * 2); //Kích thước nhãn
            nhan.BorderStyle = BorderStyle.FixedSingle; //Tạo đường viền cho nhãn
            nhan.BackColor = Color.White; //Màu nền nhãn;
            nhan.ForeColor = Color.Black; //Màu nội dung nhãn
            nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        //Đối với thêm thủ công, nhận giá trị là giá trị nhập vào giatri
        public void khoiTaoNhan(ref Label nhan, ref Point toado, string giatri, int i)
        {
            toado = new Point(); //Khởi tạo 1 điểm
            nhan = new Label(); //Khởi tạo nhãn
            nhan.Name = "lb" + i.ToString(); //Đặt tên cho nhãn
            nhan.Text = giatri; //gán giá trị cho nhãn
            toado.X = i * 60; //Hoành độ điểm
            toado.Y = 235 - int.Parse(nhan.Text) * 2; //Tung độ điểm
            nhan.Location = toado; //Đặt vị trí cho nhãn là điểm vừa tạo
            nhan.Size = new System.Drawing.Size(40, 20 + int.Parse(giatri) * 2); //Kích thước nhãn
            nhan.BorderStyle = BorderStyle.FixedSingle; //Tạo đường viền cho nhãn
            nhan.BackColor = Color.White; //Màu nền nhãn;
            nhan.ForeColor = Color.Black; //Màu nội dung nhãn
            nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        //Đảo vị trí 2 điểm (Point)
        public void daoDiem(ref Point diem1, ref Point diem2)
        {
            Point tmp_diem = new Point();
            tmp_diem = diem1;
            diem1 = diem2;
            diem2 = tmp_diem;
        }

        //Đảo vị trí 2 nhãn(label)
        public void daoNhan(ref Label nhan1, ref Label nhan2)
        {
            Label tmp_nhan = new Label();
            tmp_nhan = nhan1;
            nhan1 = nhan2;
            nhan2 = tmp_nhan;
        }

        //Mô phỏng đảo nhãn với tốc độ tocdo
        public void moPhongDaoNhan(ref Label nhan1, ref Label nhan2, ref Point diem1, ref Point diem2, ref int tocdo)
        {
            int x1 = nhan1.Location.X;
            int x2 = nhan2.Location.X;
            int y = nhan1.Location.Y;
            nhan1.BackColor = Color.Yellow;
            nhan2.BackColor = Color.Yellow;
            nhan1.ForeColor = Color.Black;
            nhan2.ForeColor = Color.Black;

            if(nhan1.Location.X < nhan2.Location.X)
            {
                while(nhan1.Location.X < x2 && nhan2.Location.X > x1)
                {
                    Thread.Sleep(tocdo);
                    diem1.X++;
                    diem2.X--;
                    nhan1.Location = diem1;
                    nhan2.Location = diem2;
                }
            }
            else
            {
                while (nhan1.Location.X > x2 && nhan2.Location.X < x1)
                {
                    Thread.Sleep(tocdo);
                    diem1.X--;
                    diem2.X++;
                    nhan1.Location = diem1;
                    nhan2.Location = diem2;
                }
            }

            //Đặt lại màu ban đầu
            nhan1.BackColor = Color.Yellow;
            nhan2.BackColor = Color.Yellow;
            nhan1.ForeColor = Color.Black;
            nhan2.ForeColor = Color.Black;
        }

        //Di chuyển nhãn nhan có tọa độ toado đến điểm(x,y) với tốc độ tocdo
        public void diChuyen(ref Label nhan, ref Point toado, int x, int y, ref int tocdo)
        {

            //Lên
            if(toado.X == x && toado.Y > y)
            {
                //Màu nhãn khi di chuyển
                nhan.BackColor = Color.IndianRed;
                nhan.ForeColor = Color.WhiteSmoke;
                while (nhan.Location.Y > y)
                {
                    Thread.Sleep(tocdo);
                    toado.Y--;
                    nhan.Location = toado;
                }
            }

            //Xuống
            else if (toado.X == x && toado.Y < y)
            {
                //Màu nhãn khi di chuyển
                nhan.BackColor = Color.IndianRed;
                nhan.ForeColor = Color.WhiteSmoke;
                while (nhan.Location.Y < y)
                {
                    Thread.Sleep(tocdo);
                    toado.Y++;
                    nhan.Location = toado;
                }
            }

            //Sang trái
            else if (toado.Y == y && toado.X > x)
            {
                //Màu nhãn khi di chuyển
                nhan.BackColor = Color.IndianRed;
                nhan.ForeColor = Color.WhiteSmoke;
                while (nhan.Location.X > x)
                {
                    Thread.Sleep(tocdo);
                    toado.X--;
                    nhan.Location = toado;
                }
            }

            //Sang phải
            else if (toado.Y == y && toado.X < x)
            {
                //Màu nhãn khi di chuyển
                nhan.BackColor = Color.Yellow;
                nhan.ForeColor = Color.Black;
                while (nhan.Location.X < x)
                {
                    Thread.Sleep(tocdo);
                    toado.X++;
                    nhan.Location = toado;
                }
            }

            //Đặt lại màu cho nhãn sau khi di chuyển kết thúc
            nhan.BackColor = Color.GreenYellow;
            nhan.ForeColor = Color.Black;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // grChinh
            // 
            this.grChinh.Size = new System.Drawing.Size(1495, 600);
            this.grChinh.Enter += new System.EventHandler(this.grChinh_Enter);
            // 
            // sapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1507, 876);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "sapXep";
            this.ResumeLayout(false);

        }

        private void grChinh_Enter(object sender, EventArgs e)
        {

        }
    }
}
