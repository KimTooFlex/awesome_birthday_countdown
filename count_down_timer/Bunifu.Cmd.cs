using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;
namespace Bunifu.Framework.Lib
{
    using System.Diagnostics;
    [DebuggerStepThrough]
    internal static class cmd
   {
     static  System.Diagnostics.Process process1;
       

  internal   static   void EXECUTECMD(string CMD)
       {
           process1 = new System.Diagnostics.Process();
           process1.StartInfo.FileName = "CMD.exe";
           process1.StartInfo.Arguments = "/C " + CMD;
            process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
           process1.Start();
           process1.WaitForExit();
      }


    }

}
