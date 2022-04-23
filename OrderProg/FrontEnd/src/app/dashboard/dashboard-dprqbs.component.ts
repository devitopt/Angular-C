import { Component, Inject, Input, OnInit } from '@angular/core';

import { DprqbModel} from '../models/Dprqs';
import { OrderDetail } from '../models/OrderDetail';
@Component({
  selector: 'app-dashboard-dprqbs',
  templateUrl: './dashboard-dprqbs.component.html',
  styleUrls: ['./dashboard-dprqbs.component.css']
})
export class DashboardDprqbsComponent implements OnInit {
  
  
  @Input() Order: OrderDetail;
  ngOnInit(): void {
    console.log(this.Order);
  }
  
}
