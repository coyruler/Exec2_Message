namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGreet1 = new System.Windows.Forms.Button();
            this.lblGreeting1 = new System.Windows.Forms.Label();
            this.btnGreet2 = new System.Windows.Forms.Button();
            this.lblGreeting2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGreet1
            // 
            this.btnGreet1.Location = new System.Drawing.Point(66, 12);
            this.btnGreet1.Name = "btnGreet1";
            this.btnGreet1.Size = new System.Drawing.Size(75, 23);
            this.btnGreet1.TabIndex = 0;
            this.btnGreet1.Text = "你好";
            this.btnGreet1.UseVisualStyleBackColor = true;
            this.btnGreet1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGreeting1
            // 
            this.lblGreeting1.AutoSize = true;
            this.lblGreeting1.Location = new System.Drawing.Point(173, 17);
            this.lblGreeting1.Name = "lblGreeting1";
            this.lblGreeting1.Size = new System.Drawing.Size(33, 12);
            this.lblGreeting1.TabIndex = 1;
            this.lblGreeting1.Text = "label1";
            // 
            // btnGreet2
            // 
            this.btnGreet2.Location = new System.Drawing.Point(66, 87);
            this.btnGreet2.Name = "btnGreet2";
            this.btnGreet2.Size = new System.Drawing.Size(75, 23);
            this.btnGreet2.TabIndex = 2;
            this.btnGreet2.Text = "你好";
            this.btnGreet2.UseVisualStyleBackColor = true;
            this.btnGreet2.Click += new System.EventHandler(this.btnGreet2_Click);
            // 
            // lblGreeting2
            // 
            this.lblGreeting2.AutoSize = true;
            this.lblGreeting2.Location = new System.Drawing.Point(173, 92);
            this.lblGreeting2.Name = "lblGreeting2";
            this.lblGreeting2.Size = new System.Drawing.Size(33, 12);
            this.lblGreeting2.TabIndex = 3;
            this.lblGreeting2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 535);
            this.Controls.Add(this.lblGreeting2);
            this.Controls.Add(this.btnGreet2);
            this.Controls.Add(this.lblGreeting1);
            this.Controls.Add(this.btnGreet1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGreet1;
        private System.Windows.Forms.Label lblGreeting1;
        private System.Windows.Forms.Button btnGreet2;
        private System.Windows.Forms.Label lblGreeting2;
    }
}

