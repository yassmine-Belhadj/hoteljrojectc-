using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
#pragma warning disable IDE0051 // Supprimer les membres privés non utilisés
         static void Main()
         {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new chargement());
         }
    }
    }

