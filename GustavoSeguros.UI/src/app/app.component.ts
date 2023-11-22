import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { SeguroService } from './seguro.service';
import { SeguroCollection } from './models/segurocolletion';

class SeguroView {
  id?: number | string;
  modelo?: string;
  nome?: string;
  valor?: number;
  CPF?: string;
  idade?: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  displayedColumns: string[] = [
    'id',
    'modelo',
    'valor',
    'nome',
    'CPF',
    'idade',
  ];
  dataSource: MatTableDataSource<any, any> = new MatTableDataSource();
  seguroView?: SeguroView[] = [];
  seguroCollection?: SeguroCollection;
  showData: boolean = false;

  ngOnInit() {
    this.getSeguros();
  }

  constructor(private seguroService: SeguroService) {}

  getSeguros() {
    this.seguroService.GetSeguros().subscribe(
      (data: SeguroCollection) => {
        this.seguroCollection = data;
        this.mapSegurosToTable();
        this.showData = true;
      },
      (error) => {
        console.error('Error fetching seguro data:', error);
      }
    );
  }

  mapSegurosToTable() {
    this.seguroCollection?.seguros?.map((e) => {
      this.seguroView?.push({
        id: e.id,
        modelo: e.veiculo?.modelo,
        valor: e.veiculo?.valor,
        nome: e.segurado?.nome,
        CPF: e.segurado?.cpf,
        idade: e.segurado?.idade,
      });
    });
    this.dataSource = new MatTableDataSource(this.seguroView);
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
