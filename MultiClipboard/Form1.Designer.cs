namespace MultiClipboard
{
    partial class Form1
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
            this.clipboardOneInfo = new System.Windows.Forms.Label();
            this.clipboardTwoInfo = new System.Windows.Forms.Label();
            this.clipboardThreeInfo = new System.Windows.Forms.Label();
            this.clipboardOneObject = new System.Windows.Forms.TextBox();
            this.clipboardTwoObject = new System.Windows.Forms.TextBox();
            this.clipboardThreeObject = new System.Windows.Forms.TextBox();
            this.lastID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clipboardOneInfo
            // 
            this.clipboardOneInfo.AutoSize = true;
            this.clipboardOneInfo.Location = new System.Drawing.Point(43, 49);
            this.clipboardOneInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clipboardOneInfo.Name = "clipboardOneInfo";
            this.clipboardOneInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.clipboardOneInfo.Size = new System.Drawing.Size(63, 23);
            this.clipboardOneInfo.TabIndex = 1;
            this.clipboardOneInfo.Text = "Clipboard 1:";
            // 
            // clipboardTwoInfo
            // 
            this.clipboardTwoInfo.AutoSize = true;
            this.clipboardTwoInfo.Location = new System.Drawing.Point(43, 75);
            this.clipboardTwoInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clipboardTwoInfo.Name = "clipboardTwoInfo";
            this.clipboardTwoInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.clipboardTwoInfo.Size = new System.Drawing.Size(63, 23);
            this.clipboardTwoInfo.TabIndex = 3;
            this.clipboardTwoInfo.Text = "Clipboard 2:";
            // 
            // clipboardThreeInfo
            // 
            this.clipboardThreeInfo.AutoSize = true;
            this.clipboardThreeInfo.Location = new System.Drawing.Point(43, 101);
            this.clipboardThreeInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clipboardThreeInfo.Name = "clipboardThreeInfo";
            this.clipboardThreeInfo.Size = new System.Drawing.Size(63, 13);
            this.clipboardThreeInfo.TabIndex = 4;
            this.clipboardThreeInfo.Text = "Clipboard 3:";
            this.clipboardThreeInfo.Click += new System.EventHandler(this.clipboardThreeInfo_Click);
            // 
            // clipboardOneObject
            // 
            this.clipboardOneObject.Location = new System.Drawing.Point(111, 46);
            this.clipboardOneObject.Name = "clipboardOneObject";
            this.clipboardOneObject.Size = new System.Drawing.Size(360, 20);
            this.clipboardOneObject.TabIndex = 5;
            // 
            // clipboardTwoObject
            // 
            this.clipboardTwoObject.Location = new System.Drawing.Point(111, 72);
            this.clipboardTwoObject.Name = "clipboardTwoObject";
            this.clipboardTwoObject.Size = new System.Drawing.Size(360, 20);
            this.clipboardTwoObject.TabIndex = 6;
            // 
            // clipboardThreeObject
            // 
            this.clipboardThreeObject.Location = new System.Drawing.Point(111, 98);
            this.clipboardThreeObject.Name = "clipboardThreeObject";
            this.clipboardThreeObject.Size = new System.Drawing.Size(360, 20);
            this.clipboardThreeObject.TabIndex = 7;
            // 
            // lastID
            // 
            this.lastID.AutoSize = true;
            this.lastID.Location = new System.Drawing.Point(436, 151);
            this.lastID.Name = "lastID";
            this.lastID.Size = new System.Drawing.Size(0, 13);
            this.lastID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Hotkey Pressed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastID);
            this.Controls.Add(this.clipboardThreeObject);
            this.Controls.Add(this.clipboardTwoObject);
            this.Controls.Add(this.clipboardOneObject);
            this.Controls.Add(this.clipboardThreeInfo);
            this.Controls.Add(this.clipboardTwoInfo);
            this.Controls.Add(this.clipboardOneInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clipboardOneInfo;
        private System.Windows.Forms.Label clipboardTwoInfo;
        private System.Windows.Forms.Label clipboardThreeInfo;
        private System.Windows.Forms.TextBox clipboardOneObject;
        private System.Windows.Forms.TextBox clipboardTwoObject;
        private System.Windows.Forms.TextBox clipboardThreeObject;
        private System.Windows.Forms.Label lastID;
        private System.Windows.Forms.Label label1;
    }
}

