Public Class Form1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddData()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Status1.StatusDataTable.AddStatusDataTableRow("注文済")
        Status1.StatusDataTable.AddStatusDataTableRow("使用可能")
        Status1.StatusDataTable.AddStatusDataTableRow("使用不可")
        Status1.StatusDataTable.AddStatusDataTableRow("不足")
    End Sub

    Private Sub AddData()
        Dim frmAdd As FormAdd = New FormAdd(Status1)
        Dim added As DialogResult = frmAdd.ShowDialog()

        If added = DialogResult.OK Then
            Chemicals1.ChemicalsDataTable.AddChemicalsDataTableRow(
                frmAdd.txtChemicals.Text,
                frmAdd.cmbStatus.Text,
                frmAdd.MonCalendar.SelectionRange.Start(),
                Decimal.Parse(frmAdd.txtMols.Text),
                frmAdd.txtRemarks.Text)
        End If
    End Sub

    Private Sub 追加AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 追加AToolStripMenuItem.Click
        AddData()
    End Sub

    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs) Handles ButtonEnd.Click
        SaveData()
        MsgBox("変更内容は自動で保存されます。")
        Me.Close()
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        SaveData()
        MsgBox("変更内容は自動で保存されます。")
        Me.Close()
    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        SaveData()
    End Sub

    Private Sub SaveData()
        Dim path As String = "../../data/ChemicalsData.csv"
        Dim strData As String
        Dim sw As System.IO.StreamWriter _
            = New System.IO.StreamWriter(path, False, System.Text.Encoding.Default)
        For Each drChemical As chemicals.ChemicalsDataTableRow In Chemicals1.ChemicalsDataTable
            strData = drChemical.薬品名 _
                + "," + drChemical.分類 _
                + "," + drChemical.購入日.ToShortDateString() _
                + "," + drChemical.mol質量.ToString() _
                + "," + drChemical.備考
            sw.WriteLine(strData)
        Next
        sw.Close()
    End Sub

    Private Sub LoadData()
        Dim path As String = "../../data/ChemicalsData.csv"
        Dim delimStr As String = ","
        Dim delimiter() As Char = delimStr.ToCharArray
        Dim strData() As String
        Dim strLine As String
        Dim fileExists As Boolean _
            = My.Computer.FileSystem.FileExists(path)
        If fileExists Then
            Dim sr As IO.StreamReader =
                New IO.StreamReader(path, System.Text.Encoding.Default)
            While (sr.Peek() >= 0)
                strLine = sr.ReadLine()
                strData = strLine.Split(delimiter)
                Chemicals1.ChemicalsDataTable.AddChemicalsDataTableRow(
                    strData(0),
                    strData(1),
                    Date.Parse(strData(2)),
                    Decimal.Parse(strData(3)),
                    strData(4))
            End While
            sr.Close()
        End If
    End Sub

    Private Sub ButtonChange_Click(sender As Object, e As EventArgs) Handles ButtonChange.Click
        ChangeData()
    End Sub

    Private Sub ChangeData()
        Dim nowRow As Integer = dgv.CurrentRow.Index
        Dim oldName As String = dgv.Rows(nowRow).Cells(0).Value
        Dim oldStatus As String = dgv.Rows(nowRow).Cells(1).Value
        Dim olddate As Date = Date.Parse(dgv.Rows(nowRow).Cells(2).Value)
        Dim oldMols As Decimal = Decimal.Parse(dgv.Rows(nowRow).Cells(3).Value)
        Dim oldRemarks As String = dgv.Rows(nowRow).Cells(4).Value
        Dim frmAdd As FormAdd = New FormAdd(Status1, oldName, oldStatus, olddate, oldMols, oldRemarks)
        Dim drRet As DialogResult = frmAdd.ShowDialog()
        If drRet = DialogResult.OK Then
            dgv.Rows(nowRow).Cells(0).Value = frmAdd.txtChemicals.Text
            dgv.Rows(nowRow).Cells(1).Value = frmAdd.cmbStatus.Text
            dgv.Rows(nowRow).Cells(2).Value = frmAdd.MonCalendar.SelectionRange.Start()
            dgv.Rows(nowRow).Cells(3).Value = Decimal.Parse(frmAdd.txtMols.Text)
            dgv.Rows(nowRow).Cells(4).Value = frmAdd.txtRemarks.Text
        End If
    End Sub

    Private Sub 編集CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 編集CToolStripMenuItem.Click
        ChangeData()
    End Sub

    Private Sub DeleteData()
        Dim nowRow As Integer = dgv.CurrentRow.Index
        dgv.Rows.RemoveAt(nowRow)
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        DeleteData()
    End Sub

    Private Sub 削除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 削除DToolStripMenuItem.Click
        DeleteData()
    End Sub

    Private Sub バージョン情報ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles バージョン情報ToolStripMenuItem.Click
        MsgBox("理化学部薬品管理システム
version 1.0.0")
    End Sub
End Class
