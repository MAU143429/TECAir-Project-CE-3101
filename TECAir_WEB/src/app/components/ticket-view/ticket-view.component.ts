import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import { TicketView } from 'src/app/interface/ticket-view'
import html2canvas from 'html2canvas';
import { ConnectionService } from 'src/app/service/connection-service';
import { TicketRequest } from 'src/app/model/ticket-request';
import { Router } from '@angular/router';
import { BaggageService } from 'src/app/service/baggage.service';

@Component({
  selector: 'app-ticket-view',
  templateUrl: './ticket-view.component.html',
  styleUrls: ['./ticket-view.component.css']
})
export class TicketViewComponent implements OnInit {

  ticketinfo:TicketView[] | any;
  newTicketRequest:TicketRequest = new TicketRequest

  // metodo que realiza la descarga del archivo del reporte de conciliacion de maletas
  public downloadTicket(){
    // Extraemos el archivo
    const DATA: any = document.getElementById('htmlData');
    const doc = new jsPDF('p', 'pt', 'a4');
    const options = {
      background: 'white',
      scale: 3,
      allowTaint : true,
      useCORS: true
    };
    html2canvas(DATA, options,).then((canvas) => {

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
      docResult.save(`${new Date().toISOString()}_comprobante-de-pago.pdf`);
    });
  }

  async delay(ms: number) {
    await new Promise<void>(resolve => setTimeout(()=>resolve(), ms)).then(()=>console.log("fired"));
  }

  constructor(private service:BaggageService,private connectionService:ConnectionService, private router:Router) { }

  ngOnInit(): void {
    this.delay(100).then(()=>{
      this.createTicketView(this.connectionService.getNoVueloEvent(),this.connectionService.getNoTransaccionEvent())
    });
  }

  /** 
 * Este metodo permite realizar la peticion de un detalle para una reservacion en particular
 * @param data1 numero de vuelo
 * @param data2 numero de reserva
 */
   createTicketView(data1:any,data2:any){
    this.newTicketRequest.no_vuelo = data1
    this.newTicketRequest.no_transaccion = data2
    this.service.getFullTicket(this.newTicketRequest).subscribe(ticket => (this.ticketinfo = ticket));
  }

}
