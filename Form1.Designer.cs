namespace To_Do_List_3
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbShowList = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cBoxShowPriority = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbShowWork = new System.Windows.Forms.RadioButton();
            this.rbShowPersonal = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbShowMonthly = new System.Windows.Forms.RadioButton();
            this.rbShowDaily = new System.Windows.Forms.RadioButton();
            this.chBoxList = new System.Windows.Forms.CheckedListBox();
            this.MenuAllTask = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAddNew = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxPriority = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbWork = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.rbHistory = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.chBoxHistory = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moreInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tbShowList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MenuAllTask.SuspendLayout();
            this.tpAddNew.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.MenuHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbShowList);
            this.tabControl1.Controls.Add(this.tpAddNew);
            this.tabControl1.Controls.Add(this.rbHistory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbShowList
            // 
            this.tbShowList.Controls.Add(this.button2);
            this.tbShowList.Controls.Add(this.cBoxShowPriority);
            this.tbShowList.Controls.Add(this.panel4);
            this.tbShowList.Controls.Add(this.panel3);
            this.tbShowList.Controls.Add(this.chBoxList);
            this.tbShowList.Location = new System.Drawing.Point(4, 22);
            this.tbShowList.Name = "tbShowList";
            this.tbShowList.Padding = new System.Windows.Forms.Padding(3);
            this.tbShowList.Size = new System.Drawing.Size(968, 424);
            this.tbShowList.TabIndex = 0;
            this.tbShowList.Text = "To Do List";
            this.tbShowList.UseVisualStyleBackColor = true;
            this.tbShowList.Enter += new System.EventHandler(this.tbShowList_Enter);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(799, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBoxShowPriority
            // 
            this.cBoxShowPriority.AllowDrop = true;
            this.cBoxShowPriority.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxShowPriority.FormattingEnabled = true;
            this.cBoxShowPriority.IntegralHeight = false;
            this.cBoxShowPriority.Items.AddRange(new object[] {
            "All",
            "Hight",
            "Medium",
            "Low"});
            this.cBoxShowPriority.Location = new System.Drawing.Point(781, 344);
            this.cBoxShowPriority.Name = "cBoxShowPriority";
            this.cBoxShowPriority.Size = new System.Drawing.Size(181, 23);
            this.cBoxShowPriority.TabIndex = 4;
            this.cBoxShowPriority.SelectedIndexChanged += new System.EventHandler(this.tbShowList_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbShowWork);
            this.panel4.Controls.Add(this.rbShowPersonal);
            this.panel4.Location = new System.Drawing.Point(781, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 41);
            this.panel4.TabIndex = 3;
            // 
            // rbShowWork
            // 
            this.rbShowWork.AutoSize = true;
            this.rbShowWork.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowWork.Location = new System.Drawing.Point(107, 12);
            this.rbShowWork.Name = "rbShowWork";
            this.rbShowWork.Size = new System.Drawing.Size(51, 18);
            this.rbShowWork.TabIndex = 3;
            this.rbShowWork.TabStop = true;
            this.rbShowWork.Text = "Work";
            this.rbShowWork.UseVisualStyleBackColor = true;
            this.rbShowWork.CheckedChanged += new System.EventHandler(this.tbShowList_Enter);
            // 
            // rbShowPersonal
            // 
            this.rbShowPersonal.AutoSize = true;
            this.rbShowPersonal.Checked = true;
            this.rbShowPersonal.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowPersonal.Location = new System.Drawing.Point(18, 12);
            this.rbShowPersonal.Name = "rbShowPersonal";
            this.rbShowPersonal.Size = new System.Drawing.Size(65, 18);
            this.rbShowPersonal.TabIndex = 3;
            this.rbShowPersonal.TabStop = true;
            this.rbShowPersonal.Text = "Personal";
            this.rbShowPersonal.UseVisualStyleBackColor = true;
            this.rbShowPersonal.CheckedChanged += new System.EventHandler(this.tbShowList_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbShowMonthly);
            this.panel3.Controls.Add(this.rbShowDaily);
            this.panel3.Location = new System.Drawing.Point(781, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 41);
            this.panel3.TabIndex = 2;
            // 
            // rbShowMonthly
            // 
            this.rbShowMonthly.AutoSize = true;
            this.rbShowMonthly.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowMonthly.Location = new System.Drawing.Point(107, 11);
            this.rbShowMonthly.Name = "rbShowMonthly";
            this.rbShowMonthly.Size = new System.Drawing.Size(66, 18);
            this.rbShowMonthly.TabIndex = 2;
            this.rbShowMonthly.TabStop = true;
            this.rbShowMonthly.Text = "Monthly";
            this.rbShowMonthly.UseVisualStyleBackColor = true;
            this.rbShowMonthly.CheckedChanged += new System.EventHandler(this.tbShowList_Enter);
            // 
            // rbShowDaily
            // 
            this.rbShowDaily.AutoSize = true;
            this.rbShowDaily.Checked = true;
            this.rbShowDaily.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShowDaily.Location = new System.Drawing.Point(18, 11);
            this.rbShowDaily.Name = "rbShowDaily";
            this.rbShowDaily.Size = new System.Drawing.Size(50, 18);
            this.rbShowDaily.TabIndex = 1;
            this.rbShowDaily.TabStop = true;
            this.rbShowDaily.Text = "Daily";
            this.rbShowDaily.UseVisualStyleBackColor = true;
            this.rbShowDaily.CheckedChanged += new System.EventHandler(this.tbShowList_Enter);
            // 
            // chBoxList
            // 
            this.chBoxList.CheckOnClick = true;
            this.chBoxList.ColumnWidth = 200;
            this.chBoxList.ContextMenuStrip = this.MenuAllTask;
            this.chBoxList.FormattingEnabled = true;
            this.chBoxList.Location = new System.Drawing.Point(8, 7);
            this.chBoxList.Name = "chBoxList";
            this.chBoxList.Size = new System.Drawing.Size(767, 409);
            this.chBoxList.TabIndex = 0;
            // 
            // MenuAllTask
            // 
            this.MenuAllTask.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreInfoToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.MenuAllTask.Name = "contextMenuStrip1";
            this.MenuAllTask.Size = new System.Drawing.Size(127, 48);
            this.MenuAllTask.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.moreInfoToolStripMenuItem.Text = "More Info";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tpAddNew
            // 
            this.tpAddNew.Controls.Add(this.button1);
            this.tpAddNew.Controls.Add(this.dateTimeTime);
            this.tpAddNew.Controls.Add(this.dateTimeDate);
            this.tpAddNew.Controls.Add(this.cBoxPriority);
            this.tpAddNew.Controls.Add(this.panel2);
            this.tpAddNew.Controls.Add(this.panel1);
            this.tpAddNew.Controls.Add(this.label2);
            this.tpAddNew.Controls.Add(this.label1);
            this.tpAddNew.Controls.Add(this.txtTaskDescription);
            this.tpAddNew.Controls.Add(this.txtTaskTitle);
            this.tpAddNew.Location = new System.Drawing.Point(4, 22);
            this.tpAddNew.Name = "tpAddNew";
            this.tpAddNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNew.Size = new System.Drawing.Size(968, 424);
            this.tpAddNew.TabIndex = 1;
            this.tpAddNew.Text = "Add New";
            this.tpAddNew.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeTime
            // 
            this.dateTimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeTime.Location = new System.Drawing.Point(712, 256);
            this.dateTimeTime.Name = "dateTimeTime";
            this.dateTimeTime.ShowUpDown = true;
            this.dateTimeTime.Size = new System.Drawing.Size(82, 20);
            this.dateTimeTime.TabIndex = 10;
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.Enabled = false;
            this.dateTimeDate.Location = new System.Drawing.Point(800, 256);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(124, 20);
            this.dateTimeDate.TabIndex = 9;
            // 
            // cBoxPriority
            // 
            this.cBoxPriority.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriority.FormattingEnabled = true;
            this.cBoxPriority.Items.AddRange(new object[] {
            "Hight",
            "Medium",
            "Low"});
            this.cBoxPriority.Location = new System.Drawing.Point(712, 203);
            this.cBoxPriority.Name = "cBoxPriority";
            this.cBoxPriority.Size = new System.Drawing.Size(212, 23);
            this.cBoxPriority.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbWork);
            this.panel2.Controls.Add(this.rbPersonal);
            this.panel2.Location = new System.Drawing.Point(712, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 37);
            this.panel2.TabIndex = 7;
            // 
            // rbWork
            // 
            this.rbWork.AutoSize = true;
            this.rbWork.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWork.Location = new System.Drawing.Point(128, 10);
            this.rbWork.Name = "rbWork";
            this.rbWork.Size = new System.Drawing.Size(54, 19);
            this.rbWork.TabIndex = 6;
            this.rbWork.Text = "Work";
            this.rbWork.UseVisualStyleBackColor = true;
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Checked = true;
            this.rbPersonal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonal.Location = new System.Drawing.Point(16, 10);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(71, 19);
            this.rbPersonal.TabIndex = 5;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMonthly);
            this.panel1.Controls.Add(this.rbDaily);
            this.panel1.Location = new System.Drawing.Point(712, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 37);
            this.panel1.TabIndex = 4;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonthly.Location = new System.Drawing.Point(128, 10);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(72, 19);
            this.rbMonthly.TabIndex = 6;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDaily.Location = new System.Drawing.Point(16, 10);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(53, 19);
            this.rbDaily.TabIndex = 5;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Title";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(35, 102);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(570, 314);
            this.txtTaskDescription.TabIndex = 1;
            this.txtTaskDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtTaskDescription_Validating);
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(35, 45);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(570, 27);
            this.txtTaskTitle.TabIndex = 0;
            // 
            // rbHistory
            // 
            this.rbHistory.Controls.Add(this.btnClear);
            this.rbHistory.Controls.Add(this.chBoxHistory);
            this.rbHistory.Location = new System.Drawing.Point(4, 22);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Padding = new System.Windows.Forms.Padding(3);
            this.rbHistory.Size = new System.Drawing.Size(968, 424);
            this.rbHistory.TabIndex = 2;
            this.rbHistory.Text = "History";
            this.rbHistory.UseVisualStyleBackColor = true;
            this.rbHistory.Enter += new System.EventHandler(this.rbHistory_Enter);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(845, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chBoxHistory
            // 
            this.chBoxHistory.CheckOnClick = true;
            this.chBoxHistory.ContextMenuStrip = this.MenuHistory;
            this.chBoxHistory.FormattingEnabled = true;
            this.chBoxHistory.Location = new System.Drawing.Point(0, 3);
            this.chBoxHistory.Name = "chBoxHistory";
            this.chBoxHistory.Size = new System.Drawing.Size(837, 424);
            this.chBoxHistory.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // MenuHistory
            // 
            this.MenuHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreInfoToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.MenuHistory.Name = "MenuHistory";
            this.MenuHistory.Size = new System.Drawing.Size(181, 70);
            // 
            // moreInfoToolStripMenuItem1
            // 
            this.moreInfoToolStripMenuItem1.Name = "moreInfoToolStripMenuItem1";
            this.moreInfoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.moreInfoToolStripMenuItem1.Text = "More Info";
            this.moreInfoToolStripMenuItem1.Click += new System.EventHandler(this.moreInfoToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbShowList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MenuAllTask.ResumeLayout(false);
            this.tpAddNew.ResumeLayout(false);
            this.tpAddNew.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rbHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.MenuHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbShowList;
        private System.Windows.Forms.TabPage tpAddNew;
        private System.Windows.Forms.TabPage rbHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbWork;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.ComboBox cBoxPriority;
        private System.Windows.Forms.DateTimePicker dateTimeTime;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chBoxList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbShowWork;
        private System.Windows.Forms.RadioButton rbShowPersonal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbShowMonthly;
        private System.Windows.Forms.RadioButton rbShowDaily;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cBoxShowPriority;
        private System.Windows.Forms.CheckedListBox chBoxHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ContextMenuStrip MenuAllTask;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuHistory;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

