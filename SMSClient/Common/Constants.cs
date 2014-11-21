using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSClient.Common
{
    public class Constants
    {
        public const int oxygenLevelLow = 0;
        public const int oxygenLevel = 100;
        public const int heartRateLow = 0;
        public const int heartRate = 400;
        public const int bloodSugarMinLevel = 0;
        public const int bloodSugarMaxLevel = 2000;
        
        public const string AccountSid = "AC7a6db27538ba8ed863c14e825beb35f4";
        public const string AuthToken = "56cb022777274d5e98fdeed9523987a7";
        public const string requestObjectVal = "26881576-3F9B-4F97-B7F7-91532DE1586A";
        public const string twilioNumber = "+17743077070";
        
        public const string BaseUrl = "https://demoutdesign.dev.vivifyhealth.com";
        
        public const string UrlCreateSession = "/api/session/{id}";
        public const string UrlGetPatient = "/api/Patient/{PatientId}";
        public const string UrlGetAllPatients = "/api/Patient";
        public const string UrlGetPatientSurveys = "/api/PatientSurvey";
        public const string UrlGetPatientSurveyQuestion = "/api/PatientSurveyQuestion";
        public const string UrlPostPatientResponse = "/api/PatientResponse?AuthToken={AUTHTOKEN}";
        
        public const string ClientId = "UTDSMSClient";
        public const string ApiKey = "c54cccac-0d78-4010-bbb8-f3c19c813b0a";
        public const string ApiSecret = "e4dd052f-fb45-4a95-afc1-183b293a5cf1";

        public const string YES = "yes";
        public const int NOT_STARTED = -1;
    }
}