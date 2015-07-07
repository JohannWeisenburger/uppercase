using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace upperscape
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            chkBoxHistory.Checked = false;
            btn_convert.BackColor = Color.FromArgb(235, 235, 235);
        }

        //Text to clipboard
        private void ToClipboard(string text)
        {
            System.Windows.Forms.Clipboard.SetDataObject(text, true);
        }

        //Text from clipboard
        private string ReadFromClipboard()
        {
            //Gibt den Inhalt aus dem Clipboard zurück

            string strTextFromClipboard = "";
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.UnicodeText))
            {
                string strChar = (String)iData.GetData(DataFormats.UnicodeText);
                strTextFromClipboard = strChar;
            }
            return strTextFromClipboard;
        }

        private void ConvertToUpper(string text)
        {
            //check if content in clipboard is text
            if (text == "")
            {
                text = "EMPTY";
            }

            //Add Text to ListView
            ListViewItem item = new ListViewItem();
            item.Text = DateTime.Now.ToShortTimeString();
            item.SubItems.Add(text);
            ViewHistory.Items.Insert(0, item);

            ToClipboard(text.ToUpper());

        }

        private void chkBoxHistory_CheckStateChanged(object sender, EventArgs e)
        {
            //History enabled
            if (chkBoxHistory.Checked == true)
            {
                this.Size = new Size(651, 477);
            }
            //History disabled
            else
            {
                this.Size = new Size(288, 143);
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            ConvertToUpper(ReadFromClipboard());
        }

        private void ViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string text = "";
            text = ViewHistory.SelectedItems[0].SubItems[1].Text;
            ToClipboard(text);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = Convert.ToString("v" + version.Major + "." + version.Minor);
        }
    }
}
