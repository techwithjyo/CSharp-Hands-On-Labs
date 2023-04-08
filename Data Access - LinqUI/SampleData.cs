using Data_Access___LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access___LinqUI
{
    public static class SampleData
    {
        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel {Id =1, ContactId=1, City="Kolkata", State="WB"},
                new AddressModel {Id =2, ContactId=2, City="Hyderabad", State ="Telengana"},
                new AddressModel {Id =3, ContactId=3, City="Bhubaneswar", State="Odissa"},
                new AddressModel {Id =4, ContactId=4, City="Kolkata", State="WB"},
                new AddressModel {Id =5, ContactId=2, City="Hyderabad", State ="Telen gana"},
                new AddressModel {Id =6, ContactId=1, City="Bhubaneswar", State="Odissa"}
            };

            return output;
        }
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel{Id=1, FirstName="Joe", LastName="Smith", Addresses = new List<int> { 1, 2, 3 } },
                new ContactModel{Id=2, FirstName="Joe", LastName="Jones", Addresses = new List<int> { 1 } },
                new ContactModel{Id=3, FirstName="Joe", LastName="Storm", Addresses = new List<int> {  2, 3 } },
                new ContactModel{Id=4, FirstName="Joe", LastName="Evans", Addresses = new List<int> { 1,  3 } },
                new ContactModel{Id=5, FirstName="Joe", LastName="Baggins", Addresses = new List<int> { 3 } }
            };

            return output;
        }


    }
}
