﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ViewModelSend
    {
        public string Message { get; set; }
        public int Id { get; set; }
        
        public ViewModelSend(string Message, int Id)
        {
            this.Message = Message;
            this.Id = Id;
        }
    }
}
