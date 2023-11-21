Imports System

Public Class Calculator
    ' Variables
    Private num1 As Double
    Private num2 As Double
    Private operation As String
    Private userInput As String = ""

    ' Handles all number button clicks
    Private Sub btn_number_Click(sender As Object, e As EventArgs) _
        Handles btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click,
                btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click, btn_0.Click

        Dim button As Button = CType(sender, Button)
        userInput &= button.Text
        label_current_number.Text = userInput
    End Sub

    ' Handles operation clicks
    Private Sub Operation_Click(sender As Object, e As EventArgs) _
        Handles btn_addition.Click, btn_subtraction.Click, btn_multiplication.Click, btn_division.Click

        num1 = Double.Parse(label_current_number.Text)
        Dim button As Button = CType(sender, Button)
        operation = button.Text
        userInput = ""
        label_display_operations.Text = $"{num1} {operation}"
    End Sub

    ' Executes the operation
    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If Not String.IsNullOrEmpty(userInput) Then
            num2 = Double.Parse(userInput)
            Select Case operation
                Case "+"
                    num1 += num2
                Case "-"
                    num1 -= num2
                Case "x"
                    num1 *= num2
                Case "/"
                    If num2 <> 0 Then
                        num1 /= num2
                    Else
                        label_current_number.Text = "Error"
                        Exit Sub
                    End If
                Case "^"
                    num1 = Math.Pow(num1, num2)
                Case "%"
                    num1 = num1 * (num2 / 100)
                Case "mod"
                    num1 = num1 Mod num2
            End Select

            label_current_number.Text = num1.ToString()
            label_display_operations.Text = $"{num1}"
            userInput = ""
        End If
    End Sub

    ' CE : Clears the most recent entry
    Private Sub btn_ce_clear_most_recent_entry_Click(sender As Object, e As EventArgs) Handles btn_ce_clear_most_recent_entry.Click
        userInput = ""
        label_current_number.Text = "0"
    End Sub

    ' C : Clears all memory and resets the calculator
    Private Sub btn_clear_all_memory_Click(sender As Object, e As EventArgs) Handles btn_clear_all_memory.Click
        num1 = 0
        num2 = 0
        userInput = ""
        operation = ""
        label_display_operations.Text = ""
        label_current_number.Text = "0"
    End Sub

    'IMMEDIATE OPERATIONS
    ' Percentage : Converts current input to a percentage
    Private Sub btn_percentage_Click(sender As Object, e As EventArgs) Handles btn_percentage.Click
        If Not String.IsNullOrEmpty(userInput) Then
            userInput = (Double.Parse(userInput) / 100).ToString()
            label_current_number.Text = userInput
        End If
    End Sub

    ' Power : Raises num1 to the power of num2
    Private Sub btn_power_Click(sender As Object, e As EventArgs) Handles btn_power.Click
        operation = "^"
        num1 = Double.Parse(label_current_number.Text)
        userInput = ""
        label_display_operations.Text = $"{num1} ^"
    End Sub

    ' Modulo : Finds the remainder of the division of num1 by num2
    Private Sub btn_modulo_Click(sender As Object, e As EventArgs) Handles btn_modulo.Click
        operation = "mod"
        num1 = Double.Parse(label_current_number.Text)
        userInput = ""
        label_display_operations.Text = $"{num1} mod"
    End Sub

    ' Plus/Minus : Changes the sign of the current input
    Private Sub bnt_minus_plus_Click(sender As Object, e As EventArgs) Handles bnt_minus_plus.Click
        If Not String.IsNullOrEmpty(userInput) Then
            userInput = (-1 * Double.Parse(userInput)).ToString()
            label_current_number.Text = userInput
        End If
    End Sub

    ' Decimal Point : Appends a decimal point to the current input
    Private Sub btn_dot_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        If Not userInput.Contains(".") Then
            If String.IsNullOrEmpty(userInput) Then
                'If the number is 0
                userInput = "0."
            Else
                'If the number is not zero, just add a "."
                userInput &= "."
            End If
            label_current_number.Text = userInput
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If userInput.Length > 0 Then
            ' Remove the last character from userInput
            userInput = userInput.Substring(0, userInput.Length - 1)
        End If

        ' Update the display label
        label_current_number.Text = If(userInput.Length > 0, userInput, "0")
    End Sub
End Class
