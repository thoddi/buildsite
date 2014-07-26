using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSite.Models
{
    public class Build
    {
        int id;
        string name;
        string heroClass;
        Item[] item = new Item[13];
        int element;
        DateTime date;
        string version;
        int upvotes;
        bool hardCore;
        string contributor;
        string link;
        string[] paragonLevel = new string[12];
    }
}