using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetHotKey {
  public class HotAlreadyRegisteredException : HotKeyException {

    public HotAlreadyRegisteredException(HotKey hotKey) : base("Hotkey already in used.",hotKey) {
    }

    public HotAlreadyRegisteredException(string mesage,HotKey hotKey) : base(hotKey) {
    }

  }
}
