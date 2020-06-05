import { Component, OnInit } from "@angular/core";
import { User } from "../../model/user";
import { UserService } from "../../services/user/user.service";

@Component({
  selector: "register-user",
  templateUrl: "./register.user.component.html",
  styleUrls: ["./register.user.component.css"]
})

export class RegisterUserComponent implements OnInit {

  public user: User;
  public active_spinner: boolean;
  public message: string;
  public registeredUser: boolean;

  constructor(private userService: UserService) {

  }

  ngOnInit(): void {
    this.user = new User();
  }

  public register() {
    this.active_spinner = true;
    this.userService.registerUser(this.user)
      .subscribe(
        userJson => {
          this.registeredUser = true;
          this.message = "";
          this.active_spinner = false;
        }, e => {
          this.message = e.error;
          this.active_spinner = false;
        }
      );

  }

}
