import { getLocaleDateTimeFormat } from '@angular/common';
import { compilePipeFromMetadata } from '@angular/compiler';
import { ChangeDetectionStrategy } from '@angular/compiler/src/core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AddUserDTO, GetUserDTO } from 'src/app/models/models';
import { AccountService } from 'src/app/services/account/account.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  profileForm = this.formBuilder.group({
    name: ['', Validators.required],
    lastName: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    dateOfBirth: ['', Validators.required],
    userType: ['', Validators.required],
    userStatus: ['', {disabled: true}],
    photo: ['']
  });

  errorMessage: string;
  photoFile: any;
  photoChanged: boolean = false;
  photoPath: string;
  photoMessage: string = 'Choose photo';

  constructor(private accountService: AccountService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.getUser();
    this.profileForm.get('userStatus').disable();
  }

   submit() {
      if (!this.validateForm()) {
         return;
      }
      this.errorMessage = '';
      let user = new AddUserDTO(this.profileForm.controls.email.value, this.profileForm.controls.name.value,
      this.profileForm.controls.lastName.value, this.profileForm.controls.dateOfBirth.value, this.profileForm.controls.userType.value, '');
      this.accountService.update(user).subscribe(
         result => {
            let user = result.data;
            this.populate(user);
            if (this.photoChanged) {
               if (this.photoFile != null) {
                  let formData = new FormData();
                  formData.append('image', this.photoFile, this.photoFile.name);
                  formData.append('id', localStorage['id']);

                  this.accountService.uploadImage(formData).subscribe(
                  result => {
                     console.log(result.data);
                     this.photoPath = `http://localhost:6001/${result.data}`;
                     //this.photoPath = `http://localhost:80/account/${result.data}`;

                     this.photoChanged = false;
                     this.photoFile = null;
                     location.reload();
                  },
                  err => {
                     console.log(err.error.message);
                     window.alert(err.error.message);
                  }
                  );
               }
            }
         },
         err => {
            console.log(err.error.message);
            window.alert(err.error.message);
         }
      );
   }

   onImageChange(event) {
      this.photoFile = <File>event.target.files[0];
      this.photoChanged = true;
      this.photoMessage = this.photoFile.name;
   }

   onSelect(event: any) {
      //this.selectValue = event.target.value;
   }

  getUser() {
    this.accountService.getUser().subscribe(
      result => {
        let user = result.data;
        this.populate(user);
      },
      err => {
        console.log(err.error.message);
      }
    );
  }
  populate(user: any) {
    if (user.name) {
      this.profileForm.controls.name.setValue(user.name);
    }
    if (user.lastName) {
      this.profileForm.controls.lastName.setValue(user.lastName);
    }
    if (user.email) {
      this.profileForm.controls.email.setValue(user.email);
    }
    if (user.dateOfBirth) {
      let fullDate = user.dateOfBirth.split(' ')[0].split('/');
      let formattedDate = `${fullDate[2]}-${fullDate[0]}-${fullDate[1]}`;

      this.profileForm.controls.dateOfBirth.setValue(formattedDate);
    }
    if (user.userType) {
      this.profileForm.controls.userType.setValue(user.userType);
    }
    if (user.photo) {
      this.photoPath = `http://localhost:6001/${user.photo}`;
      //this.photoPath = `http://localhost:80/account/${user.photo}`;
    }
    if (user.userStatus) {
      if (user.userStatus == "InProcess") {
        this.profileForm.controls.userStatus.setValue(`User status: In process`);
      }
      else
      {
        this.profileForm.controls.userStatus.setValue(`User status: ${user.userStatus}`);
      }
    }
  }

  validateForm(): boolean{
   if (this.profileForm.controls.name.errors) {
     this.errorMessage = 'Name is required.';
     return false;
   }
   else if (this.profileForm.controls.lastName.errors) {
     this.errorMessage = 'Last name is required.';
     return false;
   }
   else if (this.profileForm.controls.email.errors) {
     console.log(JSON.stringify(this.profileForm.controls.email.errors));
     if (JSON.stringify(this.profileForm.controls.email.errors).includes('required')) {
       this.errorMessage = 'Email is required.';
     }
     else if (JSON.stringify(this.profileForm.controls.email.errors).includes('email')) {
       this.errorMessage = 'Email format is invalid.';
     }
     return false;
   }
   else if (this.profileForm.controls.dateOfBirth.errors) {
     console.log(this.profileForm.controls.dateOfBirth.errors);
     this.errorMessage = 'Date of birth is required.';
     return false;
   }
   return true;
 }

}
