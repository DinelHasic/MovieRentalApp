import { Pipe, PipeTransform } from '@angular/core';
import { Genre } from '../movie/genre.module';

@Pipe({
  name: 'genre',
})
export class GenrePipe implements PipeTransform {
  transform(value: number, ...args: unknown[]): unknown {
    return 0;
  }
}
