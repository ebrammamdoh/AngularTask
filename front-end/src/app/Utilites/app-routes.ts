import { Routes } from "@angular/router";
import { HomeComponent } from "../Components/HomeComponent/home-component";
import { RegisterComponent } from "../Components/RegisterComponent/regist-component";


export const routes:Routes = [
    { path:'Home', component: HomeComponent},
    { path:'Register', component: RegisterComponent},
    { path: '', redirectTo: 'Home', pathMatch: 'full' },
    { path: '**', component: HomeComponent }
]