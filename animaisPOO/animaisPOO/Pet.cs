using System;

 abstract class Pet   //Classe que serve de escopo para outrasa classes.
    {

    public Pet(string name, int age, string genre)
    {
        Name = name;
        Age  = age;
        Genre = genre;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Genre { get; set; }
            
    }


   
