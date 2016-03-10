using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesignMode
{
    static class Program
    {
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (CheckRunning())
            //{//如果已启动，则返回
            //    return;
            //}
            //CloseRunner();

            string abc = "1,2,3,4,5,6,7,8,9,10";


            float a = 1.03f;
            decimal b = Convert.ToDecimal(a);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmShow());
        }

        /// <summary>
        /// 关闭加载程序，如果有的话
        /// </summary>
        private static void CloseRunner()
        {
            try
            {
                System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcesses();
                for (int k = 0; k < process.Length; k++)
                {
                    if ((process[k].ProcessName.ToString().ToUpper() == "名称"))
                    {//是启动进程，则关闭
                        process[k].Kill();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 自我启动检测，保证只启动一个应用  
        /// </summary>
        private static bool CheckRunning()
        {
            string productName = "名称";
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcesses();
            int id = System.Diagnostics.Process.GetCurrentProcess().Id;//当前进程ID
            for (int k = 0; k < process.Length; k++)
            {
                if (process[k].Id != id && (process[k].ProcessName.ToString().ToUpper() == "进程名称" || process[k].MainWindowTitle == productName))
                {//不是本进程，且主窗体名称与本进程窗体名称相同，则视为程序已启动过
                    if (process[k].MainWindowTitle == "登录" || process[k].MainWindowTitle == "注销")
                    {//登录窗口正常显示
                        ShowWindowAsync(process[k].MainWindowHandle, 1); //调用api函数，最大化显示窗口,1为正常显示. 
                    }
                    else
                    {
                        ShowWindowAsync(process[k].MainWindowHandle, 3); //调用api函数，最大化显示窗口,1为正常显示. 
                    }
                    SetForegroundWindow(process[k].MainWindowHandle); //将窗口放置最前端。 
                    return true;
                }
            }
            return false;
        }

    }
}
