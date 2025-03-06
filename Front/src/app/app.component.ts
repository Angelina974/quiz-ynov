import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Quiz } from './business/models/quiz.model';
import { QuizService } from './business/services/quiz.service';
import { Subscription } from 'rxjs';

@Component({
    selector: 'app-root',
    standalone: true,
    imports: [RouterOutlet],
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
    protected quiz: Quiz[] = [];
    subscription?: Subscription;

    constructor(private readonly service: QuizService) {}

    public ngOnInit(): void {
        this.subscription = this.service.list().subscribe(quiz => (this.quiz = quiz));
    }

    public ngOnDestroy(): void {
        this.subscription?.unsubscribe();
    }
}
