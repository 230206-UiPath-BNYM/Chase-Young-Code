Imports System

Module Program
' Main Method - starting point of program
' 2 kinds of methods:
' Functions - return something
' Subs - return nothing or void
    Sub Main(args As String())
    ' vb has no grouping symbols like {}
    ' Instead uses words/closing statements
    ' Also, tabbing for documentation
    ' vb.net does not use semi colons (Will lead to errors)
        Console.WriteLine("Hello World!")
    ' variables - holds data, reference in memory, placeholder
    ' create variables using dim keyword
    ' using dim, syntax is dim name of var as datatype
    ' greeter function returns string that we are passing to the greeting variable
    dim greeting as String = greeter("casual")
    Console.WriteLine(greeting)
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

End Module
