﻿using System.Collections.Generic;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Model
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}