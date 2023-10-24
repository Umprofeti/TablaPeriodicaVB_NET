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
        Elemento.PropEstadoOxidacion = "-1 y 1"
        Elemento.PropSimbolo = "H"
        UpdateData(Pnl_H.BackColor)
    End Sub
    Private Sub Pnl_Li_Click(sender As Object, e As EventArgs) Handles Pnl_Li.Click, Lbl_Li.Click
        Elemento.PropNombreElemento = "Litio"
        Elemento.PropMasaAtomica = 6.94
        Elemento.PropNumeroAtomico = 3
        Elemento.PropEstadoOxidacion = "1"
        Elemento.PropSimbolo = "Li"
        UpdateData(Pnl_Li.BackColor)
    End Sub
    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click, Label18.Click
        Elemento.PropNombreElemento = "Berilio"
        Elemento.PropMasaAtomica = 9.0122
        Elemento.PropNumeroAtomico = 4
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Be"
        UpdateData(Panel9.BackColor)
    End Sub

    Private Sub Pnl_Na_Click(sender As Object, e As EventArgs) Handles Pnl_Na.Click, Lbl_Na.Click
        Elemento.PropNombreElemento = "Sodio"
        Elemento.PropMasaAtomica = 22.99
        Elemento.PropNumeroAtomico = 11
        Elemento.PropEstadoOxidacion = "-1 y 1"
        Elemento.PropSimbolo = "Na"
        UpdateData(Pnl_Na.BackColor)
    End Sub

    Private Sub Pnl_K_Click(sender As Object, e As EventArgs) Handles Pnl_K.Click, Lbl_K.Click
        Elemento.PropNombreElemento = "Potasio"
        Elemento.PropMasaAtomica = 39.098
        Elemento.PropNumeroAtomico = 19
        Elemento.PropEstadoOxidacion = "-1 y 1"
        Elemento.PropSimbolo = "K"
        UpdateData(Pnl_K.BackColor)
    End Sub

    Private Sub Pnl_Rb_Click(sender As Object, e As EventArgs) Handles Pnl_Rb.Click, Lbl_Rb.Click
        Elemento.PropNombreElemento = "Rubidio"
        Elemento.PropMasaAtomica = 85.468
        Elemento.PropNumeroAtomico = 37
        Elemento.PropEstadoOxidacion = "-1 y 1"
        Elemento.PropSimbolo = "Rb"
        UpdateData(Pnl_Rb.BackColor)
    End Sub

    Private Sub Pnl_Cs_Click(sender As Object, e As EventArgs) Handles Pnl_Cs.Click, Lbl_Cs.Click
        Elemento.PropNombreElemento = "Cesio"
        Elemento.PropMasaAtomica = 132.91
        Elemento.PropNumeroAtomico = 55
        Elemento.PropEstadoOxidacion = "-1 y 1"
        Elemento.PropSimbolo = "Cs"
        UpdateData(Pnl_Cs.BackColor)
    End Sub

    Private Sub Pnl_Fr_Click(sender As Object, e As EventArgs) Handles Pnl_Fr.Click, Lbl_Fr.Click
        Elemento.PropNombreElemento = "Francio"
        Elemento.PropMasaAtomica = 223
        Elemento.PropNumeroAtomico = 87
        Elemento.PropEstadoOxidacion = "1"
        Elemento.PropSimbolo = "Fr"
        UpdateData(Pnl_Fr.BackColor)
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click, Label19.Click
        Elemento.PropNombreElemento = "Magnesio"
        Elemento.PropMasaAtomica = 24.305
        Elemento.PropNumeroAtomico = 12
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Mg"
        UpdateData(Panel10.BackColor)
    End Sub

    Private Sub Panel11_Click(sender As Object, e As EventArgs) Handles Panel11.Click, Label20.Click
        Elemento.PropNombreElemento = "Calcio"
        Elemento.PropMasaAtomica = 40.078
        Elemento.PropNumeroAtomico = 20
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Ca"
        UpdateData(Panel11.BackColor)
    End Sub

    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click, Label21.Click
        Elemento.PropNombreElemento = "Estroncio"
        Elemento.PropMasaAtomica = 87.62
        Elemento.PropNumeroAtomico = 38
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Sr"
        UpdateData(Panel12.BackColor)
    End Sub

    Private Sub Panel13_Click(sender As Object, e As EventArgs) Handles Panel13.Click, Label22.Click
        Elemento.PropNombreElemento = "Bario"
        Elemento.PropMasaAtomica = 137.33
        Elemento.PropNumeroAtomico = 56
        Elemento.PropEstadoOxidacion = "2"
        Elemento.PropSimbolo = "Ba"
        UpdateData(Panel13.BackColor)
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Panel14.Click, Label23.Click
        Elemento.PropNombreElemento = "Radio"
        Elemento.PropMasaAtomica = 226
        Elemento.PropNumeroAtomico = 88
        Elemento.PropEstadoOxidacion = "2"
        Elemento.PropSimbolo = "Ra"
        UpdateData(Panel14.BackColor)
    End Sub

    Private Sub Panel15_Click(sender As Object, e As EventArgs) Handles Panel15.Click, Label24.Click
        Elemento.PropNombreElemento = "Escandio"
        Elemento.PropMasaAtomica = 44.956
        Elemento.PropNumeroAtomico = 21
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "Sc"
        UpdateData(Panel15.BackColor)
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click, Label25.Click
        Elemento.PropNombreElemento = "Itrio"
        Elemento.PropMasaAtomica = 88.906
        Elemento.PropNumeroAtomico = 39
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "Y"
        UpdateData(Panel16.BackColor)
    End Sub

    Private Sub Panel19_Click(sender As Object, e As EventArgs) Handles Panel19.Click, Label28.Click
        Elemento.PropNombreElemento = "Titanio"
        Elemento.PropMasaAtomica = 47.867
        Elemento.PropNumeroAtomico = 22
        Elemento.PropEstadoOxidacion = "-1, 2, 3, 4"
        Elemento.PropSimbolo = "Ti"
        UpdateData(Panel19.BackColor)
    End Sub

    Private Sub Panel20_Click(sender As Object, e As EventArgs) Handles Panel20.Click, Label29.Click
        Elemento.PropNombreElemento = "Circonio"
        Elemento.PropMasaAtomica = 91.224
        Elemento.PropNumeroAtomico = 40
        Elemento.PropEstadoOxidacion = "1, 2, 3, 4"
        Elemento.PropSimbolo = "Zr"
        UpdateData(Panel20.BackColor)
    End Sub

    Private Sub Panel21_Click(sender As Object, e As EventArgs) Handles Panel21.Click, Label30.Click
        Elemento.PropNombreElemento = "Hafnio"
        Elemento.PropMasaAtomica = 178.49
        Elemento.PropNumeroAtomico = 72
        Elemento.PropEstadoOxidacion = "2, 3, 4"
        Elemento.PropSimbolo = "Hf"
        UpdateData(Panel21.BackColor)
    End Sub

    Private Sub Panel22_Click(sender As Object, e As EventArgs) Handles Panel22.Click, Label31.Click
        Elemento.PropNombreElemento = "Rutherfordio"
        Elemento.PropMasaAtomica = 267
        Elemento.PropNumeroAtomico = 104
        Elemento.PropEstadoOxidacion = "4"
        Elemento.PropSimbolo = "Rf"
        UpdateData(Panel22.BackColor)
    End Sub

    Private Sub Panel23_Click(sender As Object, e As EventArgs) Handles Panel23.Click, Label32.Click
        Elemento.PropNombreElemento = "Vanadio"
        Elemento.PropMasaAtomica = 50.942
        Elemento.PropNumeroAtomico = 23
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "V"
        UpdateData(Panel23.BackColor)
    End Sub

    Private Sub Panel24_Click(sender As Object, e As EventArgs) Handles Panel24.Click, Label33.Click
        Elemento.PropNombreElemento = "Niobio"
        Elemento.PropMasaAtomica = 92.906
        Elemento.PropNumeroAtomico = 41
        Elemento.PropEstadoOxidacion = "-1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "Nb"
        UpdateData(Panel24.BackColor)
    End Sub

    Private Sub Panel25_Click(sender As Object, e As EventArgs) Handles Panel25.Click, Label34.Click
        Elemento.PropNombreElemento = "Tántalo"
        Elemento.PropMasaAtomica = 180.95
        Elemento.PropNumeroAtomico = 73
        Elemento.PropEstadoOxidacion = "-1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "Ta"
        UpdateData(Panel25.BackColor)
    End Sub

    Private Sub Panel26_Click(sender As Object, e As EventArgs) Handles Panel26.Click, Label35.Click
        Elemento.PropNombreElemento = "Dubnio"
        Elemento.PropMasaAtomica = 268
        Elemento.PropNumeroAtomico = 105
        Elemento.PropEstadoOxidacion = "5"
        Elemento.PropSimbolo = "Db"
        UpdateData(Panel26.BackColor)
    End Sub

    Private Sub Panel27_Click(sender As Object, e As EventArgs) Handles Panel27.Click, Label36.Click
        Elemento.PropNombreElemento = "Cromo"
        Elemento.PropMasaAtomica = 51.996
        Elemento.PropNumeroAtomico = 24
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "Cr"
        UpdateData(Panel27.BackColor)
    End Sub

    Private Sub Panel28_Click(sender As Object, e As EventArgs) Handles Panel28.Click, Label37.Click
        Elemento.PropNombreElemento = "Molibdeno"
        Elemento.PropMasaAtomica = 95.95
        Elemento.PropNumeroAtomico = 42
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "Mo"
        UpdateData(Panel28.BackColor)
    End Sub

    Private Sub Panel29_Click(sender As Object, e As EventArgs) Handles Panel29.Click, Label38.Click
        Elemento.PropNombreElemento = "Wolframio"
        Elemento.PropMasaAtomica = 183.84
        Elemento.PropNumeroAtomico = 74
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "W"
        UpdateData(Panel29.BackColor)
    End Sub

    Private Sub Panel30_Click(sender As Object, e As EventArgs) Handles Panel30.Click, Label39.Click
        Elemento.PropNombreElemento = "Seaborgio"
        Elemento.PropMasaAtomica = 269
        Elemento.PropNumeroAtomico = 106
        Elemento.PropEstadoOxidacion = "6"
        Elemento.PropSimbolo = "Sg"
        UpdateData(Panel30.BackColor)
    End Sub

    Private Sub Panel31_Click(sender As Object, e As EventArgs) Handles Panel31.Click, Label40.Click
        Elemento.PropNombreElemento = "Manganeso"
        Elemento.PropMasaAtomica = 54.938
        Elemento.PropNumeroAtomico = 25
        Elemento.PropEstadoOxidacion = "-3, -2, -1, 1, 2, 3, 4, 5, 6, 7"
        Elemento.PropSimbolo = "Mn"
        UpdateData(Panel31.BackColor)
    End Sub

    Private Sub Panel32_Click(sender As Object, e As EventArgs) Handles Panel32.Click, Label41.Click
        Elemento.PropNombreElemento = "Tecnecio"
        Elemento.PropMasaAtomica = 98
        Elemento.PropNumeroAtomico = 43
        Elemento.PropEstadoOxidacion = "-3, -1, 1, 2, 3, 4, 5, 6, 7"
        Elemento.PropSimbolo = "Tc"
        UpdateData(Panel32.BackColor)
    End Sub

    Private Sub Panel33_Click(sender As Object, e As EventArgs) Handles Panel33.Click, Label42.Click
        Elemento.PropNombreElemento = "Renio"
        Elemento.PropMasaAtomica = 186.21
        Elemento.PropNumeroAtomico = 75
        Elemento.PropEstadoOxidacion = "-3, -1, 1, 2, 3, 4, 5, 6, 7"
        Elemento.PropSimbolo = "Re"
        UpdateData(Panel33.BackColor)
    End Sub

    Private Sub Panel34_Click(sender As Object, e As EventArgs) Handles Panel34.Click, Label43.Click
        Elemento.PropNombreElemento = "Bohrio"
        Elemento.PropMasaAtomica = 270
        Elemento.PropNumeroAtomico = 107
        Elemento.PropEstadoOxidacion = "7"
        Elemento.PropSimbolo = "Bh"
        UpdateData(Panel34.BackColor)
    End Sub

    Private Sub Panel119_Click(sender As Object, e As EventArgs) Handles Panel119.Click, Label131.Click
        Elemento.PropNombreElemento = "Hierro"
        Elemento.PropMasaAtomica = 55.845
        Elemento.PropNumeroAtomico = 26
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "Fe"
        UpdateData(Panel119.BackColor)
    End Sub

    Private Sub Panel120_Click(sender As Object, e As EventArgs) Handles Panel120.Click, Label132.Click
        Elemento.PropNombreElemento = "Rutenio"
        Elemento.PropMasaAtomica = 101.07
        Elemento.PropNumeroAtomico = 44
        Elemento.PropEstadoOxidacion = "-2, 1, 2, 3, 4, 5, 6, 7, 8"
        Elemento.PropSimbolo = "Ru"
        UpdateData(Panel120.BackColor)
    End Sub

    Private Sub Panel121_Click(sender As Object, e As EventArgs) Handles Panel121.Click, Label133.Click
        Elemento.PropNombreElemento = "Osmio"
        Elemento.PropMasaAtomica = 190.23
        Elemento.PropNumeroAtomico = 76
        Elemento.PropEstadoOxidacion = "-2, 1, 2, 3, 4, 5, 6, 7, 8"
        Elemento.PropSimbolo = "Os"
        UpdateData(Panel121.BackColor)
    End Sub

    Private Sub Panel122_Click(sender As Object, e As EventArgs) Handles Panel122.Click, Label134.Click
        Elemento.PropNombreElemento = "Hasio"
        Elemento.PropMasaAtomica = 277
        Elemento.PropNumeroAtomico = 108
        Elemento.PropEstadoOxidacion = "8"
        Elemento.PropSimbolo = "Hs"
        UpdateData(Panel122.BackColor)
    End Sub

    Private Sub Panel35_Click(sender As Object, e As EventArgs) Handles Panel35.Click, Label44.Click
        Elemento.PropNombreElemento = "Cobalto"
        Elemento.PropMasaAtomica = 58.933
        Elemento.PropNumeroAtomico = 27
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "Co"
        UpdateData(Panel35.BackColor)
    End Sub

    Private Sub Panel36_Click(sender As Object, e As EventArgs) Handles Panel36.Click, Label45.Click
        Elemento.PropNombreElemento = "Rodio"
        Elemento.PropMasaAtomica = 102.91
        Elemento.PropNumeroAtomico = 45
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "Rh"
        UpdateData(Panel36.BackColor)
    End Sub

    Private Sub Panel37_Click(sender As Object, e As EventArgs) Handles Panel37.Click, Label46.Click
        Elemento.PropNombreElemento = "Iridio"
        Elemento.PropMasaAtomica = 192.22
        Elemento.PropNumeroAtomico = 77
        Elemento.PropEstadoOxidacion = "-3, -1, 1, 2, 3, 4, 5, 6, 7, 8"
        Elemento.PropSimbolo = "Ir"
        UpdateData(Panel37.BackColor)
    End Sub

    Private Sub Panel38_Click(sender As Object, e As EventArgs) Handles Panel38.Click, Label47.Click
        Elemento.PropNombreElemento = "Meitnerio"
        Elemento.PropMasaAtomica = 278
        Elemento.PropNumeroAtomico = 109
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Mt"
        UpdateData(Panel38.BackColor)
    End Sub

    Private Sub Panel39_Click(sender As Object, e As EventArgs) Handles Panel39.Click, Label48.Click
        Elemento.PropNombreElemento = "Níquel"
        Elemento.PropMasaAtomica = 58.693
        Elemento.PropNumeroAtomico = 28
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 4"
        Elemento.PropSimbolo = "Ni"
        UpdateData(Panel39.BackColor)
    End Sub

    Private Sub Panel40_Click(sender As Object, e As EventArgs) Handles Panel40.Click, Label49.Click
        Elemento.PropNombreElemento = "Paladio"
        Elemento.PropMasaAtomica = 106.42
        Elemento.PropNumeroAtomico = 46
        Elemento.PropEstadoOxidacion = "2 y 4"
        Elemento.PropSimbolo = "Pd"
        UpdateData(Panel40.BackColor)
    End Sub

    Private Sub Panel41_Click(sender As Object, e As EventArgs) Handles Panel41.Click, Label50.Click
        Elemento.PropNombreElemento = "Platino"
        Elemento.PropMasaAtomica = 195.08
        Elemento.PropNumeroAtomico = 46
        Elemento.PropEstadoOxidacion = "2, 4, 5, 6"
        Elemento.PropSimbolo = "Pt"
        UpdateData(Panel41.BackColor)
    End Sub

    Private Sub Panel42_Click(sender As Object, e As EventArgs) Handles Panel42.Click, Label51.Click
        Elemento.PropNombreElemento = "Darmstatio"
        Elemento.PropMasaAtomica = 281
        Elemento.PropNumeroAtomico = 110
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Ds"
        UpdateData(Panel42.BackColor)
    End Sub

    Private Sub Panel43_Click(sender As Object, e As EventArgs) Handles Panel43.Click, Label52.Click
        Elemento.PropNombreElemento = "Cobre"
        Elemento.PropMasaAtomica = 63.546
        Elemento.PropNumeroAtomico = 29
        Elemento.PropEstadoOxidacion = "1, 2, 3, 4"
        Elemento.PropSimbolo = "Cu"
        UpdateData(Panel43.BackColor)
    End Sub

    Private Sub Panel44_Click(sender As Object, e As EventArgs) Handles Panel44.Click, Label53.Click
        Elemento.PropNombreElemento = "Plata"
        Elemento.PropMasaAtomica = 107.87
        Elemento.PropNumeroAtomico = 47
        Elemento.PropEstadoOxidacion = "1, 2, 3, 4"
        Elemento.PropSimbolo = "Ag"
        UpdateData(Panel44.BackColor)
    End Sub

    Private Sub Panel45_Click(sender As Object, e As EventArgs) Handles Panel45.Click, Label54.Click
        Elemento.PropNombreElemento = "Oro"
        Elemento.PropMasaAtomica = 196.97
        Elemento.PropNumeroAtomico = 79
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 5"
        Elemento.PropSimbolo = "Au"
        UpdateData(Panel45.BackColor)
    End Sub

    Private Sub Panel46_Click(sender As Object, e As EventArgs) Handles Panel46.Click, Label55.Click
        Elemento.PropNombreElemento = "Roentgenio"
        Elemento.PropMasaAtomica = 282
        Elemento.PropNumeroAtomico = 111
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Rg"
        UpdateData(Panel46.BackColor)
    End Sub

    Private Sub Panel47_Click(sender As Object, e As EventArgs) Handles Panel47.Click, Label56.Click
        Elemento.PropNombreElemento = "Zinc"
        Elemento.PropMasaAtomica = 65.38
        Elemento.PropNumeroAtomico = 30
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Zn"
        UpdateData(Panel47.BackColor)
    End Sub

    Private Sub Panel48_Click(sender As Object, e As EventArgs) Handles Panel48.Click, Label57.Click
        Elemento.PropNombreElemento = "Cadmio"
        Elemento.PropMasaAtomica = 112.41
        Elemento.PropNumeroAtomico = 48
        Elemento.PropEstadoOxidacion = "1 y 2"
        Elemento.PropSimbolo = "Cd"
        UpdateData(Panel48.BackColor)
    End Sub

    Private Sub Panel49_Click(sender As Object, e As EventArgs) Handles Panel49.Click, Label58.Click
        Elemento.PropNombreElemento = "Mercurio"
        Elemento.PropMasaAtomica = 200.59
        Elemento.PropNumeroAtomico = 80
        Elemento.PropEstadoOxidacion = "1, 2, 4"
        Elemento.PropSimbolo = "Hg"
        UpdateData(Panel49.BackColor)
    End Sub

    Private Sub Panel50_Click(sender As Object, e As EventArgs) Handles Panel50.Click, Label59.Click
        Elemento.PropNombreElemento = "Copernicio"
        Elemento.PropMasaAtomica = 285
        Elemento.PropNumeroAtomico = 112
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Cn"
        UpdateData(Panel50.BackColor)
    End Sub

    Private Sub Panel51_Click(sender As Object, e As EventArgs) Handles Panel51.Click, Label60.Click
        Elemento.PropNombreElemento = "Boro"
        Elemento.PropMasaAtomica = 10.81
        Elemento.PropNumeroAtomico = 5
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "B"
        UpdateData(Panel51.BackColor)
    End Sub

    Private Sub Panel52_Click(sender As Object, e As EventArgs) Handles Panel52.Click, Label61.Click
        Elemento.PropNombreElemento = "Aluminio"
        Elemento.PropMasaAtomica = 26.982
        Elemento.PropNumeroAtomico = 13
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "Al"
        UpdateData(Panel52.BackColor)
    End Sub

    Private Sub Panel53_Click(sender As Object, e As EventArgs) Handles Panel53.Click, Label62.Click
        Elemento.PropNombreElemento = "Galio"
        Elemento.PropMasaAtomica = 69.723
        Elemento.PropNumeroAtomico = 31
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "Ga"
        UpdateData(Panel53.BackColor)
    End Sub

    Private Sub Panel54_Click(sender As Object, e As EventArgs) Handles Panel54.Click, Label63.Click
        Elemento.PropNombreElemento = "Indio"
        Elemento.PropMasaAtomica = 114.82
        Elemento.PropNumeroAtomico = 49
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "In"
        UpdateData(Panel54.BackColor)
    End Sub

    Private Sub Panel56_Click(sender As Object, e As EventArgs) Handles Panel56.Click, Label65.Click
        Elemento.PropNombreElemento = "Talio"
        Elemento.PropMasaAtomica = 204.38
        Elemento.PropNumeroAtomico = 81
        Elemento.PropEstadoOxidacion = "1 y 3"
        Elemento.PropSimbolo = "Tl"
        UpdateData(Panel56.BackColor)
    End Sub

    Private Sub Panel57_Click(sender As Object, e As EventArgs) Handles Panel57.Click, Label66.Click
        Elemento.PropNombreElemento = "Nihonio"
        Elemento.PropMasaAtomica = 286
        Elemento.PropNumeroAtomico = 113
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Nh"
        UpdateData(Panel57.BackColor)
    End Sub

    Private Sub Panel55_Click(sender As Object, e As EventArgs) Handles Panel55.Click, Label64.Click
        Elemento.PropNombreElemento = "Carbono"
        Elemento.PropMasaAtomica = 12.011
        Elemento.PropNumeroAtomico = 6
        Elemento.PropEstadoOxidacion = "-4, -3, -2, -1, 1, 2, 3, 4"
        Elemento.PropSimbolo = "C"
        UpdateData(Panel55.BackColor)
    End Sub

    Private Sub Panel58_Click(sender As Object, e As EventArgs) Handles Panel58.Click, Label67.Click
        Elemento.PropNombreElemento = "Silicio"
        Elemento.PropMasaAtomica = 28.085
        Elemento.PropNumeroAtomico = 14
        Elemento.PropEstadoOxidacion = "-4, -3, -2, -1, 1, 2, 3, 4"
        Elemento.PropSimbolo = "Si"
        UpdateData(Panel58.BackColor)
    End Sub

    Private Sub Panel59_Click(sender As Object, e As EventArgs) Handles Panel59.Click, Label68.Click
        Elemento.PropNombreElemento = "Germanio"
        Elemento.PropMasaAtomica = 72.63
        Elemento.PropNumeroAtomico = 32
        Elemento.PropEstadoOxidacion = "-4, 1, 2, 3, 4"
        Elemento.PropSimbolo = "Ge"
        UpdateData(Panel59.BackColor)
    End Sub

    Private Sub Panel60_Click(sender As Object, e As EventArgs) Handles Panel60.Click, Label69.Click
        Elemento.PropNombreElemento = "Estaño"
        Elemento.PropMasaAtomica = 118.71
        Elemento.PropNumeroAtomico = 50
        Elemento.PropEstadoOxidacion = "-4, 2, 4"
        Elemento.PropSimbolo = "Sn"
        UpdateData(Panel60.BackColor)
    End Sub

    Private Sub Panel61_Click(sender As Object, e As EventArgs) Handles Panel61.Click, Label70.Click
        Elemento.PropNombreElemento = "Plomo"
        Elemento.PropMasaAtomica = 207.2
        Elemento.PropNumeroAtomico = 82
        Elemento.PropEstadoOxidacion = "-4, 2, 4"
        Elemento.PropSimbolo = "Pb"
        UpdateData(Panel61.BackColor)
    End Sub

    Private Sub Panel62_Click(sender As Object, e As EventArgs) Handles Panel62.Click, Label71.Click
        Elemento.PropNombreElemento = "Flerovio"
        Elemento.PropMasaAtomica = 289
        Elemento.PropNumeroAtomico = 114
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Fl"
        UpdateData(Panel62.BackColor)
    End Sub

    Private Sub Panel63_Click(sender As Object, e As EventArgs) Handles Panel63.Click, Label72.Click
        Elemento.PropNombreElemento = "Nitrógeno"
        Elemento.PropMasaAtomica = 14.007
        Elemento.PropNumeroAtomico = 7
        Elemento.PropEstadoOxidacion = "-3, -2, -1, 1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "N"
        UpdateData(Panel63.BackColor)
    End Sub

    Private Sub Panel64_Click(sender As Object, e As EventArgs) Handles Panel64.Click, Label73.Click
        Elemento.PropNombreElemento = "Fósforo"
        Elemento.PropMasaAtomica = 30.974
        Elemento.PropNumeroAtomico = 15
        Elemento.PropEstadoOxidacion = "-3, -2, -1, 1, 2, 3, 4, 5"
        Elemento.PropSimbolo = "P"
        UpdateData(Panel64.BackColor)
    End Sub

    Private Sub Panel65_Click(sender As Object, e As EventArgs) Handles Panel65.Click, Label74.Click
        Elemento.PropNombreElemento = "Arsénico"
        Elemento.PropMasaAtomica = 74.922
        Elemento.PropNumeroAtomico = 33
        Elemento.PropEstadoOxidacion = "-3, 2, 3, 5"
        Elemento.PropSimbolo = "As"
        UpdateData(Panel65.BackColor)
    End Sub

    Private Sub Panel66_Click(sender As Object, e As EventArgs) Handles Panel66.Click, Label75.Click
        Elemento.PropNombreElemento = "Antimonio"
        Elemento.PropMasaAtomica = 121.76
        Elemento.PropNumeroAtomico = 51
        Elemento.PropEstadoOxidacion = "-3, 3, 5"
        Elemento.PropSimbolo = "Sb"
        UpdateData(Panel66.BackColor)
    End Sub

    Private Sub Panel67_Click(sender As Object, e As EventArgs) Handles Panel67.Click, Label76.Click
        Elemento.PropNombreElemento = "Bismuto"
        Elemento.PropMasaAtomica = 208.98
        Elemento.PropNumeroAtomico = 83
        Elemento.PropEstadoOxidacion = "-3, 3, 5"
        Elemento.PropSimbolo = "Bi"
        UpdateData(Panel67.BackColor)
    End Sub

    Private Sub Panel68_Click(sender As Object, e As EventArgs) Handles Panel68.Click, Label77.Click
        Elemento.PropNombreElemento = "Moscovio"
        Elemento.PropMasaAtomica = 290
        Elemento.PropNumeroAtomico = 115
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Mc"
        UpdateData(Panel68.BackColor)
    End Sub

    Private Sub Panel69_Click(sender As Object, e As EventArgs) Handles Panel69.Click, Label78.Click
        Elemento.PropNombreElemento = "Oxígeno"
        Elemento.PropMasaAtomica = 15.999
        Elemento.PropNumeroAtomico = 8
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2"
        Elemento.PropSimbolo = "O"
        UpdateData(Panel69.BackColor)
    End Sub

    Private Sub Panel70_Click(sender As Object, e As EventArgs) Handles Panel70.Click, Label79.Click
        Elemento.PropNombreElemento = "Asufre"
        Elemento.PropMasaAtomica = 32.06
        Elemento.PropNumeroAtomico = 16
        Elemento.PropEstadoOxidacion = "-2, -1, 1, 2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "S"
        UpdateData(Panel70.BackColor)
    End Sub

    Private Sub Panel71_Click(sender As Object, e As EventArgs) Handles Panel71.Click, Label80.Click
        Elemento.PropNombreElemento = "Selenio"
        Elemento.PropMasaAtomica = 78.971
        Elemento.PropNumeroAtomico = 34
        Elemento.PropEstadoOxidacion = "-2, 1, 2, 4, 6"
        Elemento.PropSimbolo = "Se"
        UpdateData(Panel71.BackColor)
    End Sub

    Private Sub Panel72_Click(sender As Object, e As EventArgs) Handles Panel72.Click, Label81.Click
        Elemento.PropNombreElemento = "Telurio"
        Elemento.PropMasaAtomica = 127.6
        Elemento.PropNumeroAtomico = 52
        Elemento.PropEstadoOxidacion = "-2, 2, 4, 5, 6"
        Elemento.PropSimbolo = "Te"
        UpdateData(Panel72.BackColor)
    End Sub

    Private Sub Panel73_Click(sender As Object, e As EventArgs) Handles Panel73.Click, Label82.Click
        Elemento.PropNombreElemento = "Polonio"
        Elemento.PropMasaAtomica = 209
        Elemento.PropNumeroAtomico = 84
        Elemento.PropEstadoOxidacion = "-2, 2, 4, 6"
        Elemento.PropSimbolo = "Po"
        UpdateData(Panel73.BackColor)
    End Sub

    Private Sub Panel74_Click(sender As Object, e As EventArgs) Handles Panel74.Click, Label83.Click
        Elemento.PropNombreElemento = "Livermorio"
        Elemento.PropMasaAtomica = 293
        Elemento.PropNumeroAtomico = 116
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Lv"
        UpdateData(Panel74.BackColor)
    End Sub

    Private Sub Panel75_Click(sender As Object, e As EventArgs) Handles Panel75.Click, Label84.Click
        Elemento.PropNombreElemento = "Flúor"
        Elemento.PropMasaAtomica = 18.998
        Elemento.PropNumeroAtomico = 9
        Elemento.PropEstadoOxidacion = "-1"
        Elemento.PropSimbolo = "F"
        UpdateData(Panel75.BackColor)
    End Sub

    Private Sub Panel76_Click(sender As Object, e As EventArgs) Handles Panel76.Click, Label85.Click
        Elemento.PropNombreElemento = "Cloro"
        Elemento.PropMasaAtomica = 35.45
        Elemento.PropNumeroAtomico = 17
        Elemento.PropEstadoOxidacion = "-1, 1, 2, 3, 4, 5, 6, 7"
        Elemento.PropSimbolo = "Cl"
        UpdateData(Panel76.BackColor)
    End Sub

    Private Sub Panel77_Click(sender As Object, e As EventArgs) Handles Panel77.Click, Label86.Click
        Elemento.PropNombreElemento = "Bromo"
        Elemento.PropMasaAtomica = 79.904
        Elemento.PropNumeroAtomico = 35
        Elemento.PropEstadoOxidacion = "-1, 1, 3, 4, 5, 7"
        Elemento.PropSimbolo = "Br"
        UpdateData(Panel77.BackColor)
    End Sub

    Private Sub Panel78_Click(sender As Object, e As EventArgs) Handles Panel78.Click, Label87.Click
        Elemento.PropNombreElemento = "Yodo"
        Elemento.PropMasaAtomica = 126.9
        Elemento.PropNumeroAtomico = 53
        Elemento.PropEstadoOxidacion = "-1, 1, 3, 4, 5, 7"
        Elemento.PropSimbolo = "I"
        UpdateData(Panel78.BackColor)
    End Sub

    Private Sub Panel79_Click(sender As Object, e As EventArgs) Handles Panel79.Click, Label88.Click
        Elemento.PropNombreElemento = "Ástato"
        Elemento.PropMasaAtomica = 210
        Elemento.PropNumeroAtomico = 85
        Elemento.PropEstadoOxidacion = "-1, 1, 3, 5, 7"
        Elemento.PropSimbolo = "At"
        UpdateData(Panel79.BackColor)
    End Sub

    Private Sub Panel80_Click(sender As Object, e As EventArgs) Handles Panel80.Click, Label89.Click
        Elemento.PropNombreElemento = "Teneso"
        Elemento.PropMasaAtomica = 294
        Elemento.PropNumeroAtomico = 117
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Ts"
        UpdateData(Panel80.BackColor)
    End Sub

    Private Sub Panel87_Click(sender As Object, e As EventArgs) Handles Panel87.Click, Label96.Click
        Elemento.PropNombreElemento = "Helio"
        Elemento.PropMasaAtomica = 4.0026
        Elemento.PropNumeroAtomico = 2
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "He"
        UpdateData(Panel87.BackColor)
    End Sub

    Private Sub Panel81_Click(sender As Object, e As EventArgs) Handles Panel81.Click, Label90.Click
        Elemento.PropNombreElemento = "Neón"
        Elemento.PropMasaAtomica = 20.18
        Elemento.PropNumeroAtomico = 10
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Ne"
        UpdateData(Panel81.BackColor)
    End Sub

    Private Sub Panel82_Click(sender As Object, e As EventArgs) Handles Panel82.Click, Label91.Click
        Elemento.PropNombreElemento = "Argón"
        Elemento.PropMasaAtomica = 39.948
        Elemento.PropNumeroAtomico = 18
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Ar"
        UpdateData(Panel82.BackColor)
    End Sub

    Private Sub Panel83_Click(sender As Object, e As EventArgs) Handles Panel83.Click, Label92.Click
        Elemento.PropNombreElemento = "Kriptón"
        Elemento.PropMasaAtomica = 83.798
        Elemento.PropNumeroAtomico = 36
        Elemento.PropEstadoOxidacion = "2"
        Elemento.PropSimbolo = "Kr"
        UpdateData(Panel83.BackColor)
    End Sub

    Private Sub Panel84_Click(sender As Object, e As EventArgs) Handles Panel84.Click, Label93.Click
        Elemento.PropNombreElemento = "Xenón"
        Elemento.PropMasaAtomica = 131.29
        Elemento.PropNumeroAtomico = 54
        Elemento.PropEstadoOxidacion = "2, 4, 6, 8"
        Elemento.PropSimbolo = "Xe"
        UpdateData(Panel84.BackColor)
    End Sub

    Private Sub Panel85_Click(sender As Object, e As EventArgs) Handles Panel85.Click, Label94.Click
        Elemento.PropNombreElemento = "Radón"
        Elemento.PropMasaAtomica = 222
        Elemento.PropNumeroAtomico = 86
        Elemento.PropEstadoOxidacion = "2"
        Elemento.PropSimbolo = "Rn"
        UpdateData(Panel85.BackColor)
    End Sub

    Private Sub Panel86_Click(sender As Object, e As EventArgs) Handles Panel86.Click, Label95.Click
        Elemento.PropNombreElemento = "Oganesón"
        Elemento.PropMasaAtomica = 294
        Elemento.PropNumeroAtomico = 118
        Elemento.PropEstadoOxidacion = "N/A"
        Elemento.PropSimbolo = "Og"
        UpdateData(Panel86.BackColor)
    End Sub

    Private Sub Panel90_Click(sender As Object, e As EventArgs) Handles Panel90.Click, Label98.Click
        Elemento.PropNombreElemento = "Lantano"
        Elemento.PropMasaAtomica = 138.91
        Elemento.PropNumeroAtomico = 57
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "La"
        UpdateData(Panel90.BackColor)
    End Sub

    Private Sub Panel91_Click(sender As Object, e As EventArgs) Handles Panel91.Click, Label99.Click
        Elemento.PropNombreElemento = "Actinio"
        Elemento.PropMasaAtomica = 227
        Elemento.PropNumeroAtomico = 89
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Ac"
        UpdateData(Panel91.BackColor)
    End Sub

    Private Sub Panel92_Click(sender As Object, e As EventArgs) Handles Panel92.Click, Label100.Click
        Elemento.PropNombreElemento = "Cerio"
        Elemento.PropMasaAtomica = 140.12
        Elemento.PropNumeroAtomico = 58
        Elemento.PropEstadoOxidacion = "2, 3, 4"
        Elemento.PropSimbolo = "Ce"
        UpdateData(Panel92.BackColor)
    End Sub

    Private Sub Panel93_Click(sender As Object, e As EventArgs) Handles Panel93.Click, Label101.Click
        Elemento.PropNombreElemento = "Torio"
        Elemento.PropMasaAtomica = 232.04
        Elemento.PropNumeroAtomico = 90
        Elemento.PropEstadoOxidacion = "2, 3, 4"
        Elemento.PropSimbolo = "Th"
        UpdateData(Panel92.BackColor)
    End Sub

    Private Sub Panel94_Click(sender As Object, e As EventArgs) Handles Panel94.Click, Label102.Click
        Elemento.PropNombreElemento = "Praseodimio"
        Elemento.PropMasaAtomica = 140.91
        Elemento.PropNumeroAtomico = 59
        Elemento.PropEstadoOxidacion = "2, 3, 4"
        Elemento.PropSimbolo = "Pr"
        UpdateData(Panel94.BackColor)
    End Sub

    Private Sub Panel95_Click(sender As Object, e As EventArgs) Handles Panel95.Click, Label103.Click
        Elemento.PropNombreElemento = "Protactinio"
        Elemento.PropMasaAtomica = 231.04
        Elemento.PropNumeroAtomico = 91
        Elemento.PropEstadoOxidacion = "2, 3, 4, 5"
        Elemento.PropSimbolo = "Pa"
        UpdateData(Panel95.BackColor)
    End Sub

    Private Sub Panel96_Click(sender As Object, e As EventArgs) Handles Panel96.Click, Label104.Click
        Elemento.PropNombreElemento = "Neodimio"
        Elemento.PropMasaAtomica = 144.24
        Elemento.PropNumeroAtomico = 60
        Elemento.PropEstadoOxidacion = "2, 3, 4, 5"
        Elemento.PropSimbolo = "Nd"
        UpdateData(Panel96.BackColor)
    End Sub

    Private Sub Panel97_Click(sender As Object, e As EventArgs) Handles Panel97.Click, Label105.Click
        Elemento.PropNombreElemento = "Uranio"
        Elemento.PropMasaAtomica = 238.03
        Elemento.PropNumeroAtomico = 92
        Elemento.PropEstadoOxidacion = "2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "U"
        UpdateData(Panel97.BackColor)
    End Sub

    Private Sub Panel98_Click(sender As Object, e As EventArgs) Handles Panel98.Click, Label106.Click
        Elemento.PropNombreElemento = "Prometio"
        Elemento.PropMasaAtomica = 145
        Elemento.PropNumeroAtomico = 61
        Elemento.PropEstadoOxidacion = "3"
        Elemento.PropSimbolo = "Pm"
        UpdateData(Panel98.BackColor)
    End Sub

    Private Sub Panel99_Click(sender As Object, e As EventArgs) Handles Panel99.Click, Label107.Click
        Elemento.PropNombreElemento = "Neptunio"
        Elemento.PropMasaAtomica = 237
        Elemento.PropNumeroAtomico = 93
        Elemento.PropEstadoOxidacion = "3, 4, 5, 6, 7"
        Elemento.PropSimbolo = "Np"
        UpdateData(Panel99.BackColor)
    End Sub

    Private Sub Panel100_Click(sender As Object, e As EventArgs) Handles Panel100.Click, Label108.Click
        Elemento.PropNombreElemento = "Samario"
        Elemento.PropMasaAtomica = 150.36
        Elemento.PropNumeroAtomico = 62
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Sm"
        UpdateData(Panel100.BackColor)
    End Sub

    Private Sub Panel101_Click(sender As Object, e As EventArgs) Handles Panel101.Click, Label109.Click
        Elemento.PropNombreElemento = "Plutonio"
        Elemento.PropMasaAtomica = 244
        Elemento.PropNumeroAtomico = 94
        Elemento.PropEstadoOxidacion = "3, 4, 5, 6, 7, 8"
        Elemento.PropSimbolo = "Pu"
        UpdateData(Panel101.BackColor)
    End Sub

    Private Sub Panel123_Click(sender As Object, e As EventArgs) Handles Panel123.Click, Label135.Click
        Elemento.PropNombreElemento = "Europio"
        Elemento.PropMasaAtomica = 151.96
        Elemento.PropNumeroAtomico = 63
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Eu"
        UpdateData(Panel123.BackColor)
    End Sub

    Private Sub Panel124_Click(sender As Object, e As EventArgs) Handles Panel124.Click, Label136.Click
        Elemento.PropNombreElemento = "Americio"
        Elemento.PropMasaAtomica = 243
        Elemento.PropNumeroAtomico = 95
        Elemento.PropEstadoOxidacion = "2, 3, 4, 5, 6"
        Elemento.PropSimbolo = "Am"
        UpdateData(Panel124.BackColor)
    End Sub

    Private Sub Panel102_Click(sender As Object, e As EventArgs) Handles Panel102.Click, Label110.Click
        Elemento.PropNombreElemento = "Gadolinio"
        Elemento.PropMasaAtomica = 157.25
        Elemento.PropNumeroAtomico = 64
        Elemento.PropEstadoOxidacion = "1, 2, 3"
        Elemento.PropSimbolo = "Gd"
        UpdateData(Panel102.BackColor)
    End Sub

    Private Sub Panel103_Click(sender As Object, e As EventArgs) Handles Panel103.Click, Label111.Click
        Elemento.PropNombreElemento = "Curio"
        Elemento.PropMasaAtomica = 247
        Elemento.PropNumeroAtomico = 96
        Elemento.PropEstadoOxidacion = "3 y 4"
        Elemento.PropSimbolo = "Cm"
        UpdateData(Panel103.BackColor)
    End Sub

    Private Sub Panel104_Click(sender As Object, e As EventArgs) Handles Panel104.Click, Label112.Click
        Elemento.PropNombreElemento = "Terbio"
        Elemento.PropMasaAtomica = 158.93
        Elemento.PropNumeroAtomico = 65
        Elemento.PropEstadoOxidacion = "1, 3, 4"
        Elemento.PropSimbolo = "Tb"
        UpdateData(Panel104.BackColor)
    End Sub

    Private Sub Panel105_Click(sender As Object, e As EventArgs) Handles Panel105.Click, Label113.Click
        Elemento.PropNombreElemento = "Berkelio"
        Elemento.PropMasaAtomica = 247
        Elemento.PropNumeroAtomico = 97
        Elemento.PropEstadoOxidacion = "3 y 4"
        Elemento.PropSimbolo = "Bk"
        UpdateData(Panel105.BackColor)
    End Sub

    Private Sub Panel106_Click(sender As Object, e As EventArgs) Handles Panel106.Click, Label114.Click
        Elemento.PropNombreElemento = "Disprosio"
        Elemento.PropMasaAtomica = 162.5
        Elemento.PropNumeroAtomico = 66
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Dy"
        UpdateData(Panel106.BackColor)
    End Sub

    Private Sub Panel107_Click(sender As Object, e As EventArgs) Handles Panel107.Click, Label115.Click
        Elemento.PropNombreElemento = "Californio"
        Elemento.PropMasaAtomica = 251
        Elemento.PropNumeroAtomico = 98
        Elemento.PropEstadoOxidacion = "2, 3, 4"
        Elemento.PropSimbolo = "Cf"
        UpdateData(Panel107.BackColor)
    End Sub

    Private Sub Panel108_Click(sender As Object, e As EventArgs) Handles Panel108.Click, Label116.Click
        Elemento.PropNombreElemento = "Holmio"
        Elemento.PropMasaAtomica = 164.93
        Elemento.PropNumeroAtomico = 67
        Elemento.PropEstadoOxidacion = "3"
        Elemento.PropSimbolo = "Ho"
        UpdateData(Panel108.BackColor)
    End Sub

    Private Sub Panel109_Click(sender As Object, e As EventArgs) Handles Panel109.Click, Label117.Click
        Elemento.PropNombreElemento = "Einstenio"
        Elemento.PropMasaAtomica = 252
        Elemento.PropNumeroAtomico = 99
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Es"
        UpdateData(Panel109.BackColor)
    End Sub

    Private Sub Panel110_Click(sender As Object, e As EventArgs) Handles Panel110.Click, Label118.Click
        Elemento.PropNombreElemento = "Erbio"
        Elemento.PropMasaAtomica = 167.26
        Elemento.PropNumeroAtomico = 68
        Elemento.PropEstadoOxidacion = "3"
        Elemento.PropSimbolo = "Er"
        UpdateData(Panel110.BackColor)
    End Sub

    Private Sub Panel111_Click(sender As Object, e As EventArgs) Handles Panel111.Click, Label119.Click
        Elemento.PropNombreElemento = "Fermio"
        Elemento.PropMasaAtomica = 257
        Elemento.PropNumeroAtomico = 100
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Fm"
        UpdateData(Panel111.BackColor)
    End Sub

    Private Sub Panel112_Click(sender As Object, e As EventArgs) Handles Panel112.Click, Label120.Click
        Elemento.PropNombreElemento = "Tulio"
        Elemento.PropMasaAtomica = 168.93
        Elemento.PropNumeroAtomico = 69
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Tm"
        UpdateData(Panel112.BackColor)
    End Sub

    Private Sub Panel113_Click(sender As Object, e As EventArgs) Handles Panel113.Click, Label121.Click
        Elemento.PropNombreElemento = "Mendelevio"
        Elemento.PropMasaAtomica = 258
        Elemento.PropNumeroAtomico = 101
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Md"
        UpdateData(Panel113.BackColor)
    End Sub

    Private Sub Panel114_Click(sender As Object, e As EventArgs) Handles Panel114.Click, Label122.Click
        Elemento.PropNombreElemento = "Iterbio"
        Elemento.PropMasaAtomica = 173.05
        Elemento.PropNumeroAtomico = 70
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "Yb"
        UpdateData(Panel114.BackColor)
    End Sub

    Private Sub Panel115_Click(sender As Object, e As EventArgs) Handles Panel115.Click, Label123.Click
        Elemento.PropNombreElemento = "Nobelio"
        Elemento.PropMasaAtomica = 259
        Elemento.PropNumeroAtomico = 102
        Elemento.PropEstadoOxidacion = "2 y 3"
        Elemento.PropSimbolo = "No"
        UpdateData(Panel115.BackColor)
    End Sub

    Private Sub Panel116_Click(sender As Object, e As EventArgs) Handles Panel116.Click, Label124.Click
        Elemento.PropNombreElemento = "Lutecio"
        Elemento.PropMasaAtomica = 174.97
        Elemento.PropNumeroAtomico = 71
        Elemento.PropEstadoOxidacion = "3"
        Elemento.PropSimbolo = "Lu"
        UpdateData(Panel116.BackColor)
    End Sub

    Private Sub Panel117_Click(sender As Object, e As EventArgs) Handles Panel117.Click, Label125.Click
        Elemento.PropNombreElemento = "Lawrencio"
        Elemento.PropMasaAtomica = 266
        Elemento.PropNumeroAtomico = 103
        Elemento.PropEstadoOxidacion = "3"
        Elemento.PropSimbolo = "Lr"
        UpdateData(Panel117.BackColor)
    End Sub
End Class
