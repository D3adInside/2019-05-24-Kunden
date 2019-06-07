<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdDaten = New System.Windows.Forms.Button()
        Me.cmdAddGuthaben = New System.Windows.Forms.Button()
        Me.lbKdDaten = New System.Windows.Forms.Label()
        Me.lbKdGuthaben = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdDaten
        '
        Me.cmdDaten.Location = New System.Drawing.Point(229, 22)
        Me.cmdDaten.Name = "cmdDaten"
        Me.cmdDaten.Size = New System.Drawing.Size(390, 81)
        Me.cmdDaten.TabIndex = 0
        Me.cmdDaten.Text = "Daten füllen"
        Me.cmdDaten.UseVisualStyleBackColor = True
        '
        'cmdAddGuthaben
        '
        Me.cmdAddGuthaben.Location = New System.Drawing.Point(229, 261)
        Me.cmdAddGuthaben.Name = "cmdAddGuthaben"
        Me.cmdAddGuthaben.Size = New System.Drawing.Size(379, 139)
        Me.cmdAddGuthaben.TabIndex = 1
        Me.cmdAddGuthaben.Text = "Guthaben addieren"
        Me.cmdAddGuthaben.UseVisualStyleBackColor = True
        '
        'lbKdDaten
        '
        Me.lbKdDaten.AutoSize = True
        Me.lbKdDaten.Location = New System.Drawing.Point(399, 141)
        Me.lbKdDaten.Name = "lbKdDaten"
        Me.lbKdDaten.Size = New System.Drawing.Size(57, 20)
        Me.lbKdDaten.TabIndex = 2
        Me.lbKdDaten.Text = "Label1"
        '
        'lbKdGuthaben
        '
        Me.lbKdGuthaben.AutoSize = True
        Me.lbKdGuthaben.Location = New System.Drawing.Point(399, 209)
        Me.lbKdGuthaben.Name = "lbKdGuthaben"
        Me.lbKdGuthaben.Size = New System.Drawing.Size(57, 20)
        Me.lbKdGuthaben.TabIndex = 3
        Me.lbKdGuthaben.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbKdGuthaben)
        Me.Controls.Add(Me.lbKdDaten)
        Me.Controls.Add(Me.cmdAddGuthaben)
        Me.Controls.Add(Me.cmdDaten)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDaten As Button
    Friend WithEvents cmdAddGuthaben As Button
    Friend WithEvents lbKdDaten As Label
    Friend WithEvents lbKdGuthaben As Label
End Class
