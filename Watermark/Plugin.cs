using Exiled.API.Features;
using System;
using Exiled.Events.EventArgs.Player;
using RueI.API;
using RueI.API.Elements;

// Copyright (c) 2026 polyshed

namespace Watermark
{
  public class Plugin : Plugin<Config>
  {
    public static Plugin Instance {get; private set;}
    
    public override string Name { get; } = "ServerWatermark";
    public override string Author  { get; } = "@polyshed.";
    public override Version Version  { get; } = new Version(0, 1, 0);
    public override Version RequiredExiledVersion { get; } = new Version(9, 14, 2);

    private static readonly Tag tagWatermark = new("watermarkElement");
    private BasicElement watermark;
    

    public override void OnEnabled()
    {
      Instance = this;
      Exiled.Events.Handlers.Player.Verified += OnVerified;
      watermark = new BasicElement(Instance.Config.Position, Instance.Config.Text);
      base.OnEnabled();
    }

    public void OnVerified(VerifiedEventArgs ev)
    {
      RueDisplay watermarkDisplay = RueDisplay.Get(ev.Player);
      watermarkDisplay.Show(tagWatermark, watermark);
    }

    public override void OnDisabled()
    {
      Exiled.Events.Handlers.Player.Verified -= OnVerified;
      Instance = null;
      base.OnDisabled();
    }
  }
}
