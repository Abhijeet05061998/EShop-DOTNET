import { Component, OnInit } from '@angular/core';
import { Item } from 'src/app/Models/item';
import { ItemService } from 'src/app/Services/item.service';

@Component({
  selector: 'app-add-items',
  templateUrl: './add-items.component.html',
  styleUrls: ['./add-items.component.css']
})
export class AddItemsComponent implements OnInit {
  item:Item;

  constructor(private item_services:ItemService) { 
    this.item=new Item();
  }

  ngOnInit(): void {
  }
  AddItems()
  {
    console.log(this.item)
    this.item_services.AddItems(this.item).subscribe(Response=>{
      

    },error=>{
      console.log(error)
    })
  }

}
