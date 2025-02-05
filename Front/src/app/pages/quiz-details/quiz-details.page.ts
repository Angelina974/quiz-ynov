import { Component, Input } from '@angular/core';
import { QuizService } from '../../business/services/quiz.service';
import { Quiz } from '../../business/models/quiz.model';
import { Category } from '../../business/models/category.model';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-quiz-details',
  standalone: true,
  templateUrl: './quiz-details.page.html',
  styleUrls: ['./quiz-details.page.scss'],
  imports: [RouterLink],
})
export class QuizDetailsPage {

  @Input() public readonly id!: string;
  protected quiz?: Quiz;

  constructor(private readonly quizService: QuizService) {}

  ngOnInit(): void {
    this.quizService.get(this.id).subscribe((data) => {
      this.quiz = data;
    });
  }
}
