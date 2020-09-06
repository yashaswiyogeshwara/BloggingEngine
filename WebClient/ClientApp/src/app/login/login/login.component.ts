import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroupDirective, NgForm, Validators, FormGroup} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';



/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  userLoginFormGroup = new FormGroup({
    "email" : new FormControl('',[Validators.required,Validators.email]),
    "password": new FormControl('',)
  })
  
  matcher = new MyErrorStateMatcher();
  constructor() {     

  }

  ngOnInit() {

  }

  OnSubmit():void{
    console.log(this.userLoginFormGroup);
    
    this.userLoginFormGroup.controls['email']
  }

}
