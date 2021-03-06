﻿namespace ProjectManager
{
    partial class TaskMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.tbTaskDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTaskPhase = new System.Windows.Forms.ComboBox();
            this.deadlineDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btCreateTask = new System.Windows.Forms.Button();
            this.showDeadline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task details:";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(12, 38);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(100, 20);
            this.tbTaskName.TabIndex = 2;
            // 
            // tbTaskDetails
            // 
            this.tbTaskDetails.Location = new System.Drawing.Point(12, 174);
            this.tbTaskDetails.Multiline = true;
            this.tbTaskDetails.Name = "tbTaskDetails";
            this.tbTaskDetails.Size = new System.Drawing.Size(230, 66);
            this.tbTaskDetails.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phase:";
            // 
            // cbTaskPhase
            // 
            this.cbTaskPhase.FormattingEnabled = true;
            this.cbTaskPhase.Location = new System.Drawing.Point(135, 37);
            this.cbTaskPhase.Name = "cbTaskPhase";
            this.cbTaskPhase.Size = new System.Drawing.Size(106, 21);
            this.cbTaskPhase.TabIndex = 5;
            // 
            // deadlineDate
            // 
            this.deadlineDate.CustomFormat = "dd/MM/yyyy";
            this.deadlineDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadlineDate.Location = new System.Drawing.Point(12, 123);
            this.deadlineDate.Name = "deadlineDate";
            this.deadlineDate.Size = new System.Drawing.Size(100, 20);
            this.deadlineDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deadline:";
            // 
            // btCreateTask
            // 
            this.btCreateTask.Location = new System.Drawing.Point(12, 256);
            this.btCreateTask.Name = "btCreateTask";
            this.btCreateTask.Size = new System.Drawing.Size(230, 41);
            this.btCreateTask.TabIndex = 8;
            this.btCreateTask.Text = "Create Task";
            this.btCreateTask.UseVisualStyleBackColor = true;
            this.btCreateTask.Click += new System.EventHandler(this.btCreateTask_Click);
            // 
            // showDeadline
            // 
            this.showDeadline.AutoSize = true;
            this.showDeadline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDeadline.Location = new System.Drawing.Point(12, 78);
            this.showDeadline.Name = "showDeadline";
            this.showDeadline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showDeadline.Size = new System.Drawing.Size(87, 17);
            this.showDeadline.TabIndex = 9;
            this.showDeadline.Text = "Time-limited?";
            this.showDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showDeadline.UseVisualStyleBackColor = true;
            this.showDeadline.CheckedChanged += new System.EventHandler(this.showDeadline_CheckedChanged);
            // 
            // TaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 307);
            this.Controls.Add(this.showDeadline);
            this.Controls.Add(this.btCreateTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deadlineDate);
            this.Controls.Add(this.cbTaskPhase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTaskDetails);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskMenu";
            this.Text = "Task Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbTaskDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTaskPhase;
        private System.Windows.Forms.DateTimePicker deadlineDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCreateTask;
        private System.Windows.Forms.CheckBox showDeadline;
    }
}