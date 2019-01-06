using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen
{
    /*
     * De class EventManager bepaalt welke gebruiker verantwoordelijk is voor
     * een event. Een EventManager moet dus een User een een Event hebben. Die
     * heb je al uitgewerkt in de vorige oefeningen.
     * 
     * Bij deze oefening krijg je geen stappenplan meer. Je bepaalt zelf welke
     * properties, constructor en functies je class nodig heeft. 
     * 
     * Je kan de class testen in de functie TestEventManager onder de class.
     * Daarin zal je ook Users, Events en Locations moeten voorzien om dat te kunnen 
     * doen.
     */ 
    public class EventManager
    {
        User user;
        public User User { get => user; }
        
        Event @event; // event is a reserved name!
        public Event Event { get => @event; }

        public EventManager(Event @event, User user)
        {
            this.@event = @event;
            this.user = user;
        }

        public string AsText()
        {
            return Event.AsText() + "\nIt is managed by " + User.FirstName + " " + User.LastName;
        }
    }

    public partial class Tests
    {
        public static void TestEventManager()
        {
            var user = new User("Eric", "Cartman", new DateTime(1992, 4, 2));
            var location = new Location("South Park", new System.Device.Location.GeoCoordinate(38.9679, -106.04517));
            var @event = new Event("Choir Rehearsal", new DateTime(2025, 12, 24), location);
            var eventManager = new EventManager(@event, user);

            Console.WriteLine(eventManager.AsText());
        }
    }
}
