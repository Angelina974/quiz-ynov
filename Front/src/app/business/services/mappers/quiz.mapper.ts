import { Injectable } from "@angular/core";
import { Quiz } from "../../models/quiz.model";
import { QuizDto } from "../dtos/quiz.dto";

@Injectable({ providedIn: 'root' })
export class QuizMapper {
    public fromDto(dto: QuizDto): Quiz {
        const { publishedDate, categoryId, ...rest } = dto;
        return { ...rest, publishedDate: new Date(publishedDate), category: { id: categoryId }, question: '' };
    }

    public toDto(data: Quiz): QuizDto {
        const { publishedDate, ...rest } = data;
        return { ...rest, publishedDate: publishedDate.toISOString(), categoryId: '' };
    }
}
