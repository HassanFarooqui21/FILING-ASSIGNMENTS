Module Module1

    Sub Main()
        Dim MemberName, MemberID As String
        Dim C As Integer

        FileOpen(1, "C:\FILING\MembersInfo.txt", OpenMode.Append)
        For C = 1 To 5
            Console.WriteLine("MEMBER NAME:")
            MemberName = Console.ReadLine
            Console.WriteLine("MEMBER ID:")
            MemberID = Console.ReadLine
            WriteLine(1, MemberName)
            WriteLine(1, MemberID)
        Next

        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
