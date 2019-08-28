<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceTotal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiscountamout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCaculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal;"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(148, 21)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(120, 20)
        Me.txtSubtotal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Discount percent:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(148, 52)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.Size = New System.Drawing.Size(120, 20)
        Me.txtDiscountPercent.TabIndex = 3
        Me.txtDiscountPercent.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscountamout
        '
        Me.txtDiscountamout.Location = New System.Drawing.Point(148, 84)
        Me.txtDiscountamout.Name = "txtDiscountamout"
        Me.txtDiscountamout.ReadOnly = True
        Me.txtDiscountamout.Size = New System.Drawing.Size(120, 20)
        Me.txtDiscountamout.TabIndex = 7
        Me.txtDiscountamout.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(148, 116)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TabStop = False
        '
        'btnCaculate
        '
        Me.btnCaculate.Location = New System.Drawing.Point(82, 142)
        Me.btnCaculate.Name = "btnCaculate"
        Me.btnCaculate.Size = New System.Drawing.Size(80, 23)
        Me.btnCaculate.TabIndex = 4
        Me.btnCaculate.Text = "&Calculate"
        Me.btnCaculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(215, 142)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInvoiceTotal
        '
        Me.AcceptButton = Me.btnCaculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 218)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCaculate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDiscountamout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInvoiceTotal"
        Me.Text = "jsparks1b1:Invoice Total Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiscountPercent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiscountamout As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCaculate As Button
    Friend WithEvents btnExit As Button
End Class
