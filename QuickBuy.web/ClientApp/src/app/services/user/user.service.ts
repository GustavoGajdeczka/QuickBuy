import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { User } from "../../model/user";


@Injectable({
  providedIn: "root"
})
export class UserService {


  private baseURL: string;
  private _user: User;

  set user(user: User) {
    sessionStorage.setItem("auth-user", JSON.stringify(user));
    this._user = user;
  }
  get user(): User {
    let user_json = sessionStorage.getItem("auth-user");
    this._user = JSON.parse(user_json);
    return this._user;
  }

  public auth_user(): boolean {
    return this._user != null && this._user.email != "" && this._user.password != "";
  }

  public clean_session() {
    sessionStorage.setItem("auth-user", "");
    this._user = null;
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verifyUser(user: User): Observable<User> {

    const headers = new HttpHeaders().set('Content-type', 'application/json');
    var body = {
      email: user.email,
      password: user.password
    }
    return this.http.post<User>(this.baseURL + "api/user/VerifyUser", body, { headers });
  }

  public registerUser(user: User): Observable<User> {
    return this.http.post<User>(this.baseURL + "api/user", JSON.stringify(user), { headers: this.headers });
  }
}
