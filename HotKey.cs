using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NetHotKey {

  [Serializable]
  public class HotKey {
    public Keys Key { get; set; }
    [DefaultValue(false)]
    public bool Ctrl { get; set; }
    [DefaultValue(false)]
    public bool Shift { get; set; }
    [DefaultValue(false)]
    public bool Alt { get; set; }
    [DefaultValue(false)]
    public bool WindowsKey { get; set; }

    public KeyModifiers KeyModifiers {
      get {
        KeyModifiers modifiers = KeyModifiers.None;
        if (Ctrl) { modifiers |= KeyModifiers.Ctrl; }
        if (Shift) { modifiers |= KeyModifiers.Shift; }
        if (Alt) { modifiers |= KeyModifiers.Alt; }
        if (WindowsKey) { modifiers |= KeyModifiers.WindowsKey; }
        return modifiers;
      }
    }

    public override string ToString() {
      string txt = "";
      if (Ctrl && (int)Key != 17)
        txt += "Ctrl+";
      if (Alt && (int)Key != 18)
        txt += "Alt+";
      if (Shift && (int)Key != 16)
        txt += "Shift+";
      switch ((int)Key) {
        case 17:
          txt += "Ctrl";
          break;
        case 18:
          txt += "Alt";
          break;
        case 16:
          txt += "Shift";
          break;
        default:
          txt += Key.ToString();
          break;
      }
      return txt;
    }
  }
}
