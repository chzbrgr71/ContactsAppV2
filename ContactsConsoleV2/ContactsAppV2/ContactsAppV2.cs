﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using ContactsConsoleV2;
using Microsoft.Rest;

namespace ContactsConsoleV2
{
    public partial class ContactsAppV2 : ServiceClient<ContactsAppV2>, IContactsAppV2
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IContacts _contacts;
        
        public virtual IContacts Contacts
        {
            get { return this._contacts; }
        }
        
        private IValues _values;
        
        public virtual IValues Values
        {
            get { return this._values; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        public ContactsAppV2()
            : base()
        {
            this._contacts = new Contacts(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp0d23bc15bbfd4f84a69311ec9d8fa2bb.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ContactsAppV2(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._contacts = new Contacts(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp0d23bc15bbfd4f84a69311ec9d8fa2bb.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ContactsAppV2(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._contacts = new Contacts(this);
            this._values = new Values(this);
            this._baseUri = new Uri("https://microsoft-apiapp0d23bc15bbfd4f84a69311ec9d8fa2bb.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ContactsAppV2(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ContactsAppV2(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the ContactsAppV2 class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ContactsAppV2(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}
