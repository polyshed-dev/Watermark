using Exiled.API.Features;
using System;
using Exiled.Events.EventArgs.Player;
using RueI.API;
using RueI.API.Elements;

namespace Watermark
{
  public class Plugin : Plugin<Config>
  {
    public override string Name => "ServerWatermark";
    public override string Author => "@polyshed.";
    public override Version Version => new Version(1, 0, 0);

    public override void OnEnabled()
    {
      Exiled.Events.Handlers.Player.Verified += OnVerified;
      base.OnEnabled();
    }

    public void OnVerified(VerifiedEventArgs ev)
    {
      RueDisplay watermarkDisplay = RueDisplay.Get(ev.Player);
      Tag tagWatermark = new Tag();
      BasicElement watermark = new BasicElement(Config.Position, Config.Text);
      watermarkDisplay.Show(tagWatermark,  watermark);
    }

    public override void OnDisabled()
    {
      Exiled.Events.Handlers.Player.Verified -= OnVerified;
      base.OnDisabled();
    }
  }
}