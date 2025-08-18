import { Component, inject, input, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ButtonComponent } from '../../components/button/button.component';
//import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-inventory',
  imports: [ButtonComponent, FormsModule,
    CommonModule],
  templateUrl: 'inventory.component.html',
  styleUrl: 'inventory.component.css'
})

export class InventoryComponent implements OnInit {
  constructor(private httpClient: HttpClient) { }

  inventoryDetails: any;

  inventoryData = {
    productId: "",
    comicTitle: "",
    comicPrice: "",
    imagePath: "",
    quantity: "",    
  }

  ngOnInit() {
    this.getInventoryData();
  }

  getInventoryData() {
    let apiUrl = "https://localhost:7196/Inventory";

    this.httpClient.get(apiUrl).subscribe(data => {
      this.inventoryDetails = data;
    });

    this.inventoryData = {
      productId: "",
      comicTitle: "",
      comicPrice: "",
      imagePath: "",
      quantity: ""
    };
  }

}
