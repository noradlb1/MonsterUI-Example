Imports WindowsApp6يسباسيلسيبقلاشيبثيفاشثسبثيا.MonsterUI

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MonsterShapeBubblesV21.Add(MonsterShapeBubblesV2.Bubble.Fast, Color.HotPink, Nothing)
        '' أمثلة للاستخدام:
        'HeartBubbles1.CurrentShape = HeartBubbles.ShapeType.Eye
        'HeartBubbles1.CurrentShape = HeartBubbles.ShapeType.Spider
        'HeartBubbles1.CurrentShape = HeartBubbles.ShapeType.Lightning
        'HeartBubbles1.CurrentShape = HeartBubbles.ShapeType.MatrixNumbers
        'HeartBubbles1.EnableRotation = True

        '' إضافة مع ألوان مختلفة
        'HeartBubbles1.Add(HeartBubbles.Bubble.Fast, Color.Red, Color.Black)    ' عين حمراء
        'HeartBubbles1.Add(HeartBubbles.Bubble.Slow, Color.Green, Nothing)      ' Matrix أخضر

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MonsterShapeBubblesV21.Add()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MonsterShapeBubblesV21.CurrentShape = MonsterShapeBubblesV2.ShapeType.Heart
    End Sub
End Class