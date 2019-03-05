
using IO.Swagger.Api.ASL;
using IO.Swagger.Au.Api;
using IO.Swagger.Au.Model;
using IO.Swagger.Model;
using System.Collections.Generic;



namespace SandBoxServiceSedeAsl
{
    class Program
    {
        static void Main(string[] args)
        {

            //Telefono mTest = new Telefono();
            //mTest.CodiceTipoTelefono = "12223";
            //mTest.DataMovimentazione = 2;
            //string aaa =  JsonConvert.SerializeObject(mTest);


            //Impostazioni di configurazione Client
            IO.Swagger.Client.Configuration mConf = new IO.Swagger.Client.Configuration
            {
                BasePath = "https://572050ca-7cf9-4bf3-a222-964324396089.mock.pstmn.io"
            };
            mConf.ApiKey.Add(new KeyValuePair<string, string>("Authorization", "12355"));

            //istanza CLient
            AuSedeAslControllerApi instance = new AuSedeAslControllerApi(mConf);
            string codiccodiceSede = "123849";

            // Chiamata all client REST
            List<Telefono> response = instance.EstraiTelefonoUsingGET1(codiccodiceSede);






            //Impostazioni di configurazione Client
            IO.Swagger.Au.Client.Configuration mConfAu = new IO.Swagger.Au.Client.Configuration();
            mConfAu.BasePath = "https://0fa9b0a4-5249-4774-8b0a-ce46413838d9.mock.pstmn.io";
            mConfAu.ApiKey.Add(new KeyValuePair<string, string>("Authorization", "12355"));

            //istanza CLient
            AuPfControllerApi instanceAu = new AuPfControllerApi(mConfAu);

            PersonaFisicaDTO mRequ = new PersonaFisicaDTO();


            // Chiamata all client REST
            IO.Swagger.Au.Client.ApiResponse<List<PersonaFisica>> Auresponse = instanceAu.GetPersonaFisicaUsingPOST1WithHttpInfo(mRequ);

            foreach (PersonaFisica mPerson in Auresponse.Data)
            {

                string buffer = mPerson.ToJson();


            }








        }
    }
}
