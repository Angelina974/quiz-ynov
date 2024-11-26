import { Component, input } from '@angular/core';
import { QuizService } from '../../business/services/quiz.service';
import { Quiz } from '../../business/models/quiz.model';


@Component({
  selector: 'app-quiz-details',
  standalone: true,
  imports: [],
  templateUrl: './quiz-details.page.html',
  styleUrl: './quiz-details.page.scss'
})
export class QuizDetailsPage {
  public readonly id = input.required<string>();

  protected quiz?: Quiz;

  constructor(private readonly quizService: QuizService) {}

  ngOnInit(): void {
    this.quizService.get(this.id()).subscribe((data) => {
      this.quiz = data;
    });

  }



}
