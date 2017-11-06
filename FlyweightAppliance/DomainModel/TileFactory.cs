namespace FlyweightAppliance.DomainModel
{
    using System;
    using System.Collections.Generic;

    public class TileFactory
    {
        static readonly Dictionary<string, ITile> Tiles = new Dictionary<string, ITile>();

        public static ITile GetTile(string tileType)
        {
            switch (tileType)
            {
                case "Ceramic":

                    if (!Tiles.ContainsKey("Ceramic"))
                        Tiles["Ceramic"] = new CeramicTile();
                    return Tiles["Ceramic"];

                case "Stone":

                    if (!Tiles.ContainsKey("Stone"))
                        Tiles["Stone"] = new StoneTile();
                    return Tiles["Stone"];

                default: throw new NotSupportedException("No such Tile type");
            }
        }
    }
}