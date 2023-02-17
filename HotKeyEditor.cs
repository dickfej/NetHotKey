using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace NetHotKey {
  internal class HotKeyEditor: UITypeEditor {

    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
      return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
      using (frmHotKeyEditor frm = new frmHotKeyEditor()) { 
        if(value != null) { frm.HotKey = (HotKey)value; }
        if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          value= frm.HotKey;
          return value;
        }
      }
      return base.EditValue(context, provider, value);
    }
  }
}
