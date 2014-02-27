Imports System.Xml

Public Class FileWriteProcess

    'HTMLFile içeriðine eklenecek metnin olusturulmasý..
    Public Sub WriteHTMLFile(ByVal SourceTable As DataTable, ByVal FilePath As String, ByVal TableCaption As String, ByVal CssText As String)
        '
        'First Statment(HTML File Information)
        '
        Dim TopStatment As String = "<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.0 Transitional//TR" & Chr(34) & " " & Chr(34) & "http://www.w3.org//TR/xhtml1/DTD/xhtml1-transitional.dtd" & Chr(34) & ">" & vbCrLf & _
"<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & ">" & vbCrLf & _
"<head>" & vbCrLf & _
"    <title>" & TableCaption & "</title>" & vbCrLf & _
"<meta http-equiv=" & Chr(34) & "content-type" & Chr(34) & vbCrLf & _
"    content=" & Chr(34) & "text/html; charset=ISO-8859-9" & Chr(34) & " />" & vbCrLf & _
"<Style>" & vbCrLf & _
CssText & vbCrLf & _
"</Style>" & vbCrLf & _
"</head>" & vbCrLf & _
"<body>" & vbCrLf & _
"<table class=" & Chr(34) & "datatable" & Chr(34) & ">" & vbCrLf & vbCrLf & _
"  <caption>" & TableCaption & "</caption>" & vbCrLf & _
"<!--Tablodaki kolon basliklari..-->"

        '
        'SecondStatment(Insert Columns Caption)
        '
        Dim MiddleStatment As String = "        <tr>" & vbCrLf
        For i As Integer = 0 To SourceTable.Columns.Count - 1
            MiddleStatment &= "    <th scope=" & Chr(34) & "col" & Chr(34) & ">" & SourceTable.Columns.Item(i).Caption.ToString & "</th>" & vbCrLf
        Next
        MiddleStatment &= "        </tr>" & vbCrLf

        '
        'ThirdStatment(Drawing Line)
        '
        Dim ThirdStatment As String = ""
        For i As Integer = 0 To SourceTable.Rows.Count - 1
            '==========================
            'Satýr için Comment yazma..
            '==========================
            ThirdStatment &= "<!--" & i & ".satýr -->" & vbCrLf
            '==========================
            'Satýr aþýrý renkendirme..
            '==========================
            If i Mod 2 = 0 Then
                ThirdStatment &= "       <tr>" & vbCrLf
            Else
                ThirdStatment &= "       <tr class=" & Chr(34) & "altrow_" & Chr(34) & ">" & vbCrLf
            End If
            '==========================
            'Satýrlarý Yazma..
            '==========================
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                ThirdStatment &= "    <td>" & SourceTable.Rows(i)(j).ToString & "</td>" & vbCrLf
            Next
            'Satýrý sonlandýrma..
            ThirdStatment &= "       </tr>" & vbCrLf
        Next

        '
        'EndStatement(Closing Statement)
        '
        Dim EndSatetment As String = "<!--Table Body HTML kapanýþ cumleleri..-->" & vbCrLf
        EndSatetment &= "    </table>" & vbCrLf & vbCrLf

        '==========================
        'JavaScript Kodu ve Kapanýþ
        '==========================
        EndSatetment &= "<script type=" & Chr(34) & "text/javascript" & Chr(34) & ">" & vbCrLf & _
        "var rows = document.getElementsByTagName('tr');" & vbCrLf & _
        "for (var i = 0; i < rows.length; i++) {" & vbCrLf & _
        "	rows[i].onmouseover = function() {" & vbCrLf & _
        "		this.className += 'hilite';" & vbCrLf & _
        "	}" & vbCrLf & _
        "	rows[i].onmouseout = function() {" & vbCrLf & _
        "		this.className = this.className.replace('hilite', '');" & vbCrLf & _
        "	}" & vbCrLf & _
        "}" & vbCrLf & _
        "</script>" & vbCrLf & _
        "</body>" & vbCrLf & _
        "</html>" & vbCrLf

        Dim FC As FileCreating = New FileCreating
        FC.WritingCreateFile(FilePath, TopStatment & MiddleStatment & ThirdStatment & EndSatetment)
    End Sub

    'TextFile içeriðine eklenecek metnin olusturulmasý..
    Public Sub WriteTEXTFile(ByVal SourceTable As DataTable, ByVal FilePath As String)
        Dim Statement As String = ""

        For i As Integer = 0 To SourceTable.Rows.Count - 1
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                Statement &= SourceTable.Columns.Item(j).Caption.ToString & " : "
                Statement &= SourceTable.Rows(i)(j).ToString & vbCrLf
            Next
            Statement &= vbCrLf
        Next

        'Belirtilen konuma Text dosya olusturma..
        Dim FC As FileCreating = New FileCreating
        FC.WritingCreateFile(FilePath, Statement)
    End Sub

    'Instance olusturma..
    Public Sub New()

    End Sub
