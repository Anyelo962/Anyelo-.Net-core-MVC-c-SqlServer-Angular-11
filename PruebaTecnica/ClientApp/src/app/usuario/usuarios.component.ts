import { Component, Inject, Injectable, OnInit } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { getBaseUrl } from '../../main';
import { IUsuario } from "src/app/Interface/IUsuario.interface"
import { ServicioUsuario } from './usuario.servicio';
import { userInfo } from 'os';
@Component({
  selector: "usuarios-list",
  templateUrl: "./usuarios.component.html"
})

  @Injectable({
    providedIn: 'root'
})

export class UsuariosComponent implements OnInit  {
  model: IUsuario = { nombre: '', apellido: '', cedula: '', fechaNacimiento: null, departamento: null, cargo: '', supervisorInmediato: '' };

  constructor(private ServicioUsuario: ServicioUsuario) { }

  ngOnInit() {

  }

  onSubmit() {
    this.ServicioUsuario.crearUsuarios(this.model).subscribe(x => console.log(x));
  }


}
