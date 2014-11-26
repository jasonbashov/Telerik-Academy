public class Chef
{
    private Bowl GetBowl()
    {   
        //... 
    }
    private Carrot GetCarrot()
    {
	    //...
	}
	private Potato GetPotato()
	{
	    //...
	}
	private void Cut(Vegetable vegetableToCut)
	{
	    //...
	}  
	public void Cook()
	{
    	Potato potato = GetPotato(); 
		Carrot carrot = GetCarrot(); 
		Bowl bowl;
		
        Peel(potato);
        Peel(carrot);

        Cut(potato);
        Cut(carrot);

        bowl = GetBowl();
        bowl.Add(carrot);
        bowl.Add(potato);
    }
}