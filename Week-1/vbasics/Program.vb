Imports System

Module Program
' main method - starting point of program
' 2 kinds of methods:
' functions - return something
' subs - return nothing or void
    Sub Main(args As String())
    ' vb has no grouping symbols like {}
    ' instead uses words/closing statements
    ' also, tabbing for documentation
    ' vb.net does not use semi colons (Will lead to errors)
        Console.WriteLine("Hello World!")
    ' variables - holds data, reference in memory, placeholder
    ' create variables using dim keyword
    ' using dim, syntax is dim name of var as datatype
    ' greeter function returns string that we are passing to the greeting variable
    dim greeting as String = greeter("casual")
    Console.WriteLine(greeting)
    GuessingGame(1)
    Counter(3)
    End Sub
    ' set datatype with "as" keyword
    Function greeter(greeting_type as String) As String
        ' flow control statements, used to channel logic based on conditions
        ' select case AKA switch
        Select Case greeting_type
            Case "casual"
                Return "'sup"
            Case "business casual"
                Return "salutations!"
            Case "full business"
                Return "to whom it may concern"
            Case Else
                Return "hello"
        End Select
    
    End Function

    Sub GuessingGame(guess as Integer)
        ' Use random class to generate random number
        dim rnd as Random = new Random()
        dim mysteryNumber as integer = rnd.Next(1,2)
        ' Use <> to represent not equal, ie !=
        If guess <> mysteryNumber Then
            Console.WriteLine("Wrong guess")
        Else
            Console.WriteLine("Correct guess")
        End If
    End Sub

    Sub Counter(stopping_point as Integer)
        dim start as Integer = 0
        ' while loop
        While start < stopping_point
            Console.WriteLine(start)
            start = start + 1
        End While

        ' for loop
        ' lower and upper bounds are included in iteration
        For index As integer = 0 To stopping_point
            Console.WriteLine(index)
        Next
        
    End Sub

End Module
