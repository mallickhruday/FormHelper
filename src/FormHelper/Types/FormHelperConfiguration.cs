﻿namespace FormHelper
{
    public class FormHelperConfiguration
    {
        public bool UsePascalCaseJson { get; set; } = false;
        public string CheckTheFormFieldsMessage { get; set; } = "Check the form fields.";
        public int RedirectDelay { get; set; } = 2000;
        public bool DebugMode { get; set; } = false;
    }
}
