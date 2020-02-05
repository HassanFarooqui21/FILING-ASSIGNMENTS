Module Module1

    Sub Main()
        Dim MemberName, MemberID, SearchName As String
        Dim NameFound As Boolean
        NameFound = False
        Console.WriteLine("Enter name to search for : ")
        SearchName = Console.ReadLine
        FileOpen(1, "C:\FILING\MembersInfo.txt", OpenMode.Input)

        While Not EOF(1) And NameFound = False
            Input(1, MemberName)
            Input(1, MemberID)

            If MemberName = SearchName Then
                NameFound = True

                Console.WriteLine("Id Number :" & MemberID)
            End If
        End While
        FileClose(1)
        If NameFound = False Then Console.WriteLine(">> N O  R E C O R D S  F O U N D <<")
        Console.ReadKey()

    End Sub

End Module
