Module Module1

    Sub Main()
        Dim MemberName, MemberID, TelephoneNum, StartingDate, NameSearch As String
        Dim C As Integer
        Dim NameFound As Boolean
        NameFound = False
        FileOpen(1, "C:\FILING\MembersInfo.txt", OpenMode.Output)


        For C = 1 To 6
            Console.WriteLine("MEMBER NAME:")
            MemberName = Console.ReadLine
            Console.WriteLine("MEMBER ID:")
            MemberID = Console.ReadLine
            Console.WriteLine("TELEPHONE NUMBER: ")
            TelephoneNum = Console.ReadLine
            Console.WriteLine("MEMBERSHIP STARTING DATE:")
            StartingDate = Console.ReadLine
            WriteLine(1, MemberName)
            WriteLine(1, MemberID)
            WriteLine(1, TelephoneNum)
            WriteLine(1, StartingDate)
        Next

        FileClose(1)
        FileOpen(1, "C:\FILING\MembersInfo.txt", OpenMode.Input)
        FileOpen(2, "C:\FILING\UpdatedMembersInfo.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, MemberName)
            Input(1, MemberID)
            Input(1, TelephoneNum)
            Input(1, StartingDate)
            If MemberName <> NameSearch Then
                WriteLine(2, MemberName)
                WriteLine(2, MemberID)
                WriteLine(2, TelephoneNum)
                WriteLine(2, StartingDate)
            ElseIf MemberName = NameSearch Then
                NameFound = True
            End If
        End While
        FileClose(1)
        FileClose(2)
        My.Computer.FileSystem.DeleteFile("C:\FILING\MembersInfo.txt")
        My.Computer.FileSystem.RenameFile("C:\FILING\UpdatedMembersInfo.txt", "ClubMembers.txt")
        If NameFound = False Then Console.WriteLine("** N O  R E C O R D S  F O U N D **")
2:

        Console.ReadKey()
    End Sub

End Module
