using InheritanceConcept;

class Program {

    public static void Main(String[] args) 
    {
    Chef chef = new Chef();
        chef.makechicken();
        chef.makesplDish();
        chef.makechicken("spicy");

    ItalianChef italianChef = new ItalianChef();
        italianChef.makesplDish();
    
    
    
    }
}