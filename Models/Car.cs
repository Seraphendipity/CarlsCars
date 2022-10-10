namespace CC { 
    public class Car { 
        public string Id {get; set;}
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public int Price {get; set;} 
        public int Msrp {get; set;} 

        // [DataType(DataType.Date)]
        public DateTime ListedDate {get; set;}

                
    }

}

