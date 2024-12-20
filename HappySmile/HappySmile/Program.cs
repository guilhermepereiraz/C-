﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappySmile
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.MontarStringConexao();
            frmLogin frm = new frmLogin();           
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK) 
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
