import { Component } from "@angular/core";
import { User } from "../../model/user";
import { Router } from "@angular/router";


@Component({
  selector: "app-login",
  templateUrl: "./login.components.html",
  styleUrls: ["./login.components.css"]
})
export class LoginComponent {
  public user;
  

  constructor(private router: Router) {
    this.user = new User();
  }

  enter() {
    if (this.user.email == "gustavo@teste.com" && this.user.password == "1234") {
      sessionStorage.setItem("auth-user", "1");
      this.router.navigate(['/']);
    }
  }
  on_keypress() {

  }
}
