﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesRepository.HttpServices
{
    public class ServiceAuthenticationException : Exception
    {
        public string Content { get; set; }

        public ServiceAuthenticationException(string content)
        {
            Content = content;
        }
    }
}
