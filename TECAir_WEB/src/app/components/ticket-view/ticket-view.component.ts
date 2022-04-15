import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';

@Component({
  selector: 'app-ticket-view',
  templateUrl: './ticket-view.component.html',
  styleUrls: ['./ticket-view.component.css']
})
export class TicketViewComponent implements OnInit {

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

  constructor() { }

  ngOnInit(): void {
  }

}
