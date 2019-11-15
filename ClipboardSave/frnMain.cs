using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardTest;

namespace ClipboardSave
{
    public partial class frnMain : Form
    {
        public frnMain()
        {
            InitializeComponent();
        }

        private void btnGetClip_Click(object sender, EventArgs e)
        {
            foreach (string source in Clipboard.GetFileDropList())
            {
                File.Copy(source, @"D:\temp\" + Path.GetFileName(source));
            }
        }
    }
}
