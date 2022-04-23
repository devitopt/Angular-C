import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from 'src/environments/environment';
import { ActionResponse } from './models/ActionResponse';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
   
  private apiUrl = environment.apiUrl; 
  private apiOrderController = `${this.apiUrl}/Orders` ;
constructor(private http:HttpClient) { }

 // getOrderlist():Observable<any>{ return this.http.get<ActionResponse>(`${this.apiOrderController}/GetOrderList`); }

  // addOrder(val:any){
  //   return this.http.post(`${this.apiOrderController}/AddOrder`,val)
  // }

  // updateOrder(val:any) {
  //   return this.http.put(`${this.apiOrderController}/UpdateOrder`,val)
  // }

  // deleteOrder(val:any) {
  //   return this.http.delete(this.apiOrderController+val)
  // }
}
