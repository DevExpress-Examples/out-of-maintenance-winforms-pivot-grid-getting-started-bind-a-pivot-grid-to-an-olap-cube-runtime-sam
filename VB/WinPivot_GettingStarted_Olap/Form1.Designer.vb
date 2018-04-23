Namespace WinPivot_GettingStarted_Olap
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5})
            pivotGridGroup1.Caption = "Date.Fiscal"
            pivotGridGroup1.Fields.Add(Me.pivotGridField3)
            pivotGridGroup1.Fields.Add(Me.pivotGridField4)
            pivotGridGroup1.Hierarchy = "[Date].[Fiscal]"
            pivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=https://demos.devexpress.com/Services/OLAP/msmdpump.d" & "ll;initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure Wo" & "rks"""
            Me.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(768, 362)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField1.AreaIndex = 0
            Me.pivotGridField1.Caption = "Country"
            Me.pivotGridField1.DisplayFolder = "Location"
            Me.pivotGridField1.FieldName = "[Customer].[Country].[Country]"
            Me.pivotGridField1.Name = "pivotGridField1"
            ' 
            ' pivotGridField2
            ' 
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField2.AreaIndex = 1
            Me.pivotGridField2.Caption = "City"
            Me.pivotGridField2.DisplayFolder = "Location"
            Me.pivotGridField2.FieldName = "[Customer].[City].[City]"
            Me.pivotGridField2.Name = "pivotGridField2"
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.Caption = "Fiscal Year"
            Me.pivotGridField3.DisplayFolder = "Fiscal"
            Me.pivotGridField3.FieldName = "[Date].[Fiscal].[Fiscal Year]"
            Me.pivotGridField3.Name = "pivotGridField3"
            ' 
            ' pivotGridField4
            ' 
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField4.AreaIndex = 1
            Me.pivotGridField4.Caption = "Fiscal Quarter"
            Me.pivotGridField4.DisplayFolder = "Fiscal"
            Me.pivotGridField4.FieldName = "[Date].[Fiscal].[Fiscal Quarter]"
            Me.pivotGridField4.Name = "pivotGridField4"
            ' 
            ' pivotGridField5
            ' 
            Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField5.AreaIndex = 0
            Me.pivotGridField5.Caption = "Internet Sales Amount"
            Me.pivotGridField5.DisplayFolder = "Internet Sales"
            Me.pivotGridField5.FieldName = "[Measures].[Internet Sales Amount]"
            Me.pivotGridField5.Name = "pivotGridField5"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(768, 362)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
        Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
        Private pivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
        Private pivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

