Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Welcome to hangman! Guess the 7 letter word")

        dim answer as String = ("program")
        dim blank as String = ("_ _ _ _ _ _ _")
        Console.WriteLine(blank)
        For index as Integer = 1 To 6
            Console.WriteLine("Enter guess: ")
            dim guess as String = Console.ReadLine()
            If guess = answer Then
                Console.WriteLine("Correct! Good job!")
                Exit For
            Else
                Console.WriteLine("Wrong! Try again!")
            End If
        Next
        
    End Sub
End Module
