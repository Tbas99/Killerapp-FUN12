namespace ProjectManager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToGoogleCalendarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskCreationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceCreationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbProjectTasksResources = new System.Windows.Forms.ListBox();
            this.projectManagerDataDataSet = new ProjectManager.ProjectManagerDataDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.projectManagerDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTaskDetails = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1183, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.syncToGoogleCalendarsToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem2.Text = "New";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem13.Text = "Agile";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem14.Text = "Waterfall";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // syncToGoogleCalendarsToolStripMenuItem
            // 
            this.syncToGoogleCalendarsToolStripMenuItem.Name = "syncToGoogleCalendarsToolStripMenuItem";
            this.syncToGoogleCalendarsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.syncToGoogleCalendarsToolStripMenuItem.Text = "Sync to Google Calendars";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem4.Text = "About";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem5.Text = "View";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem6.Text = "Import";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem7.Text = "Export";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem12});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem8.Text = "Tasks and resources";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskCreationMenuItem,
            this.resourceCreationMenuItem});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem9.Text = "New";
            // 
            // taskCreationMenuItem
            // 
            this.taskCreationMenuItem.Name = "taskCreationMenuItem";
            this.taskCreationMenuItem.Size = new System.Drawing.Size(122, 22);
            this.taskCreationMenuItem.Text = "Task";
            this.taskCreationMenuItem.Click += new System.EventHandler(this.taskCreationMenuItem_Click);
            // 
            // resourceCreationMenuItem
            // 
            this.resourceCreationMenuItem.Name = "resourceCreationMenuItem";
            this.resourceCreationMenuItem.Size = new System.Drawing.Size(122, 22);
            this.resourceCreationMenuItem.Text = "Resource";
            this.resourceCreationMenuItem.Click += new System.EventHandler(this.resourceCreationMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem12.Text = "Overview";
            // 
            // lbProjectTasksResources
            // 
            this.lbProjectTasksResources.FormattingEnabled = true;
            this.lbProjectTasksResources.Location = new System.Drawing.Point(13, 67);
            this.lbProjectTasksResources.Name = "lbProjectTasksResources";
            this.lbProjectTasksResources.Size = new System.Drawing.Size(163, 225);
            this.lbProjectTasksResources.TabIndex = 1;
            this.lbProjectTasksResources.SelectedIndexChanged += new System.EventHandler(this.lbProjectTasksResources_SelectedIndexChanged);
            // 
            // projectManagerDataDataSet
            // 
            this.projectManagerDataDataSet.DataSetName = "ProjectManagerDataDataSet";
            this.projectManagerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "All project tasks:";
            // 
            // projectManagerDataDataSetBindingSource
            // 
            this.projectManagerDataDataSetBindingSource.DataSource = this.projectManagerDataDataSet;
            this.projectManagerDataDataSetBindingSource.Position = 0;
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(185, 246);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(221, 46);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Task details:";
            // 
            // lbTaskDetails
            // 
            this.lbTaskDetails.FormattingEnabled = true;
            this.lbTaskDetails.Location = new System.Drawing.Point(185, 67);
            this.lbTaskDetails.Name = "lbTaskDetails";
            this.lbTaskDetails.Size = new System.Drawing.Size(221, 173);
            this.lbTaskDetails.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(543, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 225);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project-calendar:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 304);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbTaskDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProjectTasksResources);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Project manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagerDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem taskCreationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceCreationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ListBox lbProjectTasksResources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem syncToGoogleCalendarsToolStripMenuItem;
        private ProjectManagerDataDataSet projectManagerDataDataSet;
        private System.Windows.Forms.BindingSource projectManagerDataDataSetBindingSource;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTaskDetails;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

