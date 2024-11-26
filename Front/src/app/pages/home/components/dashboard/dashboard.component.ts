import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { QuizService } from '../../../../business/services/quiz.service';
import { Quiz } from '../../../../business/models/quiz.model';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {
  public quizzes: Quiz[] = [];

  constructor(private readonly quizService: QuizService) {}

  ngOnInit(): void {
    this.quizService
      .list()
      .subscribe((data) => {
        this.quizzes = data;
      })
    ;
  }
}
