using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ProjectManager
{
    class GoogleCalendarSync
    {
        public void syncTasks(List<TaskData> tasks)
        {
            // List for user info
            List<string> eventsCreated = new List<string>();

            // bool to check if calendaritem exists
            bool itemExists = false;

            // Authorize API call
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "173158901438-pcogjsudrgr4lk4pitlnc1dgdn2d3qm8.apps.googleusercontent.com",
                    ClientSecret = "22rAjXySpj21xzFjU8AWYOlY"
                },
                new[] { CalendarService.Scope.Calendar }, "user", CancellationToken.None).Result;

            // Create the service
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Project Manager",
            });

            // Get already registered events
            var events = service.Events.List("primary").Execute();

            // Add a new calendar item to the google calendar, unless it already exists
            foreach (TaskData r in tasks)
            {
                for (int i = 0; i < events.Items.Count(); i++)
                {
                    if (r.Name == events.Items.ElementAt(i).Summary)
                    {
                        itemExists = true;
                        break;
                    }
                }
                if (itemExists)
                {
                    // Put it back to false for next loop instance
                    itemExists = false;

                    continue;
                }
                else
                {
                    // Creates an event object
                    Event newEvent = new Event()
                    {
                        Summary = r.Name,
                        Description = r.Details,
                        Start = new EventDateTime()
                        {
                            DateTime = DateTime.Now,
                            TimeZone = "Europe/Amsterdam",
                        },
                        End = new EventDateTime()
                        {
                            DateTime = DateTime.Parse(r.Deadline),
                            TimeZone = "Europe/Amsterdam",
                        }
                    };

                    string calendarId = "primary";
                    EventsResource.InsertRequest req = service.Events.Insert(newEvent, calendarId);
                    Event createdEvent = req.Execute();
                    eventsCreated.Add("Event has been created, link to the event: " + createdEvent.HtmlLink);
                }
            }

            var message = string.Join(Environment.NewLine, eventsCreated);
            string filepath = @"C:\Users\Tobias\source\repos\FUN12 Project\Killerapp-FUN12\ProjectManager\AppInfo\AddedEvents.txt";

            // Finally, display created events
            if (message == "")
            {
                MessageBox.Show("No new events were added. Existing events already synced to calendar.");
            }
            else
            {
                // Write events to txt file
                using (TextWriter tw = new StreamWriter(filepath))
                {
                    foreach (String s in eventsCreated)
                    {
                        tw.WriteLine(s);
                    }
                }

                // User info
                MessageBox.Show("All events are written to the info file at: " + filepath);
            }
        }
    }
}
