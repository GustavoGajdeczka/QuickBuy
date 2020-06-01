import { Component } from "@angular/core";
import { User } from "../../model/user";


@Component({
  selector: "app-login",
  templateUrl: "./login.components.html",
  styleUrls: ["./login.components.css"]
})
export class LoginComponent {
  public user;
  

  constructor() {
    this.user = new User();
  }

  enter() {
    
  }
  on_keypress() {

  }
}
