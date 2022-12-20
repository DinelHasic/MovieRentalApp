export interface NewMovie {
    id: number;
  
    title: string;
  
    description: string;
  
    genres: Array<number>;
  
    directors: Array<number>;
  
    year: Date;
  
    imageUrl: string;
  }