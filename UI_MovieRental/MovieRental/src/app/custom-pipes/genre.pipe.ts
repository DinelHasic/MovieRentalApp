import { Pipe, PipeTransform } from '@angular/core';
import { Genre } from '../movie/genre.enum';

@Pipe({
  name: 'genre'
})
export class GenrePipe implements PipeTransform {

  transform(value: number, ...args: unknown[]): unknown {
    return Genre[value];
  }

}
