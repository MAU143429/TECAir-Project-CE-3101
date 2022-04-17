import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';

@Component({
  selector: 'app-baggage-check',
  templateUrl: './baggage-check.component.html',
  styleUrls: ['./baggage-check.component.css']
})
export class BaggageCheckComponent implements OnInit {


  constructor() { }

  ngOnInit(): void {
  }
  // metodo que realiza la descarga del archivo de factura
  public downloadBillingReport(){
    // Extraemos el archivo
    const DATA: any = document.getElementById('htmlData2');
    const doc = new jsPDF('p', 'pt', 'a4');
    const options = {
      background: 'white',
      scale: 3
    };
    html2canvas(DATA, options).then((canvas) => {

      const img = canvas.toDataURL('image/PNG');

      // Creamos una imagen con el canva HTML y creamos un PDF con esa imagem
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
  

}
