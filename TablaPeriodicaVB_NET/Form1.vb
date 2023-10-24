Public Class Form1
    Dim Elemento As Elemento = New Elemento()


    Private Sub UpdateData(color As Color)
        Pnl_ElementoSelect.BackColor = color
        Lbl_ElementoSelect.Text = Elemento.PropSimbolo()
        Txt_Nombre.Text = Elemento.PropNombreElemento()
        Txt_M_Atomica.Text = Elemento.PropMasaAtomica()
        Txt_E_Oxidacion.Text = Elemento.PropEstadoOxidacion()
        Txt_N_Atomico.Text = Elemento.PropNumeroAtomico()
    End Sub
    Private Sub Pnl_H_MouseClick(sender As Object, e As MouseEventArgs) Handles Pnl_H.MouseClick
        Elemento.PropNombreElemento = "Hidrógeno"
        Elemento.PropMasaAtomica = 1.008
        Elemento.PropNumeroAtomico = 1
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "H"
        UpdateData(Pnl_H.BackColor)
    End Sub

    Private Sub Lbl_H_Click(sender As Object, e As EventArgs) Handles Lbl_H.Click
        Elemento.PropNombreElemento = "Hidrógeno"
        Elemento.PropMasaAtomica = 1.008
        Elemento.PropNumeroAtomico = 1
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "H"
        UpdateData(Pnl_H.BackColor)
    End Sub

    Private Sub Pnl_Li_Click(sender As Object, e As EventArgs) Handles Pnl_Li.Click
        Elemento.PropNombreElemento = "Litio"
        Elemento.PropMasaAtomica = 6.94
        Elemento.PropNumeroAtomico = 3
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "Li"
        UpdateData(Pnl_Li.BackColor)
    End Sub

    Private Sub Lbl_Li_Click(sender As Object, e As EventArgs) Handles Lbl_Li.Click
        Elemento.PropNombreElemento = "Litio"
        Elemento.PropMasaAtomica = 6.94
        Elemento.PropNumeroAtomico = 3
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "Li"
        UpdateData(Pnl_Li.BackColor)
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        Elemento.PropNombreElemento = "Berilio"
        Elemento.PropMasaAtomica = 9.0122
        Elemento.PropNumeroAtomico = 4
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "Be"
        UpdateData(Panel9.BackColor)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Elemento.PropNombreElemento = "Berilio"
        Elemento.PropMasaAtomica = 9.0122
        Elemento.PropNumeroAtomico = 4
        Elemento.PropEstadoOxidacion = ""
        Elemento.PropSimbolo = "Be"
        UpdateData(Panel9.BackColor)
    End Sub
End Class
