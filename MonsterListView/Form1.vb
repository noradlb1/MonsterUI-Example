Imports System.Drawing
Imports System.Windows.Forms
Imports WindowsApp6يسباسيلسيبقلاشيبثيفاشثسبثيا.MonsterUI

Public Class Form1
    Inherits Form

    Private WithEvents MonsterListView As MonsterListView
    Private WithEvents btnModern As Button
    Private WithEvents btnDark As Button
    Private WithEvents btnColorful As Button
    Private WithEvents btnAdd As Button
    Private WithEvents btnClear As Button
    Private WithEvents btnCustom As Button
    Private WithEvents chkAlternate As CheckBox
    Private WithEvents chkHover As CheckBox
    Private WithEvents chkGrid As CheckBox
    Private controlPanel As Panel

    Public Sub New()
        InitializeForm()
        CreateControls()
        LoadSampleData()
    End Sub

    Private Sub InitializeForm()
        Me.Text = "Custom ListView Demo - monstermc"
        Me.Size = New Size(1000, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.WhiteSmoke
        Me.MinimumSize = New Size(800, 600)
    End Sub

    Private Sub CreateControls()
        ' Create control panel
        controlPanel = New Panel() With {
            .Dock = DockStyle.Top,
            .Height = 100,
            .BackColor = Color.FromArgb(230, 230, 230),
            .BorderStyle = BorderStyle.FixedSingle
        }

        ' Theme buttons
        btnModern = New Button() With {
            .Text = "Modern Theme",
            .Location = New Point(10, 10),
            .Size = New Size(120, 35),
            .BackColor = Color.FromArgb(0, 120, 215),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnModern.FlatAppearance.BorderSize = 0

        btnDark = New Button() With {
            .Text = "Dark Theme",
            .Location = New Point(140, 10),
            .Size = New Size(120, 35),
            .BackColor = Color.FromArgb(64, 64, 64),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnDark.FlatAppearance.BorderSize = 0

        btnColorful = New Button() With {
            .Text = "Colorful Theme",
            .Location = New Point(270, 10),
            .Size = New Size(120, 35),
            .BackColor = Color.FromArgb(50, 205, 50),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnColorful.FlatAppearance.BorderSize = 0

        btnCustom = New Button() With {
            .Text = "Custom Colors",
            .Location = New Point(400, 10),
            .Size = New Size(120, 35),
            .BackColor = Color.FromArgb(255, 140, 0),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnCustom.FlatAppearance.BorderSize = 0

        ' Action buttons
        btnAdd = New Button() With {
            .Text = "Add Items",
            .Location = New Point(530, 10),
            .Size = New Size(100, 35),
            .BackColor = Color.FromArgb(40, 167, 69),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnAdd.FlatAppearance.BorderSize = 0

        btnClear = New Button() With {
            .Text = "Clear All",
            .Location = New Point(640, 10),
            .Size = New Size(100, 35),
            .BackColor = Color.FromArgb(220, 53, 69),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        btnClear.FlatAppearance.BorderSize = 0

        ' Checkboxes
        chkAlternate = New CheckBox() With {
            .Text = "Alternate Colors",
            .Location = New Point(10, 55),
            .Size = New Size(130, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }

        chkHover = New CheckBox() With {
            .Text = "Hover Effect",
            .Location = New Point(150, 55),
            .Size = New Size(120, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }

        chkGrid = New CheckBox() With {
            .Text = "Grid Lines",
            .Location = New Point(280, 55),
            .Size = New Size(100, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }

        ' Add controls to panel
        controlPanel.Controls.AddRange({
            btnModern, btnDark, btnColorful, btnCustom,
            btnAdd, btnClear, chkAlternate, chkHover, chkGrid
        })

        ' Create custom ListView
        MonsterListView = New MonsterListView() With {
            .Dock = DockStyle.Fill,
            .Margin = New Padding(10),
            .Font = New Font("Segoe UI", 9)
        }

        ' Setup columns
        MonsterListView.AddColumn("Monster Name", 180)
        MonsterListView.AddColumn("Type", 120)
        MonsterListView.AddColumn("Level", 80)
        MonsterListView.AddColumn("HP", 100)
        MonsterListView.AddColumn("MP", 100)
        MonsterListView.AddColumn("Skills", 150)
        MonsterListView.AddColumn("Description", 250)

        ' Apply default theme
        MonsterListView.ApplyModernTheme()

        ' Add to form
        Me.Controls.Add(MonsterListView)
        Me.Controls.Add(controlPanel)
    End Sub

    Private Sub LoadSampleData()
        Dim monsters As New List(Of MonsterListViewItem)

        ' Create comprehensive monster data
        monsters.Add(MonsterListView.CreateItem("Ancient Fire Dragon", "Fire", "95", "5000", "3500", "Fire Breath, Wing Attack", "Legendary ancient dragon with immense fire powers"))
        monsters.Add(MonsterListView.CreateItem("Frost Wolf Alpha", "Ice", "65", "1800", "1200", "Ice Bite, Frost Aura", "Leader of the frost wolf pack from frozen lands"))
        monsters.Add(MonsterListView.CreateItem("Thunder Phoenix", "Electric", "88", "2800", "4000", "Lightning Strike, Thunder Call", "Majestic bird with control over storms"))
        monsters.Add(MonsterListView.CreateItem("Earth Titan", "Earth", "92", "6000", "800", "Earthquake, Rock Throw", "Massive stone giant protecting ancient ruins"))
        monsters.Add(MonsterListView.CreateItem("Water Empress", "Water", "78", "2200", "3800", "Tidal Wave, Healing Spring", "Royal water elemental with healing abilities"))
        monsters.Add(MonsterListView.CreateItem("Shadow Assassin", "Dark", "72", "1500", "2200", "Stealth, Shadow Strike", "Swift and deadly creature of darkness"))
        monsters.Add(MonsterListView.CreateItem("Wind Spirit", "Air", "55", "900", "2800", "Tornado, Wind Blade", "Playful but powerful air elemental"))
        monsters.Add(MonsterListView.CreateItem("Lava Salamander", "Fire", "48", "1100", "900", "Molten Spit, Heat Wave", "Fire lizard living in volcanic regions"))
        monsters.Add(MonsterListView.CreateItem("Crystal Guardian", "Crystal", "83", "2500", "2000", "Crystal Shield, Prism Beam", "Beautiful guardian with crystal abilities"))
        monsters.Add(MonsterListView.CreateItem("Storm King", "Thunder", "90", "4200", "2500", "Lightning Storm, Thunder Roar", "Mighty ruler of storm creatures"))
        monsters.Add(MonsterListView.CreateItem("Poison Viper", "Poison", "42", "800", "1100", "Venom Bite, Toxic Cloud", "Deadly venomous serpent"))
        monsters.Add(MonsterListView.CreateItem("Light Seraph", "Light", "96", "3200", "5000", "Divine Light, Healing Aura", "Angelic being of pure light energy"))
        monsters.Add(MonsterListView.CreateItem("Blood Bat", "Dark", "35", "600", "800", "Blood Drain, Sonic Screech", "Vampiric bat creature of the night"))
        monsters.Add(MonsterListView.CreateItem("Rock Golem", "Earth", "58", "2800", "400", "Stone Fist, Rock Armor", "Animated stone creature guarding caves"))
        monsters.Add(MonsterListView.CreateItem("Ice Queen", "Ice", "85", "2600", "3200", "Blizzard, Ice Prison", "Regal ruler of the frozen kingdom"))
        monsters.Add(MonsterListView.CreateItem("Forest Dryad", "Nature", "67", "1400", "2600", "Nature's Blessing, Vine Whip", "Ancient tree spirit protecting the forest"))
        monsters.Add(MonsterListView.CreateItem("Metal Dragon", "Steel", "89", "4800", "1800", "Steel Claw, Metal Breath", "Mechanical dragon with steel armor"))
        monsters.Add(MonsterListView.CreateItem("Dream Eater", "Psychic", "71", "1600", "3400", "Mind Control, Dream Walk", "Mysterious creature feeding on dreams"))
        monsters.Add(MonsterListView.CreateItem("Solar Eagle", "Light", "76", "2000", "2400", "Solar Flare, Blinding Light", "Majestic eagle powered by sunlight"))
        monsters.Add(MonsterListView.CreateItem("Void Walker", "Dark", "94", "3800", "4200", "Void Step, Dark Portal", "Interdimensional being from the void"))

        MonsterListView.AddItems(monsters)
    End Sub

    Private Sub btnModern_Click(sender As Object, e As EventArgs) Handles btnModern.Click
        MonsterListView.ApplyModernTheme()
        ShowStatusMessage("Modern theme applied! Clean and professional look.")
    End Sub

    Private Sub btnDark_Click(sender As Object, e As EventArgs) Handles btnDark.Click
        MonsterListView.ApplyDarkTheme()
        ShowStatusMessage("Dark theme applied! Easy on the eyes.")
    End Sub

    Private Sub btnColorful_Click(sender As Object, e As EventArgs) Handles btnColorful.Click
        MonsterListView.ApplyColorfulTheme()
        ShowStatusMessage("Colorful theme applied! Vibrant and lively.")
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        ' Apply custom colors
        MonsterListView.SetCustomTheme(Color.LightSalmon, Color.DarkRed, Color.DarkBlue)
        MonsterListView.HeaderBackColor = Color.Coral
        MonsterListView.HeaderForeColor = Color.White
        MonsterListView.GridLinesColor = Color.IndianRed
        ShowStatusMessage("Custom theme applied! Warm sunset colors.")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rand As New Random()
        Dim newMonsters As New List(Of MonsterListViewItem)

        Dim types() As String = {"Fire", "Water", "Earth", "Air", "Electric", "Ice", "Dark", "Light", "Poison", "Crystal", "Steel", "Nature"}
        Dim adjectives() As String = {"Fierce", "Ancient", "Mystical", "Powerful", "Swift", "Deadly", "Majestic", "Savage", "Noble", "Cunning", "Wild", "Legendary"}
        Dim creatures() As String = {"Dragon", "Wolf", "Eagle", "Bear", "Tiger", "Serpent", "Phoenix", "Griffin", "Wyvern", "Basilisk", "Hydra", "Chimera"}
        Dim skills() As String = {"Claw Attack", "Magic Blast", "Roar", "Charge", "Bite", "Tail Whip", "Wing Strike", "Breath Attack"}

        For i As Integer = 1 To 5
            Dim adjective As String = adjectives(rand.Next(adjectives.Length))
            Dim creature As String = creatures(rand.Next(creatures.Length))
            Dim monsterType As String = types(rand.Next(types.Length))
            Dim level As Integer = rand.Next(20, 100)
            Dim hp As Integer = rand.Next(500, 5000)
            Dim mp As Integer = rand.Next(300, 3000)
            Dim skill1 As String = skills(rand.Next(skills.Length))
            Dim skill2 As String = skills(rand.Next(skills.Length))

            newMonsters.Add(MonsterListView.CreateItem(
                $"{adjective} {creature}",
                monsterType,
                level.ToString(),
                hp.ToString(),
                mp.ToString(),
                $"{skill1}, {skill2}",
                $"A {adjective.ToLower()} {creature.ToLower()} with {monsterType.ToLower()} elemental powers"
            ))
        Next

        MonsterListView.AddItems(newMonsters)
        ShowStatusMessage($"Added {newMonsters.Count} new monsters to the collection!")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim result = MessageBox.Show("Are you sure you want to clear all monsters from the list?",
                                   "Confirm Clear",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MonsterListView.ClearItems()
            ShowStatusMessage("All monsters have been cleared from the list.")
        End If
    End Sub

    Private Sub chkAlternate_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlternate.CheckedChanged
        MonsterListView.UseAlternateRowColors = chkAlternate.Checked
        ShowStatusMessage($"Alternate row colors: {If(chkAlternate.Checked, "Enabled", "Disabled")}")
    End Sub

    Private Sub chkHover_CheckedChanged(sender As Object, e As EventArgs) Handles chkHover.CheckedChanged
        MonsterListView.UseHoverEffect = chkHover.Checked
        ShowStatusMessage($"Hover effects: {If(chkHover.Checked, "Enabled", "Disabled")}")
    End Sub

    Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
        MonsterListView.ShowGridLines = chkGrid.Checked
        ShowStatusMessage($"Grid lines: {If(chkGrid.Checked, "Visible", "Hidden")}")
    End Sub

    Private Sub ShowStatusMessage(message As String)
        ' Update form title with status message
        Me.Text = $"Custom ListView Demo - {message}"

        ' Reset title after 3 seconds
        Dim resetTimer As New Timer With {.Interval = 3000, .Enabled = True}
        AddHandler resetTimer.Tick, Sub(s, e)
                                        Me.Text = "Custom ListView Demo - monstermc"
                                        resetTimer.Stop()
                                        resetTimer.Dispose()
                                    End Sub
    End Sub
End Class

