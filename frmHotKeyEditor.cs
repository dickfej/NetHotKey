using System;
using System.Windows.Forms;

namespace NetHotKey {

  public partial class frmHotKeyEditor : Form {


    public HotKey HotKey { get { return hotKeySettingBox1.HotKey; } set { hotKeySettingBox1.HotKey = value; }}

    public frmHotKeyEditor() {
      InitializeComponent();
    }

    private void frmHotKeyEditor_Load(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

  }
}
