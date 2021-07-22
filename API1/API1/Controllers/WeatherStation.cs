using System;

namespace API1.Controllers
{
    public class WeatherStation
    {
        public Guid WeatherStationId { get; set; }
        public string Nombre { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }



    }
}