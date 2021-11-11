import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddItemsComponent } from './Component/Supplier/add-items/add-items.component';
import { ViewItemsComponent } from './Component/Supplier/view-items/view-items.component';

const routes: Routes = [

{path:'view-items',component:ViewItemsComponent},
{path:'add-items',component:AddItemsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
