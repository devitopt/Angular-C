import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { MsalService } from '@azure/msal-angular';
@Injectable({
    providedIn: 'root'
  })
export class AuthInterceptor implements HttpInterceptor {
        constructor(private authService: MsalService) { }
        
    intercept(req: HttpRequest<any>,
              next: HttpHandler): Observable<HttpEvent<any>> {

        this.authService.getLogger()
        const id_token = this.GetAccessToken();

        if (id_token) {
            const cloned = req.clone({
                headers: req.headers.set("Authorization",
                    "Bearer " + id_token)
            });

            return next.handle(cloned);
        }
        else {
            return next.handle(req);
        }
    }
    public GetAccessToken()  {

        if (localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken") !== undefined && localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken") != null) {
            return localStorage.getItem("msal.22db4210-6a8f-4538-a645-ab8f4256b4fd.idtoken");
        }
        return "";
    }
}


