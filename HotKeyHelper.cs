using System;
using System.Windows.Forms;
namespace NetHotKey {

  internal static class HotKeyHelper {

    public const int WM_HOTKEY = 0x0312;

    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    public static extern bool RegisterHotKey(IntPtr hWnd,                //要定义热键的窗口的句柄
                 int id,                     //定义热键ID（不能与其它ID重复）
                  KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
                  Keys vk                     //定义热键的内容
                  );
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    public static extern bool UnregisterHotKey(
                 IntPtr hWnd,                //要取消热键的窗口的句柄
                 int id                      //要取消热键的ID
                 );

    public static HotKey KeyEventArgs2HotKeySetting(KeyEventArgs e) {
      return new HotKey() { Ctrl = e.Control, Alt = e.Alt, Shift = e.Shift, Key = e.KeyCode };
    }

  }

  [Flags()]
  public enum KeyModifiers {
    None = 0,
    Alt = 1,
    Ctrl = 2,
    Shift = 4,
    WindowsKey = 8
  }
}