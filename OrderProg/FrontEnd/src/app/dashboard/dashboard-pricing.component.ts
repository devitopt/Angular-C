import { Component, OnInit, Input } from '@angular/core';
import { OrderDetail } from '../models/OrderDetail';
import { MatDialog } from '@angular/material/dialog';
import { PricingModal2Component } from './pricing-modal2/pricing-modal2.component';
import { MarkdownData, MarkupData } from './dashboard.component';
import { PricingModal1Component } from './pricing-modal1/pricing-modal1.component';

@Component({
  selector: 'app-dashboard-pricing',
  templateUrl: './dashboard-pricing.component.html',
  styleUrls: ['./dashboard-pricing.component.css']
})
export class DashboardPricingComponent implements OnInit {
  
  markupTable: MarkupData[] = [
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
  ];
  markdownTable: MarkdownData[] = [
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
  ];
  constructor(
    public dialog: MatDialog,
  ) { }
  @Input() Order: OrderDetail;

  ngOnInit(): void {
  }

  openPricingModal1(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.markupTable[index];
    }
    const dialogRef = this.dialog.open(PricingModal1Component, {
      width: '550px',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      if (res) {
        if (isEdit) {
          this.markupTable[index] = res;
        } else {
          this.markupTable.push(res);
        }
      }
    });
  }
  openPricingModal2(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.markdownTable[index];
    }
    const dialogRef = this.dialog.open(PricingModal2Component, {
      width: '550px',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
        console.log(res);
        if (res) {
          if (isEdit) {
            this.markdownTable[index] = res;
          } else {
            this.markdownTable.push(res);
          }
        }
    });
  }
  removeMarkdown(index) {
    this.markdownTable.splice(index, 1);
  }
  removeMarkup(index) {
    this.markupTable.splice(index, 1);
  }
}
