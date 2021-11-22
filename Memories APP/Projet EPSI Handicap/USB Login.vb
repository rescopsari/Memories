Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Module USB_Login
    <Serializable>
    Public Class KeyFile
        Public Property USER_NAME As String
        Public Property USER_PASS As String

        <NonSerialized>
        Public KEY_FILE_PATH As String

        Public Function Save() As Boolean
            Dim fs As FileStream = File.OpenWrite(KEY_FILE_PATH)
            Dim Encoder As New BinaryFormatter
            Try
                Encoder.Serialize(fs, Me)
                fs.Close()
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Return False
            End Try
        End Function

        Public Function Open() As Boolean
            Dim fs As FileStream = File.OpenRead(KEY_FILE_PATH)
            Dim TempObj As New KeyFile
            Dim Decoder As New BinaryFormatter
            Try
                TempObj = Decoder.Deserialize(fs)
                fs.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Return False
            End Try

            If TempObj Is Nothing Then Return False
            With TempObj
                Me.USER_NAME = .USER_NAME
                Me.USER_PASS = .USER_PASS
            End With
            Return True
        End Function
    End Class
End Module
