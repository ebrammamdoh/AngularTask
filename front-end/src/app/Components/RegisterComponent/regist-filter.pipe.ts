import { Pipe, PipeTransform } from "@angular/core";
import { Customer } from "../../Models/customer";


@Pipe({
    name: 'customerFilter'
})
export class CustomerFilerPipe implements PipeTransform{
    transform(value: Customer[], filterBy: string): Customer[] {
        filterBy = filterBy? filterBy.toLocaleLowerCase(): null;
        return filterBy ? value.filter((customer: Customer) => 
        customer.firstName.toLocaleLowerCase().indexOf(filterBy) !== -1): value;
    }

}