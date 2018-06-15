using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;

namespace MvvmApp.Core
{
    [Preserve(AllMembers = true)]
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
    }
}
