

export class FavoriteMovie 
{
  public name!:string;

  public rating!:number;


  constructor(name:string,rating:number){
    this.name = name;
    this.rating = rating;
  }
}