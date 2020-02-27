Imports System
Imports SV

Module Program
    Dim WithEvents c As SV.Counter = New SV.Counter()
    Sub Main(args As String())


        AddHandler c.CounterStartEvent, AddressOf c_CounterStartEvent
        'RemoveHandler c.CounterStartEvent, AddressOf c_CounterStartEvent
        c.Run()

        Console.ReadLine()
    End Sub

    Sub c_CounterStartEvent(sender As Object)
        Dim s As SV.Counter = CType(sender, SV.Counter)
        Console.WriteLine("COUNTER_START_EVENT Count = " & s.Count)
    End Sub

    'Sub c_CounterStartEvent(sender As Object) Handles c.CounterStartEvent
    '    Dim s As Counter = CType(sender, Counter)
    '    Console.WriteLine("COUNTER_START_EVENT Count = " & s.Count)
    'End Sub

    Sub c_CounterChangeEvent(sender As Object) Handles c.CounterChangeEvent
        Dim s As SV.Counter = CType(sender, SV.Counter)
        Console.WriteLine("COUNTER_CHANGE_EVENT Count = " & s.Count)
    End Sub

    Sub c_CounterFinishEvent(sender As Object) Handles c.CounterFinishEvent
        Dim s As SV.Counter = CType(sender, SV.Counter)
        Console.WriteLine("COUNTER_FINISH_EVENT Count = " & s.Count)
    End Sub
End Module




