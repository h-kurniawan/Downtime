using System;
using System.Collections.Generic;

namespace Downtime.Data
{
    public class RequestRepository : IRequestRepository
    {
        public NotificationRequest GetRequest(int id)
        {
            if (id == 1)
            {
                return new NotificationRequest
                {
                    Id = id,
                    Start = new DateTime(2019, 03, 20),
                    End = new DateTime(2019, 03, 21),
                    DraftMessage = "123",
                    ProductName = "Rave Coder",
                    ProductUrls = new List<ProductUrl>
                    {
                        new ProductUrl
                        {
                            Url = "sanofi.mdsol.com",
                            Language = "en",
                            ClientEmails = new string[] 
                            {
                                "customer1@sanofi.com",
                                "customer2@sndofi.com",
                                "customer3@sndofi.com",
                                "customer4@sndofi.com",
                                "customer5@sndofi.com"
                            },
                            ProjectManagerEmails = new string[]
                            {
                                "pm1@medidata.com",
                                "pm2@medidata.com",
                            }
                        }
                    }
                };
            }
            else if (id == 2)
            {
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