End Class

Public Class FileReading
    Public Function FileRead(ByVal FilePath As String) As String
        Dim Text As String = ""

        Dim FS As System.IO.FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Open, IO.FileAccess.Read)
        Dim SR As System.IO.StreamReader = New System.IO.StreamReader(FS, System.Text.ASCIIEncoding.GetEncoding("ISO-8859-9"))

        Text += SR.ReadToEnd

        SR.Close()
        FS.Close()

        Return Text
    End Function

    Public Sub New()

    End Sub
End Class

Public Class FileCreating

    'Belirtilen konumdaki dosyaya metni ekler..
    Public Sub WritingAppendFile(ByVal FilePath As String, ByVal Text As String)
        Dim FS As System.IO.FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Open, IO.FileAccess.Write)
        Dim SW As System.IO.StreamWriter = New System.IO.StreamWriter(FS, System.Text.ASCIIEncoding.GetEncoding("ISO-8859-9"))

        SW.Write(Text)
        SW.Close()
        FS.Close()
    End Sub

    'Dosya olusturulup kodlarýn eklenmesi..
    Public Sub WritingCreateFile(ByVal FilePath As String, ByVal Text As String)
        'Belirtilen konuma str(eklenecek metni alarak) dosya olusturma..
        Dim FileStream As System.IO.FileStream
        FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Create, IO.FileAccess.Write)

        Dim FileWriter As System.IO.StreamWriter
        FileWriter = New System.IO.StreamWriter(FileStream, System.Text.ASCIIEncoding.GetEncoding("ISO-8859-9"))

        FileWriter.Write(Text)

        FileWriter.Close()
        FileStream.Close()
    End Sub

    Public Sub New()

    End Sub
End Class

Public Class XMLProcess

    Public Sub XMLDataWriting(ByVal DT As DataTable, ByVal FilePath As String)
        Dim XTW As XmlTextWriter = New XmlTextWriter(FilePath, System.Text.ASCIIEncoding.GetEncoding("ISO-8859-9"))

        XTW.Formatting = Formatting.Indented

        XTW.WriteStartDocument()
        XTW.WriteStartElement("root")
        For i As Integer = 0 To DT.Rows.Count - 1
            XTW.WriteElementString(DT.Rows(i)("NodeName").ToString, DT.Rows(i)("NodeValue").ToString)
        Next
        XTW.WriteEndElement()
        XTW.WriteEndDocument()
        XTW.Close()
    End Sub

    Public Function XMLDataReading(ByVal FilePath As String) As DataTable
        'XML'den data okuma..
        Dim DT As DataTable = New DataTable
        DT.Columns.Add("NodeName")
        DT.Columns.Add("NodeValue")
        Dim XTR As XmlTextReader = New XmlTextReader(FilePath)

        While XTR.Read
            If XTR.NodeType = XmlNodeType.Element Then
                Dim DR As DataRow = DT.NewRow
                DR(0) = XTR.Name
                XTR.Read()
                DR(1) = XTR.Value
                DT.Rows.Add(DR)
            End If
        End While

        Return DT
    End Function

    Public Sub New()

    End Sub
End Class

