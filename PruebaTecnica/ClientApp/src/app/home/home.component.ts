import { Component, OnInit } from '@angular/core';
import { ServicioUsuario } from '../usuario/usuario.servicio'
import { UsuariosComponent } from '../usuario/usuarios.component';
import { IUsuario } from "src/app/interface/IUsuario.interface"

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

 
  Usuario: IUsuario[];

  constructor(private servicioUsuario: ServicioUsuario) { }

  ngOnInit() {
    this.servicioUsuario.getUsuarios().subscribe(x => {
      this.Usuario = x;
    }, error => console.log(error));
  }



}
