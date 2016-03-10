namespace DesignMode
{
    partial class fmShow
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
            this.btnAdapter = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnFacade = new System.Windows.Forms.Button();
            this.btnFlyweightPattern = new System.Windows.Forms.Button();
            this.btnObserver = new System.Windows.Forms.Button();
            this.btnSimpleFactory = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnStrategy = new System.Windows.Forms.Button();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(34, 37);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(75, 23);
            this.btnAdapter.TabIndex = 0;
            this.btnAdapter.Text = "适配器模式";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(144, 37);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(75, 23);
            this.btnCommand.TabIndex = 1;
            this.btnCommand.Text = "命令模式";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnFacade
            // 
            this.btnFacade.Location = new System.Drawing.Point(258, 37);
            this.btnFacade.Name = "btnFacade";
            this.btnFacade.Size = new System.Drawing.Size(75, 23);
            this.btnFacade.TabIndex = 2;
            this.btnFacade.Text = "门面模式";
            this.btnFacade.UseVisualStyleBackColor = true;
            this.btnFacade.Click += new System.EventHandler(this.btnFacade_Click);
            // 
            // btnFlyweightPattern
            // 
            this.btnFlyweightPattern.Location = new System.Drawing.Point(370, 37);
            this.btnFlyweightPattern.Name = "btnFlyweightPattern";
            this.btnFlyweightPattern.Size = new System.Drawing.Size(75, 23);
            this.btnFlyweightPattern.TabIndex = 3;
            this.btnFlyweightPattern.Text = "享元模式";
            this.btnFlyweightPattern.UseVisualStyleBackColor = true;
            this.btnFlyweightPattern.Click += new System.EventHandler(this.btnFlyweightPattern_Click);
            // 
            // btnObserver
            // 
            this.btnObserver.Location = new System.Drawing.Point(34, 83);
            this.btnObserver.Name = "btnObserver";
            this.btnObserver.Size = new System.Drawing.Size(75, 23);
            this.btnObserver.TabIndex = 4;
            this.btnObserver.Text = "观察者模式";
            this.btnObserver.UseVisualStyleBackColor = true;
            this.btnObserver.Click += new System.EventHandler(this.btnObserver_Click);
            // 
            // btnSimpleFactory
            // 
            this.btnSimpleFactory.Location = new System.Drawing.Point(144, 83);
            this.btnSimpleFactory.Name = "btnSimpleFactory";
            this.btnSimpleFactory.Size = new System.Drawing.Size(85, 23);
            this.btnSimpleFactory.TabIndex = 5;
            this.btnSimpleFactory.Text = "简单工厂模式";
            this.btnSimpleFactory.UseVisualStyleBackColor = true;
            this.btnSimpleFactory.Click += new System.EventHandler(this.btnSimpleFactory_Click);
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(258, 83);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(75, 23);
            this.btnState.TabIndex = 6;
            this.btnState.Text = "状态模式";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnStrategy
            // 
            this.btnStrategy.Location = new System.Drawing.Point(370, 83);
            this.btnStrategy.Name = "btnStrategy";
            this.btnStrategy.Size = new System.Drawing.Size(75, 23);
            this.btnStrategy.TabIndex = 7;
            this.btnStrategy.Text = "策略模式";
            this.btnStrategy.UseVisualStyleBackColor = true;
            this.btnStrategy.Click += new System.EventHandler(this.btnStrategy_Click);
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(34, 131);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnTemplate.TabIndex = 8;
            this.btnTemplate.Text = "模板模式";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // fmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 501);
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.btnStrategy);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnSimpleFactory);
            this.Controls.Add(this.btnObserver);
            this.Controls.Add(this.btnFlyweightPattern);
            this.Controls.Add(this.btnFacade);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.btnAdapter);
            this.Name = "fmShow";
            this.Text = "fmShow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdapter;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button btnFacade;
        private System.Windows.Forms.Button btnFlyweightPattern;
        private System.Windows.Forms.Button btnObserver;
        private System.Windows.Forms.Button btnSimpleFactory;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnStrategy;
        private System.Windows.Forms.Button btnTemplate;
    }
}