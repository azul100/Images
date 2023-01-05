Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents PicBoxCard As System.Windows.Forms.PictureBox
    Friend WithEvents gbcard As System.Windows.Forms.GroupBox
    Friend WithEvents lstCards As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents cboPkmn1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPkmn3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPkmn4 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPkmn6 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPkmn5 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPkmn2 As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbpkmn As System.Windows.Forms.GroupBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents gbType As System.Windows.Forms.GroupBox
    Friend WithEvents rdCcard As System.Windows.Forms.RadioButton
    Friend WithEvents rdTCard As System.Windows.Forms.RadioButton
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents gbnom As System.Windows.Forms.GroupBox
    Friend WithEvents chkItalique As System.Windows.Forms.CheckBox
    Friend WithEvents chkSouligne As System.Windows.Forms.CheckBox
    Friend WithEvents chkGras As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbautre As System.Windows.Forms.GroupBox
    Friend WithEvents cboBadge As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDresseur As System.Windows.Forms.ComboBox
    Friend WithEvents btDDroite As System.Windows.Forms.Button
    Friend WithEvents btDBas As System.Windows.Forms.Button
    Friend WithEvents btDHaut As System.Windows.Forms.Button
    Friend WithEvents btDGauche As System.Windows.Forms.Button
    Friend WithEvents btPDroite As System.Windows.Forms.Button
    Friend WithEvents cboPkmnD As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btPBas As System.Windows.Forms.Button
    Friend WithEvents btPHaut As System.Windows.Forms.Button
    Friend WithEvents btPGauche As System.Windows.Forms.Button
    Friend WithEvents cboPlan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbsave As System.Windows.Forms.GroupBox
    Friend WithEvents mnuSave As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicBoxCard = New System.Windows.Forms.PictureBox()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.gbcard = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbnom = New System.Windows.Forms.GroupBox()
        Me.chkItalique = New System.Windows.Forms.CheckBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.chkSouligne = New System.Windows.Forms.CheckBox()
        Me.chkGras = New System.Windows.Forms.CheckBox()
        Me.gbpkmn = New System.Windows.Forms.GroupBox()
        Me.cboPkmn1 = New System.Windows.Forms.ComboBox()
        Me.cboPkmn2 = New System.Windows.Forms.ComboBox()
        Me.cboPkmn5 = New System.Windows.Forms.ComboBox()
        Me.cboPkmn3 = New System.Windows.Forms.ComboBox()
        Me.cboPkmn6 = New System.Windows.Forms.ComboBox()
        Me.cboPkmn4 = New System.Windows.Forms.ComboBox()
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.mnuSave = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.gbsave = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.rdCcard = New System.Windows.Forms.RadioButton()
        Me.rdTCard = New System.Windows.Forms.RadioButton()
        Me.gbautre = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPlan = New System.Windows.Forms.ComboBox()
        Me.btDDroite = New System.Windows.Forms.Button()
        Me.cboDresseur = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBadge = New System.Windows.Forms.ComboBox()
        Me.btDBas = New System.Windows.Forms.Button()
        Me.btDHaut = New System.Windows.Forms.Button()
        Me.btDGauche = New System.Windows.Forms.Button()
        Me.btPDroite = New System.Windows.Forms.Button()
        Me.btPGauche = New System.Windows.Forms.Button()
        Me.btPHaut = New System.Windows.Forms.Button()
        Me.btPBas = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPkmnD = New System.Windows.Forms.ComboBox()
        CType(Me.PicBoxCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcard.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbnom.SuspendLayout()
        Me.gbpkmn.SuspendLayout()
        Me.gbsave.SuspendLayout()
        Me.gbType.SuspendLayout()
        Me.gbautre.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBoxCard
        '
        Me.PicBoxCard.BackColor = System.Drawing.Color.White
        Me.PicBoxCard.Image = CType(resources.GetObject("PicBoxCard.Image"), System.Drawing.Image)
        Me.PicBoxCard.Location = New System.Drawing.Point(24, 32)
        Me.PicBoxCard.Name = "PicBoxCard"
        Me.PicBoxCard.Size = New System.Drawing.Size(228, 148)
        Me.PicBoxCard.TabIndex = 0
        Me.PicBoxCard.TabStop = False
        '
        'lstCards
        '
        Me.lstCards.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstCards.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCards.ItemHeight = 15
        Me.lstCards.Location = New System.Drawing.Point(24, 32)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.ScrollAlwaysVisible = True
        Me.lstCards.Size = New System.Drawing.Size(184, 79)
        Me.lstCards.Sorted = True
        Me.lstCards.TabIndex = 1
        '
        'gbcard
        '
        Me.gbcard.Controls.Add(Me.PicBoxCard)
        Me.gbcard.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbcard.Location = New System.Drawing.Point(256, 64)
        Me.gbcard.Name = "gbcard"
        Me.gbcard.Size = New System.Drawing.Size(272, 208)
        Me.gbcard.TabIndex = 2
        Me.gbcard.TabStop = False
        Me.gbcard.Text = "Ta Carte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCards)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2. Choix du Modèle"
        '
        'gbnom
        '
        Me.gbnom.Controls.Add(Me.chkItalique)
        Me.gbnom.Controls.Add(Me.txtnom)
        Me.gbnom.Controls.Add(Me.chkSouligne)
        Me.gbnom.Controls.Add(Me.chkGras)
        Me.gbnom.Enabled = False
        Me.gbnom.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbnom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbnom.Location = New System.Drawing.Point(16, 192)
        Me.gbnom.Name = "gbnom"
        Me.gbnom.Size = New System.Drawing.Size(232, 80)
        Me.gbnom.TabIndex = 4
        Me.gbnom.TabStop = False
        Me.gbnom.Text = "3. Ton Nom"
        '
        'chkItalique
        '
        Me.chkItalique.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalique.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkItalique.Location = New System.Drawing.Point(192, 32)
        Me.chkItalique.Name = "chkItalique"
        Me.chkItalique.Size = New System.Drawing.Size(32, 24)
        Me.chkItalique.TabIndex = 1
        Me.chkItalique.Text = "I"
        '
        'txtnom
        '
        Me.txtnom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtnom.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.Location = New System.Drawing.Point(16, 32)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(88, 23)
        Me.txtnom.TabIndex = 0
        '
        'chkSouligne
        '
        Me.chkSouligne.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSouligne.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSouligne.Location = New System.Drawing.Point(152, 32)
        Me.chkSouligne.Name = "chkSouligne"
        Me.chkSouligne.Size = New System.Drawing.Size(32, 24)
        Me.chkSouligne.TabIndex = 8
        Me.chkSouligne.Text = "S"
        '
        'chkGras
        '
        Me.chkGras.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGras.Location = New System.Drawing.Point(112, 32)
        Me.chkGras.Name = "chkGras"
        Me.chkGras.Size = New System.Drawing.Size(32, 24)
        Me.chkGras.TabIndex = 9
        Me.chkGras.Text = "G"
        '
        'gbpkmn
        '
        Me.gbpkmn.Controls.Add(Me.cboPkmn1)
        Me.gbpkmn.Controls.Add(Me.cboPkmn2)
        Me.gbpkmn.Controls.Add(Me.cboPkmn5)
        Me.gbpkmn.Controls.Add(Me.cboPkmn3)
        Me.gbpkmn.Controls.Add(Me.cboPkmn6)
        Me.gbpkmn.Controls.Add(Me.cboPkmn4)
        Me.gbpkmn.Enabled = False
        Me.gbpkmn.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpkmn.ForeColor = System.Drawing.Color.Black
        Me.gbpkmn.Location = New System.Drawing.Point(16, 272)
        Me.gbpkmn.Name = "gbpkmn"
        Me.gbpkmn.Size = New System.Drawing.Size(512, 112)
        Me.gbpkmn.TabIndex = 5
        Me.gbpkmn.TabStop = False
        Me.gbpkmn.Text = "4. Choix des Pokémon"
        '
        'cboPkmn1
        '
        Me.cboPkmn1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn1.Location = New System.Drawing.Point(16, 32)
        Me.cboPkmn1.Name = "cboPkmn1"
        Me.cboPkmn1.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn1.TabIndex = 0
        '
        'cboPkmn2
        '
        Me.cboPkmn2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn2.Location = New System.Drawing.Point(176, 32)
        Me.cboPkmn2.Name = "cboPkmn2"
        Me.cboPkmn2.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn2.TabIndex = 10
        '
        'cboPkmn5
        '
        Me.cboPkmn5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn5.Location = New System.Drawing.Point(176, 72)
        Me.cboPkmn5.Name = "cboPkmn5"
        Me.cboPkmn5.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn5.TabIndex = 9
        '
        'cboPkmn3
        '
        Me.cboPkmn3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn3.Location = New System.Drawing.Point(336, 32)
        Me.cboPkmn3.Name = "cboPkmn3"
        Me.cboPkmn3.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn3.TabIndex = 6
        '
        'cboPkmn6
        '
        Me.cboPkmn6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn6.Location = New System.Drawing.Point(336, 72)
        Me.cboPkmn6.Name = "cboPkmn6"
        Me.cboPkmn6.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn6.TabIndex = 8
        '
        'cboPkmn4
        '
        Me.cboPkmn4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPkmn4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmn4.Location = New System.Drawing.Point(16, 72)
        Me.cboPkmn4.Name = "cboPkmn4"
        Me.cboPkmn4.Size = New System.Drawing.Size(152, 23)
        Me.cboPkmn4.TabIndex = 7
        '
        'SaveFD
        '
        Me.SaveFD.DefaultExt = "png"
        Me.SaveFD.FileName = "Sans titre"
        Me.SaveFD.Title = "Enregistre ta T-Card"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.mnuSave, Me.MenuItem6, Me.MenuItem4})
        Me.MenuItem1.Text = "&Fichier"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "&Nouveau"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Index = 1
        Me.mnuSave.Text = "&Enregistrer"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "&Quitter"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7})
        Me.MenuItem2.Text = "&?"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "A propos de Trainer Card Creator..."
        '
        'gbsave
        '
        Me.gbsave.Controls.Add(Me.Button1)
        Me.gbsave.Enabled = False
        Me.gbsave.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbsave.ForeColor = System.Drawing.Color.Black
        Me.gbsave.Location = New System.Drawing.Point(16, 560)
        Me.gbsave.Name = "gbsave"
        Me.gbsave.Size = New System.Drawing.Size(512, 72)
        Me.gbsave.TabIndex = 6
        Me.gbsave.TabStop = False
        Me.gbsave.Text = "6. Sauvegarder"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(168, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Sauvegarder"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbType
        '
        Me.gbType.Controls.Add(Me.rdCcard)
        Me.gbType.Controls.Add(Me.rdTCard)
        Me.gbType.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.ForeColor = System.Drawing.Color.Black
        Me.gbType.Location = New System.Drawing.Point(16, 8)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(512, 56)
        Me.gbType.TabIndex = 7
        Me.gbType.TabStop = False
        Me.gbType.Text = "1. Type de carte"
        '
        'rdCcard
        '
        Me.rdCcard.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCcard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdCcard.Location = New System.Drawing.Point(256, 24)
        Me.rdCcard.Name = "rdCcard"
        Me.rdCcard.Size = New System.Drawing.Size(120, 24)
        Me.rdCcard.TabIndex = 1
        Me.rdCcard.Text = "Coordinator Card"
        '
        'rdTCard
        '
        Me.rdTCard.Checked = True
        Me.rdTCard.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTCard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdTCard.Location = New System.Drawing.Point(80, 24)
        Me.rdTCard.Name = "rdTCard"
        Me.rdTCard.Size = New System.Drawing.Size(128, 24)
        Me.rdTCard.TabIndex = 0
        Me.rdTCard.TabStop = True
        Me.rdTCard.Text = "Trainer Card"
        '
        'gbautre
        '
        Me.gbautre.Controls.Add(Me.Label4)
        Me.gbautre.Controls.Add(Me.cboPlan)
        Me.gbautre.Controls.Add(Me.btDDroite)
        Me.gbautre.Controls.Add(Me.cboDresseur)
        Me.gbautre.Controls.Add(Me.Label2)
        Me.gbautre.Controls.Add(Me.Label1)
        Me.gbautre.Controls.Add(Me.cboBadge)
        Me.gbautre.Controls.Add(Me.btDBas)
        Me.gbautre.Controls.Add(Me.btDHaut)
        Me.gbautre.Controls.Add(Me.btDGauche)
        Me.gbautre.Controls.Add(Me.btPDroite)
        Me.gbautre.Controls.Add(Me.btPGauche)
        Me.gbautre.Controls.Add(Me.btPHaut)
        Me.gbautre.Controls.Add(Me.btPBas)
        Me.gbautre.Controls.Add(Me.Label3)
        Me.gbautre.Controls.Add(Me.cboPkmnD)
        Me.gbautre.Enabled = False
        Me.gbautre.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbautre.ForeColor = System.Drawing.Color.Black
        Me.gbautre.Location = New System.Drawing.Point(16, 384)
        Me.gbautre.Name = "gbautre"
        Me.gbautre.Size = New System.Drawing.Size(512, 176)
        Me.gbautre.TabIndex = 8
        Me.gbautre.TabStop = False
        Me.gbautre.Text = "5. Autres éléments"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(200, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Premier plan :"
        '
        'cboPlan
        '
        Me.cboPlan.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlan.Location = New System.Drawing.Point(296, 136)
        Me.cboPlan.Name = "cboPlan"
        Me.cboPlan.Size = New System.Drawing.Size(144, 23)
        Me.cboPlan.TabIndex = 18
        '
        'btDDroite
        '
        Me.btDDroite.BackColor = System.Drawing.Color.Silver
        Me.btDDroite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btDDroite.Image = CType(resources.GetObject("btDDroite.Image"), System.Drawing.Image)
        Me.btDDroite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDDroite.Location = New System.Drawing.Point(288, 56)
        Me.btDDroite.Name = "btDDroite"
        Me.btDDroite.Size = New System.Drawing.Size(24, 40)
        Me.btDDroite.TabIndex = 4
        Me.btDDroite.UseVisualStyleBackColor = False
        '
        'cboDresseur
        '
        Me.cboDresseur.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDresseur.Location = New System.Drawing.Point(176, 64)
        Me.cboDresseur.Name = "cboDresseur"
        Me.cboDresseur.Size = New System.Drawing.Size(104, 23)
        Me.cboDresseur.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(128, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dresseur :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Badges :"
        '
        'cboBadge
        '
        Me.cboBadge.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBadge.Location = New System.Drawing.Point(16, 64)
        Me.cboBadge.Name = "cboBadge"
        Me.cboBadge.Size = New System.Drawing.Size(112, 23)
        Me.cboBadge.TabIndex = 0
        '
        'btDBas
        '
        Me.btDBas.BackColor = System.Drawing.Color.Silver
        Me.btDBas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btDBas.Image = CType(resources.GetObject("btDBas.Image"), System.Drawing.Image)
        Me.btDBas.Location = New System.Drawing.Point(208, 96)
        Me.btDBas.Name = "btDBas"
        Me.btDBas.Size = New System.Drawing.Size(40, 24)
        Me.btDBas.TabIndex = 11
        Me.btDBas.UseVisualStyleBackColor = False
        '
        'btDHaut
        '
        Me.btDHaut.BackColor = System.Drawing.Color.Silver
        Me.btDHaut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btDHaut.Image = CType(resources.GetObject("btDHaut.Image"), System.Drawing.Image)
        Me.btDHaut.Location = New System.Drawing.Point(208, 32)
        Me.btDHaut.Name = "btDHaut"
        Me.btDHaut.Size = New System.Drawing.Size(40, 24)
        Me.btDHaut.TabIndex = 10
        Me.btDHaut.UseVisualStyleBackColor = False
        '
        'btDGauche
        '
        Me.btDGauche.BackColor = System.Drawing.Color.Silver
        Me.btDGauche.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btDGauche.Image = CType(resources.GetObject("btDGauche.Image"), System.Drawing.Image)
        Me.btDGauche.Location = New System.Drawing.Point(144, 56)
        Me.btDGauche.Name = "btDGauche"
        Me.btDGauche.Size = New System.Drawing.Size(24, 40)
        Me.btDGauche.TabIndex = 9
        Me.btDGauche.UseVisualStyleBackColor = False
        '
        'btPDroite
        '
        Me.btPDroite.BackColor = System.Drawing.Color.Silver
        Me.btPDroite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btPDroite.Image = CType(resources.GetObject("btPDroite.Image"), System.Drawing.Image)
        Me.btPDroite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPDroite.Location = New System.Drawing.Point(472, 56)
        Me.btPDroite.Name = "btPDroite"
        Me.btPDroite.Size = New System.Drawing.Size(24, 40)
        Me.btPDroite.TabIndex = 14
        Me.btPDroite.UseVisualStyleBackColor = False
        '
        'btPGauche
        '
        Me.btPGauche.BackColor = System.Drawing.Color.Silver
        Me.btPGauche.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btPGauche.Image = CType(resources.GetObject("btPGauche.Image"), System.Drawing.Image)
        Me.btPGauche.Location = New System.Drawing.Point(328, 56)
        Me.btPGauche.Name = "btPGauche"
        Me.btPGauche.Size = New System.Drawing.Size(24, 40)
        Me.btPGauche.TabIndex = 15
        Me.btPGauche.UseVisualStyleBackColor = False
        '
        'btPHaut
        '
        Me.btPHaut.BackColor = System.Drawing.Color.Silver
        Me.btPHaut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btPHaut.Image = CType(resources.GetObject("btPHaut.Image"), System.Drawing.Image)
        Me.btPHaut.Location = New System.Drawing.Point(392, 32)
        Me.btPHaut.Name = "btPHaut"
        Me.btPHaut.Size = New System.Drawing.Size(40, 24)
        Me.btPHaut.TabIndex = 16
        Me.btPHaut.UseVisualStyleBackColor = False
        '
        'btPBas
        '
        Me.btPBas.BackColor = System.Drawing.Color.Silver
        Me.btPBas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btPBas.Image = CType(resources.GetObject("btPBas.Image"), System.Drawing.Image)
        Me.btPBas.Location = New System.Drawing.Point(392, 96)
        Me.btPBas.Name = "btPBas"
        Me.btPBas.Size = New System.Drawing.Size(40, 24)
        Me.btPBas.TabIndex = 17
        Me.btPBas.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(312, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Pokémon :"
        '
        'cboPkmnD
        '
        Me.cboPkmnD.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPkmnD.Location = New System.Drawing.Point(360, 64)
        Me.cboPkmnD.Name = "cboPkmnD"
        Me.cboPkmnD.Size = New System.Drawing.Size(104, 23)
        Me.cboPkmnD.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 637)
        Me.Controls.Add(Me.gbautre)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.gbsave)
        Me.Controls.Add(Me.gbpkmn)
        Me.Controls.Add(Me.gbnom)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbcard)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(544, 696)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(544, 696)
        Me.Name = "Form1"
        Me.Text = "github-azul100"
        CType(Me.PicBoxCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcard.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbnom.ResumeLayout(False)
        Me.gbnom.PerformLayout()
        Me.gbpkmn.ResumeLayout(False)
        Me.gbsave.ResumeLayout(False)
        Me.gbType.ResumeLayout(False)
        Me.gbautre.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private SourcePath As String
    Private CardPath As String = "Images\azul100\"
    Private coord() As String
    Private coordDresseurX As Integer = 10
    Private coordDresseurY As Integer = 45
    Private coordPokemonX As Integer = 15
    Private coordPokemonY As Integer = 50

#Region "Fonctions Récupérées"
    'Charge un tableau de String avec la liste des chemins d'accès des fichiers d'une arborescence
    Private Function getFilesInDirectory(ByVal path As String, Optional ByVal ext As String = "") As String()
        'Déclarations
        Dim dir As IO.Directory
        Dim arrFiles As New ArrayList
        Dim file As String
        Dim tabExt() As String = Split(ext, ";")
        Dim nbExt As Int32 = tabExt.Length
        Dim i, j As Int32
        Dim trouve As Boolean

        Try
            'On copie tous les "fichiers" du répertoire path...
            '... dans le tableau arrFiles
            arrFiles.AddRange(dir.GetFileSystemEntries(path))

            'Pour chaque fichiers du tableau...
            i = 0
            While i < arrFiles.Count
                file = arrFiles(i)

                '...si c'est un répertoire
                If dir.Exists(file) Then
                    '...alors on ajoute tous les fichiers qu'il contient...)
                    arrFiles.AddRange(getFilesInDirectory(file, ext))
                End If

                '... si le fichier n'a pas l'extension souhaitée...
                '... ou que c'est un répertoire alors...
                '... on supprime la ligne SANS incrémenter i...
                '... car en supprimant, on va "remonter" tous les éléments...
                '... suivant cette référence et l'élément suivant l'élément courant...
                '... n'aurait pas été traité si on aurait incrémenté i
                If dir.Exists(file) Then
                    arrFiles.RemoveAt(i)
                Else
                    'test d'extension
                    trouve = False
                    j = 0
                    While Not trouve AndAlso j <= nbExt - 1
                        If file.EndsWith("." & tabExt(j)) Then
                            trouve = True
                        Else
                            j += 1
                        End If
                    End While

                    'S'il a pas trouvé les extensions... on le supprime
                    If Not trouve Then
                        arrFiles.RemoveAt(i)
                    Else
                        i += 1
                    End If

                End If
            End While

            Return (arrFiles.ToArray(GetType(String)))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erreur")
            Return (Nothing)
        End Try
    End Function

    Private Sub AddImageToPicture(ByVal Img As System.Drawing.Image, ByVal Location As System.Drawing.Point)
        Dim FinalImg As System.Drawing.Image = New System.Drawing.Bitmap(PicBoxCard.Width, PicBoxCard.Height)
        Dim Graphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(FinalImg)
        If Not PicBoxCard.Image Is Nothing Then
            Graphics.DrawImage(PicBoxCard.Image, System.Drawing.Point.Empty)
        End If
        Graphics.DrawImage(Img, Location)
        PicBoxCard.Image = FinalImg
    End Sub

    Private Sub AddTextToPicture(ByVal Text As String, ByVal Brush As System.Drawing.Brush, ByVal Font As System.Drawing.Font, ByVal x As Single, ByVal y As Single)
        Dim FinalImg As System.Drawing.Image = New System.Drawing.Bitmap(PicBoxCard.Width, PicBoxCard.Height)
        Dim Graphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(FinalImg)
        If Not PicBoxCard.Image Is Nothing Then
            Graphics.DrawImage(PicBoxCard.Image, System.Drawing.Point.Empty)
        End If
        Graphics.DrawString(Text, Font, Brush, x, y)
        PicBoxCard.Image = FinalImg
    End Sub

#End Region

    Private Sub Initialiser()
        SourcePath = System.AppDomain.CurrentDomain.BaseDirectory()

        gbpkmn.Enabled = False
        gbnom.Enabled = False
        gbsave.Enabled = False
        mnuSave.Enabled = False
        gbautre.Enabled = False

        ' Ajout des modèles de T-Card dans la liste
        lstCards.Items.Clear()

        Dim TCards() As String
        Dim lenTCard As Integer
        TCards = getFilesInDirectory(SourcePath & CardPath, "PNG;png")

        lenTCard = Len(SourcePath & CardPath)

        Dim TCard As String
        Dim choix As String
        For Each TCard In TCards
            choix = Mid(TCard, lenTCard + 1, Len(TCard) - lenTCard - 4)
            lstCards.Items.Add(choix)
        Next

        ' Ajout des Pokemon dans les listes
        cboPkmn1.Items.Clear()
        cboPkmn2.Items.Clear()
        cboPkmn3.Items.Clear()
        cboPkmn4.Items.Clear()
        cboPkmn5.Items.Clear()
        cboPkmn6.Items.Clear()

        cboPkmn1.Items.Add("Aucun")
        cboPkmn2.Items.Add("Aucun")
        cboPkmn3.Items.Add("Aucun")
        cboPkmn4.Items.Add("Aucun")
        cboPkmn5.Items.Add("Aucun")
        cboPkmn6.Items.Add("Aucun")

        Dim Pkmns() As String
        Dim lenPkmn As Integer
        Pkmns = getFilesInDirectory(SourcePath & "Images\Pkmn\", "BMP;bmp;PNG;png;JPG;jpg;JPEG;jpeg")

        lenPkmn = Len(SourcePath & "Images\Pkmn\")

        Dim Pkmn As String
        For Each Pkmn In Pkmns
            choix = Mid(Pkmn, lenPkmn + 1, Len(Pkmn) - lenPkmn)
            cboPkmn1.Items.Add(choix)
            cboPkmn2.Items.Add(choix)
            cboPkmn3.Items.Add(choix)
            cboPkmn4.Items.Add(choix)
            cboPkmn5.Items.Add(choix)
            cboPkmn6.Items.Add(choix)
        Next

        ' Remplissage cbo plan
        cboPlan.Items.Clear()

        cboPlan.Items.Add("Pokémon")
        cboPlan.Items.Add("Dresseur")

        ' Ajout des Badges dans la liste
        cboBadge.Items.Clear()

        cboBadge.Items.Add("Aucun")
        cboBadge.Items.Add("Hoen")
        cboBadge.Items.Add("Kanto")

        ' Ajout des dresseurs dans la liste
        cboDresseur.Items.Clear()

        Dim Dresseurs() As String
        Dim lenDresseur As Integer

        cboDresseur.Items.Add("Aucun")

        lenDresseur = Len(SourcePath & "Images\Dresseurs\")

        Dresseurs = getFilesInDirectory(SourcePath & "Images\Dresseurs\", "GIF;gif")

        Dim Dresseur As String
        For Each Dresseur In Dresseurs
            choix = Mid(Dresseur, lenDresseur + 1, Len(Dresseur) - lenDresseur - 4)
            cboDresseur.Items.Add(choix)
        Next

        ' Ajout des Pokémon dans la liste
        cboPkmnD.Items.Clear()

        Dim PokemonDs() As String
        Dim lenPokemonD As Integer

        cboPkmnD.Items.Add("Aucun")

        lenPokemonD = Len(SourcePath & "Images\PkmnD\")

        PokemonDs = getFilesInDirectory(SourcePath & "Images\PkmnD\", "PNG;png")

        Dim PokemonD As String
        For Each PokemonD In PokemonDs
            choix = Mid(PokemonD, lenPokemonD + 1, Len(PokemonD) - lenPokemonD - 4)
            cboPkmnD.Items.Add(choix)
        Next

        'Initialisation du nom
        txtnom.Text = ""
        chkGras.Checked = False
        chkItalique.Checked = False
        chkSouligne.Checked = False

        'Initialisation des valeurs
        cboDresseur.SelectedIndex = 0
        cboPkmnD.SelectedIndex = 0
        cboBadge.SelectedIndex = 0
        cboPlan.SelectedIndex = 0
        cboPkmn1.SelectedIndex = 0
        cboPkmn2.SelectedIndex = 0
        cboPkmn3.SelectedIndex = 0
        cboPkmn4.SelectedIndex = 0
        cboPkmn5.SelectedIndex = 0
        cboPkmn6.SelectedIndex = 0

        ' Effacer l'image
        PicBoxCard.Image = Nothing
        PicBoxCard.BackColor = System.Drawing.Color.White

    End Sub

    Private Sub AfficherImages()

        ' Affichage de la T-Card
        If lstCards.SelectedItem <> Nothing Then
            Call AddImageToPicture(Image.FromFile(SourcePath & CardPath & lstCards().SelectedItem & ".png"), New System.Drawing.Point(0, 0))
        End If

        ' Affichage des Pokemon
        If ((cboPkmn1.SelectedItem <> Nothing) And (cboPkmn1.SelectedItem <> "Aucun")) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn1().SelectedItem), New System.Drawing.Point(coord(1), coord(2)))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn1().SelectedItem), New System.Drawing.Point(coord(1), coord(2)))
            End If
        End If

        If ((cboPkmn2.SelectedItem <> Nothing) And (cboPkmn2.SelectedItem <> "Aucun")) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn2().SelectedItem), New System.Drawing.Point(coord(1) + 52, coord(2)))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn2().SelectedItem), New System.Drawing.Point(coord(1) + 78, coord(2) - 8))
            End If
        End If

        If ((cboPkmn3.SelectedItem <> Nothing) And (cboPkmn3.SelectedItem <> "Aucun")) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn3().SelectedItem), New System.Drawing.Point(coord(1) + 104, coord(2)))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn3().SelectedItem), New System.Drawing.Point(coord(1) + 156, coord(2)))
            End If
        End If

        If ((cboPkmn4.SelectedItem <> Nothing) And (cboPkmn4.SelectedItem <> "Aucun")) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn4().SelectedItem), New System.Drawing.Point(coord(1), coord(2) + 36))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn4().SelectedItem), New System.Drawing.Point(coord(1), coord(2) + 36))
            End If
        End If

        If ((cboPkmn5.SelectedItem <> Nothing) And (cboPkmn5.SelectedItem <> "Aucun")) Then
            Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn5().SelectedItem), New System.Drawing.Point(coord(1) + 52, coord(2) + 36))
        End If

        If ((cboPkmn6.SelectedItem <> Nothing) And (cboPkmn6.SelectedItem <> "Aucun")) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn6().SelectedItem), New System.Drawing.Point(coord(1) + 104, coord(2) + 36))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Pkmn\" & cboPkmn6().SelectedItem), New System.Drawing.Point(coord(1) + 156, coord(2) + 36))
            End If
        End If

        ' Eriture du Nom
        Dim gras As System.Drawing.FontStyle = FontStyle.Bold
        Dim Italique As System.Drawing.FontStyle = FontStyle.Italic
        Dim Souligne As System.Drawing.FontStyle = FontStyle.Underline
        Dim StyleText As System.Drawing.FontStyle
        Dim LaBrush As System.Drawing.Brush = New System.Drawing.SolidBrush(System.Drawing.Color.Black)

        If chkGras.Checked Then
            gras = FontStyle.Bold
        Else
            gras = Nothing
        End If

        If chkItalique.Checked Then
            Italique = FontStyle.Italic
        Else
            Italique = Nothing
        End If

        If chkSouligne.Checked Then
            Souligne = FontStyle.Underline
        Else
            Souligne = Nothing
        End If

        StyleText = Italique Or gras Or Souligne

        Dim LaFont As New System.Drawing.Font("Tahoma", 8, StyleText)
        If txtnom.Text <> "" Then
            If rdTCard.Checked Then
                AddTextToPicture(txtnom.Text, LaBrush, LaFont, 133, 10)
            Else
                AddTextToPicture(txtnom.Text, LaBrush, LaFont, 124, 10)
            End If
        End If

        ' Ajout des badges
        If ((cboBadge.SelectedItem <> "Aucun") And (cboBadge.SelectedItem <> Nothing)) Then
            Dim i As Integer
            If rdTCard.Checked Then
                For i = 1 To 8
                    Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Badges\" & cboBadge.SelectedItem & "\" & i & ".gif"), New System.Drawing.Point(coord(1) - 43 + (i - 1) * 24, coord(2) + 92))
                Next
            End If
        End If

        If ((cboPlan.SelectedItem = "Pokémon") Or (cboPlan.SelectedItem = Nothing)) Then
            ' Affichage du Dresseur
            If ((cboDresseur.SelectedItem <> "Aucun") And (cboDresseur.SelectedItem <> Nothing)) Then
                If rdTCard.Checked Then
                    Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Dresseurs\" & cboDresseur.SelectedItem & ".gif"), New System.Drawing.Point(coordDresseurX, coordDresseurY))
                Else
                    Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Dresseurs\" & cboDresseur.SelectedItem & ".gif"), New System.Drawing.Point(coordDresseurX + 80, coordDresseurY + 25))
                End If
            End If
        End If

        ' Affichage du Pokemon
        If ((cboPkmnD.SelectedItem <> "Aucun") And (cboPkmnD.SelectedItem <> Nothing)) Then
            If rdTCard.Checked Then
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\PkmnD\" & cboPkmnD.SelectedItem & ".png"), New System.Drawing.Point(coordPokemonX, coordPokemonY))
            Else
                Call AddImageToPicture(Image.FromFile(SourcePath & "Images\PkmnD\" & cboPkmnD.SelectedItem & ".png"), New System.Drawing.Point(coordPokemonX + 80, coordPokemonY + 25))
            End If
        End If

        If (cboPlan.SelectedItem = "Dresseur") Then
            ' Affichage du Dresseur
            If ((cboDresseur.SelectedItem <> "Aucun") And (cboDresseur.SelectedItem <> Nothing)) Then
                If rdTCard.Checked Then
                    Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Dresseurs\" & cboDresseur.SelectedItem & ".gif"), New System.Drawing.Point(coordDresseurX, coordDresseurY))
                Else
                    Call AddImageToPicture(Image.FromFile(SourcePath & "Images\Dresseurs\" & cboDresseur.SelectedItem & ".gif"), New System.Drawing.Point(coordDresseurX + 80, coordDresseurY + 25))
                End If
            End If
        End If

    End Sub

#Region "Element Modifié"
    Private Sub rdCCard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTCard.CheckedChanged
        If rdTCard.Checked Then
            CardPath = "Images\azul100\"
            cboPkmn5.Enabled = True
            cboBadge.Enabled = True
        Else
            CardPath = "Images\C-Cards\"
            cboPkmn5.Enabled = False
            cboBadge.Enabled = False
        End If

        Call Initialiser()
    End Sub

    Private Sub lstTCards_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCards.SelectedIndexChanged
        coord = Split(lstCards().SelectedItem, "_")

        gbpkmn.Enabled = True
        gbnom.Enabled = True
        gbautre.Enabled = True
        gbsave.Enabled = True
        mnuSave.Enabled = True

        Call AfficherImages()
    End Sub

    Private Sub cboPkmn1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn1.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmn2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn2.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmn3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn3.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmn4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn4.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmn5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn5.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmn6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmn6.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub txtnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom.TextChanged
        Call AfficherImages()
    End Sub

    Private Sub chkGras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGras.CheckedChanged
        Call AfficherImages()
    End Sub

    Private Sub chkSouligne_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSouligne.CheckedChanged
        Call AfficherImages()
    End Sub

    Private Sub chkItalique_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItalique.CheckedChanged
        Call AfficherImages()
    End Sub

    Private Sub cboBadge_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBadge.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboDresseur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDresseur.SelectedIndexChanged
        Call AfficherImages()
    End Sub

    Private Sub cboPkmnD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPkmnD.SelectedIndexChanged
        Call AfficherImages()
    End Sub
    Private Sub cboPlan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlan.SelectedIndexChanged
        Call AfficherImages()
    End Sub
#End Region

#Region "Déplacements"
    ' Délacement du dresseur
    Private Sub btDHaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDHaut.Click
        coordDresseurY -= 1
        Call AfficherImages()
    End Sub

    Private Sub btDBas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDBas.Click
        coordDresseurY += 1
        Call AfficherImages()
    End Sub

    Private Sub btDGauche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDGauche.Click
        coordDresseurX -= 1
        Call AfficherImages()
    End Sub

    Private Sub btDDroite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDDroite.Click
        coordDresseurX += 1
        Call AfficherImages()
    End Sub

    ' Déplacement du Pokémon
    Private Sub btPHaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPHaut.Click
        coordPokemonY -= 1
        Call AfficherImages()
    End Sub

    Private Sub btPDroite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPDroite.Click
        coordPokemonX += 1
        Call AfficherImages()
    End Sub

    Private Sub btPBas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPBas.Click
        coordPokemonY += 1
        Call AfficherImages()
    End Sub

    Private Sub btPGauche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPGauche.Click
        coordPokemonX -= 1
        Call AfficherImages()
    End Sub
#End Region

#Region "Divers"
    ' Sauvegarde de l'image
    Private Sub Sauvegarde()
        Dim buffer As Bitmap = PicBoxCard.Image
        Dim controlSize As Size

        SaveFD.ShowDialog()

        If SaveFD.FileName <> "" Then ' Si l'enregistrement n'a pas été annulé
            buffer.Save(SaveFD.FileName, System.Drawing.Imaging.ImageFormat.Png)
        End If
    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Call Initialiser()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Sauvegarde()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        Call Sauvegarde()
    End Sub

    ' Fermer la fenetre
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Dispose()
    End Sub

    ' Ouvrir A propos de...
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim FCP As New frmcopy
        FCP.Show()
    End Sub
#End Region

End Class
