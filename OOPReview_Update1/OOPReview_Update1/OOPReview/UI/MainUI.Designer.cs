namespace OOPReview.UI
{
    partial class MainUI
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
            this.createDepartmentButton = new System.Windows.Forms.Button();
            this.createHeadButton = new System.Windows.Forms.Button();
            this.createCourseButton = new System.Windows.Forms.Button();
            this.showReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDepartmentButton
            // 
            this.createDepartmentButton.Location = new System.Drawing.Point(94, 38);
            this.createDepartmentButton.Name = "createDepartmentButton";
            this.createDepartmentButton.Size = new System.Drawing.Size(195, 23);
            this.createDepartmentButton.TabIndex = 0;
            this.createDepartmentButton.Text = "Create New Department";
            this.createDepartmentButton.UseVisualStyleBackColor = true;
            this.createDepartmentButton.Click += new System.EventHandler(this.createDepartmentButton_Click);
            // 
            // createHeadButton
            // 
            this.createHeadButton.Location = new System.Drawing.Point(94, 77);
            this.createHeadButton.Name = "createHeadButton";
            this.createHeadButton.Size = new System.Drawing.Size(195, 23);
            this.createHeadButton.TabIndex = 1;
            this.createHeadButton.Text = "Create New Departmental Head";
            this.createHeadButton.UseVisualStyleBackColor = true;
            this.createHeadButton.Click += new System.EventHandler(this.createHeadButton_Click);
            // 
            // createCourseButton
            // 
            this.createCourseButton.Location = new System.Drawing.Point(94, 107);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(195, 23);
            this.createCourseButton.TabIndex = 2;
            this.createCourseButton.Text = "Create Course";
            this.createCourseButton.UseVisualStyleBackColor = true;
            this.createCourseButton.Click += new System.EventHandler(this.createCourseButton_Click);
            // 
            // showReportButton
            // 
            this.showReportButton.Location = new System.Drawing.Point(94, 149);
            this.showReportButton.Name = "showReportButton";
            this.showReportButton.Size = new System.Drawing.Size(195, 23);
            this.showReportButton.TabIndex = 3;
            this.showReportButton.Text = "Show Report";
            this.showReportButton.UseVisualStyleBackColor = true;
            this.showReportButton.Click += new System.EventHandler(this.showReportButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.showReportButton);
            this.Controls.Add(this.createCourseButton);
            this.Controls.Add(this.createHeadButton);
            this.Controls.Add(this.createDepartmentButton);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createDepartmentButton;
        private System.Windows.Forms.Button createHeadButton;
        private System.Windows.Forms.Button createCourseButton;
        private System.Windows.Forms.Button showReportButton;
    }
}