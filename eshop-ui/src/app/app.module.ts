import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewItemsComponent } from './Component/Supplier/view-items/view-items.component';
import { ItemService } from './Services/item.service';
import { AddItemsComponent } from './Component/Supplier/add-items/add-items.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewItemsComponent,
    AddItemsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ItemService],
  bootstrap: [AppComponent]
})
export class AppModule { }
