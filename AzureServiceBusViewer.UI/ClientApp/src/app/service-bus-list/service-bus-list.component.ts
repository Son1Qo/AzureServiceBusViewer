import { Component } from '@angular/core';
import { FormBuilder, FormControl } from "@angular/forms";

@Component({
  selector: 'service-bus-list-component',
  templateUrl: './service-bus-list.component.html',
  styleUrls: ['./service-bus-list.component.css']
})
export class ServiceBusListComponent {

  selected = new FormControl(0);
  public isFormVisible: boolean = true;
  public list: ServiceBusConnection[] = [];
  public form = this.formBuilder.group({
    name: '',
    connectionString: ''
  });

  constructor(private formBuilder: FormBuilder) { }


  public Add() : void {
    this.list.push(new ServiceBusConnection(this.form.value.name, this.form.value.connectionString));
    this.isFormVisible = false;
    this.form.reset();
  }

  public Plus(): void {
    this.isFormVisible = true;
  }
}

export class ServiceBusConnection {
  constructor(private name: string, private connectionString: string) { }
}
