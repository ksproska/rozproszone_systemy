﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWebService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IRestService
    {
        private static List<Book> books_list = new List<Book>() {
            new Book {Id = 100, Title = "Echoman", Price = 32.55},
            new Book {Id = 101, Title = "Ekstradycja", Price = 15.00},
            new Book {Id = 102, Title = "Project Riese", Price = 42.90}
        };

        public string addXml(Book item)
        {
            if (item == null)
                throw new WebFaultException<string>("400: Bad Request", System.Net.HttpStatusCode.BadRequest);
            int newIdx = item.Id;
            int idx = books_list.FindIndex(b => b.Id == newIdx);
            if (idx == -1)
            {
                item.Id = newIdx;
                books_list.Add(item);
                return "Added item with ID=" + item.Id;
            }
            else
                return "Id already exists ID=" + item.Id;
        }

        public string deleteXml(string Id)
        {
            int intId = int.Parse(Id);
            int idx = books_list.FindIndex(b => b.Id == intId);
            if (idx == -1)
                return "No book with ID=" + Id;
            books_list.RemoveAt(idx);
            return "Removed item with ID=" + Id;
        }

        public List<Book> getAllXml()
        {
            return books_list;
        }

        public Book getByIdXml(string Id)
        {
            int intId = int.Parse(Id);
            int idx = books_list.FindIndex(b => b.Id == intId);
            if (idx == -1)
                return null;
            return books_list.ElementAt(idx);
        }

        string IRestService.addJson(Book item)
        {
            return addXml(item);
        }

        string IRestService.deleteJson(string Id)
        {
            return deleteXml(Id);
        }

        List<Book> IRestService.getAllJson()
        {
            return getAllXml();
        }

        Book IRestService.getByIdJson(string Id)
        {
            return getByIdXml(Id);
        }
    }
}
