import { Injectable } from '@angular/core';
import { Category } from '../../models/category.model';
import { CategoryDto } from '../dtos/category.dto';

@Injectable({ providedIn: 'root' })
export class CategoryMapper {
  public fromDto(dto: CategoryDto): Category {
    return {
      id: dto.id,
      name: dto.name
    };
  }

  public toDto(category: Category): CategoryDto {
    return {
      id: category.id,
      name: category.name
    };
  }
}
