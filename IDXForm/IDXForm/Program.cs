using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;

namespace IDXForm
{
    static class Program
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventid, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (isAssociated())
            {
                SetAssociation(".code", "Dot DeCode", Application.ExecutablePath, "Dot DeCode"); 
            }
            else
            {
               // SetAssociation(".code", "Dot DeCode", Application.ExecutablePath, "Dot DeCode");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (args.Length == 0)
            { 
                Application.Run(new Form1());
            }
            else
            {
                string temp = string.Empty;    
                for(int i =0; i < args.Length;i++)
                {
                    temp += args[i];
                    temp += " ";
                }
                temp = temp.Remove(temp.Length - 1);
                Application.Run(new Form1(temp));
            }
        }


        public static bool isAssociated()
        {
            return (Registry.ClassesRoot.OpenSubKey(".code", false) == null);
        }


        public static void SetAssociation(string Extension, string KeyName, string OpenWith, string FileDescription)
        {
            RegistryKey BaseKey;
            RegistryKey OpenMethod;
            RegistryKey Shell;
            RegistryKey CurrentUser;

            BaseKey = Registry.ClassesRoot.CreateSubKey(Extension);
            BaseKey.SetValue("", KeyName);

            OpenMethod = Registry.ClassesRoot.CreateSubKey(KeyName);
            OpenMethod.SetValue("", FileDescription);
            OpenMethod.CreateSubKey("DefaultIcon").SetValue("", System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\code.png.ico");
            Shell = OpenMethod.CreateSubKey("Shell");
            Shell.CreateSubKey("edit").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            Shell.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            BaseKey.Close();
            OpenMethod.Close();
            Shell.Close();

            CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + Extension, true);
            CurrentUser.DeleteSubKey("UserChoice", false);
            CurrentUser.Close();
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        public static void Associate()
        {
            /*
            RegistryKey FileReg = Registry.ClassesRoot.CreateSubKey(".code");
            RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Dot DeCode.exe");
            //RegistryKey FileReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.code");
            // RegistryKey AppReg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\Dot DeCode.exe");
            //  RegistryKey AssReg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.code");


            string configFile = string.Empty; ;
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            configFile = Path.Combine(appdata, configFile);

            FileReg.CreateSubKey("DefaultIcon").SetValue("", System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)+ "\\code.png.ico");
            

            AppReg.CreateSubKey("shell\\open\\command").SetValue("", "\"" + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Dot DeCode.exe"+"\"%1");
            AppReg.CreateSubKey("DefaultIcon").SetValue("",  System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\code.png.ico");

            //AssReg.CreateSubKey("UserChoice").SetValue("Progid", "Applications\\Dot DeCode.exe");

           // RegistryKey CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + ".code", true);
           // CurrentUser.DeleteSubKey("UserChoice", false);
           // CurrentUser.Close();

            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
            */

            RegistryKey BaseKey;
            RegistryKey OpenMethod;
            RegistryKey Shell;
            RegistryKey CurrentUser;
            string KeyName = "Dot DeCode";
            BaseKey = Registry.ClassesRoot.CreateSubKey(".code");
            string configFile = string.Empty; ;
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            configFile = Path.Combine(appdata, configFile);
            BaseKey.SetValue("",KeyName);

            OpenMethod = Registry.ClassesRoot.CreateSubKey(KeyName);
            OpenMethod.SetValue("", "CoDe File");
            OpenMethod.CreateSubKey("DefaultIcon").SetValue("", System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\code.png.ico");
            Shell = OpenMethod.CreateSubKey("Shell");
            Shell.CreateSubKey("edit").CreateSubKey("command").SetValue("", "\"" + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Dot DeCode.exe" + "\"%1");
            Shell.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Dot DeCode.exe" + "\"%1");
            BaseKey.Close();
            OpenMethod.Close();
            Shell.Close();

            /*
            CurrentUser = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + ".code", true);
            CurrentUser.DeleteSubKey("UserChoice", false);
            CurrentUser.Close();
            */

            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);



        }


    }
}
