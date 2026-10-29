using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows Forms 的視覺樣式與預設文字呈現方式。
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 啟動貸款資格審核表單。
            Application.Run(new Form1());
        }
    }
}
