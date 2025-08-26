namespace QueuingForm
{
    partial class CashierWindowQueueForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listCashierQueue = new System.Windows.Forms.ListView();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(12, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // listCashierQueue
            // 
            this.listCashierQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listCashierQueue.HideSelection = false;
            this.listCashierQueue.Location = new System.Drawing.Point(173, 22);
            this.listCashierQueue.Name = "listCashierQueue";
            this.listCashierQueue.Size = new System.Drawing.Size(342, 525);
            this.listCashierQueue.TabIndex = 1;
            this.listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(12, 75);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 47);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // CashierWindowQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(527, 559);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.listCashierQueue);
            this.Controls.Add(this.btnRefresh);
            this.Name = "CashierWindowQueueForm";
            this.Text = "CashierWindowQueueForm";
            this.Load += new System.EventHandler(this.CashierWindowQueueForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listCashierQueue;
        private System.Windows.Forms.Button btnNext;
    }
}