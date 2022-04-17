import { Component, OnInit } from '@angular/core';
import { jsPDF } from "jspdf";
import html2canvas from 'html2canvas';


@Component({
  selector: 'app-flight-summary',
  templateUrl: './flight-summary.component.html',
  styleUrls: ['./flight-summary.component.css']
})
export class FlightSummaryComponent implements OnInit {

  passangerData = [
    {
      "no_transaccion" : "6567857",
      "p_nombre" : "Juan",
      "p_apellido1" : "Perez",
      "p_apellido2" : "Chaverri",
      "dni": "1:00 PM",
      "cant_maletas": "1"
    },

    {
      "no_transaccion" : "5647867",
      "p_nombre" : "Juan",
      "p_apellido1" : "Perez",
      "p_apellido2" : "Chaverri",
      "dni": "1:00 PM",
      "cant_maletas": "1"

    },

    {
      "no_transaccion" : "6757345",
      "p_nombre" : "Juan",
      "p_apellido1" : "Perez",
      "p_apellido2" : "Chaverri",
      "dni": "1:00 PM",
      "cant_maletas": "1"
    },

    {
      "no_transaccion" : "6767878",
      "p_nombre" : "Juan",
      "p_apellido1" : "Perez",
      "p_apellido2" : "Chaverri",
      "dni": "1:00 PM",
      "cant_maletas": "1"
    }
]

baggageData = [
  {
    "no_maleta" : "XMF-675",
    "dni" : "1223365",
    "peso" : "13 kg",
    "color": "verde"
  },

  {
    "no_maleta" : "XMF-675",
    "dni" : "1223365",
    "peso" : "13 kg",
    "color": "verde"
  },

  {
    "no_maleta" : "XMF-675",
    "dni" : "1223365",
    "peso" : "13 kg",
    "color": "verde"
  },

  {
    "no_maleta" : "XMF-675",
    "dni" : "1223365",
    "peso" : "13 kg",
    "color": "verde"
  },

  {
    "no_maleta" : "XMF-675",
    "dni" : "1223365",
    "peso" : "13 kg",
    "color": "verde"
  }
]

  constructor() { }

  ngOnInit(): void {
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

}
