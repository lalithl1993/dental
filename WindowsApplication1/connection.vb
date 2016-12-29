Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module connection
    Public connectionstring As String = Nothing
    Public reader As SqlDataReader = Nothing
    Public conn As SqlConnection = Nothing
    Public cmd As SqlCommand = Nothing
    Public sql As String = Nothing
    Public Sub executesqlstmt(ByVal sql As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        connectionstring = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\database\Dental.mdf;Integrated Security=True;User Instance=True;"
        conn.ConnectionString = connectionstring
        conn.Open()

    End Sub

    Public Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

    End Function


End Module