using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace NetHotKey {
  public partial class HotKeySettingBox : UserControl {

    private HotKey _hotKey = new HotKey();

    [Editor(typeof(HotKeyEditor), typeof(UITypeEditor))]
    public HotKey HotKey { get { return _hotKey; } set { 
        if(value!= null) {
          _hotKey = value;
          txtBox.Text = _hotKey.ToString();
        }
      } 
    }

    public HotKeySettingBox() {
      InitializeComponent();
      txtBox.BackColor = System.Drawing.SystemColors.Window;
    }

    private void txtBox_KeyDown(object sender, KeyEventArgs e) {
      HotKey = HotKeyHelper.KeyEventArgs2HotKeySetting(e);
    }
  }

}
