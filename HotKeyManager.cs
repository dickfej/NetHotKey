using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace NetHotKey {

  public class HotKeyManager : Component, ISupportInitialize {

    private MessageWindow _messageWindows;

    private HotKey _hotKey = new HotKey();

    private bool _isInit = false;

    private static int _keyId = 0;

    private bool _isRegister = false;

    [Editor(typeof(HotKeyEditor),typeof(UITypeEditor))]
    public HotKey HotKey { get { return _hotKey; } set { _hotKey = value; } }

    [DefaultValue(false)]
    public bool AutoRegister { get; set; }

    public event EventHandler<HotKeyEventArgs> HotKeyActive { add { _messageWindows.HotKeyActive += value; } remove { _messageWindows.HotKeyActive -= value; } }

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
      HotKeyHelper.RegisterHotKey(_messageWindows.Handle, _keyId, HotKey.KeyModifiers, HotKey.Key);
      _isRegister = true;
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

