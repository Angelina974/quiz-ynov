import { QuestionsDto } from './question.dto';
import { CategoryDto } from './category.dto';

export interface QuizDto {
    readonly id: string;

    readonly name: string;

    readonly description: string;

    readonly difficulty: number;

    readonly publishedDate: Date;

    readonly categoryId: string;

    readonly category?: CategoryDto;

    readonly questions?: QuestionsDto[];
}
