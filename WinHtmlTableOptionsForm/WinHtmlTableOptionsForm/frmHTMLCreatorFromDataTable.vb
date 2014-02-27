Imports System.Drawing.Color


Public Class frmHTMLCreatorFromDataTable

#Region "Local Variables"
    'Private CSSName As String = "hiliterow1.css"
    Private TableCaption As String = ""
    Private rdb As RadioButton
#End Region

#Region "Methods"

    Private Sub DesignViewChange()
        Dim CUri As System.UriTypeConverter = New System.UriTypeConverter
        Me.WebBrowser1.Url = CUri.ConvertFromString(Application.StartupPath & "\Gecici.html")
    End Sub

    Private Sub WriteProperty(ByVal DT As DataTable)
        'Seçilen XML file'dan gelen deðerler datatable'ýný alýr ve 
        'form'daki nesnelere bu deðerleri girer.
        'Gelen tablo þöyle..
        '=================
        'NodeName | NodeValue
        For i As Integer = 1 To DT.Rows.Count - 1
            Select Case DT.Rows(i)(0).ToString
                '====================
                'Hücre..
                Case "nudCellWidth"
                    Me.nudCellWidth.Value = CInt(DT.Rows(i)(1).ToString)
                Case "txtCellFont"
                    Me.txtCellFont.Text = DT.Rows(i)(1).ToString
                    Me.txtCellFont.Font = New Font(DT.Rows(i)(1).ToString, 10, FontStyle.Regular)
                Case "cmbCellFontSize"
                    Me.cmbCellFontSize.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCellTextAlign"
                    Me.cmbCellTextAlign.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCellBorderSize"
                    Me.cmbCellBorderSize.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCellBorderType"
                    Me.cmbCellBorderType.SelectedItem = DT.Rows(i)(1).ToString
                Case "txtCellBorderColor"
                    Me.txtCellBorderColor.Text = DT.Rows(i)(1).ToString
                    Me.txtCellBorderColor.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "cmbCellPadding"
                    Me.cmbCellPadding.SelectedItem = DT.Rows(i)(1).ToString
                    '====================
                    'Tablo..
                Case "cmbTableBorderSize"
                    Me.cmbTableBorderSize.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbTableBorderType"
                    Me.cmbTableBorderType.SelectedItem = DT.Rows(i)(1).ToString
                Case "txtTableBorderColor"
                    Me.txtTableBorderColor.Text = DT.Rows(i)(1).ToString
                    Me.txtTableBorderColor.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "cmbTableBorderStyle"
                    Me.cmbTableBorderStyle.SelectedItem = DT.Rows(i)(1).ToString
                    '====================
                    'Kolon..
                Case "cmbColumnBorderSize"
                    Me.cmbColumnBorderSize.SelectedItem = DT.Rows(i)(1).ToString
                Case "txtColumnBorderColor"
                    Me.txtColumnBorderColor.Text = DT.Rows(i)(1).ToString
                    Me.txtColumnBorderColor.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "cmbColumnBorderType"
                    Me.cmbColumnBorderType.SelectedItem = DT.Rows(i)(1).ToString
                Case "txtColumnBackColor"
                    Me.txtColumnBackColor.Text = DT.Rows(i)(1).ToString
                    Me.txtColumnBackColor.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "cmbColumnTextAlign"
                    Me.cmbColumnTextAlign.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbColumnFontBold"
                    Me.cmbColumnFontBold.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbColumnPaddingLeft"
                    Me.cmbColumnPaddingLeft.SelectedItem = DT.Rows(i)(1).ToString
                    '====================
                    'Baslik..
                Case "txtCaptionFont"
                    Me.txtCaptionFont.Text = DT.Rows(i)(1).ToString
                Case "cmbCaptionFontSize"
                    Me.cmbCaptionFontSize.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCaptionFontBold"
                    Me.cmbCaptionFontBold.SelectedItem = DT.Rows(i)(1).ToString
                Case "txtCaptionColor"
                    Me.txtCaptionColor.Text = DT.Rows(i)(1).ToString
                    Me.txtCaptionColor.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "cmbCaptionAlign"
                    Me.cmbCaptionAlign.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCaptionPaddingTop"
                    Me.cmbCaptionPaddingTop.SelectedItem = DT.Rows(i)(1).ToString
                Case "cmbCaptionPaddingBottom"
                    Me.cmbCaptionPaddingBottom.SelectedItem = DT.Rows(i)(1).ToString
                    '====================
                    'JavaKodu..
                Case "txtBackColorRow"
                    Me.txtBackColorRow.Text = DT.Rows(i)(1).ToString
                    Me.txtBackColorRow.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "txtFontColorRow"
                    Me.txtFontColorRow.Text = DT.Rows(i)(1).ToString
                    Me.txtFontColorRow.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "txtHoverBackColorRow"
                    Me.txtHoverBackColorRow.Text = DT.Rows(i)(1).ToString
                    Me.txtHoverBackColorRow.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
                Case "txtHoverFontColorRow"
                    Me.txtHoverFontColorRow.Text = DT.Rows(i)(1).ToString
                    Me.txtHoverFontColorRow.ForeColor = ColorTranslator.FromHtml(DT.Rows(i)(1).ToString)
            End Select
        Next
    End Sub

    Private Function WriteCSS() As String
        Dim StringCSS As String = ""

        StringCSS &= "p, td, th {" & vbCrLf
        StringCSS &= "	width: " & Me.nudCellWidth.Value & "px;" & vbCrLf
        StringCSS &= "	font-family: " & Me.txtCellFont.Text & " ;" & vbCrLf
        StringCSS &= "	font-size: " & Me.cmbCellFontSize.SelectedItem.ToString & " ;" & vbCrLf & "}" & vbCrLf & ".datatable {" & vbCrLf
        StringCSS &= "	border-collapse: " & Me.cmbTableBorderStyle.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-width: " & Me.cmbTableBorderSize.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-style: " & Me.cmbTableBorderType.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-color: " & Me.txtTableBorderColor.Text & ";" & vbCrLf
        StringCSS &= "}" & vbCrLf
        StringCSS &= ".datatable td {" & vbCrLf
        StringCSS &= "	padding: " & Me.cmbCellPadding.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-width: " & Me.cmbCellBorderSize.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-style: " & Me.cmbCellBorderType.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-color: " & Me.txtCellBorderColor.Text & ";" & vbCrLf
        StringCSS &= "	text-align: " & Me.cmbCellTextAlign.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "}" & vbCrLf & ".datatable th {" & vbCrLf
        StringCSS &= "	border-width: " & Me.cmbColumnBorderSize.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	border-color: " & Me.txtColumnBorderColor.Text & ";" & vbCrLf
        StringCSS &= "	background-color: " & Me.txtColumnBackColor.Text & ";" & vbCrLf
        StringCSS &= "	font-weight: " & Me.cmbColumnFontBold.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	text-align: " & Me.cmbColumnTextAlign.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	padding-left: " & Me.cmbColumnPaddingLeft.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "}" & vbCrLf & ".datatable caption {" & vbCrLf
        StringCSS &= "	font-family: " & Me.txtCaptionFont.Text & ";" & vbCrLf
        StringCSS &= "	font-size: " & Me.cmbCaptionFontSize.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	font-weight: " & Me.cmbCaptionFontBold.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	color: " & Me.txtCaptionColor.Text & ";" & vbCrLf
        StringCSS &= "	text-align: " & Me.cmbCaptionAlign.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	padding-top: " & Me.cmbCaptionPaddingTop.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "	padding-bottom: " & Me.cmbCaptionPaddingBottom.SelectedItem.ToString & ";" & vbCrLf
        StringCSS &= "}" & vbCrLf & ".datatable tr:hover, .datatable tr.hilite, .datatable tr.altrow_hilite {" & vbCrLf
        StringCSS &= "	background-color: " & Me.txtHoverBackColorRow.Text & ";" & vbCrLf
        StringCSS &= "	color: " & Me.txtHoverFontColorRow.Text & ";" & vbCrLf
        StringCSS &= "}" & vbCrLf & ".datatable tr.altrow_ {" & vbCrLf
        StringCSS &= "	background-color: " & Me.txtBackColorRow.Text & ";" & vbCrLf
        StringCSS &= "	color: " & Me.txtFontColorRow.Text & ";" & vbCrLf & "}" & vbCrLf

        Return StringCSS
    End Function

    Private Function CreateDataTable() As DataTable
        Dim dt As DataTable = New DataTable

        If System.IO.File.Exists(Application.StartupPath & "\datasource.xml") = True Then
            'Eger programýn okumasý için xml formatýnda bir datatable ,uygulamanýn bulunduðu klasörde "datasource.xml" ismi ile varsa..
            Dim XFC As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating
            dt = XFC.ReadXMLFile(Application.StartupPath & "\datasource.xml")
        Else
            'Eger programýn okumasý için xml formatýnda bir datatable ,uygulamanýn bulunduðu klasörde "datasource.xml" ismi ile yoksa geçici bir datatable yaratýlýr..
            For i As Integer = 0 To 5
                dt.Columns.Add("Kolon " & i)
            Next

            For i As Integer = 0 To 3
                Dim dr As DataRow = dt.NewRow
                For j As Integer = 0 To 5
                    Dim itm As String
                    itm = "Deger (" & j & "," & i & ")"
                    dr.Item(j) = itm
                Next
                dt.Rows.Add(dr)
            Next
        End If

        Return dt
    End Function

    Private Sub WriteHTMLWithStyleText(ByVal dt As DataTable)

        Dim GeciciFile As FileWriteProcess = New FileWriteProcess
        GeciciFile.WriteHTMLFile(dt, Application.StartupPath & "\Gecici.html", TableCaption, WriteCSS)

        DesignViewChange()
    End Sub

