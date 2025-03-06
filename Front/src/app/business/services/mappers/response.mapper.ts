import { Injectable } from '@angular/core';
import { Responses } from '../../models/response.model';
import { ResponsesDto } from '../dtos/response.dto';

@Injectable({ providedIn: 'root' })
export class ResponseMapper {
    public fromDto(dto: ResponsesDto): Responses {
        return {
            id: dto.id,
            text: dto.text,
            isCorrect: dto.isCorrect
        };
    }

    public toDto(response: Responses): ResponsesDto {
        return {
            id: response.id,
            text: response.text,
            isCorrect: response.isCorrect
        };
    }
}
