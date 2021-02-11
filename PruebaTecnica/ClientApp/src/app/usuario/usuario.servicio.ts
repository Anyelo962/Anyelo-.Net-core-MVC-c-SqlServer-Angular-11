import { Component, Injectable } from "@angular/core"
import { HttpClient } from '@angular/common/http'
import { Observable, observable } from 'rxjs'
import { IUsuario } from "src/app/Interface/IUsuario.interface"
import { UsuariosComponent } from "./usuarios.component";
import { environment } from "src/environments/environment"
import { CoreEnvironment } from "@angular/compiler/src/compiler_facade_interface";


@Injectable({
  providedIn: "root"
})

export class ServicioUsuario {
  private baseURL = environment.apiURL + "Usuarios";
  constructor(private http: HttpClient) { }

  getUsuarios(): Observable<IUsuario[]> {
    return this.http.get<IUsuario[]>(this.baseURL);
  }
  crearUsuarios(usuario: IUsuario) {
    return this.http.post(this.baseURL, usuario);
  }
}
