﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_8
{
    internal static class Program
    {
        public static Base_Form Main_Form;    
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_Form = new Base_Form();
            Application.Run(Main_Form);
        }
        //public System.Data.SqlClient.SqlConnection connect;
        
    }
}
