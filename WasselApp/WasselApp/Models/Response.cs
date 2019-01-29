using System;
using System.Collections.Generic;
using System.Text;

namespace WasselApp.NewFolder
{
    public class Response<T, I>
    {
        public bool success { get; set; }
        public T data { get; set; }
        public I message { get; set; }
    }
}
