import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';

@Component({
  selector: 'app-payment-employee',
  templateUrl: './payment-employee.component.html',
  styleUrls: ['./payment-employee.component.css']
})
export class PaymentEmployeeComponent implements OnInit {

  ticketinfo = [
    {
      "no_vuelo" : "#9999999",
      "no_transaccion" : "#111111111",
      "origen" : "Aeropuerto Internacional Juan Santamaria",
      "destino": "MXN Mexico Aeropuerto Benito Juarez",
      "ciudad_origen" : "San Jose",
      "ciudad_destino" :"Ciudad de Mexico",
      "avion": "Airbus 737",
      "ptr_abordaje" : "G31",
      "fecha": "22/04/2022",
      "h_salida": "1:50 PM",
      "h_llegada": "10:50 PM",
      "duracion" : "8 h 31 mins",
      "cant_escalas" : "2"
    },

]

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

  constructor() { }

  ngOnInit(): void {
  }

}
