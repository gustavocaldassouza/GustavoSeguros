import { Segurado } from './segurado';
import { Veiculo } from './veiculo';

export class Seguro {
  id?: number;
  veiculo?: Veiculo;
  segurado?: Segurado;
}
