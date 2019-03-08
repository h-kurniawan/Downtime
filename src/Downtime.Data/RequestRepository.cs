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
                return  new NotificationRequest
                {
                    Id = id,
                    Start = new DateTime(2019, 03, 20),
                    End = new DateTime(2019, 03, 21),
                    ProductName = "Rave Coder",
                    ProductUrls = new List<ProductUrl>
                    {
                        new ProductUrl
                        {
                            Url = new Uri("https://sanofi.mdsol.com"),
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
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://amgen.mdsol.co.jp"),
                            Language = "ja",
                            ClientEmails = new[] { "john.doe@amgen.co.jp" },
                            ProjectManagerEmails = new[] { "pm1@medidata.com" }
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://amgen.mdsol.co.kr"),
                            Language = "en",
                            ClientEmails = new[] { "john.wick@amgen.co.kr" },
                            ProjectManagerEmails = new[] { "pm3@medidata.com" }
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://amgen.mdsol.co.ch"),
                            Language = "zh",
                            ClientEmails = new[] { "jack.reacher@amgen.co.zh" },
                            ProjectManagerEmails = new[] { "pm3@medidata.com" }
                        }
                    }
                };
            }
            else if (id == 2)
            {
                return new NotificationRequest
                {
                    Id = id,
                    Start = new DateTime(2019, 04, 1),
                    End = new DateTime(2019, 04, 2),
                    ProductName = "TSDV",
                    ProductUrls = new List<ProductUrl>
                    {
                        new ProductUrl
                        {
                            Url = new Uri("https://beigene.mdsol.com"),
                            Language = "en",
                            ClientEmails = new string[]
                            {
                                "customer1@beigene.com",
                                "customer2@beigene.com",
                                "customer3@beigene.com"
                            },
                            ProjectManagerEmails = new string[]
                            {
                                "pmx@medidata.com",
                                "pmy@medidata.com",
                            }
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://pfizer.mdsol.com"),
                            Language = "en",
                            ClientEmails = new[] { "john.doe@pfizer.com" },
                            ProjectManagerEmails = new[] { "pmz@medidata.com" }
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://pfizer-new.mdsol.com"),
                            Language = "en",
                            ClientEmails = new[] { "john.wick@pfizer.com" },
                            ProjectManagerEmails = new[] { "pmz@medidata.com" }
                        },
                        new ProductUrl
                        {
                            Url = new Uri("https://roche.mdsol.com"),
                            Language = "en",
                            ClientEmails = new[] { "jack.reacher@roche.com" },
                            ProjectManagerEmails = new[] { "pmxyz@medidata.com" }
                        }
                    }
                };
            }
            else
            {
                return null;
            }
        }
    }
}
