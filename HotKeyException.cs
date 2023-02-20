using System;

namespace NetHotKey {
  public class HotKeyException:Exception {
    
    public HotKey HotKey { get;}

    public HotKeyException(HotKey hotKey) {
      HotKey = hotKey;
    }
    public HotKeyException(string message,HotKey hotKey):base(message) {
      HotKey = hotKey;
    }
  }
}
