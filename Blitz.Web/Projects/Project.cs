﻿using System.Collections.Generic;
using Blitz.Web.Cronjobs;
using Blitz.Web.Domain;

namespace Blitz.Web.Projects
{
    public class Project : Entity
    {
        public string Title { get; set; }
        public List<Cronjob> Cronjobs { get; set; } = new();
    }
}