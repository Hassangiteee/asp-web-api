﻿using System;

namespace my_books.Data.ViewModels
{
    public class BookVm
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }
        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        public DateTime? DateAdded { get; set; }

        public string Genre { get; set; }

        public string CoverUrl { get; set; }
    }
}
