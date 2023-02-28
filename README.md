# ProjectQuoteExpress

El siguiente proyecto realiza el calculo de cotizaciones en base a prendas seleccionadas, y el valor de cada prenda cambiara dependiendo del tipo de prenda y calidad de la misma.

El proyecto tiene por nombre "Cotizador Express", consta de conexión a la base de datos sqlserver, scripts de carga de datos iniciales, script para crear la tablas, etc.

Pasos para la instalación:

1) Instale Sqlserver, lo puede descargar del siguiente enlace: https://www.microsoft.com/es-es/sql-server/sql-server-2019
2) Instale Visual Studio 2022, esta es la versión utilizada para el desarrollo de la app y su enlace de descarga es: https://visualstudio.microsoft.com/es/vs/
3) Para modificar, visualizar el codigo fuente se recomienda instalar el IDE VS2022 para una mejor experiencia.
4) Descargue el repositorio ProjectQuoteExpress, donde se aloja el codigo fuente completo de la solución planteada.
5) Con todas las herramientas instaladas, se puede realizar la modificación en la clase CS que realiza la conexión a la BDD.
    En la línea 22 de la clase ConnectionBDD se debe modificar lo siguiente:
                connectionString = "server=DESKTOP-BIE877C ; database=quote_express ; integrated security = true";
    
    Reemplace DESKTOP-BIE877C por el nombre del host su pc.
    Si tienen alguna duda de como iniciar la base de sqlserver, puede revisar el siguiente enlace https://www.youtube.com/watch?v=c_FwJ_Yf6To

6)  Crear la bdd con el nombre quote_express
7)  Ejecute el script para generar las tablas del archivo Tablas_QuoteExpress.sql
8)  Ejecute los scripts de datos iniciales del archivo Script_Insert_BDD.sql

Con estas configuraciones realizadas, la aplicación se ejecutara sin problemas

La aplicación esta desarrollado bajo el framework 4 .net, para mayor compatibilidad.


  
                

    
