﻿using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace WritingExpansion
{
    public class WritingExpansionModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + api.Side);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("writingexpansion:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("writingexpansion:hello"));
        }

    }
}
