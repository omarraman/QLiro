import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { SimulationComponent } from './simulation/simulation.component';
import { HttpClientModule } from '@angular/common/http';

import {
  DxNumberBoxModule,
  DxCheckBoxModule,
  DxButtonModule
} from 'devextreme-angular';

@NgModule({
  declarations: [
    AppComponent,
    SimulationComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    DxNumberBoxModule,DxCheckBoxModule,DxButtonModule
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
