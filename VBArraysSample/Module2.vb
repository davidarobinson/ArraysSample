Module Module2

    Sub Main()
        'single dimension
        Dim ages() As Integer = New Integer(4) {3, 6, 20, 34, 67}

        Console.WriteLine("Single Dimensional Array")
        For Each age As Integer In ages
            Console.WriteLine(age)
        Next

        Console.Write(vbCrLf & vbCrLf & "Multi Dimensional Array" & vbCrLf)

        'multi dimensional
        Dim names(,) As String = New String(1, 1) {{"Andrew", "Bobby"}, {"Susan", "Peter"}}

        Console.WriteLine("Row" + vbTab + "Col" + vbTab + "Value")
        For Each name As String In names
            Console.WriteLine(name)
        Next

        Console.Write(vbCrLf & vbCrLf & "Array of Arrays" & vbCrLf)

        ' Array of arrays
        Dim days()() As String = { _
            New String() {"Monday", "Wednesday"}, _
            New String() {"Tuesday", "Friday", "Saturday", "Sunday"} _
        }

        Console.WriteLine("Row" + vbTab + "Col" + vbTab + "Value")
        For Each d() As String In days
            For Each day As String In d
                Console.WriteLine(day)
            Next
        Next

        If (System.Diagnostics.Debugger.IsAttached) Then
            System.Diagnostics.Debugger.Break()
        End If
    End Sub

End Module
