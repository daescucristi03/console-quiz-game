using System;

class Quiz {
    
    int questionsAnsweredCorrectly = 0;

    public struct questionData {
        public string question;

        public string[] answers;
        public int correctAnswerIndex;
    };

    public void displayCorrectAnswer(int index) {
        Console.WriteLine("'" + quizData[index].answers[quizData[index].correctAnswerIndex] + "'");
    }

    public void displayCurrentQuestion(int quizIndex, int index) {
        Console.WriteLine((quizIndex + 1) + ". " + quizData[index].question);
        for(int i = 0; i < 4; i++) {
            Console.WriteLine("\t" + quizData[index].answers[i]);
        }

        string? answer;
        Console.Write("Answer: ");
        answer = Console.ReadLine();    
        handleAnswer(answer, index);
    }

    protected void handleAnswer(string? answer, int index) {
        // Use the StringComparison.OrdinalIgnoreCase parameter to make the comparison non case-sensitive
        if(String.Compare(
            answer, 
            quizData[index].answers[quizData[index].correctAnswerIndex].Substring(0,1),
            StringComparison.OrdinalIgnoreCase) == 0) {

            Console.WriteLine();
            Console.Write("You got it right! the answer is ");
            questionsAnsweredCorrectly++;
            displayCorrectAnswer(index);
        } else {
            Console.Write("You got it wrong! the answer was ");
            displayCorrectAnswer(index);
        }
    }

