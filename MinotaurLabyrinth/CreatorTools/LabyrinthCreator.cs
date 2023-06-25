using System.Collections.Generic;

namespace MinotaurLabyrinth
{
    public static class LabyrinthCreator
    {
        const int ScalingFactor = 16;
        static readonly Dictionary<Size, (int rows, int cols)> _mapSizeDimensions = new()
        {
            { Size.Small, (4, 4) },
            { Size.Medium, (6, 6) },
            { Size.Large, (8, 8) },
        };

        public static (Map, Hero) InitializeMap(Size mapSize)
        {
            Map map = CreateMap(mapSize);
            ProceduralGenerator.Initialize(map);
            Location start = RandomizeMap(map);
            return (map, InitializePlayer(start));
        }

        private static Map CreateMap(Size mapSize)
        {
            if (!_mapSizeDimensions.TryGetValue(mapSize, out var dimensions))
            {
                throw new ArgumentException("Unknown map size");
            }

            return new Map(dimensions.rows, dimensions.cols);
        }

        private static Location RandomizeMap(Map map)
        {
            Location start = PlaceEntrance(map);
            PlaceSword(map, start);
            AddRooms(RoomType.ElementalRoom, map);
            InitializeMonsters(map);
            return start;
        }

        private static Location PlaceEntrance(Map map)
        {
            Location start = ProceduralGenerator.GetRandomEdgeLocation(map);
            map.SetRoomAtLocation(start, RoomType.Entrance);
            return start;
        }

        private static void PlaceSword(Map map, Location start)
        {
            Location swordLocation = ProceduralGenerator.GetRandomLocationNotAdjacentTo(start);
            map.SetRoomAtLocation(swordLocation, RoomType.Sword);
        }

        private static void AddRooms(RoomType roomType, Map map, int multiplier = 1)
        {
            int numRooms = map.Rows * map.Columns * multiplier / ScalingFactor;
            for (int i = 0; i < numRooms; ++i)
            {
                map.SetRoomAtLocation(ProceduralGenerator.GetRandomLocation(), RoomType.ElementalRoom);
            }
        }

        private static Hero InitializePlayer(Location start)
        {
            return new Hero(start);
        }

        private static void InitializeMonsters(Map map)
        {
            Location guardian1Location = ProceduralGenerator.GetRandomLocation();
            Room room1 = map.GetRoomAtLocation(guardian1Location);
            room1.AddMonster(new FireGuardian());

            Location guardian2Location = ProceduralGenerator.GetRandomLocation();
            Room room2 = map.GetRoomAtLocation(guardian2Location);
            room2.AddMonster(new EarthGuardian());

            Location guardian3Location = ProceduralGenerator.GetRandomLocation();
            Room room3 = map.GetRoomAtLocation(guardian3Location);
            room3.AddMonster(new WaterGuardian());
        }
    }
}
