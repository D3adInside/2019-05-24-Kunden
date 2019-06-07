Public Class Form1
    Inherits System.Windows.Forms.Form
    Private oKunde1 As CKunde
    Private Sub cmdDaten_Click(sender As Object, e As EventArgs) Handles cmdDaten.Click

        Dim oKunde1 As New CKunde
        oKunde1.pAnrede = "Herr"
        oKunde1.pName = "Müller"
        oKunde1.pPLZ = "12345"
        oKunde1.pOrt = "Berlin"
        oKunde1.pStammkunde = True
        oKunde1.pGuthaben = 10

        lbKdDaten.Text = oKunde1.mthAdresse()
        oKunde1.mthGuthabenMan(50)
        lbKdGuthaben.Text = "Guthaben beträgt:" & oKunde1.pGuthaben & "€."


    End Sub

End Class

Public Class CKunde
    Dim oKunde As New CKunde
    Private mAnrede As String
    Private mName As String
    Private mPLZ As String
    Private mOrt As String
    Private mStammkunde As Boolean
    Private mGuthaben As Integer
    Sub New()

    End Sub
    Public Property pAnrede As String
        Get
            Return mAnrede
        End Get
        Set(ByVal prmAnrede As String)
            mAnrede = prmAnrede
        End Set
    End Property
    Public Property pName As String
        Get
            Return mName
        End Get
        Set(ByVal prmName As String)
            mName = prmName
        End Set
    End Property
    Public Property pPLZ As String
        Get
            Return mPLZ
        End Get
        Set(ByVal prmPLZ As String)
            mPLZ = prmPLZ
        End Set
    End Property
    Public Property pOrt As String
        Get
            Return mOrt
        End Get
        Set(ByVal prmOrt As String)
            mOrt = prmOrt
        End Set
    End Property
    Public Property pStammkunde As Boolean
        Get
            Return mStammkunde
        End Get
        Set(ByVal prmStammkunde As Boolean)
            mStammkunde = prmStammkunde
        End Set
    End Property
    Public Property pGuthaben As Integer
        Get
            Return mGuthaben
        End Get
        Set(ByVal prmGuthaben As Integer)
            mGuthaben = prmGuthaben
        End Set
    End Property
    Public Sub mthGuthabenMan(ByVal prmBetrag As Integer)
        If mStammkunde = True Then
            mGuthaben = mGuthaben + prmBetrag
        End If
    End Sub
    Public Function mthAdresse()
        Return mAnrede & "" & mName & vbCrLf & mPLZ & "" & mOrt
    End Function
End Class







