
export interface IUsuario {
  nombre: string;
  apellido: string;
  cedula: string;
  fechaNacimiento: Date;
  departamento?: string[];
  cargo: string;
  supervisorInmediato: string;
}
