import {
  Directive,
  ElementRef,
  HostBinding,
  HostListener,
  Input,
  OnInit,
  Renderer2,
} from '@angular/core';

@Directive({
  selector: '[backgroundColorGreen]',
})
export class BackgroundColorGreenDirective implements OnInit {
  @Input() defaultColor: string = 'orange';
  @Input() hightailedColor: string = '#cc7000';

  @HostBinding('style.backgroundColor') backgroundColor!: string;

  // private renderer!:Renderer2;

  // private elementRef!:ElementRef<HTMLElement>;

  constructor() {}
  // constructor(elementRef:ElementRef,render:Renderer2)
  //  {

  //      this.elementRef = elementRef
  //      this.renderer = render;
  //  }

  ngOnInit(): void {
    // this.renderer.setStyle(this.elementRef.nativeElement,'backgroundColor','orange');
    this.backgroundColor = this.defaultColor;
  }

  @HostListener('mouseover') mouseover(eventData: Event) {
    this.backgroundColor = this.hightailedColor;
    // this.renderer.setStyle(this.elementRef.nativeElement,'backgroundColor','green');
  }

  @HostListener('mouseleave') mouseleave(eventData: Event) {
    // this.renderer.setStyle(this.elementRef.nativeElement,'backgroundColor','orange');
    this.backgroundColor = this.defaultColor;
  }
}
