import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';
import { BaggageReport } from 'src/app/interface/baggage-report';
import { PassangersReport } from 'src/app/interface/passangers-report';
import { FlightsService } from 'src/app/service/flights.service';
import { ConnectionService } from 'src/app/service/connection-service';
import { CloseFlight } from 'src/app/model/close-flight';
import { Router } from '@angular/router';


@Component({
  selector: 'app-flight-summary',
  templateUrl: './flight-summary.component.html',
  styleUrls: ['./flight-summary.component.css']
})
export class FlightSummaryComponent implements OnInit {

  baggageData:BaggageReport[] | any;

  passangerData:PassangersReport[]|any;
 
  newBaggageReport:CloseFlight = new CloseFlight

  newPassangerReport:CloseFlight = new CloseFlight

  constructor(private service:FlightsService,private connectionService:ConnectionService, private router:Router) { }

  async delay(ms: number) {
    await new Promise<void>(resolve => setTimeout(()=>resolve(), ms)).then(()=>console.log("fired"));
  }

  ngOnInit(): void {
    this.delay(100).then(()=>{
      this.createBaggageReport(this.newBaggageReport,this.connectionService.getNoVueloEvent())
      this.createPassangerReport(this.newPassangerReport,this.connectionService.getNoVueloEvent())
    });
  }


   // metodo que realiza la descarga del archivo del reporte de conciliacion de maletas
   public downloadGeneralReport(){
    // Extraemos el archivo
    const DATA: any = document.getElementById('htmlData');
    const doc = new jsPDF('p', 'pt', 'a4');
    const options = {
      background: 'white',
      scale: 3
    };
    html2canvas(DATA, options).then((canvas) => {

      const img = canvas.toDataURL('image/PNG');

      // Se agrega la imagen creada al PDF
      const bufferX = 15;
      const bufferY = 15;
      const imgProps = (doc as any).getImageProperties(img);
      const pdfWidth = doc.internal.pageSize.getWidth() - 2 * bufferX;
      const pdfHeight = (imgProps.height * pdfWidth) / imgProps.width;
      doc.addImage(img, 'PNG', bufferX, bufferY, pdfWidth, pdfHeight, undefined, 'FAST');
      return doc;
    }).then((docResult) => {
      docResult.save(`${new Date().toISOString()}_reporte-conciliación.pdf`);
    });
  }

    /** 
    * Este metodo permite realizar la peticion de un detalle para un cierre de vuelo.
    * @param newBaggageReport es el objeto que almacenara los detalles de numero de vuelo 
    * @param data1 numero de vuelo
    */
     createBaggageReport(newBaggageReport:CloseFlight, data1:any){
      newBaggageReport.no_vuelo = data1
      this.service.getBaggageReport(newBaggageReport).subscribe(ticket => (this.baggageData = ticket));
    }

    /** 
    * Este metodo permite realizar la peticion de todos los pasajeros de un vuelo
    * @param newBaggageReport es el objeto que almacenara los detalles de numero de vuelo 
    * @param data1 numero de vuelo
    */
     createPassangerReport(newPassangerReport:CloseFlight, data1:any){
      newPassangerReport.no_vuelo = data1
      this.service.getPassangerReport(newPassangerReport).subscribe(passanger => (this.passangerData = passanger));
    }

}
 