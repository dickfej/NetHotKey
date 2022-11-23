using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NetHotKey {

  public class HotKeyManager : Component, ISupportInitialize {

    private MessageWindow _messageWindows;

    private Keys _key;

    private KeyModifiers _modifierKey;

    private string _name;

    private bool _isInit = false;

    private static int _keyId = 0;

    private bool _isRegister = false;

    public Keys Key { get { return _key; } set { _key = value; } }

    [DefaultValue(KeyModifiers.None)]
    public KeyModifiers ModifierKey { get { return _modifierKey; } set { _modifierKey = value; } }
    
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
      HotKeyHelper.RegisterHotKey(_messageWindows.Handle, _keyId, ModifierKey, Key);
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
        if (AutoRegister && !DesignMode) {
          RegisterHotKey();
        }
        _isInit = false;
      }
    }
  }
}

