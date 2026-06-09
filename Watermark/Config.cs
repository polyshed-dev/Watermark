using System.ComponentModel;
using Exiled.API.Interfaces;

// Copyright (c) 2026 polyshed

namespace Watermark
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("The text to display as the watermark. Please use <color=#FFFFFF> even if you want the hint to be white.")]
        public string Text { get; set; } = "<color=#FFFFFF>your-server-name</color>";
        [Description("The vertical position of the watermark text.")]
        public float Position { get; set; }
    }
}