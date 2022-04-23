import { Component, OnInit, Input } from '@angular/core';
import { OrderDetail } from '../models/OrderDetail';
import { FactoryModalComponent } from './factory-modal/factory-modal.component';
import { MatDialog } from '@angular/material/dialog';
import { StyleModalComponent } from './style-modal/style-modal.component';

@Component({
  selector: 'app-dashboard-style',
  templateUrl: './dashboard-style.component.html',
  styleUrls: ['./dashboard-style.component.css']
})
export class DashboardStyleComponent implements OnInit {

  constructor(public dialog: MatDialog,) { }
  @Input() Order: OrderDetail;
  ngOnInit(): void {
  }
  openStyleModal(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.Order.orderStyles[index];
    }
    const dialogRef = this.dialog.open(StyleModalComponent, {
      height: '90%',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      console.log('order: ', this.Order);
      console.log('orderStyles: ', this.Order.orderStyles);
      if (res) {
        if (isEdit) {
          this.Order.orderStyles[index] = res;
        } else {
          this.Order.orderStyles.push(res);
        }
      }
    });
  }

  removeStyle(index) {
    this.Order.orderStyles.splice(index, 1);
  }

  
}
