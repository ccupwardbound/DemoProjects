namespace CourseItemList
{
    class ItemInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Description Description { get; set; }
    }

    class Description
    {
        public string BackgroundInfo { get; set; }
        public Location Location { get; set; }
    }

    class Location
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
    }

}
