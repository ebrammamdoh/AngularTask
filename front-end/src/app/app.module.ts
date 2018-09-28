import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { RegisterComponent } from './Components/RegisterComponent/regist-component';
import { HomeComponent } from './Components/HomeComponent/home-component';
import { RegisterService } from './Services/RegisterServices/register-services';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { routes } from './Utilites/app-routes';
import { CustomerFilerPipe } from './Components/RegisterComponent/regist-filter.pipe';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegisterComponent,
    CustomerFilerPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes),

  ],
  providers: [RegisterService],
  bootstrap: [AppComponent]
})
export class AppModule { }
