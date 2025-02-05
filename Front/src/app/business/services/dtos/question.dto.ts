import { ResponsesDto } from "./response.dto";

export interface QuestionsDto {

  readonly id: string;

  readonly title: string;

  readonly responses: ResponsesDto[];

}
