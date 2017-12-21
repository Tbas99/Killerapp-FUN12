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
            this.cbResourceType = new System.Windows.Forms.ComboBox();
            this.unavailableDateRangeEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.cbResourceRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbResourceRole.FormattingEnabled = true;
            this.cbResourceRole.Location = new System.Drawing.Point(145, 77);
            this.cbResourceRole.Name = "cbResourceRole";
            this.cbResourceRole.Size = new System.Drawing.Size(100, 21);
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
            this.tbNewResourceRole.Enabled = false;
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
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deployment date:";
            // 
            // availableDateRange
            // 
            this.availableDateRange.CustomFormat = "dd/MM/yyyy";
            this.availableDateRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.availableDateRange.Location = new System.Drawing.Point(15, 133);
            this.availableDateRange.Name = "availableDateRange";
            this.availableDateRange.Size = new System.Drawing.Size(100, 20);
            this.availableDateRange.TabIndex = 9;
            this.availableDateRange.Value = new System.DateTime(2017, 11, 29, 10, 49, 53, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unavailable period:";
            // 
            // unavailableDateRange
            // 
            this.unavailableDateRange.CustomFormat = "dd/MM/yyyy";
            this.unavailableDateRange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.unavailableDateRange.Location = new System.Drawing.Point(15, 211);
            this.unavailableDateRange.Name = "unavailableDateRange";
            this.unavailableDateRange.Size = new System.Drawing.Size(100, 20);
            this.unavailableDateRange.TabIndex = 11;
            this.unavailableDateRange.Value = new System.DateTime(2017, 11, 29, 0, 0, 0, 0);
            // 
            // btCreateResource
            // 
            this.btCreateResource.Location = new System.Drawing.Point(15, 252);
            this.btCreateResource.Name = "btCreateResource";
            this.btCreateResource.Size = new System.Drawing.Size(230, 41);
            this.btCreateResource.TabIndex = 12;
            this.btCreateResource.Text = "Create Resource";
            this.btCreateResource.UseVisualStyleBackColor = true;
            this.btCreateResource.Click += new System.EventHandler(this.btCreateResource_Click);
            // 
            // cbResourceType
            // 
            this.cbResourceType.FormattingEnabled = true;
            this.cbResourceType.Items.AddRange(new object[] {
            "Human",
            "Other"});
            this.cbResourceType.Location = new System.Drawing.Point(15, 26);
            this.cbResourceType.Name = "cbResourceType";
            this.cbResourceType.Size = new System.Drawing.Size(100, 21);
            this.cbResourceType.TabIndex = 13;
            this.cbResourceType.SelectedIndexChanged += new System.EventHandler(this.cbResourceType_SelectedIndexChanged);
            // 
            // unavailableDateRangeEnd
            // 
            this.unavailableDateRangeEnd.CustomFormat = "dd/MM/yyyy";
            this.unavailableDateRangeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.unavailableDateRangeEnd.Location = new System.Drawing.Point(145, 211);
            this.unavailableDateRangeEnd.Name = "unavailableDateRangeEnd";
            this.unavailableDateRangeEnd.Size = new System.Drawing.Size(100, 20);
            this.unavailableDateRangeEnd.TabIndex = 16;
            this.unavailableDateRangeEnd.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "End:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Start:";
            // 
            // ResourceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 305);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unavailableDateRangeEnd);
            this.Controls.Add(this.cbResourceType);
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
            this.Controls.Add(this.label1);
            this.Name = "ResourceMenu";
            this.Text = "Resource Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox cbResourceType;
        private System.Windows.Forms.DateTimePicker unavailableDateRangeEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}