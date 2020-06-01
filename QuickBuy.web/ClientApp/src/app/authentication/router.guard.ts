import { Injectable } from "@angular/core"
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router"

@Injectable({
  providedIn: 'root'
})
export class RouterGuard implements CanActivate {
  
  constructor(private router: Router) {

    }


  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var auth = sessionStorage.getItem("auth-user");
    if (auth == "1") {
      return true;
    }
    this.router.navigate(['/enter'], { queryParams: { returnUrl: state.url } });
      return false;
    }
    

}
