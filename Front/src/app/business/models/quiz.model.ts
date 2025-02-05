import { Category } from './category.model';
import { Questions } from './question.model';

export interface Quiz {

  readonly id: string;

  readonly name: string;

  readonly description: string;

  readonly difficulty: number;

  readonly publishedDate: Date;

  readonly category?: Category;

  readonly categoryId: string;

  readonly questions: Questions[];

}
