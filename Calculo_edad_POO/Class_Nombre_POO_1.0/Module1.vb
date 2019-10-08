Imports ClassPerson
Module Module1

    Sub Main()
        'Zona de declaración de nuevas variables y clases
        Dim person As Person
        person = New Person

        'IPuerta de entrada
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.Write("  ____ _____ ______ _   ___      ________ _   _ _____ _____   ____  ")
        Console.WriteLine()
        Console.Write(" |  _ \_   _|  ____| \ | \ \    / /  ____| \ | |_   _|  __ \ / __ \ ")
        Console.WriteLine()
        Console.Write(" | |_) || | | |__  |  \| |\ \  / /| |__  |  \| | | | | |  | | |  | |")
        Console.WriteLine()
        Console.Write(" |  _ < | | |  __| | . ` | \ \/ / |  __| | . ` | | | | |  | | |  | |")
        Console.WriteLine()
        Console.Write(" | |_) || |_| |____| |\  |  \  /  | |____| |\  |_| |_| |__| | |__| |")
        Console.WriteLine()
        Console.Write(" |____/_____|______|_| \_|   \/   |______|_| \_|_____|_____/ \____/ ")
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("==================================================================================================================")
        Console.WriteLine()
        Console.Write("||Este programa pedira tu nombre y fecha de nacimiento. Con ello realizara calculos que se expondran en pantalla||")
        Console.WriteLine()
        Console.Write("==================================================================================================================")
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.Write("Introduce tu nombre: ")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        person.PerName = Console.ReadLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow

        Try
            Console.Write("Introduce tu fecha de nacimiento: ")
            Console.ForegroundColor = ConsoleColor.DarkCyan
            person.dob = Console.ReadLine()
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("--->" & person.PerName & " tienes " & person.age)
            Console.WriteLine("--->tienes " & person.months & " meses")
            Console.Write("--->En días tienes " & person.days & " días")
            Console.WriteLine()
            Console.Write("--->En horas tienes " & person.hours & " horas")
            Console.WriteLine()
            Console.Write("--->En minutos tienes " & person.minutes & " minutos")
            Console.WriteLine()
        Catch ex As Exception
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.Write("El valor introducido para 'Fecha de naciemiento' no esta admitido por el sistema")
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("[Pulsa cualquier tecla para salir]---->")
            Console.ReadKey()
            Exit Sub
        End Try

        'Sistema de cierre de la consola
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("[Pulsa cualquier tecla para salir]---->")
        Console.ReadKey()

    End Sub

End Module
