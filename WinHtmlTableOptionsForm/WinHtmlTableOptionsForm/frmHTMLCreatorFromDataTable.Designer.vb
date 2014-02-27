<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHTMLCreatorFromDataTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHTMLCreatorFromDataTable))
        Me.spcMain = New System.Windows.Forms.SplitContainer
        Me.grpTemplateDesign = New System.Windows.Forms.GroupBox
        Me.pnlTemplateImages = New System.Windows.Forms.Panel
        Me.rdbTemplateImage5 = New System.Windows.Forms.RadioButton
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rdbTemplateImage4 = New System.Windows.Forms.RadioButton
        Me.rdbTemplateImage3 = New System.Windows.Forms.RadioButton
        Me.rdbTemplateImage2 = New System.Windows.Forms.RadioButton
        Me.rdbTemplateImage1 = New System.Windows.Forms.RadioButton
        Me.rdbCustomDesign = New System.Windows.Forms.RadioButton
        Me.rdbTemplateDesign = New System.Windows.Forms.RadioButton
        Me.spcCustomDesign = New System.Windows.Forms.SplitContainer
        Me.grpWebView = New System.Windows.Forms.GroupBox
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.mnuWebBrowser = New System.Windows.Forms.MenuStrip
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMenu_Save = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuMenu_TableCaption = New System.Windows.Forms.ToolStripMenuItem
        Me.YenileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpCustomDesign = New System.Windows.Forms.GroupBox
        Me.btnApply = New System.Windows.Forms.Button
        Me.pnlCustomDesign = New System.Windows.Forms.Panel
        Me.tbcCustomDesign = New System.Windows.Forms.TabControl
        Me.tbpCell = New System.Windows.Forms.TabPage
        Me.cmbCellFontSize = New System.Windows.Forms.ComboBox
        Me.cmbCellPadding = New System.Windows.Forms.ComboBox
        Me.btnCellBorderColor = New System.Windows.Forms.Button
        Me.txtCellBorderColor = New System.Windows.Forms.TextBox
        Me.cmbCellBorderType = New System.Windows.Forms.ComboBox
        Me.cmbCellBorderSize = New System.Windows.Forms.ComboBox
        Me.cmbCellTextAlign = New System.Windows.Forms.ComboBox
        Me.btnCellFont = New System.Windows.Forms.Button
        Me.txtCellFont = New System.Windows.Forms.TextBox
        Me.nudCellWidth = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbpTable = New System.Windows.Forms.TabPage
        Me.cmbTableBorderSize = New System.Windows.Forms.ComboBox
        Me.cmbTableBorderStyle = New System.Windows.Forms.ComboBox
        Me.cmbTableBorderType = New System.Windows.Forms.ComboBox
        Me.btnTableBorderColor = New System.Windows.Forms.Button
        Me.txtTableBorderColor = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbpColumn = New System.Windows.Forms.TabPage
        Me.cmbColumnPaddingLeft = New System.Windows.Forms.ComboBox
        Me.cmbColumnFontBold = New System.Windows.Forms.ComboBox
        Me.cmbColumnTextAlign = New System.Windows.Forms.ComboBox
        Me.btnColumnBackColor = New System.Windows.Forms.Button
        Me.txtColumnBackColor = New System.Windows.Forms.TextBox
        Me.cmbColumnBorderType = New System.Windows.Forms.ComboBox
        Me.btnColumnBorderColor = New System.Windows.Forms.Button
        Me.txtColumnBorderColor = New System.Windows.Forms.TextBox
        Me.cmbColumnBorderSize = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tbpCaption = New System.Windows.Forms.TabPage
        Me.cmbCaptionPaddingBottom = New System.Windows.Forms.ComboBox
        Me.cmbCaptionPaddingTop = New System.Windows.Forms.ComboBox
        Me.cmbCaptionAlign = New System.Windows.Forms.ComboBox
        Me.btnCaptionColor = New System.Windows.Forms.Button
        Me.txtCaptionColor = New System.Windows.Forms.TextBox
        Me.cmbCaptionFontBold = New System.Windows.Forms.ComboBox
        Me.cmbCaptionFontSize = New System.Windows.Forms.ComboBox
        Me.btnCaptionFont = New System.Windows.Forms.Button
        Me.txtCaptionFont = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.tbpJava = New System.Windows.Forms.TabPage
        Me.btnHoverFontColorRow = New System.Windows.Forms.Button
        Me.txtHoverFontColorRow = New System.Windows.Forms.TextBox
        Me.btnHoverBackColorRow = New System.Windows.Forms.Button
        Me.txtHoverBackColorRow = New System.Windows.Forms.TextBox
        Me.btnFontColorRow = New System.Windows.Forms.Button
        Me.txtFontColorRow = New System.Windows.Forms.TextBox
        Me.btnBackColorRow = New System.Windows.Forms.Button
        Me.txtBackColorRow = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.mnuCustomDesign = New System.Windows.Forms.MenuStrip
        Me.mnuCustomDesign_Save = New System.Windows.Forms.ToolStripMenuItem
        Me.StiliKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCustomDesign_Load = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCustomDesign_Apply = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.grpTemplateDesign.SuspendLayout()
        Me.pnlTemplateImages.SuspendLayout()
        Me.spcCustomDesign.Panel1.SuspendLayout()
        Me.spcCustomDesign.Panel2.SuspendLayout()
        Me.spcCustomDesign.SuspendLayout()
        Me.grpWebView.SuspendLayout()
        Me.mnuWebBrowser.SuspendLayout()
        Me.grpCustomDesign.SuspendLayout()
        Me.pnlCustomDesign.SuspendLayout()
        Me.tbcCustomDesign.SuspendLayout()
        Me.tbpCell.SuspendLayout()
        CType(Me.nudCellWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTable.SuspendLayout()
        Me.tbpColumn.SuspendLayout()
        Me.tbpCaption.SuspendLayout()
        Me.tbpJava.SuspendLayout()
        Me.mnuCustomDesign.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcMain
        '
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(8, 8)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.grpTemplateDesign)
        Me.spcMain.Panel1.Controls.Add(Me.rdbCustomDesign)
        Me.spcMain.Panel1.Controls.Add(Me.rdbTemplateDesign)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.spcCustomDesign)
        Me.spcMain.Size = New System.Drawing.Size(879, 612)
        Me.spcMain.SplitterDistance = 207
        Me.spcMain.TabIndex = 4
        '
        'grpTemplateDesign
        '
        Me.grpTemplateDesign.Controls.Add(Me.pnlTemplateImages)
        Me.grpTemplateDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTemplateDesign.Location = New System.Drawing.Point(0, 34)
        Me.grpTemplateDesign.Name = "grpTemplateDesign"
        Me.grpTemplateDesign.Padding = New System.Windows.Forms.Padding(5)
        Me.grpTemplateDesign.Size = New System.Drawing.Size(879, 173)
        Me.grpTemplateDesign.TabIndex = 5
        Me.grpTemplateDesign.TabStop = False
        Me.grpTemplateDesign.Text = "Þablon Tablo Stilleri"
        '
        'pnlTemplateImages
        '
        Me.pnlTemplateImages.AutoScroll = True
        Me.pnlTemplateImages.Controls.Add(Me.rdbTemplateImage5)
        Me.pnlTemplateImages.Controls.Add(Me.rdbTemplateImage4)
        Me.pnlTemplateImages.Controls.Add(Me.rdbTemplateImage3)
        Me.pnlTemplateImages.Controls.Add(Me.rdbTemplateImage2)
        Me.pnlTemplateImages.Controls.Add(Me.rdbTemplateImage1)
        Me.pnlTemplateImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTemplateImages.Location = New System.Drawing.Point(5, 18)
        Me.pnlTemplateImages.Name = "pnlTemplateImages"
        Me.pnlTemplateImages.Size = New System.Drawing.Size(869, 150)
        Me.pnlTemplateImages.TabIndex = 1
        '
        'rdbTemplateImage5
        '
        Me.rdbTemplateImage5.AutoSize = True
        Me.rdbTemplateImage5.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbTemplateImage5.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdbTemplateImage5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.rdbTemplateImage5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbTemplateImage5.ImageKey = "hiliterow5.bmp"
        Me.rdbTemplateImage5.ImageList = Me.ýmageList1
        Me.rdbTemplateImage5.Location = New System.Drawing.Point(800, 0)
        Me.rdbTemplateImage5.Name = "rdbTemplateImage5"
        Me.rdbTemplateImage5.Size = New System.Drawing.Size(200, 133)
        Me.rdbTemplateImage5.TabIndex = 6
        Me.rdbTemplateImage5.Tag = "hiliterow5.xml"
        Me.rdbTemplateImage5.Text = "Gümüþ Tema"
        Me.rdbTemplateImage5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.rdbTemplateImage5, "Resimde görünen temayý kullanarak tablo oluþturur..")
        Me.rdbTemplateImage5.UseVisualStyleBackColor = True
        '
        'ýmageList1
        '
        Me.ýmageList1.ImageStream = CType(resources.GetObject("ýmageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ýmageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ýmageList1.Images.SetKeyName(0, "hiliterow5.bmp")
        Me.ýmageList1.Images.SetKeyName(1, "hiliterow1.bmp")
        Me.ýmageList1.Images.SetKeyName(2, "hiliterow2.bmp")
        Me.ýmageList1.Images.SetKeyName(3, "hiliterow3.bmp")
        Me.ýmageList1.Images.SetKeyName(4, "hiliterow4.bmp")
        '
        'rdbTemplateImage4
        '
        Me.rdbTemplateImage4.AutoSize = True
        Me.rdbTemplateImage4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbTemplateImage4.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdbTemplateImage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rdbTemplateImage4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbTemplateImage4.ImageKey = "hiliterow4.bmp"
        Me.rdbTemplateImage4.ImageList = Me.ýmageList1
        Me.rdbTemplateImage4.Location = New System.Drawing.Point(600, 0)
        Me.rdbTemplateImage4.Name = "rdbTemplateImage4"
        Me.rdbTemplateImage4.Size = New System.Drawing.Size(200, 133)
        Me.rdbTemplateImage4.TabIndex = 5
        Me.rdbTemplateImage4.Tag = "hiliterow4.xml"
        Me.rdbTemplateImage4.Text = "Sarý Tema"
        Me.rdbTemplateImage4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.rdbTemplateImage4, "Resimde görünen temayý kullanarak tablo oluþturur..")
        Me.rdbTemplateImage4.UseVisualStyleBackColor = True
        '
        'rdbTemplateImage3
        '
        Me.rdbTemplateImage3.AutoSize = True
        Me.rdbTemplateImage3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbTemplateImage3.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdbTemplateImage3.ForeColor = System.Drawing.Color.Green
        Me.rdbTemplateImage3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbTemplateImage3.ImageKey = "hiliterow3.bmp"
        Me.rdbTemplateImage3.ImageList = Me.ýmageList1
        Me.rdbTemplateImage3.Location = New System.Drawing.Point(400, 0)
        Me.rdbTemplateImage3.Name = "rdbTemplateImage3"
        Me.rdbTemplateImage3.Size = New System.Drawing.Size(200, 133)
        Me.rdbTemplateImage3.TabIndex = 4
        Me.rdbTemplateImage3.Tag = "hiliterow3.xml"
        Me.rdbTemplateImage3.Text = "Yeþil Tema"
        Me.rdbTemplateImage3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.rdbTemplateImage3, "Resimde görünen temayý kullanarak tablo oluþturur..")
        Me.rdbTemplateImage3.UseVisualStyleBackColor = True
        '
        'rdbTemplateImage2
        '
        Me.rdbTemplateImage2.AutoSize = True
        Me.rdbTemplateImage2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbTemplateImage2.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdbTemplateImage2.ForeColor = System.Drawing.Color.Maroon
        Me.rdbTemplateImage2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbTemplateImage2.ImageKey = "hiliterow2.bmp"
        Me.rdbTemplateImage2.ImageList = Me.ýmageList1
        Me.rdbTemplateImage2.Location = New System.Drawing.Point(200, 0)
        Me.rdbTemplateImage2.Name = "rdbTemplateImage2"
        Me.rdbTemplateImage2.Size = New System.Drawing.Size(200, 133)
        Me.rdbTemplateImage2.TabIndex = 3
        Me.rdbTemplateImage2.Tag = "hiliterow2.xml"
        Me.rdbTemplateImage2.Text = "Kýrmýzý Tema"
        Me.rdbTemplateImage2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.rdbTemplateImage2, "Resimde görünen temayý kullanarak tablo oluþturur..")
        Me.rdbTemplateImage2.UseVisualStyleBackColor = True
        '
        'rdbTemplateImage1
        '
        Me.rdbTemplateImage1.AutoSize = True
        Me.rdbTemplateImage1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdbTemplateImage1.Checked = True
        Me.rdbTemplateImage1.Dock = System.Windows.Forms.DockStyle.Left
        Me.rdbTemplateImage1.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdbTemplateImage1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rdbTemplateImage1.ImageKey = "hiliterow1.bmp"
        Me.rdbTemplateImage1.ImageList = Me.ýmageList1
        Me.rdbTemplateImage1.Location = New System.Drawing.Point(0, 0)
        Me.rdbTemplateImage1.Name = "rdbTemplateImage1"
        Me.rdbTemplateImage1.Size = New System.Drawing.Size(200, 133)
        Me.rdbTemplateImage1.TabIndex = 2
        Me.rdbTemplateImage1.TabStop = True
        Me.rdbTemplateImage1.Tag = "hiliterow1.xml"
        Me.rdbTemplateImage1.Text = "Mavi Tema"
        Me.rdbTemplateImage1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.rdbTemplateImage1, "Resimde görünen temayý kullanarak tablo oluþturur..")
        Me.rdbTemplateImage1.UseVisualStyleBackColor = True
        '
        'rdbCustomDesign
        '
        Me.rdbCustomDesign.AutoSize = True
        Me.rdbCustomDesign.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.rdbCustomDesign.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdbCustomDesign.Location = New System.Drawing.Point(0, 17)
        Me.rdbCustomDesign.Name = "rdbCustomDesign"
        Me.rdbCustomDesign.Size = New System.Drawing.Size(879, 17)
        Me.rdbCustomDesign.TabIndex = 4
        Me.rdbCustomDesign.TabStop = True
        Me.rdbCustomDesign.Text = "Özelleþtirilmiþ Tablo Stilini Kullan"
        Me.rdbCustomDesign.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.rdbCustomDesign, "Kendi tablo ayarlarýnýzý yükleyerek veya oluþturarak tema oluþturmanýzý saðlar..")
        Me.rdbCustomDesign.UseVisualStyleBackColor = True
        '
        'rdbTemplateDesign
        '
        Me.rdbTemplateDesign.AutoSize = True
        Me.rdbTemplateDesign.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdbTemplateDesign.Checked = True
        Me.rdbTemplateDesign.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdbTemplateDesign.Location = New System.Drawing.Point(0, 0)
        Me.rdbTemplateDesign.Name = "rdbTemplateDesign"
        Me.rdbTemplateDesign.Size = New System.Drawing.Size(879, 17)
        Me.rdbTemplateDesign.TabIndex = 3
        Me.rdbTemplateDesign.TabStop = True
        Me.rdbTemplateDesign.Text = "Þablon Tablo Stili Kullan"
        Me.rdbTemplateDesign.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.rdbTemplateDesign, "Var olan tablo þablonlarýný kullanmanýzý saðlar..")
        Me.rdbTemplateDesign.UseVisualStyleBackColor = True
        '
        'spcCustomDesign
        '
        Me.spcCustomDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCustomDesign.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spcCustomDesign.Location = New System.Drawing.Point(0, 0)
        Me.spcCustomDesign.Name = "spcCustomDesign"
        '
        'spcCustomDesign.Panel1
        '
        Me.spcCustomDesign.Panel1.Controls.Add(Me.grpWebView)
        '
        'spcCustomDesign.Panel2
        '
        Me.spcCustomDesign.Panel2.Controls.Add(Me.grpCustomDesign)
        Me.spcCustomDesign.Size = New System.Drawing.Size(879, 401)
        Me.spcCustomDesign.SplitterDistance = 566
        Me.spcCustomDesign.TabIndex = 7
        '
        'grpWebView
        '
        Me.grpWebView.Controls.Add(Me.WebBrowser1)
        Me.grpWebView.Controls.Add(Me.mnuWebBrowser)
        Me.grpWebView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpWebView.Location = New System.Drawing.Point(0, 0)
        Me.grpWebView.Name = "grpWebView"
        Me.grpWebView.Padding = New System.Windows.Forms.Padding(5)
        Me.grpWebView.Size = New System.Drawing.Size(566, 401)
        Me.grpWebView.TabIndex = 0
        Me.grpWebView.TabStop = False
        Me.grpWebView.Text = "Tablo Önizleme"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(5, 42)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(556, 354)
        Me.WebBrowser1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.WebBrowser1, "Seçtiðiniz stil ile tablonuzun nasýl görüneceðinin önizlemesini gösterir..")
        '
        'mnuWebBrowser
        '
        Me.mnuWebBrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu, Me.YenileToolStripMenuItem})
        Me.mnuWebBrowser.Location = New System.Drawing.Point(5, 18)
        Me.mnuWebBrowser.Name = "mnuWebBrowser"
        Me.mnuWebBrowser.Size = New System.Drawing.Size(556, 24)
        Me.mnuWebBrowser.TabIndex = 2
        Me.mnuWebBrowser.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu_Save, Me.ToolStripMenuItem2, Me.mnuMenu_TableCaption})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(45, 20)
        Me.mnuMenu.Text = "Menü"
        '
        'mnuMenu_Save
        '
        Me.mnuMenu_Save.Image = CType(resources.GetObject("mnuMenu_Save.Image"), System.Drawing.Image)
        Me.mnuMenu_Save.ImageTransparentColor = System.Drawing.Color.White
        Me.mnuMenu_Save.Name = "mnuMenu_Save"
        Me.mnuMenu_Save.Size = New System.Drawing.Size(185, 22)
        Me.mnuMenu_Save.Text = "Yazdýrma Ýçin Kaydet"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(182, 6)
        '
        'mnuMenu_TableCaption
        '
        Me.mnuMenu_TableCaption.Name = "mnuMenu_TableCaption"
        Me.mnuMenu_TableCaption.Size = New System.Drawing.Size(185, 22)
        Me.mnuMenu_TableCaption.Text = "Tablo Baþlýðý Ekle"
        '
        'YenileToolStripMenuItem
        '
        Me.YenileToolStripMenuItem.Image = CType(resources.GetObject("YenileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.YenileToolStripMenuItem.Name = "YenileToolStripMenuItem"
        Me.YenileToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.YenileToolStripMenuItem.Text = "Yenile"
        '
        'grpCustomDesign
        '
        Me.grpCustomDesign.Controls.Add(Me.btnApply)
        Me.grpCustomDesign.Controls.Add(Me.pnlCustomDesign)
        Me.grpCustomDesign.Controls.Add(Me.mnuCustomDesign)
        Me.grpCustomDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCustomDesign.Enabled = False
        Me.grpCustomDesign.Location = New System.Drawing.Point(0, 0)
        Me.grpCustomDesign.Name = "grpCustomDesign"
        Me.grpCustomDesign.Padding = New System.Windows.Forms.Padding(5)
        Me.grpCustomDesign.Size = New System.Drawing.Size(309, 401)
        Me.grpCustomDesign.TabIndex = 1
        Me.grpCustomDesign.TabStop = False
        Me.grpCustomDesign.Text = "Özel Tablo Stili"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(217, 19)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(87, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Uygula !"
        Me.ToolTip1.SetToolTip(Me.btnApply, "Yaptýðýnýz deðiþikliklerin önizlemede geçerli olmasýný saðlar..")
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'pnlCustomDesign
        '
        Me.pnlCustomDesign.AutoScroll = True
        Me.pnlCustomDesign.Controls.Add(Me.tbcCustomDesign)
        Me.pnlCustomDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomDesign.Location = New System.Drawing.Point(5, 42)
        Me.pnlCustomDesign.Name = "pnlCustomDesign"
        Me.pnlCustomDesign.Size = New System.Drawing.Size(299, 354)
        Me.pnlCustomDesign.TabIndex = 4
        '
        'tbcCustomDesign
        '
        Me.tbcCustomDesign.Controls.Add(Me.tbpCell)
        Me.tbcCustomDesign.Controls.Add(Me.tbpTable)
        Me.tbcCustomDesign.Controls.Add(Me.tbpColumn)
        Me.tbcCustomDesign.Controls.Add(Me.tbpCaption)
        Me.tbcCustomDesign.Controls.Add(Me.tbpJava)
        Me.tbcCustomDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcCustomDesign.Location = New System.Drawing.Point(0, 0)
        Me.tbcCustomDesign.Name = "tbcCustomDesign"
        Me.tbcCustomDesign.SelectedIndex = 0
        Me.tbcCustomDesign.Size = New System.Drawing.Size(299, 354)
        Me.tbcCustomDesign.TabIndex = 0
        '
        'tbpCell
        '
        Me.tbpCell.Controls.Add(Me.cmbCellFontSize)
        Me.tbpCell.Controls.Add(Me.cmbCellPadding)
        Me.tbpCell.Controls.Add(Me.btnCellBorderColor)
        Me.tbpCell.Controls.Add(Me.txtCellBorderColor)
        Me.tbpCell.Controls.Add(Me.cmbCellBorderType)
        Me.tbpCell.Controls.Add(Me.cmbCellBorderSize)
        Me.tbpCell.Controls.Add(Me.cmbCellTextAlign)
        Me.tbpCell.Controls.Add(Me.btnCellFont)
        Me.tbpCell.Controls.Add(Me.txtCellFont)
        Me.tbpCell.Controls.Add(Me.nudCellWidth)
        Me.tbpCell.Controls.Add(Me.Label11)
        Me.tbpCell.Controls.Add(Me.Label12)
        Me.tbpCell.Controls.Add(Me.Label4)
        Me.tbpCell.Controls.Add(Me.Label5)
        Me.tbpCell.Controls.Add(Me.Label6)
        Me.tbpCell.Controls.Add(Me.Label3)
        Me.tbpCell.Controls.Add(Me.Label2)
        Me.tbpCell.Controls.Add(Me.Label1)
        Me.tbpCell.Location = New System.Drawing.Point(4, 22)
        Me.tbpCell.Name = "tbpCell"
        Me.tbpCell.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.tbpCell.Size = New System.Drawing.Size(291, 328)
        Me.tbpCell.TabIndex = 0
        Me.tbpCell.Text = "Hücre Özellikleri"
        Me.tbpCell.UseVisualStyleBackColor = True
        '
        'cmbCellFontSize
        '
        Me.cmbCellFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCellFontSize.FormattingEnabled = True
        Me.cmbCellFontSize.Items.AddRange(New Object() {"6pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "18pt", "24pt"})
        Me.cmbCellFontSize.Location = New System.Drawing.Point(182, 67)
        Me.cmbCellFontSize.Name = "cmbCellFontSize"
        Me.cmbCellFontSize.Size = New System.Drawing.Size(100, 21)
        Me.cmbCellFontSize.TabIndex = 61
        '
        'cmbCellPadding
        '
        Me.cmbCellPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCellPadding.FormattingEnabled = True
        Me.cmbCellPadding.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px", "10px", "11px", "12px", "13px", "14px", "15px"})
        Me.cmbCellPadding.Location = New System.Drawing.Point(182, 200)
        Me.cmbCellPadding.Name = "cmbCellPadding"
        Me.cmbCellPadding.Size = New System.Drawing.Size(100, 21)
        Me.cmbCellPadding.TabIndex = 60
        '
        'btnCellBorderColor
        '
        Me.btnCellBorderColor.Location = New System.Drawing.Point(136, 174)
        Me.btnCellBorderColor.Name = "btnCellBorderColor"
        Me.btnCellBorderColor.Size = New System.Drawing.Size(40, 20)
        Me.btnCellBorderColor.TabIndex = 59
        Me.btnCellBorderColor.Text = "Seç"
        Me.btnCellBorderColor.UseVisualStyleBackColor = True
        '
        'txtCellBorderColor
        '
        Me.txtCellBorderColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCellBorderColor.Location = New System.Drawing.Point(182, 174)
        Me.txtCellBorderColor.Name = "txtCellBorderColor"
        Me.txtCellBorderColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCellBorderColor.TabIndex = 58
        '
        'cmbCellBorderType
        '
        Me.cmbCellBorderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCellBorderType.FormattingEnabled = True
        Me.cmbCellBorderType.Items.AddRange(New Object() {"none", "dotted", "dashed", "solid", "double", "groove", "ridge", "inset", "outset"})
        Me.cmbCellBorderType.Location = New System.Drawing.Point(182, 147)
        Me.cmbCellBorderType.Name = "cmbCellBorderType"
        Me.cmbCellBorderType.Size = New System.Drawing.Size(100, 21)
        Me.cmbCellBorderType.TabIndex = 57
        '
        'cmbCellBorderSize
        '
        Me.cmbCellBorderSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCellBorderSize.FormattingEnabled = True
        Me.cmbCellBorderSize.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px"})
        Me.cmbCellBorderSize.Location = New System.Drawing.Point(182, 120)
        Me.cmbCellBorderSize.Name = "cmbCellBorderSize"
        Me.cmbCellBorderSize.Size = New System.Drawing.Size(100, 21)
        Me.cmbCellBorderSize.TabIndex = 56
        '
        'cmbCellTextAlign
        '
        Me.cmbCellTextAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCellTextAlign.FormattingEnabled = True
        Me.cmbCellTextAlign.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.cmbCellTextAlign.Location = New System.Drawing.Point(182, 93)
        Me.cmbCellTextAlign.Name = "cmbCellTextAlign"
        Me.cmbCellTextAlign.Size = New System.Drawing.Size(100, 21)
        Me.cmbCellTextAlign.TabIndex = 55
        '
        'btnCellFont
        '
        Me.btnCellFont.Location = New System.Drawing.Point(136, 41)
        Me.btnCellFont.Name = "btnCellFont"
        Me.btnCellFont.Size = New System.Drawing.Size(40, 20)
        Me.btnCellFont.TabIndex = 53
        Me.btnCellFont.Text = "Seç"
        Me.btnCellFont.UseVisualStyleBackColor = True
        '
        'txtCellFont
        '
        Me.txtCellFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCellFont.Location = New System.Drawing.Point(182, 41)
        Me.txtCellFont.Name = "txtCellFont"
        Me.txtCellFont.Size = New System.Drawing.Size(100, 20)
        Me.txtCellFont.TabIndex = 52
        '
        'nudCellWidth
        '
        Me.nudCellWidth.Location = New System.Drawing.Point(182, 15)
        Me.nudCellWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCellWidth.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCellWidth.Name = "nudCellWidth"
        Me.nudCellWidth.Size = New System.Drawing.Size(100, 20)
        Me.nudCellWidth.TabIndex = 51
        Me.nudCellWidth.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Hücre Padding :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Hücre Kenarlýk Rengi :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Hücre Metin Hizalama : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Hücre Kenarlýk Geniþliði :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Hücre Kenarlýk Tipi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Hücre Yazý Boyutu :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Hücre Yazý Tipi :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Hücre Geniþliði :"
        '
        'tbpTable
        '
        Me.tbpTable.Controls.Add(Me.cmbTableBorderSize)
        Me.tbpTable.Controls.Add(Me.cmbTableBorderStyle)
        Me.tbpTable.Controls.Add(Me.cmbTableBorderType)
        Me.tbpTable.Controls.Add(Me.btnTableBorderColor)
        Me.tbpTable.Controls.Add(Me.txtTableBorderColor)
        Me.tbpTable.Controls.Add(Me.Label7)
        Me.tbpTable.Controls.Add(Me.Label8)
        Me.tbpTable.Controls.Add(Me.Label9)
        Me.tbpTable.Controls.Add(Me.Label10)
        Me.tbpTable.Location = New System.Drawing.Point(4, 22)
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.tbpTable.Size = New System.Drawing.Size(291, 328)
        Me.tbpTable.TabIndex = 1
        Me.tbpTable.Text = "Tablo Özellikleri"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'cmbTableBorderSize
        '
        Me.cmbTableBorderSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableBorderSize.FormattingEnabled = True
        Me.cmbTableBorderSize.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px"})
        Me.cmbTableBorderSize.Location = New System.Drawing.Point(182, 12)
        Me.cmbTableBorderSize.Name = "cmbTableBorderSize"
        Me.cmbTableBorderSize.Size = New System.Drawing.Size(100, 21)
        Me.cmbTableBorderSize.TabIndex = 64
        '
        'cmbTableBorderStyle
        '
        Me.cmbTableBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableBorderStyle.FormattingEnabled = True
        Me.cmbTableBorderStyle.Items.AddRange(New Object() {"none", "collapse"})
        Me.cmbTableBorderStyle.Location = New System.Drawing.Point(182, 92)
        Me.cmbTableBorderStyle.Name = "cmbTableBorderStyle"
        Me.cmbTableBorderStyle.Size = New System.Drawing.Size(100, 21)
        Me.cmbTableBorderStyle.TabIndex = 63
        '
        'cmbTableBorderType
        '
        Me.cmbTableBorderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableBorderType.FormattingEnabled = True
        Me.cmbTableBorderType.Items.AddRange(New Object() {"none", "dotted", "dashed", "solid", "double", "groove", "ridge", "inset", "outset"})
        Me.cmbTableBorderType.Location = New System.Drawing.Point(182, 65)
        Me.cmbTableBorderType.Name = "cmbTableBorderType"
        Me.cmbTableBorderType.Size = New System.Drawing.Size(100, 21)
        Me.cmbTableBorderType.TabIndex = 62
        '
        'btnTableBorderColor
        '
        Me.btnTableBorderColor.Location = New System.Drawing.Point(136, 39)
        Me.btnTableBorderColor.Name = "btnTableBorderColor"
        Me.btnTableBorderColor.Size = New System.Drawing.Size(40, 20)
        Me.btnTableBorderColor.TabIndex = 61
        Me.btnTableBorderColor.Text = "Seç"
        Me.btnTableBorderColor.UseVisualStyleBackColor = True
        '
        'txtTableBorderColor
        '
        Me.txtTableBorderColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTableBorderColor.Location = New System.Drawing.Point(182, 39)
        Me.txtTableBorderColor.Name = "txtTableBorderColor"
        Me.txtTableBorderColor.Size = New System.Drawing.Size(100, 20)
        Me.txtTableBorderColor.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Tablo Kenarlýk Rengi :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Tablo Kenarlýk Tipi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Tablo Kenarlýk Stili :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Tablo Kenarlýk Geniþliði :"
        '
        'tbpColumn
        '
        Me.tbpColumn.Controls.Add(Me.cmbColumnPaddingLeft)
        Me.tbpColumn.Controls.Add(Me.cmbColumnFontBold)
        Me.tbpColumn.Controls.Add(Me.cmbColumnTextAlign)
        Me.tbpColumn.Controls.Add(Me.btnColumnBackColor)
        Me.tbpColumn.Controls.Add(Me.txtColumnBackColor)
        Me.tbpColumn.Controls.Add(Me.cmbColumnBorderType)
        Me.tbpColumn.Controls.Add(Me.btnColumnBorderColor)
        Me.tbpColumn.Controls.Add(Me.txtColumnBorderColor)
        Me.tbpColumn.Controls.Add(Me.cmbColumnBorderSize)
        Me.tbpColumn.Controls.Add(Me.Label17)
        Me.tbpColumn.Controls.Add(Me.Label18)
        Me.tbpColumn.Controls.Add(Me.Label20)
        Me.tbpColumn.Controls.Add(Me.Label13)
        Me.tbpColumn.Controls.Add(Me.Label14)
        Me.tbpColumn.Controls.Add(Me.Label15)
        Me.tbpColumn.Controls.Add(Me.Label16)
        Me.tbpColumn.Location = New System.Drawing.Point(4, 22)
        Me.tbpColumn.Name = "tbpColumn"
        Me.tbpColumn.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.tbpColumn.Size = New System.Drawing.Size(291, 328)
        Me.tbpColumn.TabIndex = 2
        Me.tbpColumn.Text = "Kolon Özellikleri"
        Me.tbpColumn.UseVisualStyleBackColor = True
        '
        'cmbColumnPaddingLeft
        '
        Me.cmbColumnPaddingLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumnPaddingLeft.FormattingEnabled = True
        Me.cmbColumnPaddingLeft.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px", "10px", "11px", "12px", "13px", "14px", "15px"})
        Me.cmbColumnPaddingLeft.Location = New System.Drawing.Point(182, 173)
        Me.cmbColumnPaddingLeft.Name = "cmbColumnPaddingLeft"
        Me.cmbColumnPaddingLeft.Size = New System.Drawing.Size(100, 21)
        Me.cmbColumnPaddingLeft.TabIndex = 71
        '
        'cmbColumnFontBold
        '
        Me.cmbColumnFontBold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumnFontBold.FormattingEnabled = True
        Me.cmbColumnFontBold.Items.AddRange(New Object() {"normal", "bolder", "bold", "lighter", "100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.cmbColumnFontBold.Location = New System.Drawing.Point(182, 146)
        Me.cmbColumnFontBold.Name = "cmbColumnFontBold"
        Me.cmbColumnFontBold.Size = New System.Drawing.Size(100, 21)
        Me.cmbColumnFontBold.TabIndex = 70
        '
        'cmbColumnTextAlign
        '
        Me.cmbColumnTextAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumnTextAlign.FormattingEnabled = True
        Me.cmbColumnTextAlign.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.cmbColumnTextAlign.Location = New System.Drawing.Point(182, 119)
        Me.cmbColumnTextAlign.Name = "cmbColumnTextAlign"
        Me.cmbColumnTextAlign.Size = New System.Drawing.Size(100, 21)
        Me.cmbColumnTextAlign.TabIndex = 69
        '
        'btnColumnBackColor
        '
        Me.btnColumnBackColor.Location = New System.Drawing.Point(136, 93)
        Me.btnColumnBackColor.Name = "btnColumnBackColor"
        Me.btnColumnBackColor.Size = New System.Drawing.Size(40, 20)
        Me.btnColumnBackColor.TabIndex = 68
        Me.btnColumnBackColor.Text = "Seç"
        Me.btnColumnBackColor.UseVisualStyleBackColor = True
        '
        'txtColumnBackColor
        '
        Me.txtColumnBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtColumnBackColor.Location = New System.Drawing.Point(182, 93)
        Me.txtColumnBackColor.Name = "txtColumnBackColor"
        Me.txtColumnBackColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnBackColor.TabIndex = 67
        '
        'cmbColumnBorderType
        '
        Me.cmbColumnBorderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumnBorderType.FormattingEnabled = True
        Me.cmbColumnBorderType.Items.AddRange(New Object() {"none", "dotted", "dashed", "solid", "double", "groove", "ridge", "inset", "outset"})
        Me.cmbColumnBorderType.Location = New System.Drawing.Point(182, 66)
        Me.cmbColumnBorderType.Name = "cmbColumnBorderType"
        Me.cmbColumnBorderType.Size = New System.Drawing.Size(100, 21)
        Me.cmbColumnBorderType.TabIndex = 66
        '
        'btnColumnBorderColor
        '
        Me.btnColumnBorderColor.Location = New System.Drawing.Point(136, 40)
        Me.btnColumnBorderColor.Name = "btnColumnBorderColor"
        Me.btnColumnBorderColor.Size = New System.Drawing.Size(40, 20)
        Me.btnColumnBorderColor.TabIndex = 65
        Me.btnColumnBorderColor.Text = "Seç"
        Me.btnColumnBorderColor.UseVisualStyleBackColor = True
        '
        'txtColumnBorderColor
        '
        Me.txtColumnBorderColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtColumnBorderColor.Location = New System.Drawing.Point(182, 40)
        Me.txtColumnBorderColor.Name = "txtColumnBorderColor"
        Me.txtColumnBorderColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColumnBorderColor.TabIndex = 64
        '
        'cmbColumnBorderSize
        '
        Me.cmbColumnBorderSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColumnBorderSize.FormattingEnabled = True
        Me.cmbColumnBorderSize.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px"})
        Me.cmbColumnBorderSize.Location = New System.Drawing.Point(182, 13)
        Me.cmbColumnBorderSize.Name = "cmbColumnBorderSize"
        Me.cmbColumnBorderSize.Size = New System.Drawing.Size(100, 21)
        Me.cmbColumnBorderSize.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Kolon Kalýn Yazý :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Kolon Padding Sol :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Kolon Metin Hizalama :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Kolon Kenarlýk Rengi :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Kolon Kenarlýk Tipi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Kolon Arkaplan Rengi :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Kolon Kenarlýk Geniþliði :"
        '
        'tbpCaption
        '
        Me.tbpCaption.Controls.Add(Me.cmbCaptionPaddingBottom)
        Me.tbpCaption.Controls.Add(Me.cmbCaptionPaddingTop)
        Me.tbpCaption.Controls.Add(Me.cmbCaptionAlign)
        Me.tbpCaption.Controls.Add(Me.btnCaptionColor)
        Me.tbpCaption.Controls.Add(Me.txtCaptionColor)
        Me.tbpCaption.Controls.Add(Me.cmbCaptionFontBold)
        Me.tbpCaption.Controls.Add(Me.cmbCaptionFontSize)
        Me.tbpCaption.Controls.Add(Me.btnCaptionFont)
        Me.tbpCaption.Controls.Add(Me.txtCaptionFont)
        Me.tbpCaption.Controls.Add(Me.Label31)
        Me.tbpCaption.Controls.Add(Me.Label19)
        Me.tbpCaption.Controls.Add(Me.Label22)
        Me.tbpCaption.Controls.Add(Me.Label23)
        Me.tbpCaption.Controls.Add(Me.Label24)
        Me.tbpCaption.Controls.Add(Me.Label25)
        Me.tbpCaption.Controls.Add(Me.Label26)
        Me.tbpCaption.Location = New System.Drawing.Point(4, 22)
        Me.tbpCaption.Name = "tbpCaption"
        Me.tbpCaption.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.tbpCaption.Size = New System.Drawing.Size(291, 328)
        Me.tbpCaption.TabIndex = 3
        Me.tbpCaption.Text = "Baþlýk Özellikleri"
        Me.tbpCaption.UseVisualStyleBackColor = True
        '
        'cmbCaptionPaddingBottom
        '
        Me.cmbCaptionPaddingBottom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaptionPaddingBottom.FormattingEnabled = True
        Me.cmbCaptionPaddingBottom.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px", "10px", "11px", "12px", "13px", "14px", "15px"})
        Me.cmbCaptionPaddingBottom.Location = New System.Drawing.Point(182, 173)
        Me.cmbCaptionPaddingBottom.Name = "cmbCaptionPaddingBottom"
        Me.cmbCaptionPaddingBottom.Size = New System.Drawing.Size(100, 21)
        Me.cmbCaptionPaddingBottom.TabIndex = 76
        '
        'cmbCaptionPaddingTop
        '
        Me.cmbCaptionPaddingTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaptionPaddingTop.FormattingEnabled = True
        Me.cmbCaptionPaddingTop.Items.AddRange(New Object() {"0px", "1px", "2px", "3px", "4px", "5px", "6px", "7px", "8px", "9px", "10px", "11px", "12px", "13px", "14px", "15px"})
        Me.cmbCaptionPaddingTop.Location = New System.Drawing.Point(182, 146)
        Me.cmbCaptionPaddingTop.Name = "cmbCaptionPaddingTop"
        Me.cmbCaptionPaddingTop.Size = New System.Drawing.Size(100, 21)
        Me.cmbCaptionPaddingTop.TabIndex = 75
        '
        'cmbCaptionAlign
        '
        Me.cmbCaptionAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaptionAlign.FormattingEnabled = True
        Me.cmbCaptionAlign.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.cmbCaptionAlign.Location = New System.Drawing.Point(182, 119)
        Me.cmbCaptionAlign.Name = "cmbCaptionAlign"
        Me.cmbCaptionAlign.Size = New System.Drawing.Size(100, 21)
        Me.cmbCaptionAlign.TabIndex = 74
        '
        'btnCaptionColor
        '
        Me.btnCaptionColor.Location = New System.Drawing.Point(136, 93)
        Me.btnCaptionColor.Name = "btnCaptionColor"
        Me.btnCaptionColor.Size = New System.Drawing.Size(40, 20)
        Me.btnCaptionColor.TabIndex = 73
        Me.btnCaptionColor.Text = "Seç"
        Me.btnCaptionColor.UseVisualStyleBackColor = True
        '
        'txtCaptionColor
        '
        Me.txtCaptionColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCaptionColor.Location = New System.Drawing.Point(182, 93)
        Me.txtCaptionColor.Name = "txtCaptionColor"
        Me.txtCaptionColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCaptionColor.TabIndex = 72
        '
        'cmbCaptionFontBold
        '
        Me.cmbCaptionFontBold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaptionFontBold.FormattingEnabled = True
        Me.cmbCaptionFontBold.Items.AddRange(New Object() {"normal", "bolder", "bold", "lighter", "100", "200", "300", "400", "500", "600", "700", "800", "900"})
        Me.cmbCaptionFontBold.Location = New System.Drawing.Point(182, 66)
        Me.cmbCaptionFontBold.Name = "cmbCaptionFontBold"
        Me.cmbCaptionFontBold.Size = New System.Drawing.Size(100, 21)
        Me.cmbCaptionFontBold.TabIndex = 71
        '
        'cmbCaptionFontSize
        '
        Me.cmbCaptionFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaptionFontSize.FormattingEnabled = True
        Me.cmbCaptionFontSize.Items.AddRange(New Object() {"6pt", "8pt", "9pt", "10pt", "11pt", "12pt", "13pt", "14pt", "15pt", "16pt", "18pt", "24pt"})
        Me.cmbCaptionFontSize.Location = New System.Drawing.Point(182, 39)
        Me.cmbCaptionFontSize.Name = "cmbCaptionFontSize"
        Me.cmbCaptionFontSize.Size = New System.Drawing.Size(100, 21)
        Me.cmbCaptionFontSize.TabIndex = 70
        '
        'btnCaptionFont
        '
        Me.btnCaptionFont.Location = New System.Drawing.Point(136, 13)
        Me.btnCaptionFont.Name = "btnCaptionFont"
        Me.btnCaptionFont.Size = New System.Drawing.Size(40, 20)
        Me.btnCaptionFont.TabIndex = 69
        Me.btnCaptionFont.Text = "Seç"
        Me.btnCaptionFont.UseVisualStyleBackColor = True
        '
        'txtCaptionFont
        '
        Me.txtCaptionFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCaptionFont.Location = New System.Drawing.Point(182, 13)
        Me.txtCaptionFont.Name = "txtCaptionFont"
        Me.txtCaptionFont.Size = New System.Drawing.Size(100, 20)
        Me.txtCaptionFont.TabIndex = 68
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(9, 176)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 13)
        Me.Label31.TabIndex = 67
        Me.Label31.Text = "Baþlýk Padding Alt :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 149)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Baþlýk Padding Üst :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 13)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Baþlýk Metin Hizalama :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 64
        Me.Label23.Text = "Baþlýk Yazý Boyutu :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 69)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 13)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Baþlýk Kalýn Yazý :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Baþlýk Rengi :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "Baþlýk Yazý Tipi :"
        '
        'tbpJava
        '
        Me.tbpJava.Controls.Add(Me.btnHoverFontColorRow)
        Me.tbpJava.Controls.Add(Me.txtHoverFontColorRow)
        Me.tbpJava.Controls.Add(Me.btnHoverBackColorRow)
        Me.tbpJava.Controls.Add(Me.txtHoverBackColorRow)
        Me.tbpJava.Controls.Add(Me.btnFontColorRow)
        Me.tbpJava.Controls.Add(Me.txtFontColorRow)
        Me.tbpJava.Controls.Add(Me.btnBackColorRow)
        Me.tbpJava.Controls.Add(Me.txtBackColorRow)
        Me.tbpJava.Controls.Add(Me.Label27)
        Me.tbpJava.Controls.Add(Me.Label28)
        Me.tbpJava.Controls.Add(Me.Label29)
        Me.tbpJava.Controls.Add(Me.Label30)
        Me.tbpJava.Location = New System.Drawing.Point(4, 22)
        Me.tbpJava.Name = "tbpJava"
        Me.tbpJava.Padding = New System.Windows.Forms.Padding(6, 10, 6, 6)
        Me.tbpJava.Size = New System.Drawing.Size(291, 328)
        Me.tbpJava.TabIndex = 4
        Me.tbpJava.Text = "Görsel Özellikler"
        Me.tbpJava.UseVisualStyleBackColor = True
        '
        'btnHoverFontColorRow
        '
        Me.btnHoverFontColorRow.Location = New System.Drawing.Point(12, 149)
        Me.btnHoverFontColorRow.Name = "btnHoverFontColorRow"
        Me.btnHoverFontColorRow.Size = New System.Drawing.Size(40, 20)
        Me.btnHoverFontColorRow.TabIndex = 77
        Me.btnHoverFontColorRow.Text = "Seç"
        Me.btnHoverFontColorRow.UseVisualStyleBackColor = True
        '
        'txtHoverFontColorRow
        '
        Me.txtHoverFontColorRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtHoverFontColorRow.Location = New System.Drawing.Point(58, 149)
        Me.txtHoverFontColorRow.Name = "txtHoverFontColorRow"
        Me.txtHoverFontColorRow.Size = New System.Drawing.Size(100, 20)
        Me.txtHoverFontColorRow.TabIndex = 76
        '
        'btnHoverBackColorRow
        '
        Me.btnHoverBackColorRow.Location = New System.Drawing.Point(12, 110)
        Me.btnHoverBackColorRow.Name = "btnHoverBackColorRow"
        Me.btnHoverBackColorRow.Size = New System.Drawing.Size(40, 20)
        Me.btnHoverBackColorRow.TabIndex = 75
        Me.btnHoverBackColorRow.Text = "Seç"
        Me.btnHoverBackColorRow.UseVisualStyleBackColor = True
        '
        'txtHoverBackColorRow
        '
        Me.txtHoverBackColorRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtHoverBackColorRow.Location = New System.Drawing.Point(58, 110)
        Me.txtHoverBackColorRow.Name = "txtHoverBackColorRow"
        Me.txtHoverBackColorRow.Size = New System.Drawing.Size(100, 20)
        Me.txtHoverBackColorRow.TabIndex = 74
        '
        'btnFontColorRow
        '
        Me.btnFontColorRow.Location = New System.Drawing.Point(12, 71)
        Me.btnFontColorRow.Name = "btnFontColorRow"
        Me.btnFontColorRow.Size = New System.Drawing.Size(40, 20)
        Me.btnFontColorRow.TabIndex = 73
        Me.btnFontColorRow.Text = "Seç"
        Me.btnFontColorRow.UseVisualStyleBackColor = True
        '
        'txtFontColorRow
        '
        Me.txtFontColorRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFontColorRow.Location = New System.Drawing.Point(58, 71)
        Me.txtFontColorRow.Name = "txtFontColorRow"
        Me.txtFontColorRow.Size = New System.Drawing.Size(100, 20)
        Me.txtFontColorRow.TabIndex = 72
        '
        'btnBackColorRow
        '
        Me.btnBackColorRow.Location = New System.Drawing.Point(12, 32)
        Me.btnBackColorRow.Name = "btnBackColorRow"
        Me.btnBackColorRow.Size = New System.Drawing.Size(40, 20)
        Me.btnBackColorRow.TabIndex = 71
        Me.btnBackColorRow.Text = "Seç"
        Me.btnBackColorRow.UseVisualStyleBackColor = True
        '
        'txtBackColorRow
        '
        Me.txtBackColorRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBackColorRow.Location = New System.Drawing.Point(58, 32)
        Me.txtBackColorRow.Name = "txtBackColorRow"
        Me.txtBackColorRow.Size = New System.Drawing.Size(100, 20)
        Me.txtBackColorRow.TabIndex = 70
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 133)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(140, 13)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "Üstüne Gelince Yazý Rengi :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(143, 13)
        Me.Label28.TabIndex = 67
        Me.Label28.Text = "Renkli Satýr Arkaplan Rengi :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 55)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(121, 13)
        Me.Label29.TabIndex = 66
        Me.Label29.Text = "Renkli Satýr Yazý Rengi :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(9, 94)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(162, 13)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "Üstüne Gelince Arkaplan Rengi :"
        '
        'mnuCustomDesign
        '
        Me.mnuCustomDesign.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomDesign_Save})
        Me.mnuCustomDesign.Location = New System.Drawing.Point(5, 18)
        Me.mnuCustomDesign.Name = "mnuCustomDesign"
        Me.mnuCustomDesign.Size = New System.Drawing.Size(299, 24)
        Me.mnuCustomDesign.TabIndex = 3
        Me.mnuCustomDesign.Text = "MenuStrip1"
        '
        'mnuCustomDesign_Save
        '
        Me.mnuCustomDesign_Save.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StiliKaydetToolStripMenuItem, Me.mnuCustomDesign_Load, Me.ToolStripMenuItem1, Me.mnuCustomDesign_Apply})
        Me.mnuCustomDesign_Save.Name = "mnuCustomDesign_Save"
        Me.mnuCustomDesign_Save.Size = New System.Drawing.Size(45, 20)
        Me.mnuCustomDesign_Save.Text = "Menü"
        '
        'StiliKaydetToolStripMenuItem
        '
        Me.StiliKaydetToolStripMenuItem.Image = CType(resources.GetObject("StiliKaydetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StiliKaydetToolStripMenuItem.Name = "StiliKaydetToolStripMenuItem"
        Me.StiliKaydetToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.StiliKaydetToolStripMenuItem.Text = "Stil Kaydet"
        '
        'mnuCustomDesign_Load
        '
        Me.mnuCustomDesign_Load.Image = CType(resources.GetObject("mnuCustomDesign_Load.Image"), System.Drawing.Image)
        Me.mnuCustomDesign_Load.Name = "mnuCustomDesign_Load"
        Me.mnuCustomDesign_Load.Size = New System.Drawing.Size(144, 22)
        Me.mnuCustomDesign_Load.Text = "Stil Aç"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(141, 6)
        '
        'mnuCustomDesign_Apply
        '
        Me.mnuCustomDesign_Apply.Image = CType(resources.GetObject("mnuCustomDesign_Apply.Image"), System.Drawing.Image)
        Me.mnuCustomDesign_Apply.Name = "mnuCustomDesign_Apply"
        Me.mnuCustomDesign_Apply.Size = New System.Drawing.Size(144, 22)
        Me.mnuCustomDesign_Apply.Text = "Stili Uygula !"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Açýklama"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmHTMLCreatorFromDataTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 628)
        Me.Controls.Add(Me.spcMain)
        Me.MainMenuStrip = Me.mnuWebBrowser
        Me.Name = "frmHTMLCreatorFromDataTable"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Özelleþtirilmiþ HTML Dosya Oluþturma"
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel1.PerformLayout()
        Me.spcMain.Panel2.ResumeLayout(False)
        Me.spcMain.ResumeLayout(False)
        Me.grpTemplateDesign.ResumeLayout(False)
        Me.pnlTemplateImages.ResumeLayout(False)
        Me.pnlTemplateImages.PerformLayout()
        Me.spcCustomDesign.Panel1.ResumeLayout(False)
        Me.spcCustomDesign.Panel2.ResumeLayout(False)
        Me.spcCustomDesign.ResumeLayout(False)
        Me.grpWebView.ResumeLayout(False)
        Me.grpWebView.PerformLayout()
        Me.mnuWebBrowser.ResumeLayout(False)
        Me.mnuWebBrowser.PerformLayout()
        Me.grpCustomDesign.ResumeLayout(False)
        Me.grpCustomDesign.PerformLayout()
        Me.pnlCustomDesign.ResumeLayout(False)
        Me.tbcCustomDesign.ResumeLayout(False)
        Me.tbpCell.ResumeLayout(False)
        Me.tbpCell.PerformLayout()
        CType(Me.nudCellWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTable.ResumeLayout(False)
        Me.tbpTable.PerformLayout()
        Me.tbpColumn.ResumeLayout(False)
        Me.tbpColumn.PerformLayout()
        Me.tbpCaption.ResumeLayout(False)
        Me.tbpCaption.PerformLayout()
        Me.tbpJava.ResumeLayout(False)
        Me.tbpJava.PerformLayout()
        Me.mnuCustomDesign.ResumeLayout(False)
        Me.mnuCustomDesign.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcMain As System.Windows.Forms.SplitContainer
    Friend WithEvents spcCustomDesign As System.Windows.Forms.SplitContainer
    Friend WithEvents grpWebView As System.Windows.Forms.GroupBox
    Friend WithEvents grpCustomDesign As System.Windows.Forms.GroupBox
    Friend WithEvents grpTemplateDesign As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCustomDesign As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemplateDesign As System.Windows.Forms.RadioButton
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pnlTemplateImages As System.Windows.Forms.Panel
    Friend WithEvents rdbTemplateImage5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemplateImage4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemplateImage3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemplateImage2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemplateImage1 As System.Windows.Forms.RadioButton
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mnuWebBrowser As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMenu_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuMenu_TableCaption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents YenileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents pnlCustomDesign As System.Windows.Forms.Panel
    Friend WithEvents mnuCustomDesign As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCustomDesign_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StiliKaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomDesign_Load As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCustomDesign_Apply As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbcCustomDesign As System.Windows.Forms.TabControl
    Friend WithEvents tbpCell As System.Windows.Forms.TabPage
    Friend WithEvents tbpTable As System.Windows.Forms.TabPage
    Friend WithEvents tbpColumn As System.Windows.Forms.TabPage
    Friend WithEvents tbpCaption As System.Windows.Forms.TabPage
    Friend WithEvents tbpJava As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnCellFont As System.Windows.Forms.Button
    Friend WithEvents txtCellFont As System.Windows.Forms.TextBox
    Friend WithEvents nudCellWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbCellTextAlign As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCellPadding As System.Windows.Forms.ComboBox
    Friend WithEvents btnCellBorderColor As System.Windows.Forms.Button
    Friend WithEvents txtCellBorderColor As System.Windows.Forms.TextBox
    Friend WithEvents cmbCellBorderType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCellBorderSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCellFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTableBorderStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTableBorderType As System.Windows.Forms.ComboBox
    Friend WithEvents btnTableBorderColor As System.Windows.Forms.Button
    Friend WithEvents txtTableBorderColor As System.Windows.Forms.TextBox
    Friend WithEvents cmbColumnFontBold As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColumnTextAlign As System.Windows.Forms.ComboBox
    Friend WithEvents btnColumnBackColor As System.Windows.Forms.Button
    Friend WithEvents txtColumnBackColor As System.Windows.Forms.TextBox
    Friend WithEvents cmbColumnBorderType As System.Windows.Forms.ComboBox
    Friend WithEvents btnColumnBorderColor As System.Windows.Forms.Button
    Friend WithEvents txtColumnBorderColor As System.Windows.Forms.TextBox
    Friend WithEvents cmbColumnBorderSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbColumnPaddingLeft As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCaptionPaddingBottom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCaptionPaddingTop As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCaptionAlign As System.Windows.Forms.ComboBox
    Friend WithEvents btnCaptionColor As System.Windows.Forms.Button
    Friend WithEvents txtCaptionColor As System.Windows.Forms.TextBox
    Friend WithEvents cmbCaptionFontBold As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCaptionFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents btnCaptionFont As System.Windows.Forms.Button
    Friend WithEvents txtCaptionFont As System.Windows.Forms.TextBox
    Friend WithEvents btnBackColorRow As System.Windows.Forms.Button
    Friend WithEvents txtBackColorRow As System.Windows.Forms.TextBox
    Friend WithEvents btnHoverFontColorRow As System.Windows.Forms.Button
    Friend WithEvents txtHoverFontColorRow As System.Windows.Forms.TextBox
    Friend WithEvents btnHoverBackColorRow As System.Windows.Forms.Button
    Friend WithEvents txtHoverBackColorRow As System.Windows.Forms.TextBox
    Friend WithEvents btnFontColorRow As System.Windows.Forms.Button
    Friend WithEvents txtFontColorRow As System.Windows.Forms.TextBox
    Friend WithEvents cmbTableBorderSize As System.Windows.Forms.ComboBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
