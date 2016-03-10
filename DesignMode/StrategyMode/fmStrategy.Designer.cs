namespace DesignMode
{
    partial class fmStrategy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn正常收费 = new System.Windows.Forms.Button();
            this.btn满300返100 = new System.Windows.Forms.Button();
            this.btn打8折 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn正常收费
            // 
            this.btn正常收费.Location = new System.Drawing.Point(33, 31);
            this.btn正常收费.Name = "btn正常收费";
            this.btn正常收费.Size = new System.Drawing.Size(78, 24);
            this.btn正常收费.TabIndex = 0;
            this.btn正常收费.Text = "正常收费";
            this.btn正常收费.UseVisualStyleBackColor = true;
            this.btn正常收费.Click += new System.EventHandler(this.btn正常收费_Click);
            // 
            // btn满300返100
            // 
            this.btn满300返100.Location = new System.Drawing.Point(127, 31);
            this.btn满300返100.Name = "btn满300返100";
            this.btn满300返100.Size = new System.Drawing.Size(75, 23);
            this.btn满300返100.TabIndex = 1;
            this.btn满300返100.Text = "满300返100";
            this.btn满300返100.UseVisualStyleBackColor = true;
            this.btn满300返100.Click += new System.EventHandler(this.btn满300返100_Click);
            // 
            // btn打8折
            // 
            this.btn打8折.Location = new System.Drawing.Point(33, 78);
            this.btn打8折.Name = "btn打8折";
            this.btn打8折.Size = new System.Drawing.Size(75, 23);
            this.btn打8折.TabIndex = 2;
            this.btn打8折.Text = "打8折";
            this.btn打8折.UseVisualStyleBackColor = true;
            this.btn打8折.Click += new System.EventHandler(this.btn打8折_Click);
            // 
            // fmStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Controls.Add(this.btn打8折);
            this.Controls.Add(this.btn满300返100);
            this.Controls.Add(this.btn正常收费);
            this.Name = "fmStrategy";
            this.Text = "fmStrategy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn正常收费;
        private System.Windows.Forms.Button btn满300返100;
        private System.Windows.Forms.Button btn打8折;
    }
}