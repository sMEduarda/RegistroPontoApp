using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using RegistroPontoApp.Models;

namespace RegistroPontoApp.Views;

public partial class MapaPage : ContentPage
{
    public MapaPage()
    {
        InitializeComponent();
    }

    public void AdicionarPin(CheckInModel checkIn)
    {
        if (meuMapa == null)
            return;

        var local = new Location(checkIn.Latitude, checkIn.Longitude);

        var pin = new Pin
        {
            Label = "Check-in",
            Address = $"Horário: {checkIn.DataHora:HH:mm}",
            Location = local,
            Type = PinType.Place
        };

        // ✅ Adiciona o pin no mapa
        meuMapa.Pins.Add(pin);

        // ✅ Centraliza o mapa no pin
        var region = MapSpan.FromCenterAndRadius(
            local,
            Distance.FromKilometers(0.5)
        );

        meuMapa.MoveToRegion(region);
    }
}