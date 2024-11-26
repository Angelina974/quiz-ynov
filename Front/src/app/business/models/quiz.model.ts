import { Category } from './category.model';

export interface Quiz {
  readonly id: string;

  readonly name: string;

  readonly description: string;

  readonly difficulty: number;

  readonly publishedDate: Date;

  readonly category: Category;

  readonly question: string;

}
