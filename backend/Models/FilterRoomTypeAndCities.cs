using System;
namespace HotelsWebApp.Models
{
    public partial class FilterRoomTypeAndCities
    {
       public string[] Cities { get; set;}
       public Tuple<int,string>[] RoomTypes {get; set;}
    }
}