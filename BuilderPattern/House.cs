namespace BuilderPattern
{
    public class House
    {
        private String name;
        private String type;
        private Boolean hasSwimmingPool;
        private Boolean hasGarden;

        private House(HouseBuilder houseBuilder)
        {
            this.Name = houseBuilder.name;
            this.Type = houseBuilder.type;
            this.HasSwimmingPool = houseBuilder.hasSwimmingPool;
            this.HasGarden = houseBuilder.hasGarden;

        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public bool HasSwimmingPool { get => hasSwimmingPool; set => hasSwimmingPool = value; }
        public bool HasGarden { get => hasGarden; set => hasGarden = value; }

        public String GetHouseDescription()
        {
            return String.Format("{0} {1} {2} {3}", this.Name, this.Type, this.HasSwimmingPool, this.HasGarden);
        }

        public class HouseBuilder
        {
            public String name;
            public String type;
            public Boolean hasSwimmingPool;
            public Boolean hasGarden;

            public HouseBuilder(String name, String type)
            {
                this.name = name;
                this.type = type;
            }
            public HouseBuilder SetSwimmingPoolStatus(Boolean hasSwimmingPoolStatus)
            {
                this.hasSwimmingPool = hasSwimmingPoolStatus;
                return this;
            }
            public HouseBuilder SetGardenStatus(Boolean hasGarden)
            {
                this.hasGarden = hasGarden;
                return this;
            }
            public House Build()
            {
                return new House(this);
            }
        }
    }
}
