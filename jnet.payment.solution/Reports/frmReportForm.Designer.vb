<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmReportForm
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportForm))
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupFooterBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "win-ad5es359gkm.jnet_payment_solution.dbo"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "ID"
        Table2.Name = "payment"
        ColumnExpression1.Table = Table2
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "fullname"
        ColumnExpression2.Table = Table2
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "receipt_no"
        ColumnExpression3.Table = Table2
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "user_description"
        ColumnExpression4.Table = Table2
        Column4.Expression = ColumnExpression4
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Name = "payment"
        SelectQuery1.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Title.Name = "Title"
        '
        'GroupCaption1
        '
        Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupCaption1.BorderColor = System.Drawing.Color.White
        Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupCaption1.BorderWidth = 2.0!
        Me.GroupCaption1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupCaption1.Name = "GroupCaption1"
        Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100.0!)
        Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupData1
        '
        Me.GroupData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupData1.BorderColor = System.Drawing.Color.White
        Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupData1.BorderWidth = 2.0!
        Me.GroupData1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupData1.ForeColor = System.Drawing.Color.White
        Me.GroupData1.Name = "GroupData1"
        Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100.0!)
        Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooterBackground3
        '
        Me.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.GroupFooterBackground3.BorderColor = System.Drawing.Color.White
        Me.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.GroupFooterBackground3.BorderWidth = 2.0!
        Me.GroupFooterBackground3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GroupFooterBackground3.Name = "GroupFooterBackground3"
        Me.GroupFooterBackground3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100.0!)
        Me.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageInfo
        '
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.pageInfo2})
        Me.BottomMargin.Name = "BottomMargin"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label1})
        Me.ReportHeader.HeightF = 60.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("receipt_no", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("fullname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("user_description", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader1.HeightF = 27.0!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label2})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 6.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'pageInfo1
        '
        Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.pageInfo1.Name = "pageInfo1"
        Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.pageInfo1.SizeF = New System.Drawing.SizeF(301.5!, 23.0!)
        Me.pageInfo1.StyleName = "PageInfo"
        '
        'pageInfo2
        '
        Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(319.0!, 6.0!)
        Me.pageInfo2.Name = "pageInfo2"
        Me.pageInfo2.SizeF = New System.Drawing.SizeF(301.5!, 23.0!)
        Me.pageInfo2.StyleName = "PageInfo"
        Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.pageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'label1
        '
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(615.0!, 24.19433!)
        Me.label1.StyleName = "Title"
        Me.label1.Text = "invoice_report"
        '
        'table1
        '
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(627.0!, 25.0!)
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell5, Me.tableCell2, Me.tableCell6, Me.tableCell3, Me.tableCell7, Me.tableCell4, Me.tableCell8})
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 1.0R
        '
        'tableCell1
        '
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StyleName = "GroupCaption1"
        Me.tableCell1.Text = "ID"
        Me.tableCell1.Weight = 0.031034022427061526R
        '
        'tableCell5
        '
        Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ID]")})
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StyleName = "GroupData1"
        Me.tableCell5.Weight = 0.031034022427061526R
        '
        'tableCell2
        '
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StyleName = "GroupCaption1"
        Me.tableCell2.Text = "RECEIPT NO"
        Me.tableCell2.Weight = 0.1244517057135915R
        '
        'tableCell6
        '
        Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[receipt_no]")})
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StyleName = "GroupData1"
        Me.tableCell6.Weight = 0.1244517057135915R
        '
        'tableCell3
        '
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StyleName = "GroupCaption1"
        Me.tableCell3.Text = "FULLNAME"
        Me.tableCell3.Weight = 0.11325300785533168R
        '
        'tableCell7
        '
        Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fullname]")})
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StyleName = "GroupData1"
        Me.tableCell7.Weight = 0.11325300785533168R
        '
        'tableCell4
        '
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StyleName = "GroupCaption1"
        Me.tableCell4.Text = "USER DESCRIPTION"
        Me.tableCell4.Weight = 0.19349994081439395R
        '
        'tableCell8
        '
        Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[user_description]")})
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StyleName = "GroupData1"
        Me.tableCell8.Weight = 0.26902257502554328R
        '
        'label2
        '
        Me.label2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(627.0!, 2.08!)
        Me.label2.StyleName = "GroupFooterBackground3"
        Me.label2.StylePriority.UseBorders = False
        '
        'frmReportForm
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.GroupFooter1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "payment"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.GroupCaption1, Me.GroupData1, Me.GroupFooterBackground3, Me.PageInfo})
        Me.Version = "19.2"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupFooterBackground3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
End Class
