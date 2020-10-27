Module Module1
 
     Sub Main()
         Dim STR,MyWord AS String 
         Dim nextChar AS Char
         Dim count AS Integer
         count = 0 
         nextChar = " "
         MyWord = " "
         STR= " "
         Console.Writeline("Enter your String: ")
         STR = " "
         FOR count = 1 TO Len(STR)
             nextChar = Mid(STR, count, 1)
             MyWord = nextChar & MyWord
         Next
         Console.Writeline(MyWOrd)
         Console.Readkey()
     Eng Sub

End Module
