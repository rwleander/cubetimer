
namespace cubeTimer
{
    partial class mainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.lblScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(650, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvData
            // 
            this.lvData.FullRowSelect = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(35, 105);
            this.lvData.MultiSelect = false;
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(730, 255);
            this.lvData.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvData.TabIndex = 2;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(35, 85);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(65, 13);
            this.lblScores.TabIndex = 3;
            this.lblScores.Text = "Top Scores:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cube Timer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Label lblScores;
    }
}

