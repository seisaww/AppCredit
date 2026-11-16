Public Class Crédit

    ' pourquoi une classe Crédit 
    ' réutilisable partout y compris en aspx 
    ' variable privée

    Private monMontant As Double
    Private maDurée As Double
    Private monTaux As Double
    Private maMensualité As Double
    Private listeCrédit As List(Of Crédit)
    Private monNuméro As Integer


    ' le constructeur en c# -->

    Sub New()   ' constructeur en vb
        monNuméro = 0
    End Sub

    Sub New(montant As Double, duree As Double, taux As Double)
        ' par défaux, il est public 
        ' en c#, il est privé 

        monMontant = montant
        maDurée = duree
        monTaux = taux

        ' ici c'est la mensualité qui sera calculé

        maMensualité = 0
        monNuméro += 1

    End Sub

    Sub New(montant As Double, duree As Double, taux As Double, mensualite As Double)

        monMontant = montant
        maDurée = duree
        monTaux = taux
        maMensualité = mensualite
        monNuméro += 1

        ' c'est la valeur à 0 qui sera calculé 
        ' part itération succesive 

    End Sub

    Public Sub setNumero()
        monNuméro += 1
    End Sub

    Public Function getNumero()
        Return monNuméro
    End Function
    Public Function getMensualite() As Double

        ' 
        ' m = V0 * i / (1 - (1 + i) ^ - n

        ' m : mensualité, V0 = montant fiancié initial, n : durée en mois, i : taux annuel

        Dim tauxMens As Double = monTaux / 1200 ' sur 12 mois en pourcentage 

        maMensualité = Math.Round((monMontant * tauxMens) / (1 - Math.Pow(1 + tauxMens, -maDurée))) ' Math.Pow, pour élever à la puissance 

        Return maMensualité

    End Function

    Public Function getTaux()
        Return monTaux
    End Function

    Public Function getNbMensualite()
        Return maDurée
    End Function

    Public Function getMontant()
        Return monMontant
    End Function

    Public Sub ajouterCrédit(unCredit As Crédit)
        listeCrédit.Add(unCredit)
    End Sub
End Class
