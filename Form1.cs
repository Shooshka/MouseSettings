using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace MouseSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPravsha_Click(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
            if (myKey != null)
            {
                myKey.SetValue("SwapMouseButtons", "0", RegistryValueKind.String);
                myKey.Close();
            }
            MessageBox.Show("Установка настроек для правши выполнена, полностью перезайдите в облако для применения.", "Выполнено.");
            this.Close();
        }

        private void btlLevsha_Click(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse", true);
            if (myKey != null)
            {
                myKey.SetValue("SwapMouseButtons", "1", RegistryValueKind.String);
                myKey.Close();
            }
            MessageBox.Show("Установка настроек для левши выполнена, полностью перезайдите в облако для применения.", "Выполнено.");
            this.Close();
        }
    }
}
