1. install via nuget Microsoft.AspNet.WebApi.Cors
2. add the code on App_Start > WebApiConfig.cs

    config.EnableCors();

3. add the [EnableCors] attribute to your Controller
    using System.Web.Http.Cors;

    namespace{
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    }
    
    Note: Cors parameter
    a. origins
    b. headers
    c. methods [GET,POST,PUT,DELETE]

4. to disable CORS for specific method/action
   
   [DisabeCors]
   [HttpPost]
   public HttpResponseMessage GetBranch([FromBody] BranchDataModel[] sysParam) {
    return message;
   }
