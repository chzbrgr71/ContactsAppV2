using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace ContactsConsoleV2
{
    public static class ContactsAppV2AppServiceExtensions
    {
        public static ContactsAppV2 CreateContactsAppV2(this IAppServiceClient client)
        {
            return new ContactsAppV2(client.CreateHandler());
        }

        public static ContactsAppV2 CreateContactsAppV2(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new ContactsAppV2(client.CreateHandler(handlers));
        }

        public static ContactsAppV2 CreateContactsAppV2(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new ContactsAppV2(uri, client.CreateHandler(handlers));
        }

        public static ContactsAppV2 CreateContactsAppV2(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new ContactsAppV2(rootHandler, client.CreateHandler(handlers));
        }
    }
}
