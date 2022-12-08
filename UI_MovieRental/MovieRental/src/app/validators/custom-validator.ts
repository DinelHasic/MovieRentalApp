import { AbstractControl } from "@angular/forms";

export class CustomValidator
{
  static ValidateUsername(control:AbstractControl) : { [m:string] : boolean} | null
  {
     const value = control.value as string;


     if(!value)
     {
       return {InvalidUsername: true}
     }


     if(value[0] !== value[0].toUpperCase())
     {
        return {InvalidUsername: true}
     }

     return null;
  }
}