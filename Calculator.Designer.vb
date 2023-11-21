<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        label_title = New Label()
        label_display_operations = New Label()
        label_current_number = New Label()
        btn_ce_clear_most_recent_entry = New Button()
        btn_clear_all_memory = New Button()
        btn_delete = New Button()
        btn_modulo = New Button()
        btn_power = New Button()
        btn_percentage = New Button()
        btn_division = New Button()
        btn_7 = New Button()
        btn_8 = New Button()
        btn_9 = New Button()
        btn_multiplication = New Button()
        btn_4 = New Button()
        btn_5 = New Button()
        btn_6 = New Button()
        btn_subtraction = New Button()
        btn_1 = New Button()
        btn_2 = New Button()
        btn_3 = New Button()
        btn_addition = New Button()
        bnt_minus_plus = New Button()
        btn_0 = New Button()
        btn_dot = New Button()
        btn_equal = New Button()
        SuspendLayout()
        ' 
        ' label_title
        ' 
        label_title.AutoSize = True
        label_title.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        label_title.Location = New Point(138, 9)
        label_title.Name = "label_title"
        label_title.Size = New Size(199, 50)
        label_title.TabIndex = 0
        label_title.Text = "Calculator"
        ' 
        ' label_display_operations
        ' 
        label_display_operations.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_display_operations.ForeColor = Color.Gray
        label_display_operations.Location = New Point(2, 70)
        label_display_operations.Name = "label_display_operations"
        label_display_operations.Size = New Size(467, 36)
        label_display_operations.TabIndex = 1
        label_display_operations.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' label_current_number
        ' 
        label_current_number.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        label_current_number.Location = New Point(2, 106)
        label_current_number.Name = "label_current_number"
        label_current_number.Size = New Size(467, 82)
        label_current_number.TabIndex = 2
        label_current_number.Text = "0"
        label_current_number.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_ce_clear_most_recent_entry
        ' 
        btn_ce_clear_most_recent_entry.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_ce_clear_most_recent_entry.Location = New Point(12, 207)
        btn_ce_clear_most_recent_entry.Name = "btn_ce_clear_most_recent_entry"
        btn_ce_clear_most_recent_entry.Size = New Size(107, 68)
        btn_ce_clear_most_recent_entry.TabIndex = 3
        btn_ce_clear_most_recent_entry.Text = "CE"
        btn_ce_clear_most_recent_entry.UseVisualStyleBackColor = True
        ' 
        ' btn_clear_all_memory
        ' 
        btn_clear_all_memory.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_clear_all_memory.Location = New Point(125, 207)
        btn_clear_all_memory.Name = "btn_clear_all_memory"
        btn_clear_all_memory.Size = New Size(107, 68)
        btn_clear_all_memory.TabIndex = 4
        btn_clear_all_memory.Text = "C"
        btn_clear_all_memory.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_delete.Location = New Point(238, 207)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(220, 68)
        btn_delete.TabIndex = 6
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_modulo
        ' 
        btn_modulo.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_modulo.Location = New Point(12, 281)
        btn_modulo.Name = "btn_modulo"
        btn_modulo.Size = New Size(107, 68)
        btn_modulo.TabIndex = 7
        btn_modulo.Text = "Mod"
        btn_modulo.UseVisualStyleBackColor = True
        ' 
        ' btn_power
        ' 
        btn_power.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_power.Location = New Point(125, 281)
        btn_power.Name = "btn_power"
        btn_power.Size = New Size(107, 68)
        btn_power.TabIndex = 8
        btn_power.Text = "Exp"
        btn_power.UseVisualStyleBackColor = True
        ' 
        ' btn_percentage
        ' 
        btn_percentage.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_percentage.Location = New Point(238, 281)
        btn_percentage.Name = "btn_percentage"
        btn_percentage.Size = New Size(107, 68)
        btn_percentage.TabIndex = 9
        btn_percentage.Text = "%"
        btn_percentage.UseVisualStyleBackColor = True
        ' 
        ' btn_division
        ' 
        btn_division.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_division.Location = New Point(351, 281)
        btn_division.Name = "btn_division"
        btn_division.Size = New Size(107, 68)
        btn_division.TabIndex = 10
        btn_division.Text = "/"
        btn_division.UseVisualStyleBackColor = True
        ' 
        ' btn_7
        ' 
        btn_7.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_7.Location = New Point(12, 355)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(107, 68)
        btn_7.TabIndex = 11
        btn_7.Text = "7"
        btn_7.UseVisualStyleBackColor = True
        ' 
        ' btn_8
        ' 
        btn_8.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_8.Location = New Point(125, 355)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(107, 68)
        btn_8.TabIndex = 12
        btn_8.Text = "8"
        btn_8.UseVisualStyleBackColor = True
        ' 
        ' btn_9
        ' 
        btn_9.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_9.Location = New Point(238, 355)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(107, 68)
        btn_9.TabIndex = 13
        btn_9.Text = "9"
        btn_9.UseVisualStyleBackColor = True
        ' 
        ' btn_multiplication
        ' 
        btn_multiplication.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_multiplication.Location = New Point(351, 355)
        btn_multiplication.Name = "btn_multiplication"
        btn_multiplication.Size = New Size(107, 68)
        btn_multiplication.TabIndex = 14
        btn_multiplication.Text = "x"
        btn_multiplication.UseVisualStyleBackColor = True
        ' 
        ' btn_4
        ' 
        btn_4.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_4.Location = New Point(12, 429)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(107, 68)
        btn_4.TabIndex = 15
        btn_4.Text = "4"
        btn_4.UseVisualStyleBackColor = True
        ' 
        ' btn_5
        ' 
        btn_5.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_5.Location = New Point(125, 429)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(107, 68)
        btn_5.TabIndex = 16
        btn_5.Text = "5"
        btn_5.UseVisualStyleBackColor = True
        ' 
        ' btn_6
        ' 
        btn_6.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_6.Location = New Point(238, 429)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(107, 68)
        btn_6.TabIndex = 17
        btn_6.Text = "6"
        btn_6.UseVisualStyleBackColor = True
        ' 
        ' btn_subtraction
        ' 
        btn_subtraction.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_subtraction.Location = New Point(351, 429)
        btn_subtraction.Name = "btn_subtraction"
        btn_subtraction.Size = New Size(107, 68)
        btn_subtraction.TabIndex = 18
        btn_subtraction.Text = "-"
        btn_subtraction.UseVisualStyleBackColor = True
        ' 
        ' btn_1
        ' 
        btn_1.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_1.Location = New Point(12, 503)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(107, 68)
        btn_1.TabIndex = 19
        btn_1.Text = "1"
        btn_1.UseVisualStyleBackColor = True
        ' 
        ' btn_2
        ' 
        btn_2.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_2.Location = New Point(125, 503)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(107, 68)
        btn_2.TabIndex = 20
        btn_2.Text = "2"
        btn_2.UseVisualStyleBackColor = True
        ' 
        ' btn_3
        ' 
        btn_3.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_3.Location = New Point(238, 503)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(107, 68)
        btn_3.TabIndex = 21
        btn_3.Text = "3"
        btn_3.UseVisualStyleBackColor = True
        ' 
        ' btn_addition
        ' 
        btn_addition.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_addition.Location = New Point(352, 503)
        btn_addition.Name = "btn_addition"
        btn_addition.Size = New Size(107, 68)
        btn_addition.TabIndex = 22
        btn_addition.Text = "+"
        btn_addition.UseVisualStyleBackColor = True
        ' 
        ' bnt_minus_plus
        ' 
        bnt_minus_plus.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        bnt_minus_plus.Location = New Point(12, 577)
        bnt_minus_plus.Name = "bnt_minus_plus"
        bnt_minus_plus.Size = New Size(107, 68)
        bnt_minus_plus.TabIndex = 23
        bnt_minus_plus.Text = "+/-"
        bnt_minus_plus.UseVisualStyleBackColor = True
        ' 
        ' btn_0
        ' 
        btn_0.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_0.Location = New Point(125, 577)
        btn_0.Name = "btn_0"
        btn_0.Size = New Size(107, 68)
        btn_0.TabIndex = 24
        btn_0.Text = "0"
        btn_0.UseVisualStyleBackColor = True
        ' 
        ' btn_dot
        ' 
        btn_dot.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_dot.Location = New Point(238, 577)
        btn_dot.Name = "btn_dot"
        btn_dot.Size = New Size(107, 68)
        btn_dot.TabIndex = 25
        btn_dot.Text = "."
        btn_dot.UseVisualStyleBackColor = True
        ' 
        ' btn_equal
        ' 
        btn_equal.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_equal.Location = New Point(352, 577)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(107, 68)
        btn_equal.TabIndex = 26
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(471, 654)
        Controls.Add(btn_equal)
        Controls.Add(btn_dot)
        Controls.Add(btn_0)
        Controls.Add(bnt_minus_plus)
        Controls.Add(btn_addition)
        Controls.Add(btn_3)
        Controls.Add(btn_2)
        Controls.Add(btn_1)
        Controls.Add(btn_subtraction)
        Controls.Add(btn_6)
        Controls.Add(btn_5)
        Controls.Add(btn_4)
        Controls.Add(btn_multiplication)
        Controls.Add(btn_9)
        Controls.Add(btn_8)
        Controls.Add(btn_7)
        Controls.Add(btn_division)
        Controls.Add(btn_percentage)
        Controls.Add(btn_power)
        Controls.Add(btn_modulo)
        Controls.Add(btn_delete)
        Controls.Add(btn_clear_all_memory)
        Controls.Add(btn_ce_clear_most_recent_entry)
        Controls.Add(label_current_number)
        Controls.Add(label_display_operations)
        Controls.Add(label_title)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Calculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_title As Label
    Friend WithEvents label_display_operations As Label
    Friend WithEvents label_current_number As Label
    Friend WithEvents btn_ce_clear_most_recent_entry As Button
    Friend WithEvents btn_clear_all_memory As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_modulo As Button
    Friend WithEvents btn_power As Button
    Friend WithEvents btn_percentage As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_multiplication As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_subtraction As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_addition As Button
    Friend WithEvents bnt_minus_plus As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_dot As Button
    Friend WithEvents btn_equal As Button
End Class
