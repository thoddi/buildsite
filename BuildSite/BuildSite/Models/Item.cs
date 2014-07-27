using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildSite.Models
{
    public class Item
    {
        int id;
        string name;
        // Hvar á líkamanum item-inn á að vera
        int slot;
        string[] primaryStat = new string[5];
        string[] secondaryStat = new string[3];
        int priority;
    }
}