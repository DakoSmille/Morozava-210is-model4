namespace Morozava_210is_model4.Forms
{
    partial class ProvisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvisorForm));
            this.buttonProvisor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._1AptekaDataSet = new Morozava_210is_model4._1AptekaDataSet();
            this.sotrydnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrydnikiTableAdapter = new Morozava_210is_model4._1AptekaDataSetTableAdapters.sotrydnikiTableAdapter();
            this.tableAdapterManager = new Morozava_210is_model4._1AptekaDataSetTableAdapters.TableAdapterManager();
            this.sotrydnikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sotrydnikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sotrydnikiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._1AptekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingNavigator)).BeginInit();
            this.sotrydnikiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProvisor
            // 
            this.buttonProvisor.Location = new System.Drawing.Point(650, 396);
            this.buttonProvisor.Name = "buttonProvisor";
            this.buttonProvisor.Size = new System.Drawing.Size(75, 23);
            this.buttonProvisor.TabIndex = 0;
            this.buttonProvisor.Text = "button1";
            this.buttonProvisor.UseVisualStyleBackColor = true;
            this.buttonProvisor.Click += new System.EventHandler(this.buttonProvisor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // _1AptekaDataSet
            // 
            this._1AptekaDataSet.DataSetName = "_1AptekaDataSet";
            this._1AptekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrydnikiBindingSource
            // 
            this.sotrydnikiBindingSource.DataMember = "sotrydniki";
            this.sotrydnikiBindingSource.DataSource = this._1AptekaDataSet;
            // 
            // sotrydnikiTableAdapter
            // 
            this.sotrydnikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lekarstvaTableAdapter = null;
            this.tableAdapterManager.sotrydnikiTableAdapter = this.sotrydnikiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Morozava_210is_model4._1AptekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sotrydnikiBindingNavigator
            // 
            this.sotrydnikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sotrydnikiBindingNavigator.BindingSource = this.sotrydnikiBindingSource;
            this.sotrydnikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sotrydnikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sotrydnikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sotrydnikiBindingNavigatorSaveItem});
            this.sotrydnikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sotrydnikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sotrydnikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sotrydnikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sotrydnikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sotrydnikiBindingNavigator.Name = "sotrydnikiBindingNavigator";
            this.sotrydnikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sotrydnikiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.sotrydnikiBindingNavigator.TabIndex = 2;
            this.sotrydnikiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // sotrydnikiBindingNavigatorSaveItem
            // 
            this.sotrydnikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sotrydnikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sotrydnikiBindingNavigatorSaveItem.Image")));
            this.sotrydnikiBindingNavigatorSaveItem.Name = "sotrydnikiBindingNavigatorSaveItem";
            this.sotrydnikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sotrydnikiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sotrydnikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.sotrydnikiBindingNavigatorSaveItem_Click);
            // 
            // sotrydnikiDataGridView
            // 
            this.sotrydnikiDataGridView.AutoGenerateColumns = false;
            this.sotrydnikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sotrydnikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sotrydnikiDataGridView.DataSource = this.sotrydnikiBindingSource;
            this.sotrydnikiDataGridView.Location = new System.Drawing.Point(137, 121);
            this.sotrydnikiDataGridView.Name = "sotrydnikiDataGridView";
            this.sotrydnikiDataGridView.Size = new System.Drawing.Size(445, 220);
            this.sotrydnikiDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSotrydnika";
            this.dataGridViewTextBoxColumn1.HeaderText = "id Сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn4.HeaderText = "роль";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ProvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sotrydnikiDataGridView);
            this.Controls.Add(this.sotrydnikiBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProvisor);
            this.Name = "ProvisorForm";
            this.Text = "ProvisorForm";
            this.Load += new System.EventHandler(this.ProvisorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._1AptekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiBindingNavigator)).EndInit();
            this.sotrydnikiBindingNavigator.ResumeLayout(false);
            this.sotrydnikiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProvisor;
        private System.Windows.Forms.Label label1;
        private _1AptekaDataSet _1AptekaDataSet;
        private System.Windows.Forms.BindingSource sotrydnikiBindingSource;
        private _1AptekaDataSetTableAdapters.sotrydnikiTableAdapter sotrydnikiTableAdapter;
        private _1AptekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sotrydnikiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sotrydnikiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sotrydnikiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}