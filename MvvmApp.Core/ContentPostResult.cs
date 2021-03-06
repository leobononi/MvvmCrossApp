﻿namespace MvvmApp.Core
{
    [Preserve(AllMembers = true)]
    public class ContentPostResult<T>
    {
        public T content { get; set; }
        public int statusCode { get; set; }
        public string reasonPhrase { get; set; }
        public bool isSuccessStatusCode { get; set; }
    }
}
