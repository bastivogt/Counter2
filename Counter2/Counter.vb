Namespace SV
    Class Counter

        Private _count As Integer


        Public Property StartValue As Integer
        Public Property FinishValue As Integer
        Public Property StepValue As Integer

        Public ReadOnly Property Count
            Get
                Return Me._count
            End Get
        End Property

        Public Event CounterStartEvent(sender As Object)
        Public Event CounterChangeEvent(sender As Object)
        Public Event CounterFinishEvent(sender As Object)

        Public Sub New(Optional startValue As Integer = 0, Optional finishValue As Integer = 10, Optional stepValue As Integer = 1)
            Me.StartValue = startValue
            Me.FinishValue = finishValue
            Me.StepValue = stepValue
        End Sub


        Public Sub Run()
            RaiseEvent CounterStartEvent(Me)
            For Me._count = 0 To Me.FinishValue Step Me.StepValue
                RaiseEvent CounterChangeEvent(Me)
            Next
            RaiseEvent CounterFinishEvent(Me)
        End Sub


    End Class
End Namespace

