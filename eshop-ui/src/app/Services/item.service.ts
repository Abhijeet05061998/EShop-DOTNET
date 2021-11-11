import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Item } from '../Models/item';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  Item_Url='http://localhost:55162/api/Item/'

  constructor(private http:HttpClient) { }
  GetAllItems():Observable<Item[]>
  {
    return this.http.get<Item[]>(this.Item_Url + 'GetAll');
  }
  AddItems(item:Item):Observable<any>
  {
    return this.http.post(this.Item_Url + 'AddItem',item);
  }
}
