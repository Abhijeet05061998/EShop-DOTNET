import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/Models/item';
import { ItemService } from 'src/app/Services/item.service';

@Component({
  selector: 'app-view-items',
  templateUrl: './view-items.component.html',
  styleUrls: ['./view-items.component.css']
})
export class ViewItemsComponent implements OnInit {
  items:Item[]=[];

  constructor(private item_service:ItemService) { 

item_service.GetAllItems().subscribe(Response=>{
  this.items=Response
  console.log(this.items)
},error=>{
  console.log(error);
})

  }

  ngOnInit(): void {
  }

}
