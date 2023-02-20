using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NetHotKey {

  [Serializable]
  public class HotKey {

    private static int KEYCODE_SHIFT = 16;
    private static int KEYCODE_CTRL = 17;
    private static int KEYCODE_ALT = 18;

    public Keys Key { get; set; }
    [DefaultValue(false)]
    public bool Ctrl { get; set; }
    [DefaultValue(false)]
    public bool Shift { get; set; }
    [DefaultValue(false)]
    public bool Alt { get; set; }
    [DefaultValue(false)]
    public bool WindowsKey { get; set; }

    public static HotKey None { get {
        return new HotKey() { Key = Keys.None,Ctrl = false,Shift = false,Alt = false,WindowsKey = false, };
      }
    }

    public static bool IsNone(HotKey hotkey) {
      return hotkey.Key == Keys.None;
    }

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
      if (Ctrl && (int)Key != KEYCODE_CTRL)
        txt += "Ctrl+";
      if (Alt && (int)Key != KEYCODE_ALT)
        txt += "Alt+";
      if (Shift && (int)Key != KEYCODE_SHIFT)
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
