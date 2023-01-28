using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Dùng để xử lí file

namespace CuoiKy_ProjectSort
{
    public partial class frm_Main : Form
    {
        // Sinh viên: Trương Minh Triều - 21110326

        // khai báo mảng 1 chiều lưu dữ liệu của dãy số cần sắp xếp
        int nArr = 0;
        int[] arr = new int[10000];

        // khai báo 2 input cuối cùng dùng hiện thị ra màn hình
        int[] output;
        string outputFinal;

        // khai báo chuỗi string lưu quá trình sắp xếp
        string strQuaTrinh;
        //public string UpdateQtr {
        //    set { strQtr = value; }
        //    get { return strQtr; }
        //}

        public frm_Main(string strName)
        {
            InitializeComponent();
            lb_name.Text = strName;
        }

        private void btn_sort_Click(object sender, EventArgs e)
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

            // gọi đến method sắp xếp
            sapXepDuLieu();
        }

        private void xuLyDuLieuNhapVao()
        {
            // xử lý dữ liệu nhập vào text box từ string chuyển về mảng 1 chiều
            string input = tbx_input.Text;
            string[] arrStr = input.Split(' ');
            nArr = arrStr.Length;

            for (int i = 0; i < nArr; i++)
            {
                string temp = arrStr[i];
                arr[i] = Convert.ToInt32(temp);
            }
        }

        private void sapXepDuLieu()
        {
            if (lb_name.Text == "Interchange Sort")
            {
                output = InterchangeSort.interchangeSort(arr, nArr);
                strQuaTrinh = InterchangeSort.getQuaTrinh();
            }
            else if (lb_name.Text == "Selection Sort")
            {
                output = SelectionSort.selectionSort(arr, nArr);
                strQuaTrinh = SelectionSort.getQuaTrinh();
            }
            else if (lb_name.Text == "Bubble Sort")
            {
                output = BubbleSort.bubbleSort(arr, nArr);
                strQuaTrinh = BubbleSort.getQuaTrinh();
            }
            else if (lb_name.Text == "Insertion Sort")
            {
                output = InsertionSort.insertionSort(arr, nArr);
                strQuaTrinh = InsertionSort.getQuaTrinh();
            }

            for (int i = 0; i < nArr; i++)
            {
                int temp = output[i];
                outputFinal += Convert.ToString(temp) + " ";
            }
            outputFinal += $"\r\n\r\n\r\nQuá trình chạy từng bước của thuật toán: {lb_name.Text}" + strQuaTrinh;
            tbx_output.Text = outputFinal;
            
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            // Ghi kết quả vào file
            File.WriteAllText("OutputSort.txt", outputFinal);

            MessageBox.Show("Xuất dữ liệu và tải về thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
