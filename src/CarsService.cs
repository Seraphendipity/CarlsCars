namespace CC {
    public static class CarsService {

        public static Cars GenerateCars() {
            Cars cars = new Cars();
            List<Car> list = new List<Car>() {
                new Car(){  Year = 2017, Make = "Ford",  Model = "Mustang", Price = 28000, Msrp = 34500, ListedDate = DateTime.Now}, 
                new Car(){  Year = 2013, Make = "Tesla",  Model = "X", Msrp = 34500,Price = 18500, ListedDate = DateTime.Now}, 
                new Car(){  Make = "Tesla", Year=1995, Model = "X", Price = 329,Msrp = 34500, ListedDate = DateTime.Now}, 
                new Car(){  Make = "Tesla", Year=1995, Model = "Y", Price = 2978,Msrp = 34500, ListedDate = DateTime.Now}, 
                new Car(){  Make = "Chevy", Year=1995, Model = "Bolt", Price = 566,Msrp = 34500, ListedDate = DateTime.Now}, 
                new Car(){  Make = "Chevy", Year=1995, Model = "El Dorado", Price = 240,Msrp = 34500, ListedDate = DateTime.Now}, 
                new Car(){  Make = "Ford", Year=1995, Model = "Lightning", Price = 500,Msrp = 34500, ListedDate = DateTime.Now}, 
            };
            cars.CarListing = list;
            return cars;
        }

        public static Cars GetAllCars () {
            Cars cars = new Cars();
            List<Car> list = new List<Car>() {

            };
            cars.CarListing = list;
            return cars;
        }
    }
}