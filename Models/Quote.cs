using System;


    public partial class Quote
    {
        public long id { get; set; }
       
        public int? num_of_apartments { get; set; }
        public int? num_of_floors { get; set; }
        public int? num_of_basements { get; set; }
        public int? num_of_elevator_cages { get; set; }
        public int? num_of_occupants_per_Floor { get; set; }
        public int? required_shafts { get; set; }
        public int? num_of_parking_spots { get; set; }
        public int? num_of_distinct_businesses { get; set; }
        public string building_type { get; set; }
        public string product_line { get; set; }
        public string sub_total { get; set; }
        public int? required_columns { get; set; }
        public int? num_of_activity_hours_per_day { get; set; }
        public string total { get; set; }
        public string installation_fee { get; set; }
        
        public string company_name { get; set; }
        public string email { get; set; }
    }