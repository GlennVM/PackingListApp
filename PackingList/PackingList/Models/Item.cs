﻿using System;

namespace PackingList.Models
{
    public class Item : TripComponent
    {
        public int ItemId { get; set; }

        public Boolean Checked { get; set; }

        public int Amount { get; set; }

        public String Category { get; set; }
    }
}
