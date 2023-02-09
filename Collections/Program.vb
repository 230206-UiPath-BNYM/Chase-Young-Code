Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        ' Arrays, Lists, Dictionaries

        '=========Arrays=========
        ' homogenous collection of items stored in a contiguous memory space
        ' declare arrays by including () after variable name
        ' statically sized
        dim fruits() as String = {"banana", "apple", "mango"}
        dim fruits2(3) as String
        fruits2(0) = "kiwi"
        fruits2(1) = "strawberry"
        fruits2(2) = "pineapple"

        ' enhanced for Loop aka for each that is utilized to iterate over collections
        For Each fruit As String In fruits
            Console.WriteLine(fruit)
        Next

        '=========Lists=========
        ' ordered collection of homogenous items
        ' indexed based like arrays
        ' can dynamically change size
        dim students as New List(of String)
        students.add("Chase")
        students.add("Justin")
        students.add("Amol")
        students.add("Gavin")

        For Each student As String In students
            Console.WriteLine(student)
        Next
        
        students(2) = "Amol Apte"
        Console.WriteLine(students(2))

        '=========Dictionary=========
        ' collection of key value pairs
        ' access values based on their keys

        dim gradeBook as new Dictionary(of String, Integer)
        gradeBook.add("Justin", 95)
        gradeBook.add("Marielle", 100)
        gradeBook.add("Coco", 200)

        Console.WriteLine("Marielle got a grade of {0}", gradeBook("Marielle"))
        
        ' iterating over dictionary
        For Each grade As KeyValuePair(of String, Integer) In gradeBook
            Console.WriteLine("{0} got a grade of {1}", grade.Key, grade.Value)
        Next
        
    End Sub
End Module
