
import { NgModule } from '@angular/core';
import { RouterModule, Router, Routes } from '@angular/router'

import { AdminLayoutComponent } from './components/layouts/admin-layout/admin-layout.component';
import { LoginComponent } from "./components/login/login.component";
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { SettingsComponent } from "./components/settings/settings.component";
import { NotFoundComponent } from "./components/not-found/not-found.component";
import { HomeComponent } from "./components/home/home.component";
import { AuthService } from './services/auth.service';
import { AuthGuard } from './services/auth-guard.service';


@NgModule({
    imports: [
        RouterModule.forRoot([
            //{ path: '', component: DashboardComponent, canActivate: [AuthGuard], data: { title: "Dashboard" } },
            { path: "login", component: LoginComponent, data: { title: "Login" } },
            { path: "", canActivate: [AuthGuard], redirectTo: '/', pathMatch: 'full', },
            {
                path: '', canActivate: [AuthGuard], component: AdminLayoutComponent, children: [
                {
                    path: '', loadChildren: './components/layouts/admin-layout/admin-layout.module#AdminLayoutModule'
                }]
            },
            { path: "settings", component: SettingsComponent, canActivate: [AuthGuard], data: { title: "Settings" } },
            

            //{ path: "home", redirectTo: "/", pathMatch: "full" },
            //{ path: "", component: HomeComponent, canActivate: [AuthGuard], data: { title: "Home" } },
        ])
    ],
    exports: [
        RouterModule
    ],
    providers: [
        AuthService, AuthGuard
    ]
})
export class AppRoutingModule { }
