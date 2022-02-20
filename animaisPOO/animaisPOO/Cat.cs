using System;

    class Cat : Pet 
    {
            public Cat (string name, int age, string genre, string color)
            :base(name, age, color)
    {     
              Color = color;
    }
                public string Color {  get; set; }
            
    }

