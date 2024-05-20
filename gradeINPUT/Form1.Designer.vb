<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.Check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grade
        '
        Me.grade.BackColor = System.Drawing.Color.Wheat
        Me.grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.Location = New System.Drawing.Point(298, 164)
        Me.grade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(217, 39)
        Me.grade.TabIndex = 0
        '
        'Check
        '
        Me.Check.BackColor = System.Drawing.Color.DeepPink
        Me.Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Check.Location = New System.Drawing.Point(298, 234)
        Me.Check.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(217, 69)
        Me.Check.TabIndex = 1
        Me.Check.Text = "Check"
        Me.Check.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student grade"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.grade)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grade As TextBox
    Friend WithEvents Check As Button
    Friend WithEvents Label1 As Label
End Class
