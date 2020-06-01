import { Component, OnInit } from "@angular/core";
import { User } from "../../model/user";
import { Router, ActivatedRoute } from "@angular/router";
import { UserService } from "../../services/user/user.service";


@Component({
  selector: "app-login",
  templateUrl: "./login.components.html",
  styleUrls: ["./login.components.css"]
})
export class LoginComponent implements OnInit {
  public user;
  public returnUrl: string;
  public message: string;
  

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private userService: UserService) {
  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.user = new User();
    }

  enter() {

    this.userService.verifyUser(this.user)
      .subscribe(
        data => {
          var userReturn: User;
          userReturn = data;
          sessionStorage.setItem("auth-user", "1");
          sessionStorage.setItem("email-user", userReturn.email);

          this.router.navigate([this.returnUrl]);
        },
        err => {
          console.log(err.error);
          this.message = err.error;
        }
      );
  }
}
