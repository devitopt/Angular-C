import { Component, OnInit, Input } from '@angular/core';

import { OrderDetail } from '../models/OrderDetail';

@Component({
  selector: 'app-dashboard-general',
  templateUrl: './dashboard-general.component.html',
  styleUrls: ['./dashboard-general.component.css']
})
export class DashboardGeneralComponent implements OnInit {
@Input() Order: OrderDetail;
  constructor() { 
  
  }

  ngOnInit(): void {
  }

}
