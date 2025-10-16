Imports System.Security.Cryptography

Public Class Form1

    Private questions() As String = {
        "1. What is the capital of Canada?",
        "2. Which planet is known as the Red Planet?",
        "3. Who wrote the play 'Romeo and Juliet'?",
        "4. What is the largest mammal in the world?",
        "5. Which element has the chemical symbol 'O'?",
        "6. What is the currency of Japan?",
        "7. Which continent is the Sahara Desert located in?",
        "8. Who painted the Mona Lisa?",
        "9. What is the boiling point of water at sea level in Celsius?",
        "10. Which organ in the human body is responsible for pumping blood?",
        "11. What is the smallest prime number?",
        "12. What is the longest river in the world?"
    }

    Private choices(,) As String = {
        {"A) Toronto", "B) Vancouver", "C) Ottawa", "D) Montreal"},
        {"A) Venus", "B) Mars", "C) Jupiter", "D) Saturn"},
        {"A) Charles Dickens", "B) William Shakespeare", "C) Jane Austen", "D) Mark Twain"},
        {"A) African Elephant", "B) Blue Whale", "C) Giraffe", "D) Hippopotamus"},
        {"A) Gold", "B) Oxygen", "C) Osmium", "D) Oganesson"},
        {"A) Won", "B) Yuan", "C) Yen", "D) Ringgit"},
        {"A) Asia", "B) Africa", "C) Australia", "D) South America"},
        {"A) Vincent van Gogh", "B) Pablo Picasso", "C) Leonardo da Vinci", "D) Claude Monet"},
        {"A) 90°C", "B) 100°C", "C) 120°C", "D) 80°C"},
        {"A) Brain", "B) Liver", "C) Heart", "D) Kidney"},
        {"A) 0", "B) 1", "C) 2", "D) 3"},
        {"A) Amazon", "B) Nile", "C) Yangtze", "D) Mississippi"}
    }

    Private answers() As String = {
        "C", "B", "B", "B", "B", "C", "B", "C", "B", "C", "C", "B"
    }

    Private currentQuestion As Integer = 0
    Private score As Integer = 0
    Private Sub LoadQuestion()
        lblQuestion.Text = questions(currentQuestion)
        rbA.Text = choices(currentQuestion, 0)
        rbB.Text = choices(currentQuestion, 1)
        rbC.Text = choices(currentQuestion, 2)
        rbD.Text = choices(currentQuestion, 3)

        rbA.Checked = False
        rbB.Checked = False
        rbC.Checked = False
        rbD.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestion()
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim selected As String = ""

        If rbA.Checked Then
            selected = "A"
        End If
        If rbB.Checked Then
            selected = "B"
        End If
        If rbC.Checked Then
            selected = "C"
        End If
        If rbD.Checked Then
            selected = "D"
        End If

        If selected = answers(currentQuestion) Then
            score += 1
            Checkerlbl.Text = "Previous was Correct!"
        Else
            Checkerlbl.Text = "Previous was Wrong!"
        End If

        currentQuestion += 1

        If currentQuestion < questions.Length Then
            LoadQuestion()
        Else
            lblQuestion.Text = "Quiz complete!"
            lblScore.Text = "Your score: " & score & " out of " & questions.Length
            btnNext.Enabled = False
        End If
    End Sub




End Class
