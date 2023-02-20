using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace NetHotKey {
  public partial class HotKeySettingBox : TextBox {

    private HotKey _hotKey =HotKey.None;

    [Editor(typeof(HotKeyEditor), typeof(UITypeEditor))]
    public HotKey HotKey { get { return _hotKey; } set { 
        if(value!= null) {
          _hotKey = value;
          Text = _hotKey.ToString();
        }
      } 
    }

    private void txtBox_KeyDown(object sender, KeyEventArgs e) {
      HotKey = HotKeyHelper.KeyEventArgs2HotKeySetting(e);
    }

    protected override void OnKeyDown(KeyEventArgs e) {
      HotKey = HotKeyHelper.KeyEventArgs2HotKeySetting(e);
    }

    protected override void OnTextChanged(EventArgs e) {
      Text = _hotKey.ToString() ;
    }
    public void CleanHotKey() {
      HotKey = HotKey.None;
    }
  }

}
