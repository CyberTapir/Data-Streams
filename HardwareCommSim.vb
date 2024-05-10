Public Class HardwareCommSim

    Public Function ConvertDecimalToBinary(ByVal Value As String, Optional ByVal x As Integer = 0) As String
        Dim iVal#, temp#, ret%, i%, Str$
        Dim BinVal%()

        iVal = Value
        Do
            temp = iVal / 2
            ret = InStr(temp, ".")
            If ret > 0 Then
                temp = Strings.Left(temp, ret - 1)
            End If
            ret = iVal Mod 2
            ReDim Preserve BinVal(i)
            BinVal(i) = ret
            i = i + 1
            iVal = temp
        Loop While temp > 0
        For i = UBound(BinVal) To 0 Step -1
            Str = Str + CStr(BinVal(i))
        Next
        If x = 3 Then
            Select Case Len(Str) Mod 3
                Case 1
                    Str = "00" + Str
                Case 2
                    Str = "0" + Str
            End Select
        ElseIf x = 4 Then
            Select Case Len(Str) Mod 4
                Case 1
                    Str = "000" + Str
                Case 2
                    Str = "00" + Str
                Case 3
                    Str = "0" + Str
            End Select
        End If
        ConvertDecimalToBinary = Str

    End Function

    Public Function ConvertBinaryToDecimal(ByVal BinVal As String) As String
        Dim iVal#, temp#, i%, Length%

        Length = Len(BinVal)
        For i = 0 To Length - 1
            temp = CInt(Mid(BinVal, Length - i, 1))
            iVal = iVal + (temp * (2 ^ i))
        Next i
        ConvertBinaryToDecimal = iVal
    End Function

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim strInput As String = txtInput.Text
        Dim header As String = Strings.Left(strInput, 8)
        Dim startBits As String = Strings.Left(header, 3)
        Dim dataBlockLen As String = Strings.Right(header, 5)
        Dim trailer As String = Strings.Right(strInput, 8)
        Dim crc As String = Strings.Left(trailer, 4)
        Dim endBits As String = Strings.Right(trailer, 4)
        Dim len As Integer = ConvertBinaryToDecimal(CInt(dataBlockLen))
        Dim controlCharacters As String = strInput.Substring(8, 2)
        Dim dataBlock As String = strInput.Substring(10, 7 * len)
        Dim crcCheck As Integer
        Dim crcValue As Integer
        For i = 0 To dataBlock.Length - 1
            If dataBlock(i) = "1" Then
                crcCheck += 1
            End If
        Next i
        For i = 0 To 1
            If controlCharacters(i) = "1" Then
                crcCheck += 1
            End If
        Next i
        crcValue = crcCheck Mod 13
        If startBits = "101" Then
            If crcValue = ConvertBinaryToDecimal(crc) Then
                txtHeader.Text = header
                txtLength.Text = dataBlockLen
                txtTrailer.Text = trailer
                txtCRC.Text = crc
                txtLength.Text = len
                txtData.Text = dataBlock
                txtFormat.Text = controlCharacters
                Select Case controlCharacters
                    Case "00"
                        'no special formatting
                    Case "01"
                        'bold
                        txtData.Font = New Font(txtData.Font, FontStyle.Bold)
                    Case "10"
                        'italic
                        txtData.Font = New Font(txtData.Font, FontStyle.Italic)
                    Case "11"
                        '20pt font size
                        txtData.Font = New Font(txtData.Font.FontFamily, 20)
                End Select
                For i = 0 To len - 1
                    Dim data As String ' first 7 bits
                    Dim decimalVal As Integer
                    Dim outString As String
                    data = dataBlock.Substring(i * 7, 7)
                    decimalVal = ConvertBinaryToDecimal(CInt(data))
                    outString = outString & Chr(decimalVal)
                    txtData.Text = outString
                Next i
            End If
        End If
    End Sub
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class