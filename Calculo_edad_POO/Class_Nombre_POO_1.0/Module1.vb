Imports ClassPerson
Module Module1

    Sub Main()
        'Zona de declaración de nuevas variables y clases
        Dim person, personborndate As Person
        person = New Person
        Dim personNameStr, personborndateStr As String
        Dim personYearsOld, personDaysOld, personHoursOld, personMinutesOld As Long

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
        Console.Write("||Este programa pedira su nombre y fecha de nacimiento. Con ello realizara calculos que se expondran en pantalla||")
        Console.WriteLine()
        Console.Write("==================================================================================================================")
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.Write("Introduce tu nombre: ")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        personNameStr = Console.ReadLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.Write("Introduce tu fecha de nacimiento: ")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        personborndateStr = Console.ReadLine()
        Console.WriteLine()

        '2 de agosto de 2001
        If Date.TryParse(personborndateStr, person.PerBornDate) Then
            personYearsOld = DateDiff(DateInterval.Year, person.PerBornDate, Date.Now)
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("--->" & personNameStr & " tienes " & personYearsOld & " años")
            Console.WriteLine()
            personDaysOld = DateDiff(DateInterval.Day, person.PerBornDate, Date.Now)
            Console.Write("--->En días tienes " & personDaysOld & " días")
            Console.WriteLine()
            personHoursOld = DateDiff(DateInterval.Hour, person.PerBornDate, Date.Now)
            Console.Write("--->En horas tienes " & personHoursOld & " horas")
            Console.WriteLine()
            personMinutesOld = DateDiff(DateInterval.Minute, person.PerBornDate, Date.Now)
            Console.Write("--->En minutos tienes " & personMinutesOld & " minutos")
            Console.WriteLine()

        Else
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.Write("El valor introducido para 'Fecha de naciemiento' no esta admitido por el sistema")
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("[Pulsa cualquier tecla para salir]---->")
            Console.ReadKey()
            Exit Sub
        End If


        'Sistema de cierre de la consola
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("[Pulsa cualquier tecla para salir]---->")
        Console.ReadKey()

    End Sub

End Module
