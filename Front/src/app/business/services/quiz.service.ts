import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { QuizMapper } from './mappers/quiz.mapper';
import { QuestionMapper } from './mappers/question.mapper';
import { Quiz } from '../models/quiz.model';
import { Questions } from '../models/question.model';
import { QuizDto } from './dtos/quiz.dto';
import { QuestionsDto } from './dtos/question.dto';
import { Category } from '../models/category.model';
import { CategoryMapper } from './mappers/category.mapper';

@Injectable({ providedIn: 'root' })
export class QuizService {
    constructor(
        private readonly quizMapper: QuizMapper,
        private readonly questionMapper: QuestionMapper,
        private readonly client: HttpClient,
        private readonly categoryMapper: CategoryMapper
    ) {}

    public list(): Observable<Quiz[]> {
        return this.client.get<QuizDto[]>('http://localhost:5085/api/quizzes').pipe(
            map(dtos => {
                return dtos.map(dto => this.quizMapper.fromDto(dto));
            })
        );
    }
    public get(id: string): Observable<Quiz> {
        return this.client.get<QuizDto>(`http://localhost:5085/api/quizzes/${id}`).pipe(
            map(dto => {
                return this.quizMapper.fromDto(dto);
            })
        );
    }

    public getQuestions(id: string): Observable<Questions[]> {
        return this.client
            .get<QuestionsDto[]>(`http://localhost:5085/api/quizzes/${id}/questions`)
            .pipe(map(dtos => dtos.map(dto => this.questionMapper.fromDto(dto))));
    }

    public getQuizzesByCategoryId(categoryId: string): Observable<QuizDto[]> {
      return this.client.get<QuizDto[]>(`http://localhost:5085/api/quizzes/by-category/${categoryId}`);
    }

}
