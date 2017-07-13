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
        Me.components = New System.ComponentModel.Container()
        Me.ofdSelectFiles = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectFiles = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtOverlapResults = New System.Windows.Forms.TextBox()
        Me.btnFindOverlappingTerms = New System.Windows.Forms.Button()
        Me.lblSelectFiles = New System.Windows.Forms.Label()
        Me.lblFindOverlappingTerms = New System.Windows.Forms.Label()
        Me.lblNumberOfFileSelected = New System.Windows.Forms.Label()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.txtNonOverlapResults = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdSelectFiles
        '
        Me.ofdSelectFiles.Multiselect = True
        Me.ofdSelectFiles.ShowHelp = True
        '
        'btnSelectFiles
        '
        Me.btnSelectFiles.Location = New System.Drawing.Point(15, 33)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(105, 44)
        Me.btnSelectFiles.TabIndex = 0
        Me.btnSelectFiles.Text = "Select Files"
        Me.ToolTip1.SetToolTip(Me.btnSelectFiles, "Select the files for comparison to find overlapping go terms.")
        Me.btnSelectFiles.UseVisualStyleBackColor = True
        '
        'txtOverlapResults
        '
        Me.txtOverlapResults.AcceptsReturn = True
        Me.txtOverlapResults.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtOverlapResults.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtOverlapResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverlapResults.Location = New System.Drawing.Point(3, 6)
        Me.txtOverlapResults.Multiline = True
        Me.txtOverlapResults.Name = "txtOverlapResults"
        Me.txtOverlapResults.ReadOnly = True
        Me.txtOverlapResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOverlapResults.Size = New System.Drawing.Size(502, 239)
        Me.txtOverlapResults.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtOverlapResults, "The overlap results will appear here when the program finishes.")
        '
        'btnFindOverlappingTerms
        '
        Me.btnFindOverlappingTerms.Location = New System.Drawing.Point(332, 38)
        Me.btnFindOverlappingTerms.Name = "btnFindOverlappingTerms"
        Me.btnFindOverlappingTerms.Size = New System.Drawing.Size(172, 59)
        Me.btnFindOverlappingTerms.TabIndex = 3
        Me.btnFindOverlappingTerms.Text = "Find Overlapping/Non-Overlapping Terms"
        Me.ToolTip1.SetToolTip(Me.btnFindOverlappingTerms, "Calculate the go terms shared by all files and display them in the results box be" & _
        "low.")
        Me.btnFindOverlappingTerms.UseVisualStyleBackColor = True
        '
        'lblSelectFiles
        '
        Me.lblSelectFiles.AutoSize = True
        Me.lblSelectFiles.Location = New System.Drawing.Point(12, 17)
        Me.lblSelectFiles.Name = "lblSelectFiles"
        Me.lblSelectFiles.Size = New System.Drawing.Size(159, 13)
        Me.lblSelectFiles.TabIndex = 4
        Me.lblSelectFiles.Text = "Step 1: Select Files To Compare"
        '
        'lblFindOverlappingTerms
        '
        Me.lblFindOverlappingTerms.AutoSize = True
        Me.lblFindOverlappingTerms.Location = New System.Drawing.Point(329, 22)
        Me.lblFindOverlappingTerms.Name = "lblFindOverlappingTerms"
        Me.lblFindOverlappingTerms.Size = New System.Drawing.Size(175, 13)
        Me.lblFindOverlappingTerms.TabIndex = 5
        Me.lblFindOverlappingTerms.Text = "Step 2: Find the Terms that Overlap"
        '
        'lblNumberOfFileSelected
        '
        Me.lblNumberOfFileSelected.AutoSize = True
        Me.lblNumberOfFileSelected.Location = New System.Drawing.Point(15, 84)
        Me.lblNumberOfFileSelected.Name = "lblNumberOfFileSelected"
        Me.lblNumberOfFileSelected.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfFileSelected.TabIndex = 6
        '
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep3.Location = New System.Drawing.Point(3, 106)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(196, 17)
        Me.lblStep3.TabIndex = 7
        Me.lblStep3.Text = "Step 3: Examining the Results"
        '
        'txtNonOverlapResults
        '
        Me.txtNonOverlapResults.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNonOverlapResults.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtNonOverlapResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNonOverlapResults.Location = New System.Drawing.Point(3, 3)
        Me.txtNonOverlapResults.Multiline = True
        Me.txtNonOverlapResults.Name = "txtNonOverlapResults"
        Me.txtNonOverlapResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNonOverlapResults.Size = New System.Drawing.Size(502, 242)
        Me.txtNonOverlapResults.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 274)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtOverlapResults)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Overlap"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNonOverlapResults)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Non-Overlap"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 410)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.lblNumberOfFileSelected)
        Me.Controls.Add(Me.lblFindOverlappingTerms)
        Me.Controls.Add(Me.lblSelectFiles)
        Me.Controls.Add(Me.btnFindOverlappingTerms)
        Me.Controls.Add(Me.btnSelectFiles)
        Me.Name = "Form1"
        Me.Text = "Go Term Intersector"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdSelectFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelectFiles As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtOverlapResults As System.Windows.Forms.TextBox
    Friend WithEvents btnFindOverlappingTerms As System.Windows.Forms.Button
    Friend WithEvents lblSelectFiles As System.Windows.Forms.Label
    Friend WithEvents lblFindOverlappingTerms As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfFileSelected As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label
    Friend WithEvents txtNonOverlapResults As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

End Class
