import { Component, OnInit, Input } from '@angular/core';
import { OrderDetail } from '../models/OrderDetail';
import { MatDialog } from '@angular/material/dialog';
import { FactoryModalComponent } from './factory-modal/factory-modal.component';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { startWith,map } from 'rxjs/operators';

@Component({
  selector: 'app-dashboard-production',
  templateUrl: './dashboard-production.component.html',
  styleUrls: ['./dashboard-production.component.css']
})
export class DashboardProductionComponent implements OnInit {
  myControl = new FormControl();
  filteredOptions: Observable<string[]>;
  constructor(public dialog: MatDialog,) { }
  @Input() Order: OrderDetail;
  ngOnInit(): void {
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(val => this.filter(val))
    );
  }
  filter(val: string): string[] {
    return this.Order.factories.map(x => x.title).filter(option =>
      option.toLowerCase().includes(val.toLowerCase()));
  }
  factoryModal() {
    const dialogRef = this.dialog.open(FactoryModalComponent, {
      data: this.Order.factories
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      if (res) {
        this.Order.otherOrders.push(res);
      }
    });
  }

  removeFactory(index) {
    this.Order.otherOrders.splice(index, 1);
  }

}
