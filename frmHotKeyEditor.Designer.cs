namespace NetHotKey {
  partial class frmHotKeyEditor {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotKeyEditor));
      this.hotKeySettingBox1 = new NetHotKey.HotKeySettingBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // hotKeySettingBox1
      // 
      this.hotKeySettingBox1.HotKey = ((NetHotKey.HotKey)(resources.GetObject("hotKeySettingBox1.HotKey")));
      this.hotKeySettingBox1.Location = new System.Drawing.Point(1, 3);
      this.hotKeySettingBox1.Name = "hotKeySettingBox1";
      this.hotKeySettingBox1.Size = new System.Drawing.Size(222, 24);
      this.hotKeySettingBox1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(230, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "确定";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmHotKeyEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(308, 31);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.hotKeySettingBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmHotKeyEditor";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "frmHotKeyEditor";
      this.Load += new System.EventHandler(this.frmHotKeyEditor_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private HotKeySettingBox hotKeySettingBox1;
    private System.Windows.Forms.Button button1;
  }
}