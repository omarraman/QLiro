import {Component, OnInit, ViewChild} from '@angular/core';
import {DxButtonComponent, DxCheckBoxComponent, DxNumberBoxComponent} from 'devextreme-angular';
import {RunSimulationService} from './services/run-simulation.service';
import {tap} from 'rxjs/operators';

@Component({
  selector: 'app-simulation',
  templateUrl: './simulation.component.html',
  styleUrls: ['./simulation.component.css']
})
export class SimulationComponent implements OnInit {

  @ViewChild(DxNumberBoxComponent) numberOfSimulationsNumberBox: DxNumberBoxComponent;
  @ViewChild(DxCheckBoxComponent) switchedCheckBox: DxCheckBoxComponent;
  result:number;

  constructor(private _simulationService: RunSimulationService) { }

  ngOnInit(): void {
  }

  runSimulation(){
    const numberOfSimulations:number = this.numberOfSimulationsNumberBox.value;
    const hasSwitched:boolean = this.switchedCheckBox.value;
    this._simulationService.execute(numberOfSimulations,hasSwitched).pipe(
      tap(res=>this.result=res)
    ).subscribe();

  }
}
