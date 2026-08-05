using System;
using System.Collections.Generic;
using System.Text;

namespace Wikipedia.Shared.DTOs
{
    public class WikiResultDto
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}
