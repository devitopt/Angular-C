import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrderDetail } from '../models/OrderDetail';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { ActionResponse } from '../models/ActionResponse';
import { MsalService } from '@azure/msal-angular';
@Injectable({
  providedIn: 'root'
})
export class OrderServiceService {

  private apiUrl = environment.apiUrl; 
  private apiOrderController = `${this.apiUrl}/Orders`;
  private accessToken: any;
  constructor(private httpClient: HttpClient) { }


getOrderlist():Observable<any>{ 
  // const httpOptions = {
  //   headers: new HttpHeaders({
  //     'Content-Type': 'application/json',
  //     'Authorization': 'Bearer ' + this.GetAccessToken()
  //   })

  // };
  return this.httpClient.get<ActionResponse>(`${this.apiOrderController}/GetOrderList`); 
}

GetOrderById(id): Observable<ActionResponse> {
  return this.httpClient.get<ActionResponse>(`${this.apiOrderController}/GetOrderById/` + id);
  }

   SaveOrder(id: number, order: OrderDetail): Observable<any> {
     return this.httpClient.put<OrderDetail>(`${this.apiOrderController}/SaveOrder/${id}`, order);
   }

 DeleteOrder(id: number): Observable<any> {
   return this.httpClient.delete(`${this.apiOrderController}/DeleteOrder/${id}`);
   }


  public GetAccessToken(): Observable<any> {
    if (localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken") !== undefined && localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken") != null) {
      this.accessToken = localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken");
    }
    return this.accessToken;
  }

  // GetOrder(id): Observable<OrderDetail> {
  //   return this.httpClient.get<OrderDetail>(this.baseUrl + 'WeatherForecast/GetOrderById/' + id);
  // }

  // PutOrder(id: number, order: OrderDetail): Observable<any> {
  //   return this.httpClient.put<OrderDetail>(`${this.baseUrl}WeatherForecast/${id}`, order);
  // }

  // DeleteOrder(id: number): Observable<any> {
  //   return this.httpClient.delete(`${this.baseUrl}WeatherForecast/${id}`);
  // }
}
