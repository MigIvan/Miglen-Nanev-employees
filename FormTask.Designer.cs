
namespace WorkedTogether
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.menuStripRoot = new System.Windows.Forms.MenuStrip();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRoot = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSort = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFilter = new System.Windows.Forms.ToolStripComboBox();
            this.panelRoot = new System.Windows.Forms.Panel();
            this.dataGridViewRoot = new System.Windows.Forms.DataGridView();
            this.menuStripRoot.SuspendLayout();
            this.toolStripRoot.SuspendLayout();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripRoot
            // 
            this.menuStripRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem});
            this.menuStripRoot.Location = new System.Drawing.Point(0, 0);
            this.menuStripRoot.Name = "menuStripRoot";
            this.menuStripRoot.Size = new System.Drawing.Size(823, 24);
            this.menuStripRoot.TabIndex = 0;
            this.menuStripRoot.Text = "menuStrip1";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileOpenToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripRoot
            // 
            this.toolStripRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripLabelSort,
            this.toolStripComboBoxSort,
            this.toolStripButtonSort,
            this.toolStripSeparator2,
            this.toolStripLabelFilter,
            this.toolStripComboBoxFilter});
            this.toolStripRoot.Location = new System.Drawing.Point(0, 24);
            this.toolStripRoot.Name = "toolStripRoot";
            this.toolStripRoot.Size = new System.Drawing.Size(823, 25);
            this.toolStripRoot.TabIndex = 1;
            this.toolStripRoot.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.ToolTipText = "Open file ...";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.ToolTipText = "Save file As ...";
            this.toolStripButtonSave.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelSort
            // 
            this.toolStripLabelSort.Name = "toolStripLabelSort";
            this.toolStripLabelSort.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabelSort.Text = "Sort: ";
            // 
            // toolStripComboBoxSort
            // 
            this.toolStripComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSort.Enabled = false;
            this.toolStripComboBoxSort.Name = "toolStripComboBoxSort";
            this.toolStripComboBoxSort.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSort_SelectedIndexChanged);
            // 
            // toolStripButtonSort
            // 
            this.toolStripButtonSort.AutoSize = false;
            this.toolStripButtonSort.Checked = true;
            this.toolStripButtonSort.CheckOnClick = true;
            this.toolStripButtonSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSort.Enabled = false;
            this.toolStripButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSort.Image")));
            this.toolStripButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSort.Name = "toolStripButtonSort";
            this.toolStripButtonSort.Size = new System.Drawing.Size(80, 22);
            this.toolStripButtonSort.Text = "Descending";
            this.toolStripButtonSort.CheckedChanged += new System.EventHandler(this.toolStripButtonSort_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelFilter
            // 
            this.toolStripLabelFilter.Name = "toolStripLabelFilter";
            this.toolStripLabelFilter.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabelFilter.Text = "Filter Project:";
            // 
            // toolStripComboBoxFilter
            // 
            this.toolStripComboBoxFilter.Enabled = false;
            this.toolStripComboBoxFilter.Name = "toolStripComboBoxFilter";
            this.toolStripComboBoxFilter.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFilter_SelectedIndexChanged);
            // 
            // panelRoot
            // 
            this.panelRoot.Controls.Add(this.dataGridViewRoot);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 49);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(823, 327);
            this.panelRoot.TabIndex = 2;
            // 
            // dataGridViewRoot
            // 
            this.dataGridViewRoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoot.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRoot.Name = "dataGridViewRoot";
            this.dataGridViewRoot.RowHeadersVisible = false;
            this.dataGridViewRoot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoot.Size = new System.Drawing.Size(823, 327);
            this.dataGridViewRoot.TabIndex = 0;
            this.dataGridViewRoot.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewRoot_RowPostPaint);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 376);
            this.Controls.Add(this.panelRoot);
            this.Controls.Add(this.toolStripRoot);
            this.Controls.Add(this.menuStripRoot);
            this.MainMenuStrip = this.menuStripRoot;
            this.Name = "FormTask";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTask_Load);
            this.menuStripRoot.ResumeLayout(false);
            this.menuStripRoot.PerformLayout();
            this.toolStripRoot.ResumeLayout(false);
            this.toolStripRoot.PerformLayout();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRoot;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripRoot;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.DataGridView dataGridViewRoot;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFilter;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFilter;
        private System.Windows.Forms.ToolStripButton toolStripButtonSort;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSort;
    }
}

