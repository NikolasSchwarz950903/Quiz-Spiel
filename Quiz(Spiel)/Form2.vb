Imports System.Data.SqlClient
Imports System.IO
Imports System

Public Class Form2

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    '-----------------------------------Buffer für Spalteninhalt-----------------------------------------
    Dim BufferFrage As String
    Dim BufferAntwortA As String
    Dim BufferAntwortB As String
    Dim BufferAntwortC As String
    Dim BufferAntwortD As String
    Dim BufferRichtigeAntwort As String

    '---------------------------------------Nummernrandom----------------------------------------------------
    Dim ID As String
    '---------------------------------------PunkteBuffer-----------------------------------------------------
    Dim PunkteSpieler1 As Integer = 0
    Dim PunkteSpieler2 As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatenbankAuslesenFragenSpalte()
        DatenbankAuslesenAntwortA()
        DatenBankAuslesenAntwortB()
        DatenBankAuslesenAntwortC()
        DatenBankAuslesenAntwortD()
        DatenBankAuslesenRichtigeAntwort()
        lblPunkteSpieler2.Text = "Punkte " & Form1.txtBoxSpieler2.Text & ": " & PunkteSpieler2
        lblPunkteSpieler1.Text = "Punkte " & Form1.txtBoxSpieler1.Text & ": " & PunkteSpieler1
        lblSpieler1.Text = Form1.txtBoxSpieler1.Text
        lblSpieler2.Text = Form1.txtBoxSpieler2.Text
    End Sub

    Sub DatenbankAuslesenFragenSpalte()

        lblFrage.Text = ""
        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT Frage FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferFrage = myData.GetString(0)

        End While

        lblFrage.Text = BufferFrage


    End Sub

    Sub DatenbankAuslesenAntwortA()
        txtBoxAntwortA.Text = ""
        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT AntwortA FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferAntwortA = myData.GetString(0)

        End While

        txtBoxAntwortA.Text = BufferAntwortA
    End Sub

    Sub DatenBankAuslesenAntwortB()
        txtBoxAntwortB.Text = ""
        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT AntwortB FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferAntwortB = myData.GetString(0)

        End While

        txtBoxAntwortB.Text = BufferAntwortB
    End Sub

    Sub DatenBankAuslesenAntwortC()
        txtBoxAntwortC.Text = ""
        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT AntwortC FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferAntwortC = myData.GetString(0)

        End While

        txtBoxAntwortC.Text = BufferAntwortC
    End Sub

    Sub DatenBankAuslesenAntwortD()
        txtBoxAntwortD.Text = ""
        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT AntwortD FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferAntwortD = myData.GetString(0)

        End While

        txtBoxAntwortD.Text = BufferAntwortD
    End Sub

    Sub DatenBankAuslesenRichtigeAntwort()

        Dim con2 As New SqlConnection

        con2 = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")


        If con2.State = ConnectionState.Open Then
            con2.Close()
        End If

        con2.Open()

        Dim SQLAbfrage As String = "SELECT AntwortRichtig FROM QuizFragen Where NR = '" & ID & "'  "                                  'Auslesen der Datenbank spalte Frage wo NR = ID 
        Dim myCommand As New SqlClient.SqlCommand

        myCommand.Connection = con2
        myCommand.CommandText = SQLAbfrage

        Dim myData As SqlClient.SqlDataReader

        con2.CreateCommand.CommandText = myCommand.ToString
        myData = myCommand.ExecuteReader()                                                             ' Ausführen des Auslesens der Datenbank, in myData 

        While myData.Read

            BufferRichtigeAntwort = myData.GetString(0)

        End While


    End Sub

    Private Sub btnAbgleich_Click(sender As Object, e As EventArgs) Handles btnAbgleich.Click

        'If cboBoxSpieler1.SelectedItem.ToString = BufferRichtigeAntwort AndAlso cboBoxSpieler2.SelectedItem.ToString = BufferRichtigeAntwort Then
        '    lblPunkteSpieler1.Text = "Punkte Spieler 1: " & PunkteSpieler1
        '    lblPunkteSpieler2.Text = "Punkte Spieler 2: " & PunkteSpieler2
        '    MsgBox("Beide punkten")

        If cboBoxSpieler1.SelectedItem.ToString = BufferRichtigeAntwort AndAlso cboBoxSpieler2.SelectedItem.ToString = BufferRichtigeAntwort Then
            MsgBox("Beide Spieler sind richtig.")
            PunkteSpieler2 = PunkteSpieler2 + 1
            PunkteSpieler1 = PunkteSpieler1 + 1
            lblPunkteSpieler2.Text = "Punkte " & Form1.txtBoxSpieler2.Text & ": " & PunkteSpieler2
            lblPunkteSpieler1.Text = "Punkte " & Form1.txtBoxSpieler1.Text & ": " & PunkteSpieler1

        ElseIf cboBoxSpieler1.SelectedItem.ToString = BufferRichtigeAntwort Then
            MsgBox("Spieler1 punktet")
            PunkteSpieler1 = PunkteSpieler1 + 1
            lblPunkteSpieler1.Text = "Punkte " & Form1.txtBoxSpieler1.Text & ": " & PunkteSpieler1

        ElseIf cboBoxSpieler2.SelectedItem.ToString = BufferRichtigeAntwort Then
            MsgBox("Spieler2 punktet")
            PunkteSpieler2 = PunkteSpieler2 + 1
            lblPunkteSpieler2.Text = "Punkte " & Form1.txtBoxSpieler2.Text & ": " & PunkteSpieler2

        Else
            MsgBox("Beide Falsch!")
        End If

    End Sub

    Private Sub btnNaechsteFrage_Click(sender As Object, e As EventArgs) Handles btnNaechsteFrage.Click
        txtBoxAntwortA.Text = ""
        txtBoxAntwortB.Text = ""
        txtBoxAntwortC.Text = ""
        txtBoxAntwortD.Text = ""
        lblFrage.Text = ""

        ID = Int((10 * Rnd()) + 1)

        DatenbankAuslesenFragenSpalte()
        DatenbankAuslesenAntwortA()
        DatenBankAuslesenAntwortB()
        DatenBankAuslesenAntwortC()
        DatenBankAuslesenAntwortD()
        DatenBankAuslesenRichtigeAntwort()
    End Sub
End Class
'("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=false")
'----------------------------------------------------------------'Inhalt aus Datenbank auslesen-------------------------------------------------------------------------------------------------------

'con = New SqlConnection("Data Source=DESKTOP-B9TOBIG\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

'If con.State = ConnectionState.Open Then
'con.Close()
'End If
'con.Open()

'Dim SQLAbfrage As String = "Select * from Quiz"
'Dim myCommand As New SqlClient.SqlCommand
'myCommand.Connection = con
'myCommand.CommandText = SQLAbfrage

'Dim myData As SqlClient.SqlDataReader

'con.CreateCommand.CommandText = myCommand.ToString
'myData = myCommand.ExecuteReader()

'If myData.HasRows Then

'End If