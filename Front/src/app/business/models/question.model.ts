import { Responses } from './response.model';

export interface Questions {
choices: any;

  readonly id: string;

  readonly title: string;

  readonly responses: Responses[];

}
