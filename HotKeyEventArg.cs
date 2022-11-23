using System;
using System.Windows.Forms;

namespace NetHotKey {
  public class HotKeyEventArgs : EventArgs {
    public Keys Key { get; set; }
    public KeyModifiers KeyModifiersKeyModifiers { get; set; }
    public bool Handled { get; set; }
    public HotKeyEventArgs(Keys key,KeyModifiers nkey) { 
      Key = key;
      KeyModifiersKeyModifiers = nkey;
    }
  }
}
