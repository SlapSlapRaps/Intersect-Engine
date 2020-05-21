using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Intersect.Enums;
using Intersect.GameObjects.Conditions;
using Intersect.GameObjects.Events;
using Intersect.Models;
using Intersect.Utilities;

using JetBrains.Annotations;

using Newtonsoft.Json;

namespace Intersect.GameObjects.Maps
{

    public class MapType : DatabaseObject<MapType>
    {

        protected static Network.Ceras mCeras = new Network.Ceras(false);    

        [JsonConstructor]
        public MapType(Guid id) : base(id)
        {
            Name = "New Map Type";
        }

        //EF Constructor
        public MapType()
        {
            Name = "New Map Type";
        }
        //Properties
        public bool WalkThroughPlayers { get; set; }

        public bool CanAttackNpcs{ get; set; }

        public bool CanAttackPlayers { get; set; }

        public bool DropItemsOnDeath { get; set; }

        public bool IsArena { get; set; }

        public bool CanTrade { get; set; }

        public string MapNameColor { get; set; } = "White";

    }

}
