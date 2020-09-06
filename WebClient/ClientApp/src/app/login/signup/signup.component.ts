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
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  signupFormGroup = new FormGroup(
    {
      "firstName" : new FormControl('',[Validators.required,Validators.nullValidator]),
      "lastName": new FormControl('',Validators.required),
      "email": new FormControl('',[Validators.required,Validators.email]),
      "password" : new FormControl('',Validators.required),
      "confirmPassword": new FormControl('',[Validators.required,Validators.nullValidator])
    }
  );
  constructor() { }

  ngOnInit() {
  }

}
