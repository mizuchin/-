<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdd
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChemicals = New System.Windows.Forms.TextBox()
        Me.txtMols = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.MonCalendar = New System.Windows.Forms.MonthCalendar()
        Me.Chemicals1 = New 薬品管理.chemicals()
        Me.Status = New 薬品管理.Status()
        Me.StatusDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Chemicals1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "購入日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "薬品名"
        '
        'txtChemicals
        '
        Me.txtChemicals.Location = New System.Drawing.Point(100, 351)
        Me.txtChemicals.Name = "txtChemicals"
        Me.txtChemicals.Size = New System.Drawing.Size(144, 25)
        Me.txtChemicals.TabIndex = 3
        '
        'txtMols
        '
        Me.txtMols.Location = New System.Drawing.Point(100, 403)
        Me.txtMols.Name = "txtMols"
        Me.txtMols.Size = New System.Drawing.Size(144, 25)
        Me.txtMols.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "mol質量"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "状態"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(100, 460)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(144, 25)
        Me.txtRemarks.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "備考"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(25, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(306, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DataSource = Me.StatusDataTableBindingSource
        Me.cmbStatus.DisplayMember = "状態"
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(100, 300)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(173, 26)
        Me.cmbStatus.TabIndex = 12
        '
        'MonCalendar
        '
        Me.MonCalendar.Location = New System.Drawing.Point(100, 35)
        Me.MonCalendar.Name = "MonCalendar"
        Me.MonCalendar.TabIndex = 13
        '
        'Chemicals1
        '
        Me.Chemicals1.DataSetName = "chemicals"
        Me.Chemicals1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Status
        '
        Me.Status.DataSetName = "Status"
        Me.Status.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusDataTableBindingSource
        '
        Me.StatusDataTableBindingSource.DataMember = "StatusDataTable"
        Me.StatusDataTableBindingSource.DataSource = Me.Status
        '
        'FormAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 561)
        Me.Controls.Add(Me.MonCalendar)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMols)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtChemicals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdd"
        Me.Text = "薬品追加"
        CType(Me.Chemicals1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Public WithEvents txtChemicals As TextBox
    Public WithEvents txtMols As TextBox
    Public WithEvents txtRemarks As TextBox
    Public WithEvents cmbStatus As ComboBox
    Public WithEvents MonCalendar As MonthCalendar
    Friend WithEvents Chemicals1 As chemicals
    Friend WithEvents StatusDataTableBindingSource As BindingSource
    Public WithEvents Status As Status
End Class
