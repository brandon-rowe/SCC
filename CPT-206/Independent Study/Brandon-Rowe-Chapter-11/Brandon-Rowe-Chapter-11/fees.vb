Public Class fees
    Private memberFees As Double = 0
    Private addFees As Double = 0

    Public ReadOnly Property MemberFee As Double
        Get
            Return memberFees
        End Get
    End Property

    Public ReadOnly Property addFee As Double
        Get
            Return addFees
        End Get
    End Property

    Public Sub calculateTotal(singleBool As Boolean, famBool As Boolean, golfChecked As Boolean, tennisChecked As Boolean, racChecked As Boolean)

        If singleBool = True Then
            memberFees += 50

            If golfChecked = True Then
                addFees += 25
            End If
            If tennisChecked = True Then
                addFees += 30
            End If
            If racChecked = True Then
                addFees += 20
            End If

        ElseIf famBool = True Then
            memberFees += 90

            If golfChecked = True Then
                addFees += 35
            End If
            If tennisChecked = True Then
                addFees += 50
            End If
            If racChecked = True Then
                addFees += 30
            End If

        End If
    End Sub

End Class
