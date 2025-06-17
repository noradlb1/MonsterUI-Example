Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. تحريك تدريجي (ناعم)
        MonsterHologramProgressBar1.SetProgressSmooth(75)          ' إلى 75 من 100
        MonsterHologramProgressBar1.SetProgressSmooth(150, 200)    ' إلى 150 من 200

        ' 2. تحديث مباشر (فوري)
        MonsterHologramProgressBar1.SetProgressInstant(75)         ' فوري
        MonsterHologramProgressBar1.SetProgressInstant(150, 200)   ' فوري مع تحديد الحد الأقصى

        ' 3. تحكم في خواص التحريك
        MonsterHologramProgressBar1.SmoothProgress = True          ' تفعيل التحريك التدريجي
        MonsterHologramProgressBar1.AnimationDuration = 2000       ' مدة التحريك (2 ثانية)
    End Sub
End Class