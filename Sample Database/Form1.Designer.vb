<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.databaseselect = New System.Windows.Forms.ComboBox()
        Me.Tableselect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tabtabledata = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UpdateTableButton = New System.Windows.Forms.Button()
        Me.tabledatagrid = New System.Windows.Forms.DataGridView()
        Me.NewTableTab = New System.Windows.Forms.TabPage()
        Me.Addfield = New System.Windows.Forms.Button()
        Me.NewTableName = New System.Windows.Forms.TextBox()
        Me.newtable = New System.Windows.Forms.Button()
        Me.tabledesigngrid = New System.Windows.Forms.DataGridView()
        Me.n_field = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.n_lenght = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_null = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.n_index = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.n_ai = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.newdb = New System.Windows.Forms.Button()
        Me.deletedatarow = New System.Windows.Forms.Button()
        Me.Tabtabledata.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tabledatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewTableTab.SuspendLayout()
        CType(Me.tabledesigngrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'databaseselect
        '
        Me.databaseselect.FormattingEnabled = True
        Me.databaseselect.Location = New System.Drawing.Point(123, 12)
        Me.databaseselect.Name = "databaseselect"
        Me.databaseselect.Size = New System.Drawing.Size(121, 23)
        Me.databaseselect.TabIndex = 1
        '
        'Tableselect
        '
        Me.Tableselect.FormattingEnabled = True
        Me.Tableselect.Location = New System.Drawing.Point(543, 12)
        Me.Tableselect.Name = "Tableselect"
        Me.Tableselect.Size = New System.Drawing.Size(121, 23)
        Me.Tableselect.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Database"
        '
        'Tabtabledata
        '
        Me.Tabtabledata.AccessibleName = ""
        Me.Tabtabledata.Controls.Add(Me.TabPage1)
        Me.Tabtabledata.Controls.Add(Me.NewTableTab)
        Me.Tabtabledata.Location = New System.Drawing.Point(37, 55)
        Me.Tabtabledata.Name = "Tabtabledata"
        Me.Tabtabledata.SelectedIndex = 0
        Me.Tabtabledata.Size = New System.Drawing.Size(674, 332)
        Me.Tabtabledata.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.deletedatarow)
        Me.TabPage1.Controls.Add(Me.UpdateTableButton)
        Me.TabPage1.Controls.Add(Me.tabledatagrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(666, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Table Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UpdateTableButton
        '
        Me.UpdateTableButton.Location = New System.Drawing.Point(567, 269)
        Me.UpdateTableButton.Name = "UpdateTableButton"
        Me.UpdateTableButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateTableButton.TabIndex = 2
        Me.UpdateTableButton.Text = "Update"
        Me.UpdateTableButton.UseVisualStyleBackColor = True
        '
        'tabledatagrid
        '
        Me.tabledatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabledatagrid.Location = New System.Drawing.Point(28, 20)
        Me.tabledatagrid.MultiSelect = False
        Me.tabledatagrid.Name = "tabledatagrid"
        Me.tabledatagrid.RowTemplate.Height = 25
        Me.tabledatagrid.Size = New System.Drawing.Size(614, 243)
        Me.tabledatagrid.TabIndex = 1
        '
        'NewTableTab
        '
        Me.NewTableTab.BackColor = System.Drawing.Color.Transparent
        Me.NewTableTab.Controls.Add(Me.Addfield)
        Me.NewTableTab.Controls.Add(Me.NewTableName)
        Me.NewTableTab.Controls.Add(Me.newtable)
        Me.NewTableTab.Controls.Add(Me.tabledesigngrid)
        Me.NewTableTab.Location = New System.Drawing.Point(4, 24)
        Me.NewTableTab.Name = "NewTableTab"
        Me.NewTableTab.Padding = New System.Windows.Forms.Padding(3)
        Me.NewTableTab.Size = New System.Drawing.Size(666, 304)
        Me.NewTableTab.TabIndex = 1
        Me.NewTableTab.Text = "New Table"
        '
        'Addfield
        '
        Me.Addfield.BackColor = System.Drawing.Color.Transparent
        Me.Addfield.Location = New System.Drawing.Point(454, 270)
        Me.Addfield.Name = "Addfield"
        Me.Addfield.Size = New System.Drawing.Size(85, 22)
        Me.Addfield.TabIndex = 13
        Me.Addfield.Text = "Add Field"
        Me.Addfield.UseVisualStyleBackColor = False
        '
        'NewTableName
        '
        Me.NewTableName.Location = New System.Drawing.Point(107, 269)
        Me.NewTableName.Name = "NewTableName"
        Me.NewTableName.Size = New System.Drawing.Size(121, 23)
        Me.NewTableName.TabIndex = 12
        '
        'newtable
        '
        Me.newtable.Location = New System.Drawing.Point(267, 270)
        Me.newtable.Name = "newtable"
        Me.newtable.Size = New System.Drawing.Size(85, 22)
        Me.newtable.TabIndex = 11
        Me.newtable.Text = "New Table"
        Me.newtable.UseVisualStyleBackColor = True
        '
        'tabledesigngrid
        '
        Me.tabledesigngrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabledesigngrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.n_field, Me.n_type, Me.n_lenght, Me.n_null, Me.n_index, Me.n_ai})
        Me.tabledesigngrid.Location = New System.Drawing.Point(28, 20)
        Me.tabledesigngrid.Name = "tabledesigngrid"
        Me.tabledesigngrid.RowTemplate.Height = 25
        Me.tabledesigngrid.Size = New System.Drawing.Size(614, 243)
        Me.tabledesigngrid.TabIndex = 2
        '
        'n_field
        '
        Me.n_field.DataPropertyName = "n_field"
        Me.n_field.HeaderText = "FieldName"
        Me.n_field.Name = "n_field"
        '
        'n_type
        '
        Me.n_type.DataPropertyName = "n_type"
        Me.n_type.HeaderText = "Type"
        Me.n_type.Items.AddRange(New Object() {"INT", "TEXT"})
        Me.n_type.Name = "n_type"
        '
        'n_lenght
        '
        Me.n_lenght.DataPropertyName = "n_lenght"
        Me.n_lenght.HeaderText = "Length/Values"
        Me.n_lenght.Name = "n_lenght"
        '
        'n_null
        '
        Me.n_null.DataPropertyName = "n_null"
        Me.n_null.FalseValue = "NULL"
        Me.n_null.HeaderText = "Null"
        Me.n_null.Name = "n_null"
        Me.n_null.TrueValue = "NOT NULL"
        '
        'n_index
        '
        Me.n_index.DataPropertyName = "n_index"
        Me.n_index.HeaderText = "Index"
        Me.n_index.Items.AddRange(New Object() {"PRIMARY KEY", "UNIQUE" & Global.Microsoft.VisualBasic.ChrW(9), "INDEX", "FULLTEXT"})
        Me.n_index.Name = "n_index"
        '
        'n_ai
        '
        Me.n_ai.DataPropertyName = "n_ai"
        Me.n_ai.HeaderText = "Auto"
        Me.n_ai.Name = "n_ai"
        Me.n_ai.TrueValue = "AUTO_INCREMENT"
        '
        'newdb
        '
        Me.newdb.Location = New System.Drawing.Point(261, 13)
        Me.newdb.Name = "newdb"
        Me.newdb.Size = New System.Drawing.Size(95, 22)
        Me.newdb.TabIndex = 6
        Me.newdb.Text = "New Database"
        Me.newdb.UseVisualStyleBackColor = True
        '
        'deletedatarow
        '
        Me.deletedatarow.Location = New System.Drawing.Point(435, 269)
        Me.deletedatarow.Name = "deletedatarow"
        Me.deletedatarow.Size = New System.Drawing.Size(75, 23)
        Me.deletedatarow.TabIndex = 3
        Me.deletedatarow.Text = "Delete Row"
        Me.deletedatarow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.newdb)
        Me.Controls.Add(Me.Tabtabledata)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tableselect)
        Me.Controls.Add(Me.databaseselect)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.Tabtabledata.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.tabledatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewTableTab.ResumeLayout(False)
        Me.NewTableTab.PerformLayout()
        CType(Me.tabledesigngrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents databaseselect As ComboBox
    Friend WithEvents Tableselect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tabtabledata As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabledatagrid As DataGridView
    Friend WithEvents NewTableTab As TabPage
    Friend WithEvents tabledesigngrid As DataGridView
    Friend WithEvents newdb As Button
    Friend WithEvents Addfield As Button
    Friend WithEvents NewTableName As TextBox
    Friend WithEvents newtable As Button
    Friend WithEvents UpdateTableButton As Button
    Friend WithEvents n_field As DataGridViewTextBoxColumn
    Friend WithEvents n_type As DataGridViewComboBoxColumn
    Friend WithEvents n_lenght As DataGridViewTextBoxColumn
    Friend WithEvents n_null As DataGridViewCheckBoxColumn
    Friend WithEvents n_index As DataGridViewComboBoxColumn
    Friend WithEvents n_ai As DataGridViewCheckBoxColumn
    Friend WithEvents deletedatarow As Button
End Class
