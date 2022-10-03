namespace Cars {
    public static class CarsService {
        public static Cars GetAllCars () {
            Cars cars = new Cars();
            List<Car> list = new List<Car>() {
                new Car(){ Make = "Ford", Model = "Mustang", Price = 0, ListedDate = DateTime.Now}, 
                new Car(){ Make = "Ford", Model = "Lightning", Price = 500, ListedDate = DateTime.Now}, 
                new Car(){ Make = "Tesla", Model = "X", Price = 329, ListedDate = DateTime.Now}, 
                new Car(){ Make = "Tesla", Model = "X", Price = 2978, ListedDate = DateTime.Now}, 
                new Car(){ Make = "Chevy", Model = "Bolt", Price = 566, ListedDate = DateTime.Now}, 
                new Car(){ Make = "Chevy", Model = "El Dorado", Price = 240, ListedDate = DateTime.Now}, 
            };
            cars.CarListing = list;
            return cars;
        }
    }
}