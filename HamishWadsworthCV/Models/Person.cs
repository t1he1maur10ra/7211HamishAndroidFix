using System;
using System.Collections.Generic;

namespace HamishWadsworthCV.Models
{
    public class Person
    {
        public string Name { get; set; } = "Hamish Wadsworth";
        public string Email { get; set; } = "hamishwaddy@gmail.com";
        public SocialMediaUrl SocialMediaUrl { get; set; }
    }

    public class SocialMediaUrl
    {
        public string Github { get; set; } = "https://www.github.com/hamishwaddy/";
        public string Linkedin { get; set; } = "https://www.linkedin/in/hamishwadsworth/";
    }


}
