using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace NetHotKey {

  public class HotKeyManager : Component, ISupportInitialize {

    private int ERR_HOT_KEY_ALL_ALREADY_IN_USE = 1409;

    private MessageWindow _messageWindows;

    private HotKey _hotKey = HotKey.None;

    private bool _isInit = false;

    private static int _keyId = 0;

    private bool _isRegister = false;

    [Editor(typeof(HotKeyEditor),typeof(UITypeEditor))]
    public HotKey HotKey { get { return _hotKey; } set { _hotKey = value; } }

    [DefaultValue(false)]
    public bool AutoRegister { get; set; }

    public event EventHandler<HotKeyEventArgs> HotKeyActive { add { _messageWindows.HotKeyActive += value; } remove { _messageWindows.HotKeyActive -= value; } }

    public void CleanHotKey() {
      HotKey = HotKey.None;
      UnRegisterHotKey();
    }

    public HotKeyManager() {
      _messageWindows = new MessageWindow();
      _keyId++;
      _messageWindows.KeyId = _keyId;
      _messageWindows.HandleDestroyed += _messageWindows_HandleDestroyed;
      AutoRegister= false;
    }

    private void _messageWindows_HandleDestroyed(object sender, EventArgs e) {
      UnRegisterHotKey();
    }

    public void RegisterHotKey() {
      if(!HotKey.IsNone(HotKey)) {
        if(HotKeyHelper.RegisterHotKey(_messageWindows.Handle, _keyId, HotKey.KeyModifiers, HotKey.Key))
        _isRegister = true;
        else {
          int errCode =  Marshal.GetLastWin32Error();
          if (errCode == ERR_HOT_KEY_ALL_ALREADY_IN_USE)
            throw new HotAlreadyRegisteredException(HotKey);
        }
      } else {
        throw new HotKeyIsNoneException(HotKey);
      }
    }

    public void UnRegisterHotKey() {
      HotKeyHelper.UnregisterHotKey(_messageWindows.Handle, _keyId);
      _isRegister = false;
    }

    protected override void Dispose(bool disposing) {
      if (_isRegister) { UnRegisterHotKey(); }
      base.Dispose(disposing);
    }

    void ISupportInitialize.BeginInit() {
      _isInit = true;
    }

    void ISupportInitialize.EndInit() {
      if (_isInit) {
        if (AutoRegister && !DesignMode)
          RegisterHotKey();
        _isInit = false;
      }
    }
  }
}

