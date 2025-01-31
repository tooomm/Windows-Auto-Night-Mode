﻿namespace AutoDarkModeConfig.ComponentSettings.Base
{
    public class SystemSwitchSettings
    {
        private Mode mode;
        //[JsonConverter(typeof(StringEnumConverter))]
        public Mode Mode
        {
            get { return mode; }
            set
            {
                if (value >= 0 && (int)value <= 2)
                {
                    mode = value;
                }
                else
                {
                    // DEFAULT
                    mode = 0;
                }
            }
        }
        public int TaskbarSwitchDelay { get; set; } = 1200;
        public bool TaskbarColorOnDark { get; set; }
    }
}
