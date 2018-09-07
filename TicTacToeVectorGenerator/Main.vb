Imports System.IO
Module Main

    Sub Main()

        Console.Out.WriteLine("Tic Tac Toe Vector Generator version 0.1")

        Dim pathOut = My.Computer.FileSystem.SpecialDirectories.Desktop + "\vector.txt"
        Dim introTextOut = "Please specify the path to the output file vector.txt (leave it blank for default path) : "
        Console.Out.WriteLine(introTextOut)
        Dim customPathOut = Console.ReadLine()
        If customPathOut <> "" Then pathOut = customPathOut

        Dim sw As StreamWriter
        sw = My.Computer.FileSystem.OpenTextFileWriter(pathOut, True)
        sw.Writeline("Hi")


        Dim temp As String
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                For k As Integer = 0 To 2
                    For l As Integer = 0 To 2
                        For m As Integer = 0 To 2
                            For n As Integer = 0 To 2
                                For o As Integer = 0 To 2
                                    For p As Integer = 0 To 2
                                        For q As Integer = 0 To 2
                                            temp = "" & q & p & o & n & m & l & k & j & i & "000000000"
                                            Do While temp.Contains(2) = True
                                                temp = temp.Substring(0, temp.IndexOf(2) + 9) & "1" & temp.Substring(temp.IndexOf(2) + 10)
                                                temp = temp.Substring(0, temp.IndexOf(2)) & "0" & temp.Substring(temp.IndexOf(2) + 1)
                                            Loop
                                            sw.WriteLine(temp)
                                        Next q
                                    Next p
                                Next o
                            Next n
                        Next m
                    Next l
                Next k
            Next j
        Next i



        sw.Close()

        Console.ReadLine()
    End Sub

End Module
