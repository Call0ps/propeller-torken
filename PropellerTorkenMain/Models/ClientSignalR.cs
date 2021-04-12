using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PropellerTorkenMain.Models
{
    //public class ClientSignalR : Hub
    //{
    //    HubConnection connection;

    //    public ClientSignalR()
    //    {

    //        var connection = new HubConnectionBuilder().WithUrl("http://localhost44398/orderHub").Build();

    //        connection.Closed += async (error) =>
    //        {
    //            await Task.Delay(new Random().Next(0, 5) * 1000);
    //            await connection.StartAsync();
    //        };

    //    }
    //    private async void SendMessage(object sender)
    //    {
    //        try
    //        {
    //            await connection.InvokeAsync("SendMessage");
    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //    }
    //}
}
