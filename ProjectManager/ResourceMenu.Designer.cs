namespace ProjectManager
{
    partial class ResourceMenu
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
            this.tbResource = new System.Windows.Forms.TextBox();
            this.tbResourceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbResourceRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewResourceRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.availableDateRange = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.unavailableDateRange = new System.Windows.Forms.DateTimePicker();
            this.btCreateResource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource:";
            // 
            // tbResource
            // 
            this.tbResource.Location = new System.Drawing.Point(15, 26);
            this.tbResource.Name = "tbResource";
            this.tbResource.Size = new System.Drawing.Size(100, 20);
            this.tbResource.TabIndex = 1;
            // 
            // tbResourceName
            // 
            this.tbResourceName.Location = new System.Drawing.Point(15, 76);
            this.tbResourceName.Name = "tbResourceName";
            this.tbResourceName.Size = new System.Drawing.Size(100, 20);
            this.tbResourceName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role:";
            // 
            // cbResourceRole
            // 
            this.cbResourceRole.FormattingEnabled = true;
            this.cbResourceRole.Location = new System.Drawing.Point(145, 77);
            this.cbResourceRole.Name = "cbResourceRole";
            this.cbResourceRole.Size = new System.Drawing.Size(98, 21);
            this.cbResourceRole.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add new role:";
            // 
            // tbNewResourceRole
            // 
            this.tbNewResourceRole.Location = new System.Drawing.Point(145, 26);
            this.tbNewResourceRole.Name = "tbNewResourceRole";
            this.tbNewResourceRole.Size = new System.Drawing.Size(100, 20);
            this.tbNewResourceRole.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available period:";
            // 
            // availableDateRange
            // 
            this.availableDateRange.Location = new System.Drawing.Point(15, 133);
            this.availableDateRange.Name = "availableDateRange";
            this.availableDateRange.Size = new System.Drawing.Size(228, 20);
            this.availableDateRange.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unavailable period:";
            // 
            // unavailableDateRange
            // 
            this.unavailableDateRange.Location = new System.Drawing.Point(15, 190);
            this.unavailableDateRange.Name = "unavailableDateRange";
            this.unavailableDateRange.Size = new System.Drawing.Size(228, 20);
            this.unavailableDateRange.TabIndex = 11;
            // 
            // btCreateResource
            // 
            this.btCreateResource.Location = new System.Drawing.Point(15, 225);
            this.btCreateResource.Name = "btCreateResource";
            this.btCreateResource.Size = new System.Drawing.Size(230, 41);
            this.btCreateResource.TabIndex = 12;
            this.btCreateResource.Text = "Create Resource";
            this.btCreateResource.UseVisualStyleBackColor = true;
            // 
            // ResourceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 278);
            this.Controls.Add(this.btCreateResource);
            this.Controls.Add(this.unavailableDateRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.availableDateRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNewResourceRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbResourceRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResourceName);
            this.Controls.Add(this.tbResource);
            this.Controls.Add(this.label1);
            this.Name = "ResourceMenu";
            this.Text = "Resource Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResource;
        private System.Windows.Forms.TextBox tbResourceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbResourceRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewResourceRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker availableDateRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker unavailableDateRange;
        private System.Windows.Forms.Button btCreateResource;
    }
}