    public void handleQuizProgression() {
        questionsAnsweredCorrectly = 0;

        Random random = new Random();
        int[] numbers = new int[10];
        HashSet<int> generatedNumbers = new HashSet<int>();

        for (int i = 0; i < numbers.Length; i++) {
            int randomNumber;
            do {
                randomNumber = random.Next(0, 25);
            } while (generatedNumbers.Contains(randomNumber));
            numbers[i] = randomNumber;
            generatedNumbers.Add(randomNumber);
        }


        for(int i = 0; i < 10; i++ ) {
            displayCurrentQuestion(i, numbers[i]);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("You got " + questionsAnsweredCorrectly + " / 10 answers correct!");
    }

    public questionData[] quizData = {
        // 0. What is the capital of Portugal?
        new questionData { 
            question = "What is the capital of Portugal?", 
            answers = new string[] {"A. Madrid", "B. Lisbon", "C. Paris", "D. Rome"},
            correctAnswerIndex = 1
        },
        // 1. Which planet in our solar system is closest to the sun? 
        new questionData { 
            question = "Which planet in our solar system is closest to the sun?", 
            answers = new string[] {"A. Mercury", "B. Venus", "C. Earth", "D. Mars"},
            correctAnswerIndex = 0
        },
        // 2. In which country would you find Machu Picchu?
        new questionData { 
            question = "In which country would you find Machu Picchu?", 
            answers = new string[] {"A. Mexico", "B. Peru", "C. Brazil", "D. Colombia"},
            correctAnswerIndex = 1
        },
        // 3. Who wrote the novel "Pride and Prejudice"?
        new questionData { 
            question = "Who wrote the novel 'Pride and Prejudice'?", 
            answers = new string[] {"A. Jane Austen", "B. Charles Dickens", "C. William Shakespeare", "D. Ernest Hemingway"},
            correctAnswerIndex = 0
        },
        // 4. Which famous scientist developed the theory of relativity?
        new questionData { 
            question = "Which famous scientist developed the theory of relativity?", 
            answers = new string[] {"A. Isaac Newton", "B. Galileo Galilei", "C. Albert Einstein", "D. Stephen Hawking"},
            correctAnswerIndex = 2
        },
        // 5. What is the name of the current president of Russia?
        new questionData { 
            question = "What is the name of the current president of Russia?", 
            answers = new string[] {"A. Vladimir Putin", "B. Dmitry Medvedev", "C. Boris Yeltsin", "D. Mikhail Gorbachev"},
            correctAnswerIndex = 0
        },
        // 6. In what year did World War I end?
        new questionData { 
            question = "In what year did World War I end?", 
            answers = new string[] {"A. 1914", "B. 1917", "C. 1918", "D. 1920"},
            correctAnswerIndex = 2
        },
        // 7. What is the largest planet in our solar system?
        new questionData { 
            question = "What is the largest planet in our solar system?", 
            answers = new string[] {"A. Jupiter", "B. Saturn", "C. Uranus", "D. Neptune"},
            correctAnswerIndex = 0
        },
        // 8. Who is the lead singer of the band Coldplay?
        new questionData { 
            question = "Who is the lead singer of the band Coldplay?", 
            answers = new string[] {"A. Chris Martin", "B. Jonny Buckland", "C. Guy Berryman", "D. Will Champion"},
            correctAnswerIndex = 0
        },
        // 9. What is the national animal of Canada?
        new questionData { 
            question = "What is the national animal of Canada?", 
            answers = new string[] {"A. Moose", "B. Polar bear", "C. Beaver", "D. Caribou"},
            correctAnswerIndex = 2
        },
        // 10. Who directed the movie "The Godfather"?
        new questionData { 
            question = "Who directed the movie 'The Godfather'?", 
            answers = new string[] {"A. Francis Ford Coppola", "B. Martin Scorsese", "C. Steven Spielberg", "D. Quentin Tarantino"},
            correctAnswerIndex = 0
        },
        // 11. Which planet is known as the Red Planet?
        new questionData { 
            question = "Which planet is known as the Red Planet?", 
            answers = new string[] {"A. Venus", "B. Mars", "C. Saturn", "D. Jupiter"},
            correctAnswerIndex = 1
        },
        // 12. Who wrote the novel "To Kill a Mockingbird"?
        new questionData { 
            question = "Who wrote the novel 'To Kill a Mockingbird'?", 
            answers = new string[] {"A. Harper Lee", "B. F. Scott Fitzgerald", "C. Ernest Hemingway", "D. William Faulkner"},
            correctAnswerIndex = 0
        },
        // 13. What is the capital of Australia?
        new questionData { 
            question = "What is the capital of Australia?", 
            answers = new string[] {"A. Sydney", "B. Melbourne", "C. Canberra", "D. Brisbane"},
            correctAnswerIndex = 2
        },
        // 14. Who invented the telephone?
        new questionData { 
            question = "Who invented the telephone?", 
            answers = new string[] {"A. Thomas Edison", "B. Alexander Graham Bell", "C. Nikola Tesla", "D. Guglielmo Marconi"},
            correctAnswerIndex = 1
        },
        // 15. Who painted the Mona Lisa?
        new questionData { 
            question = "Who painted the Mona Lisa?", 
            answers = new string[] {"A. Leonardo da Vinci", "B. Michelangelo", "C. Raphael", "D. Sandro Botticelli"},
            correctAnswerIndex = 0
        },
        // 16. What is the chemical symbol for gold?
        new questionData { 
            question = "What is the chemical symbol for gold?", 
            answers = new string[] {"A. Au", "B. Ag", "C. Fe", "D. Cu"},
            correctAnswerIndex = 0
        },
        // 17. Who wrote the poem "The Waste Land"?
        new questionData { 
            question = "Who wrote the poem 'The Waste Land'?", 
            answers = new string[] {"A. W. B. Yeats", "B. T. S. Eliot", "C. Robert Frost", "D. Sylvia Plath"},
            correctAnswerIndex = 1
        },
        // 18. Who is the current CEO of Amazon?
        new questionData { 
            question = "Who is the current CEO of Amazon?", 
            answers = new string[] {"A. Jeff Bezos", "B. Bill Gates", "C. Elon Musk", "D. Andy Jassy"},
            correctAnswerIndex = 3
        },
        // 19. What is the largest mammal on Earth?
        new questionData {
            question = "What is the largest mammal on Earth?",
            answers = new string[] {"A. Elephant", "B. Blue whale", "C. Hippopotamus", "D. Polar bear"},
            correctAnswerIndex = 1
        },
        // 20. Which country won the 2018 FIFA World Cup?
        new questionData { 
            question = "Which country won the 2018 FIFA World Cup?", 
            answers = new string[] {"A. France", "B. Germany", "C. Brazil", "D. Spain"},
            correctAnswerIndex = 0
        },
        // 21. What is the smallest country in the world?
        new questionData { 
            question = "What is the smallest country in the world?", 
            answers = new string[] {"A. Monaco", "B. Vatican City", "C. Liechtenstein", "D. San Marino"},
            correctAnswerIndex = 1
        },
        // 22. Who wrote the play "Hamlet"?
        new questionData { 
            question = "Who wrote the play 'Hamlet'?", 
            answers = new string[] {"A. William Shakespeare", "B. George Bernard Shaw", "C. Tennessee Williams", "D. Arthur Miller"},
            correctAnswerIndex = 0
        },
        // 23. Who was the first person to step on the Moon?
        new questionData { 
            question = "Who was the first person to step on the Moon?", 
            answers = new string[] {"A. Neil Armstrong", "B. Buzz Aldrin", "C. Yuri Gagarin", "D. Alan Shepard"},
            correctAnswerIndex = 0
        },
        // 24. What is the name of the longest river in Africa?
        new questionData { 
            question = "What is the name of the longest river in Africa?", 
            answers = new string[] {"A. Nile", "B. Congo", "C. Niger", "D. Zambezi"},
            correctAnswerIndex = 0
        }
    };
}
