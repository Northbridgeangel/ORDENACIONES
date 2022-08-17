Public Class Form1
    Public DESORDEN() As Integer
    Public ORDEN() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '*****************************************************************************
        '*************************   METODO BURBUJA  *********************************
        '*****************************************************************************
        ' FASE 1 VARIABLES Y CARGA EN EL VECTOR NUMEROS AL TUN TUN
        Cursor.Current = Cursors.WaitCursor
        ReDim DESORDEN(100000)
        ReDim ORDEN(100000)
        COMBODESORDEN.Items.Clear()
        COMBOORDEN.Items.Clear()
        Dim POSI As Integer
        Dim MINIMO As Integer
        Randomize()
        For I = 1 To 10000
            DESORDEN(I) = Int(Rnd() * 4999 + 1)
            COMBODESORDEN.Items.Add(DESORDEN(I))
        Next
        ' FASE 2 ORDENACION POR BURBUJA
        Dim INICIO1, INICIO2 As Date
        Dim segundos As String
        INICIO1 = TimeOfDay
        For I = 1 To 10000
            MINIMO = 9999
            POSI = 0
            For X = 1 To 10000
                If DESORDEN(X) < MINIMO Then
                    MINIMO = DESORDEN(X)
                    POSI = X
                End If

            Next

            ORDEN(I) = MINIMO
            DESORDEN(POSI) = 9999
        Next
        INICIO2 = TimeOfDay
        segundos = DateDiff(DateInterval.Second, CDate(INICIO1), CDate(INICIO2))
        Label4.Text = segundos
        ' FASE 3 CARGAR EN COMBOORDEN EL VECTOR ORDEN
        For I = 1 To 10000
            COMBOORDEN.Items.Add(ORDEN(I))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '*****************************************************************************
        '*************************   METODO INSERCION  *******************************
        '*****************************************************************************
        ' FASE 1 VARIABLES Y CARGA EN EL VECTOR NUMEROS AL TUN TUN
        Cursor.Current = Cursors.WaitCursor
        ReDim DESORDEN(10000)
        ReDim ORDEN(10000)
        COMBODESORDEN.Items.Clear()
        COMBOORDEN.Items.Clear()
        Randomize()
        For X = 1 To 10000
            DESORDEN(X) = Int(Rnd() * 4999 + 1)
            COMBODESORDEN.Items.Add(DESORDEN(X))
        Next
        ' FASE 2 ORDENACION POR INSERCION LO HACE EN EL VECTOR DESORDEN
        Dim INICIO1, INICIO2 As Date
        Dim segundos As String
        INICIO1 = TimeOfDay
        Dim i As Long
        Dim t As Integer
        Dim Actual As Long
        Dim Min As Long
        Dim Max As Long
        Dim ORDE As Integer
        ORDE = 1
        Min = LBound(DESORDEN)
        Max = UBound(DESORDEN)

        Actual = Min + 1
        While Actual <= Max
            i = Actual
            Do
                If i > Min Then
                    If ORDE = 1 Then
                        If DESORDEN(i) < DESORDEN(i - 1) Then
                            t = DESORDEN(i)
                            DESORDEN(i) = DESORDEN(i - 1)
                            DESORDEN(i - 1) = t
                            i = i - 1
                        Else
                            Exit Do
                        End If
                    Else
                        If DESORDEN(i) >= DESORDEN(i - 1) Then
                            t = DESORDEN(i)
                            DESORDEN(i) = DESORDEN(i - 1)
                            DESORDEN(i - 1) = t
                            i = i - 1
                        Else
                            Exit Do
                        End If
                    End If
                Else
                    Exit Do
                End If

            Loop
            Actual = Actual + 1
        End While
        INICIO2 = TimeOfDay
        segundos = DateDiff(DateInterval.Second, CDate(INICIO1), CDate(INICIO2))
        Label4.Text = segundos
        ' FASE 3 CARGAR EN COMBOORDEN EL VECTOR ORDEN
        For i = 1 To 10000
            COMBOORDEN.Items.Add(DESORDEN(i))
            ORDEN(i) = DESORDEN(i)
        Next

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '*****************************************************************************
        '*************************   BUSQUEDA BINARIA  *******************************
        '*****************************************************************************
        Dim sup, inf, m As Integer
        Dim DATO As Integer
        DATO = InputBox("Mete el Dato")
        inf = LBound(ORDEN)
        sup = UBound(ORDEN)
        Do
            m = (inf + sup) / 2
            If (DATO < ORDEN(m)) Then
                sup = m
            ElseIf (DATO > ORDEN(m)) Then
                inf = m
            End If
        Loop Until (dato = ORDEN(m) Or inf >= sup)

        If (dato = ORDEN(m)) Then
            TextBox1.Text = “La posición es:” & m
            TextBox2.Text = “El dato es: ” & ORDEN(m)
        Else
            TextBox1.Text = “El dato no se encontro”
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '*****************************************************************************
        '*******************************   QUICK SORT  *******************************
        '*****************************************************************************
        ' FASE 1 VARIABLES Y CARGA EN EL VECTOR NUMEROS AL TUN TUN
        Cursor.Current = Cursors.WaitCursor
        ReDim DESORDEN(100000)
        ReDim ORDEN(100000)
        COMBODESORDEN.Items.Clear()
        COMBOORDEN.Items.Clear()
        Randomize()
        For X = 1 To 100000
            DESORDEN(X) = Int(Rnd() * 4999 + 1)
            COMBODESORDEN.Items.Add(DESORDEN(X))
        Next
        ' 2 FASE LLAMADA A LA FUNCION
        Dim INICIO1, INICIO2 As Date
        Dim segundos As String
        INICIO1 = TimeOfDay
        Call Ordenar_Matriz(DESORDEN, LBound(DESORDEN), UBound(DESORDEN))
        INICIO2 = TimeOfDay
        segundos = DateDiff(DateInterval.Second, CDate(INICIO1), CDate(INICIO2))
        Label4.Text = segundos
        ' FASE 3 CARGAR EN COMBOORDEN EL VECTOR ORDEN
        For I = 1 To 100000
            COMBOORDEN.Items.Add(DESORDEN(I))
            ORDEN(I) = DESORDEN(I)
        Next
    End Sub
    Sub Ordenar_Matriz(El_Vector() As Integer,
                   Limite_Inferior As Long,
                   Limite_Superior As Long)

        Dim i As Long, j As Long, x As Integer, y As Integer

        i = Limite_Inferior
        j = Limite_Superior

        x = El_Vector((Limite_Inferior + Limite_Superior) / 2)

        While i <= j

            While (El_Vector(i) < x) And (i < Limite_Superior)
                i = i + 1
            End While

            While (x < El_Vector(j)) And (j > Limite_Inferior)
                j = j - 1
            End While

            If i <= j Then
                y = El_Vector(i)
                El_Vector(i) = El_Vector(j)
                El_Vector(j) = y
                i = i + 1
                j = j - 1
            End If

        End While

        If Limite_Inferior < j Then Ordenar_Matriz(El_Vector, Limite_Inferior, j)
        If i < Limite_Superior Then Ordenar_Matriz(El_Vector, i, Limite_Superior)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Val(Label4.Text) + 1
    End Sub
End Class
