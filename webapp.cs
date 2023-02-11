// Create an empty ASP.NET Web Application (.NET Framework)
var webapp = new Microsoft.Web.WebApplication("MyWebApplication");

// Add a static "Hello World" page
webapp.AddPage("index.aspx", 
    "<h1>Hello world!</h1>");

// Publish the web application to Azure
webapp.Deploy(new Microsoft.Azure.PublishSettings());
