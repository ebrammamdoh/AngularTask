import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Customer } from "../../Models/customer";


const URL = "http://localhost:5500/api/customer";
const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

@Injectable()
export class RegisterService {

    constructor(private http:HttpClient){ }

    getCustomers(): Observable<Customer[]> {
      return this.http.get<Customer[]>(URL);
    }
  
    addCustomer(entity: Customer): Observable<Customer> {
      return this.http.post<Customer>(URL, entity, httpOptions);
    }
  
    deleteCustomer(id: number): Observable<Customer> {
      return this.http.delete<Customer>(URL + id.toString(), httpOptions);
    }
}