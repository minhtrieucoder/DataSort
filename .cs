using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_ProjectSort
{
    public partial class frm_interchange : Form
    {
        // Sinh viên: Trương Minh Triều - 21110326

        // khai báo mảng 1 chiều lưu dữ liệu của dãy số cần sắp xếp
        int nArr = 0;
        int[] arr = new int[10000];

        public frm_interchange()
        {
            InitializeComponent();
        }

        private void btn_sortInterchange_Click(object sender, EventArgs e)
        {
            // xử lý dữ liệu nhập vào text box thành dữ liệu chuẩn 
            xuLyDuLieuNhapVao();

            // hiện dữ liệu đã xử lý ra màn hình để kiểm tra
            string outputKiemTra = "Số lượng số: " + nArr.ToString() + "\n" + "Dãy số vừa nhập: ";
            for (int i = 0; i < nArr; i++)
            {
                outputKiemTra += arr[i].ToString() + " ";
            }

            MessageBox.Show(outputKiemTra, "Dữ liệu bạn đã nhập là:",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xuLyDuLieuNhapVao()
        {
            // lấy số lượng số trong dãy số cần sắp xếp từ dữ liệu nhập vào
            //nArr = Convert.ToInt32(tbx_countNumber.Text);

            // xử lý dữ liệu nhập vào text box từ string chuyển về mảng 1 chiều
            string input = tbx_inputInterchange.Text;
            string[] arrStr = input.Split(' ');
            nArr = arrStr.Length;

            for (int i = 0; i < nArr; i++)
            {
                    string temp = arrStr[i];
                    arr[i] = Convert.ToInt32(temp);
            }
        }
    }
}
