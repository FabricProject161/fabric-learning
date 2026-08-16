using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MyJsonFunctionApp
{
    public class InputModel
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
