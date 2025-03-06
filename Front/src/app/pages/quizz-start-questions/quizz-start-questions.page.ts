import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { QuizService } from '../../business/services/quiz.service';
import { Questions } from '../../business/models/question.model';
import { Responses } from '../../business/models/response.model';
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-quizz-start-questions',
    templateUrl: './quizz-start-questions.page.html',
    styleUrls: ['./quizz-start-questions.page.scss'],
    imports: [RouterLink],
    standalone: true
})
export class QuizzStartQuestions implements OnInit {
    questions: Questions[] = [];
    currentQuestionIndex: number = 0;
    selectedAnswer: Responses | null = null;
    showResult: boolean = false;
    correctAnswers: number = 0;

    constructor(
        private route: ActivatedRoute,
        private quizService: QuizService
    ) {}

    ngOnInit(): void {
        const quizId = this.route.snapshot.paramMap.get('id');
        if (quizId) {
            this.quizService.getQuestions(quizId).subscribe(questions => {
                this.questions = questions;
            });
        }
    }

    get currentQuestion(): Questions {
        return this.questions[this.currentQuestionIndex];
    }

    nextQuestion(): void {
        if (this.selectedAnswer?.isCorrect) {
            this.correctAnswers++;
        }
        this.selectedAnswer = null;
        if (this.currentQuestionIndex < this.questions.length - 1) {
            this.currentQuestionIndex++;
        } else {
            this.showResult = true;
        }
    }

    restartQuiz(): void {
        this.currentQuestionIndex = 0;
        this.selectedAnswer = null;
        this.showResult = false;
        this.correctAnswers = 0;
    }
}
