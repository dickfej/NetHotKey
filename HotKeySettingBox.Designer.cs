namespace NetHotKey {
  partial class HotKeySettingBox {
    /// <summary> 
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region 组件设计器生成的代码

    /// <summary> 
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.txtBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtBox
      // 
      this.txtBox.BackColor = System.Drawing.SystemColors.Window;
      this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtBox.Location = new System.Drawing.Point(0, 0);
      this.txtBox.Name = "txtBox";
      this.txtBox.ReadOnly = true;
      this.txtBox.Size = new System.Drawing.Size(117, 25);
      this.txtBox.TabIndex = 0;
      this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
      // 
      // HotKeySettingBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtBox);
      this.Name = "HotKeySettingBox";
      this.Size = new System.Drawing.Size(117, 24);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBox;
  }
}
