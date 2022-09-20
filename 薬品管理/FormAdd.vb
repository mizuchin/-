Public Class FormAdd
    Public Sub New(ByVal dsStatus As Status)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Status.Merge(dsStatus)

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Public Sub New(ByVal dsStatus As Status,
                   name As String,
                   Statuses As String,
                   buyDate As String,
                   molMass As Decimal,
                   remarks As String)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Status.Merge(dsStatus)
        MonCalendar.SetDate(buyDate)
        cmbStatus.Text = Statuses
        txtChemicals.Text = name
        txtMols.Text = molMass
        txtRemarks.Text = remarks

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub New()
    End Sub
End Class