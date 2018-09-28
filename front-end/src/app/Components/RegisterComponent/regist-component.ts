import { Component, OnInit } from "@angular/core";
import { Customer } from "../../Models/customer";
import { RegisterService } from "../../Services/RegisterServices/register-services";


@Component({
    templateUrl: './regist-component.html',
    styleUrls: ['./regist-component.css']
})
export class RegisterComponent implements OnInit{
    

    customers: Customer[] = [];
    customer:Customer = new Customer();
    filterKey: string = "";
    constructor(private _registerService:RegisterService){}

    ngOnInit(): void {
        this._registerService.getCustomers().subscribe(
            customers => this.customers = customers
        );
    }

    saveData(): void{
        this._registerService.addCustomer(this.customer).subscribe(
            customer => this.customer = customer
        );
    }
    deleteCustomer(id:number): void{
        if (confirm("Delete this customer?")) {
            alert(id);
            this._registerService.deleteCustomer(id)
              .subscribe(() => this.customers = this.customers.filter(c => c.customerId != id));
        }
    }
    reset(): void{
        this.customer = new Customer();
    }
}