import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { QuizMapper } from './mappers/quiz.mapper';
import { QuizDto } from './dtos/quiz.dto';
import { Quiz } from '.././models/quiz.model';


@Injectable({ providedIn: 'root' })
export class QuizService {
    constructor(
        private readonly mapper: QuizMapper,
        private readonly client: HttpClient,
    ) {}

    public list(): Observable<Quiz[]> {
        return this.client
            .get<QuizDto[]>('http://localhost:5085/api/quizzes')
            .pipe(
                map(dtos => {
                    return dtos.map(quiz => this.mapper.fromDto(quiz))
                })
            );
    }

    public get(id: string): Observable<Quiz> {
        return this.client
            .get<QuizDto>(`http://localhost:5085/api/quizzes/${id}`)
            .pipe(
                map(dto => this.mapper.fromDto(dto))
            );
    }

}
