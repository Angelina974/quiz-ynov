import { Injectable } from '@angular/core';
import { Quiz } from '../../models/quiz.model';
import { QuizDto } from '../dtos/quiz.dto';
import { CategoryMapper } from './category.mapper';
import { QuestionMapper } from './question.mapper';
import { Category } from '../../models/category.model';


@Injectable({ providedIn: 'root' })
export class QuizMapper {
  constructor(
    private readonly categoryMapper: CategoryMapper,
    private readonly questionMapper: QuestionMapper
  ) {}

        public fromDto(dto: QuizDto): Quiz {
          return {
            id: dto.id,
            name: dto.name,
            description: dto.description || '',
            publishedDate: new Date(dto.publishedDate),
            categoryId: dto.categoryId,         // Mapper uniquement l'ID de la catégorie
            category: this.categoryMapper.fromDto(dto.category || { id: '', name: '' }),
            difficulty: dto.difficulty || 0,
            questions: dto.questions ? dto.questions.map(q => this.questionMapper.fromDto(q)) : []
          };
        }


  public toDto(quiz: Quiz): QuizDto {
    return {
      id: quiz.id,
      name: quiz.name,
      description: quiz.description,
      publishedDate: new Date(quiz.publishedDate),
      categoryId: quiz.categoryId,
      difficulty: quiz.difficulty,
      questions: quiz.questions.map(question => this.questionMapper.toDto(question))
    };
  }
}
