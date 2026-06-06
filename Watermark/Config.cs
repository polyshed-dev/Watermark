using Exiled.API.Interfaces;

namespace Watermark
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public string Text { get; set; } =
            "<b><color=#F70505>Y</color><color=#EB0611>u</color><color=#DF071D>p</color><color=#D30829>o</color> <color=#BB0A41>D</color><color=#AF0B4D>i</color><color=#A30C59>y</color><color=#970D65>a</color><color=#8B0E71>r</color><color=#7F0F7D>ı</color> <color=#671195>》</color><color=#5B12A1>V</color><color=#4F13AD>a</color><color=#4314B9>n</color><color=#3715C5>i</color><color=#2B16D1>l</color><color=#1F17DD>l</color><color=#1318E9>a</color><color=#0719F5>+</color><color=#001AFF>+</color></b>";
        public float Position { get; set; }
    }
}