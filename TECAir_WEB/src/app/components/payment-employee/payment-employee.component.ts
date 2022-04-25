import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';
import { Router } from '@angular/router';
import { ReservationData } from 'src/app/interface/reservation-data';
import { ReservationDetails } from 'src/app/model/reservation-details';
import { ConnectionService } from 'src/app/service/connection-service';
import { BookingsService } from 'src/app/service/bookings.service';

@Component({
  selector: 'app-payment-employee',
  templateUrl: './payment-employee.component.html',
  styleUrls: ['./payment-employee.component.css']
})
export class PaymentEmployeeComponent implements OnInit {

  ticketinfo:ReservationData[] | any;
  newReservationDetails:ReservationDetails = new ReservationDetails

  async delay(ms: number) {
    await new Promise<void>(resolve => setTimeout(()=>resolve(), ms)).then(()=>console.log("fired"));
  }
// metodo que realiza la descarga del archivo del reporte de conciliacion de maletas
public downloadGeneralReport(){
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

constructor(private service:BookingsService,private connectionService:ConnectionService, private router:Router) { }

ngOnInit(): void {
  this.delay(100).then(()=>{
    this.createTicketPayment(this.newReservationDetails,this.connectionService.getNoVueloEvent(),this.connectionService.getNoTransaccionEvent())
  });
}

/** 
* Este metodo permite realizar la peticion de un detalle para un tiquete en particular
* @param newReservationDetails es el objeto que almacenara los detalles de numero de vuelo y reserva
* @param data1 numero de vuelo
* @param data2 numero de reserva
*/
 createTicketPayment(newReservationDetails:ReservationDetails, data1:any,data2:any){
  newReservationDetails.no_vuelo = data1
  newReservationDetails.no_reservacion = data2
  this.service.newBilling(newReservationDetails).subscribe(ticket => (this.ticketinfo = ticket));
}

}
