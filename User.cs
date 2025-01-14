using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using System;
using System.Text.Json.Serialization;

namespace testTinderDogs
{
    public class User
    {
        public string id {  get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public bool IsAdmin { get; set; }
        public List<Dog> Dogs { get; set; }
        // public string google_id(nullable for email login)
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
