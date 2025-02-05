import { Injectable } from '@angular/core';
import { Questions } from '../../models/question.model';
import { QuestionsDto } from '../dtos/question.dto';
import { ResponseMapper } from './response.mapper';

@Injectable({ providedIn: 'root' })
export class QuestionMapper {
  constructor(private readonly responseMapper: ResponseMapper) {}

  public fromDto(dto: QuestionsDto): Questions {
    return {
      id: dto.id,
      title: dto.title,
      choices: [], // Add the 'choices' property here
      responses: dto.responses.map(response => this.responseMapper.fromDto(response))
    };
  }

  public toDto(question: Questions): QuestionsDto {
    return {
      id: question.id,
      title: question.title,
      responses: question.responses.map(response => this.responseMapper.toDto(response))
    };
  }
}
