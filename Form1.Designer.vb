<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Status1 = New 薬品管理.Status()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.追加AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chemicals1 = New 薬品管理.chemicals()
        Me.ButtonEnd = New System.Windows.Forms.Button()
        Me.編集CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.削除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ChemicalsDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.薬品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.購入日DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mol質量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonChange = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.Status1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Chemicals1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalsDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(240, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "理化学部薬品管理システム"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 482)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(91, 33)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "追加"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Status1
        '
        Me.Status1.DataSetName = "Status"
        Me.Status1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(938, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存SToolStripMenuItem, Me.ToolStripSeparator1, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.追加AToolStripMenuItem, Me.編集CToolStripMenuItem, Me.削除DToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '追加AToolStripMenuItem
        '
        Me.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem"
        Me.追加AToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.追加AToolStripMenuItem.Text = "追加(&A)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報ToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報ToolStripMenuItem
        '
        Me.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem"
        Me.バージョン情報ToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.バージョン情報ToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'Chemicals1
        '
        Me.Chemicals1.DataSetName = "chemicals"
        Me.Chemicals1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonEnd
        '
        Me.ButtonEnd.Location = New System.Drawing.Point(839, 478)
        Me.ButtonEnd.Name = "ButtonEnd"
        Me.ButtonEnd.Size = New System.Drawing.Size(87, 37)
        Me.ButtonEnd.TabIndex = 6
        Me.ButtonEnd.Text = "終了"
        Me.ButtonEnd.UseVisualStyleBackColor = True
        '
        '編集CToolStripMenuItem
        '
        Me.編集CToolStripMenuItem.Name = "編集CToolStripMenuItem"
        Me.編集CToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.編集CToolStripMenuItem.Text = "編集(&C)"
        '
        '削除DToolStripMenuItem
        '
        Me.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem"
        Me.削除DToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.削除DToolStripMenuItem.Text = "削除(&D)"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.薬品名DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.購入日DataGridViewTextBoxColumn, Me.Mol質量DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.ChemicalsDataTableBindingSource
        Me.dgv.Location = New System.Drawing.Point(12, 111)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 62
        Me.dgv.RowTemplate.Height = 27
        Me.dgv.Size = New System.Drawing.Size(914, 352)
        Me.dgv.TabIndex = 7
        '
        'ChemicalsDataTableBindingSource
        '
        Me.ChemicalsDataTableBindingSource.DataMember = "ChemicalsDataTable"
        Me.ChemicalsDataTableBindingSource.DataSource = Me.Chemicals1
        '
        '薬品名DataGridViewTextBoxColumn
        '
        Me.薬品名DataGridViewTextBoxColumn.DataPropertyName = "薬品名"
        Me.薬品名DataGridViewTextBoxColumn.HeaderText = "薬品名"
        Me.薬品名DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.薬品名DataGridViewTextBoxColumn.Name = "薬品名DataGridViewTextBoxColumn"
        Me.薬品名DataGridViewTextBoxColumn.ReadOnly = True
        Me.薬品名DataGridViewTextBoxColumn.Width = 150
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        Me.分類DataGridViewTextBoxColumn.ReadOnly = True
        Me.分類DataGridViewTextBoxColumn.Width = 150
        '
        '購入日DataGridViewTextBoxColumn
        '
        Me.購入日DataGridViewTextBoxColumn.DataPropertyName = "購入日"
        Me.購入日DataGridViewTextBoxColumn.HeaderText = "購入日"
        Me.購入日DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.購入日DataGridViewTextBoxColumn.Name = "購入日DataGridViewTextBoxColumn"
        Me.購入日DataGridViewTextBoxColumn.ReadOnly = True
        Me.購入日DataGridViewTextBoxColumn.Width = 150
        '
        'Mol質量DataGridViewTextBoxColumn
        '
        Me.Mol質量DataGridViewTextBoxColumn.DataPropertyName = "mol質量"
        Me.Mol質量DataGridViewTextBoxColumn.HeaderText = "mol質量"
        Me.Mol質量DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Mol質量DataGridViewTextBoxColumn.Name = "Mol質量DataGridViewTextBoxColumn"
        Me.Mol質量DataGridViewTextBoxColumn.ReadOnly = True
        Me.Mol質量DataGridViewTextBoxColumn.Width = 150
        '
        '備考DataGridViewTextBoxColumn
        '
        Me.備考DataGridViewTextBoxColumn.DataPropertyName = "備考"
        Me.備考DataGridViewTextBoxColumn.HeaderText = "備考"
        Me.備考DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn"
        Me.備考DataGridViewTextBoxColumn.ReadOnly = True
        Me.備考DataGridViewTextBoxColumn.Width = 150
        '
        'ButtonChange
        '
        Me.ButtonChange.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.ButtonChange.Location = New System.Drawing.Point(130, 482)
        Me.ButtonChange.Name = "ButtonChange"
        Me.ButtonChange.Size = New System.Drawing.Size(91, 33)
        Me.ButtonChange.TabIndex = 8
        Me.ButtonChange.Text = "編集"
        Me.ButtonChange.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.ButtonDelete.Location = New System.Drawing.Point(247, 482)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(91, 33)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "削除"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 527)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonChange)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.ButtonEnd)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "薬品管理"
        CType(Me.Status1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Chemicals1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalsDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Status1 As Status
    Friend WithEvents Chemicals1 As chemicals
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 追加AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonEnd As Button
    Friend WithEvents 編集CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 削除DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv As DataGridView
    Friend WithEvents 薬品名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 購入日DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mol質量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備考DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChemicalsDataTableBindingSource As BindingSource
    Friend WithEvents ButtonChange As Button
    Friend WithEvents ButtonDelete As Button
End Class
