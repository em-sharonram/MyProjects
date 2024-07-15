Module Main
    Friend basket As New GroceryBasket
    Friend blnLoggedIn As Boolean
    Dim arrUsernames() As String = {"Admin", "Clerk", "Manager"}
    Dim arrPasswords() As String = {"P@ssword", "pa$$word", "passw0rd"}

    Sub Login(username As String, password As String)
        blnLoggedIn = False
        If VerifyUsername(username) And VerifyPassword(password) Then
            'Find index for username
            Dim userIndex As Integer
            For loopIndex = 0 To arrUsernames.Length - 1
                If arrUsernames(loopIndex) = username Then
                    userIndex = loopIndex
                    Exit For
                End If
            Next
            'Check for password match
            If arrPasswords(userIndex) = password Then
                blnLoggedIn = True
            Else
                Throw New LoginException
            End If
        End If
    End Sub
    Function VerifyUsername(username As String) As Boolean
        'Function to verify if the username is found in the arrUsernames array
        For Each user In arrUsernames
            If user = username Then
                Return True
            End If
        Next
        Return False
    End Function
    Function VerifyPassword(password As String) As Boolean
        'Function to verify if the password is found in the arrPasswords array
        For Each pass In arrPasswords
            If pass = password Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
