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
        // Klassi Buildsins.
        string heroClass;
        // Hver einasti hlutur sem er í buildinu.
        Item[] item = new Item[13];
        // Element sem er "stimplað" á Buildið.
        int element;
        // Búið til... 
        DateTime date;
        // útgáfan af leiknum sem buildið var búið til fyrir
        string version;
        int upvotes;
        // Er buildið "hard core" eða ekki
        bool hardCore;
        // Sá sem senti inn Buildið.
        string contributor;
        // Image link á aðra síðu.
        string link;
        string[] paragonLevel = new string[12];

        // Lætur date-ið vera dagurinn sem buildið var búið til
        public Build()
		{
			date = DateTime.Now;
		}
    }
}