using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server
{
    public class Question
    {
        /* {
            "category": "Entertainment: Television",
            "type": "multiple",
            "difficulty": "medium",
            "question": "In the original Doctor Who series (1963), fourth doctor Tom Baker&#039;s scarf was how long?",
            "correct_answer": "7 Meters",
            "incorrect_answers": [
                "10 Meters",
                "2 Meters",
                "5 Meters"
            ]
        },*/
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }

        public List<string> incorrect_answers { get; set; }

    }

    public class Quizz
    {
        public string response_code { get; set; }
        public List<Question> results { get; set; }
    }
}