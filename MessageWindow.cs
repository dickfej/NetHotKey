using System;
using System.Windows.Forms;

namespace NetHotKey {

  internal class MessageWindow : ContainerControl {

    public int KeyId { get; set; }

    internal Keys Key { get; set; }

    internal KeyModifiers KeyModifiers { get; set; }

    internal EventHandler<HotKeyEventArgs> HotKeyActive;

    protected override void WndProc(ref Message m) {
      if (m.Msg == HotKeyHelper.WM_HOTKEY) {
        if (m.WParam.ToInt32() == (Int32)KeyId) {
          HotKeyEventArgs e = new HotKeyEventArgs(Key,KeyModifiers);
          HotKeyActive(this, e);
          if(e.Handled) { return; }
        }
      }
      base.WndProc(ref m);
    }
        protected override void DestroyHandle() {
            base.DestroyHandle();
        }
    }

}
