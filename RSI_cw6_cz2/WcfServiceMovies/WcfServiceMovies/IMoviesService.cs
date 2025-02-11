﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace WcfServiceMovies
{
    [ServiceContract]
    public interface IMoviesService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/movies")]
        List<Movie> getAllXml();

        [OperationContract]
        [WebGet(UriTemplate = "/json/movies", ResponseFormat = WebMessageFormat.Json)]
        List<Movie> getAllJson();

        [OperationContract]
        [WebGet(UriTemplate = "/movies/{id}", ResponseFormat = WebMessageFormat.Xml)]
        Movie getByIdXml(string Id);

        [OperationContract]
        [WebGet(UriTemplate = "/json/movies/{id}", ResponseFormat = WebMessageFormat.Json)]
        Movie getByIdJson(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/movies", Method = "POST", ResponseFormat = WebMessageFormat.Xml)]
        string addXml(Movie item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/movies", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        string addJson(Movie item);

        [OperationContract]
        [WebInvoke(UriTemplate = "/movies/{id}", Method = "DELETE")] //"Xxx{id}"
        string deleteXml(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/movies/{id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)] //"Xxx{id}"
        string deleteJson(string Id);

        [OperationContract]
        [WebGet(UriTemplate = "/mydata", ResponseFormat = WebMessageFormat.Json)]
        DataString getMyData();
    }

    // Zdefiniuj kontrakt danych
    [DataContract]
    public class Movie
    {
        [DataMember(Order = 0)]
        public int Id { get; set; }

        [DataMember(Order = 1)]
        public string Title { get; set; }

        [DataMember(Order = 2)]
        public int Length { get; set; }

        [DataMember(Order = 2)]
        public string Director { get; set; }
    }

    [DataContract]
    public class DataString
    {
        [DataMember(Order = 0)]
        public string description { get; set; }

    }
}