#End Region

#Region "Events"
    Private Sub rdbTemplateDesign_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbTemplateDesign.Click
        If Me.rdbTemplateDesign.Checked Then
            Me.grpTemplateDesign.Enabled = True
            Me.grpCustomDesign.Enabled = False

            TemplateDesignItems_Click(rdb, e)
        End If
    End Sub

    Private Sub rdbCustomDesign_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCustomDesign.Click
        If Me.rdbCustomDesign.Checked Then
            Me.grpTemplateDesign.Enabled = False
            Me.grpCustomDesign.Enabled = True
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Program kapanýrken çalýþma esnasýnda olusturulan gecici dosyalar silinir..
        If System.IO.File.Exists(Application.StartupPath & "\Gecici.html") = True Then
            Kill(Application.StartupPath & "\Gecici.html")
        End If
        'If System.IO.File.Exists(Application.StartupPath & "\hiliterowX.css") = True Then
        '    Kill(Application.StartupPath & "\hiliterowX.css")
        'End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdb = rdbTemplateImage1
        Dim FWR As XMLProcess = New XMLProcess
        Dim DT As DataTable = New DataTable
        DT = FWR.XMLDataReading(Application.StartupPath & "\" & rdb.Tag.ToString)
        WriteProperty(DT)
    End Sub

    Private Sub StiliKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StiliKaydetToolStripMenuItem.Click
        Me.SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml"
        Me.SaveFileDialog1.Title = "Stil Kaydetme"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim DT As DataTable = New DataTable
            DT.Columns.Add("NodeName")
            DT.Columns.Add("NodeValue")

            For Each tp As TabPage In Me.tbcCustomDesign.TabPages
                For Each ctrl As Control In tp.Controls
                    If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is NumericUpDown Then
                        Dim DR As DataRow = DT.NewRow
                        If TypeOf ctrl Is TextBox Then
                            DR(0) = CType(ctrl, TextBox).Name
                            DR(1) = CType(ctrl, TextBox).Text
                        ElseIf TypeOf ctrl Is ComboBox Then
                            DR(0) = CType(ctrl, ComboBox).Name
                            DR(1) = CType(ctrl, ComboBox).SelectedItem.ToString
                        ElseIf TypeOf ctrl Is NumericUpDown Then
                            DR(0) = CType(ctrl, NumericUpDown).Name
                            DR(1) = CType(ctrl, NumericUpDown).Value
                        End If
                        DT.Rows.Add(DR)
                    End If
                Next
            Next

            Dim XP As XMLProcess = New XMLProcess
            XP.XMLDataWriting(DT, Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub mnuCustomDesign_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomDesign_Load.Click
        Me.OpenFileDialog1.Filter = "XML Files(*.xml)|*.xml"
        Me.OpenFileDialog1.Title = "Stil Aç"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim DT As DataTable = New DataTable
            Dim XP As XMLProcess = New XMLProcess
            DT = XP.XMLDataReading(Me.OpenFileDialog1.FileName)
            WriteProperty(DT)
            mnuCustomDesign_Apply_Click(sender, e)
        End If
    End Sub

    Private Sub mnuCustomDesign_Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomDesign_Apply.Click
        'Önizleme penceresine deðiþiklikleri uygulayacak..
        WriteHTMLWithStyleText(CreateDataTable)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        mnuCustomDesign_Apply_Click(sender, e)
    End Sub

    Private Sub TemplateDesignItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTemplateImage1.Click, rdbTemplateImage2.Click, rdbTemplateImage3.Click, rdbTemplateImage4.Click, rdbTemplateImage5.Click
        'Hangi stil seçilirse(Þablon yada Özel) ona göre CSS dosyasý HTML e iþleniyor..
        If Me.rdbTemplateDesign.Checked Then
            rdb = CType(sender, RadioButton)
            Dim FWR As XMLProcess = New XMLProcess
            Dim DT As DataTable = New DataTable
            DT = FWR.XMLDataReading(Application.StartupPath & "\" & rdb.Tag.ToString)
            WriteProperty(DT)
        End If

        WriteHTMLWithStyleText(CreateDataTable)
    End Sub

    Private Sub mnuMenu_TableCaption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMenu_TableCaption.Click
        TableCaption = InputBox("Tablonun üstünde görünmesini istediðiniz baþlýðý yazýnýz..", "Tabloya Baþlýk Ekleme")

        TemplateDesignItems_Click(rdb, e)
    End Sub

    Private Sub mnuMenu_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMenu_Save.Click
        Dim InitDirectory As String = ""
        Me.SaveFileDialog1.Title = "Dosya Kaydet"
        Me.SaveFileDialog1.Filter = "HTML Dosyalar(*.html)|*.html;*.htm)"

        'Eger Kaydet 'e OK denirse..
        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'HTML dosya kopyalanýr..
            FileCopy(Application.StartupPath & "\Gecici.html", Me.SaveFileDialog1.FileName)
            'Dosyanýn kaydedildiði klasör yolu alýnýr..
            InitDirectory = Mid(Me.SaveFileDialog1.FileName, 1, Me.SaveFileDialog1.FileName.LastIndexOf("\"))
            '!!!!!
            'CSS dosyasý yazýlýr..
            'FileCopy(Application.StartupPath & "\" & CSSName, InitDirectory & "\" & CSSName)
            'Tablo kaydedildi ve görmek istiyormusunuz msjý..
            DialogResult = MessageBox.Show("Tablonun HTML biçimi " & Chr(34) & InitDirectory & Chr(34) & " adlý dizine kaydedilmiþtir.. Gitmek için " & Chr(34) & "Evet" & Chr(34) & " 'i týklayýnýz..", "Dosya Kaydedildi..", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'Eger kaydedilen dosyalrý oldugu klasöre gitmek istenirse..
            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Shell("explorer.exe " & InitDirectory, AppWinStyle.MaximizedFocus)
            End If
        End If
    End Sub

    Private Sub YenileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YenileToolStripMenuItem.Click
        Me.WebBrowser1.Refresh()
    End Sub
#End Region

#Region "Custom Properties"
    Private Sub btnCellFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCellFont.Click, btnCaptionFont.Click
        If Me.FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If CType(sender, Button).Name = "btnCellFont" Then
                Me.txtCellFont.Text = Me.FontDialog1.Font.Name
            Else
                Me.txtCaptionFont.Text = Me.FontDialog1.Font.Name
            End If
        End If
    End Sub

    Private Sub btnCellBorderColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCellBorderColor.Click, btnBackColorRow.Click, btnCaptionColor.Click, btnColumnBackColor.Click, btnColumnBorderColor.Click, btnFontColorRow.Click, btnHoverBackColorRow.Click, btnHoverFontColorRow.Click, btnTableBorderColor.Click

        If Me.ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim HtmlColorCode As String = ColorTranslator.ToHtml(Me.ColorDialog1.Color)
            Dim Color As Color = Me.ColorDialog1.Color
            If Color = White Then
                Color = Black
            End If

            Select Case CType(sender, Button).Name
                Case "btnCellBorderColor"
                    txtCellBorderColor.Text = HtmlColorCode
                    txtCellBorderColor.ForeColor = Color
                Case "btnBackColorRow"
                    txtBackColorRow.Text = HtmlColorCode
                    txtBackColorRow.ForeColor = Color
                Case "btnCaptionColor"
                    txtCaptionColor.Text = HtmlColorCode
                    txtCaptionColor.ForeColor = Color
                Case "btnColumnBackColor"
                    txtColumnBackColor.Text = HtmlColorCode
                    txtColumnBackColor.ForeColor = Color
                Case "btnColumnBorderColor"
                    txtColumnBorderColor.Text = HtmlColorCode
                    txtColumnBorderColor.ForeColor = Color
                Case "btnFontColorRow"
                    txtFontColorRow.Text = HtmlColorCode
                    txtFontColorRow.ForeColor = Color
                Case "btnHoverBackColorRow"
                    txtHoverBackColorRow.Text = HtmlColorCode
                    txtHoverBackColorRow.ForeColor = Color
                Case "btnHoverFontColorRow"
                    txtHoverFontColorRow.Text = HtmlColorCode
                    txtHoverFontColorRow.ForeColor = Color
                Case "btnTableBorderColor"
                    txtTableBorderColor.Text = HtmlColorCode
                    txtTableBorderColor.ForeColor = Color
            End Select
        End If
    End Sub
#End Region

End Class
