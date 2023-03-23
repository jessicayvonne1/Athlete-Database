
namespace FinalProject
{
    partial class Professional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professional));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.hiredProffessionalNameTextBox = new System.Windows.Forms.TextBox();
            this.hiringInfoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameOutputLAbel = new System.Windows.Forms.Label();
            this.salaryOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hiredTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hiredTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hiredTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionalDBDataSet = new FinalProject.ProfessionalDBDataSet();
            this.hiredTableTableAdapter = new FinalProject.ProfessionalDBDataSetTableAdapters.HiredTableTableAdapter();
            this.tableAdapterManager = new FinalProject.ProfessionalDBDataSetTableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableBindingNavigator)).BeginInit();
            this.hiredTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.hiredProffessionalNameTextBox);
            this.groupBox2.Controls.Add(this.hiringInfoButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(604, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiring Info";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Lawyer",
            "Personal Assistant",
            "Agent",
            "Trainer"});
            this.categoryComboBox.Location = new System.Drawing.Point(109, 79);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(227, 28);
            this.categoryComboBox.TabIndex = 6;
            // 
            // hiredProffessionalNameTextBox
            // 
            this.hiredProffessionalNameTextBox.Location = new System.Drawing.Point(109, 42);
            this.hiredProffessionalNameTextBox.Name = "hiredProffessionalNameTextBox";
            this.hiredProffessionalNameTextBox.Size = new System.Drawing.Size(249, 26);
            this.hiredProffessionalNameTextBox.TabIndex = 5;
            // 
            // hiringInfoButton
            // 
            this.hiringInfoButton.Location = new System.Drawing.Point(146, 122);
            this.hiringInfoButton.Name = "hiringInfoButton";
            this.hiringInfoButton.Size = new System.Drawing.Size(81, 40);
            this.hiringInfoButton.TabIndex = 4;
            this.hiringInfoButton.Text = "Add";
            this.hiringInfoButton.UseVisualStyleBackColor = true;
            this.hiringInfoButton.Click += new System.EventHandler(this.hiringInfoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name: ";
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Location = new System.Drawing.Point(770, 261);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(223, 78);
            this.viewDetailsButton.TabIndex = 3;
            this.viewDetailsButton.Text = "View Details";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameOutputLAbel
            // 
            this.nameOutputLAbel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameOutputLAbel.Location = new System.Drawing.Point(158, 55);
            this.nameOutputLAbel.Name = "nameOutputLAbel";
            this.nameOutputLAbel.Size = new System.Drawing.Size(100, 23);
            this.nameOutputLAbel.TabIndex = 5;
            this.nameOutputLAbel.Click += new System.EventHandler(this.nameOutputLAbel_Click);
            // 
            // salaryOutputLabel
            // 
            this.salaryOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salaryOutputLabel.Location = new System.Drawing.Point(158, 104);
            this.salaryOutputLabel.Name = "salaryOutputLabel";
            this.salaryOutputLabel.Size = new System.Drawing.Size(100, 25);
            this.salaryOutputLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Athlete Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Athlete\'s Salary: ";
            // 
            // hiredTableBindingNavigator
            // 
            this.hiredTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hiredTableBindingNavigator.BindingSource = this.hiredTableBindingSource;
            this.hiredTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hiredTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hiredTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.hiredTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hiredTableBindingNavigatorSaveItem});
            this.hiredTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hiredTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hiredTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hiredTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hiredTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hiredTableBindingNavigator.Name = "hiredTableBindingNavigator";
            this.hiredTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hiredTableBindingNavigator.Size = new System.Drawing.Size(1063, 38);
            this.hiredTableBindingNavigator.TabIndex = 9;
            this.hiredTableBindingNavigator.Text = "bindingNavigator1";
            this.hiredTableBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hiredTableBindingNavigatorSaveItem
            // 
            this.hiredTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hiredTableBindingNavigatorSaveItem.Enabled = false;
            this.hiredTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hiredTableBindingNavigatorSaveItem.Image")));
            this.hiredTableBindingNavigatorSaveItem.Name = "hiredTableBindingNavigatorSaveItem";
            this.hiredTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.hiredTableBindingNavigatorSaveItem.Text = "Save Data";
            this.hiredTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.hiredTableBindingNavigatorSaveItem_Click);
            // 
            // hiredTableDataGridView
            // 
            this.hiredTableDataGridView.AutoGenerateColumns = false;
            this.hiredTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hiredTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.hiredTableDataGridView.DataSource = this.hiredTableBindingSource;
            this.hiredTableDataGridView.Location = new System.Drawing.Point(16, 261);
            this.hiredTableDataGridView.Name = "hiredTableDataGridView";
            this.hiredTableDataGridView.RowHeadersWidth = 62;
            this.hiredTableDataGridView.RowTemplate.Height = 28;
            this.hiredTableDataGridView.Size = new System.Drawing.Size(662, 220);
            this.hiredTableDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // hiredTableBindingSource
            // 
            this.hiredTableBindingSource.DataMember = "HiredTable";
            this.hiredTableBindingSource.DataSource = this.professionalDBDataSet;
            // 
            // professionalDBDataSet
            // 
            this.professionalDBDataSet.DataSetName = "ProfessionalDBDataSet";
            this.professionalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hiredTableTableAdapter
            // 
            this.hiredTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HiredTableTableAdapter = this.hiredTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.ProfessionalDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Professional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 543);
            this.Controls.Add(this.hiredTableDataGridView);
            this.Controls.Add(this.hiredTableBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryOutputLabel);
            this.Controls.Add(this.nameOutputLAbel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "Professional";
            this.Text = "Professional";
            this.Load += new System.EventHandler(this.Professional_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableBindingNavigator)).EndInit();
            this.hiredTableBindingNavigator.ResumeLayout(false);
            this.hiredTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiredTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox hiredProffessionalNameTextBox;
        private System.Windows.Forms.Button hiringInfoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameOutputLAbel;
        private System.Windows.Forms.Label salaryOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ProfessionalDBDataSet professionalDBDataSet;
        private System.Windows.Forms.BindingSource hiredTableBindingSource;
        private ProfessionalDBDataSetTableAdapters.HiredTableTableAdapter hiredTableTableAdapter;
        private ProfessionalDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hiredTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hiredTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hiredTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}