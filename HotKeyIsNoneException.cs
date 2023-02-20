namespace NetHotKey {
  public class HotKeyIsNoneException : HotKeyException {

    public HotKeyIsNoneException(HotKey hotKey) : base("Hotkey is none.",hotKey) {
    }

    public HotKeyIsNoneException(string mesage,HotKey hotKey) : base(hotKey) {
    }

  }
}
