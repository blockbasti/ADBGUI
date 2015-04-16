Public NotInheritable Class SplashScreen1

    'TODO: Dieses Formular kann einfach als Begrüßungsbildschirm für die Anwendung festgelegt werden, indem Sie zur Registerkarte "Anwendung"
    '  des Projekt-Designers wechseln (Menü "Projekt", Option "Eigenschaften").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Richten Sie den Dialogtext zur Laufzeit gemäß den Assemblyinformationen der Anwendung ein.  

        'TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '  Projekteigenschaften (im Menü "Projekt") anpassen.

        'Anwendungstitel
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Wenn der Anwendungstitel fehlt, Anwendungsnamen ohne Erweiterung verwenden
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
