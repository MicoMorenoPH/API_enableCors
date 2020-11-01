1. install via nuget Microsoft.AspNet.WebApi.Cors
2. add the code on App_Start > WebApiConfig.cs

    config.EnableCors();

3. add the [EnableCors] attribute to your Controller
    using System.Web.Http.Cors;

    namespace{
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    }
