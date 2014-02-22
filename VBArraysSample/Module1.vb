
'As with the C# example here is a working console app the demonstrates Single Dimension Arrays, Multi Dimension Arrays and Arrays in Arrays, also known as Ragged or Jagged arrays.

Module Module1

    Sub Main()
        'single dimension
        Dim ages(4) As Integer
        ages(0) = 3
        ages(1) = 6
        ages(2) = 20
        ages(3) = 34
        ages(4) = 67

        Console.WriteLine("Single Dimensional Array")
        For ageLoop = 0 To ages.Length - 1
            Console.WriteLine(String.Format("Item {0}: {1}", ageLoop, ages(ageLoop)))
        Next

        Console.Write(vbCrLf & vbCrLf & "Multi Dimensional Array" & vbCrLf)

        'multi dimensional
        Dim names(1, 1) As String
        names(0, 0) = "Andrew"
        names(0, 1) = "Bobby"
        names(1, 0) = "Susan"
        names(1, 1) = "Peter"

        Console.WriteLine("Row" + vbTab + "Col" + vbTab + "Value")
        For row = 0 To names.GetUpperBound(0)
            For col = 0 To names.GetUpperBound(row)
                Console.WriteLine(String.Format("{0}{1}{2}{3}{4}", row, vbTab, col, vbTab, names(row, col)))
            Next
        Next

        Console.Write(vbCrLf & vbCrLf & "Array of Arrays" & vbCrLf)

        ' Array of arrays
        Dim days()() As String = New String(1)() {}
        days(0) = New String(1) {}
        days(0)(0) = "Monday"
        days(0)(1) = "Wednesday"

        days(1) = New String(3) {}
        days(1)(0) = "Tuesday"
        days(1)(1) = "Friday"
        days(1)(2) = "Saturday"
        days(1)(3) = "Sunday"

        Console.WriteLine("Row" + vbTab + "Col" + vbTab + "Value")
        For row = 0 To days.GetUpperBound(0)
            For col = 0 To days(row).GetUpperBound(0)
                Console.WriteLine(String.Format("{0}{1}{2}{3}{4}", row, vbTab, col, vbTab, days(row)(col)))
            Next
        Next

        If (System.Diagnostics.Debugger.IsAttached) Then
            System.Diagnostics.Debugger.Break()
        End If

    End Sub

End Module