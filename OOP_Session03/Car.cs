

    public class Car
    {
        public Car(int id)
        {
            Id = id;
        }

        public Car(int id, string name):this(id)
        {
            //Id = id;
            Name = name;
        }

        public Car(int id, string name, int speed):this(id,name)
        {
          //  Id = id;
          //  Name = name;
            this.speed = speed;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int speed { get; set; }
    }

