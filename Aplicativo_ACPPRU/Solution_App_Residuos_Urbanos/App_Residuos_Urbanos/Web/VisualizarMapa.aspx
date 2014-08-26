<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Intranet.Master" AutoEventWireup="true" CodeBehind="VisualizarMapa.aspx.cs" Inherits="App_Residuos_Urbanos.Web.Formulario_web1" %>
<asp:Content runat="server" ID="Content0" ContentPlaceHolderID="contentPlaceHolderTitulo">
    <h1>"Visualizar Mapa."<span>- Pontos principais de acumulo de residuos</span></h1>

   <h2>In character, in manner, in style, in all things, the supreme excellence is simplicity.</h2>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script> 
    <section>
        <article>
            <div id="map_canvas" style="width:100%; height:400px;"></div>
        </article>
    </section>

    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=true"></script> 
   
    <script type="text/javascript">

        var map;
        var latitud;
        var longitud;
        var Lista; 

        $(document).ready(function () {
            localizame();//Carga la pagina , carga nuestra posicion
        });

        function localizame() {

            if (navigator.geolocation) {//Si el navegador tiene geolocalizacion

                navigator.geolocation.getCurrentPosition(coordenadas, errores);

            } else {

                alert('Oops! Tu navegador no soporta Geolocalizacion, por favor actualiza a un navegador mas reciente');

            }
        }

        function coordenadas(position) {
            latitud = position.coords.latitude; /*Guardamos nuestra latitud*/
            longitud = position.coords.longitude; /*Guardamos nuestra longitud*/
            cargarMapa();
        }

        function errores(err) {
            /*Controlamos los posibles errores */
            if (err.code == 0) {
                alert("Oops! Algo ha salido mal");
            }
            if (err.code == 1) {
                alert("Oops! No has aceptado compartir tu posición");
            }
            if (err.code == 2) {
                alert("Oops! No se puede obtener la posición actual");
            }
            if (err.code == 3) {
                alert("Oops! Hemos superado el tiempo de espera");
            }
        }


        function cargarMapa() {


            //Creamos un punto con nuestras coordenadas

            var latlon = new google.maps.LatLng(latitud, longitud);
            var myOptions = {
                zoom: 17,
                center: latlon, //Definimos la posicion del mapa con el punto
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                streetViewControl: false

            };

            map = new google.maps.Map($("#map_canvas").get(0), myOptions);


             <%
        if (listaCoordenadas.Count > 0)
        {

            foreach (BusinessEntities.BECoordenada valores in listaCoordenadas)
            {
                        
        %>

            latitud = "<%=valores.str_latitud %>";
            longitud = "<%=valores.str_longitud
        %>";

            var coorMarcador = new google.maps.LatLng(latitud, longitud);

            var marcador = new google.maps.Marker({
                position: coorMarcador,
                map: map,
                title: "Donde Estoy?"
            });

            <%
                    
                }
            }
        %>

        }

     </script>

</asp:Content>
