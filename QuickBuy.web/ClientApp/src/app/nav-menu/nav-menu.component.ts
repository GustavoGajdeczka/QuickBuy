import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public loggedUser(): boolean {
    return sessionStorage.getItem("auth-user") == "1";
  }

  leave() {
    sessionStorage.setItem("auth-user", "");
    this.router.navigate(['/']);
  }
}
