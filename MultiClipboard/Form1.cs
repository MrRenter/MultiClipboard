using System;
using System.Windows.Forms;

namespace MultiClipboard
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Temporarly set to blank to prevent null
        string clipboard1 = "blank"; //Hotkey 0
        string clipboard2 = "blank"; //Hotkey 1
        string clipboard3 = "blank"; //Clipboard Default
        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public Form1()
        {
            InitializeComponent();
            //Second Argument is the Application ID for each key 
            //Third argument is total of keys
            //None = 0, Alt = 1, Control = 2, Shift = 4, WinKey = 8
            RegisterHotKey(this.Handle, 0, 6, Keys.A.GetHashCode());
            RegisterHotKey(this.Handle, 1, 6, Keys.S.GetHashCode());

            clipboard3 = Clipboard.GetText(TextDataFormat.Text);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                lastID.Text = id.ToString();

                clipboard3 = Clipboard.GetText(TextDataFormat.Text);
                //If any other modifier except shift and ctrl are used it messes with the sendkey commands below. The user needs to let go of keys before the sleep command
                //Thread.Sleep(500);
                switch (id)
                {
                    case 0:                     
                        SendKeys.Send("^c");
                        clipboard1 = Clipboard.GetText(TextDataFormat.Text);

                        break;
                    case 1:
                        Clipboard.SetText(clipboard1);
                        SendKeys.Send("^v");
                        break;
                }
                Clipboard.SetText(clipboard3);

                clipboardOneObject.Text = clipboard1;
                clipboardTwoObject.Text = clipboard2;
                clipboardThreeObject.Text = clipboard3;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
