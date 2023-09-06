public class Collision_DoubleHashing
{
    public static void insert (int key, string name, string [] myTable) {
		
		int i = 0;
		int index = hashFunction(key, i, myTable); 
		
		while (collision(index, myTable)==true) {
			i++;//increment the i for the next interation if there is collision
			index = hashFunction(key, i, myTable); //get the first hash with i incremented
			index *= doubleHash (key); //get the second hash and product with the first hash
			index %= myTable.Length; 
			Console.WriteLine(i);
			
		}
		myTable[index] = name;
	}
	
	public static int hashFunction (int key, int i, string [] myTable) {
		int index = (key%myTable.Length)+i;
		return index;
	}
	
	public static int doubleHash (int key) {
		 int index = 3 - (key%3);
		 return index;
	}
	
	public static Boolean collision (int index, string [] myTable) {
		Boolean col = false;
		if (myTable[index]!=null) {
			col = true;
		}
		return col;
	}
	
	public static void printData (string [] myTable) {
		for (int i = 0; i<myTable.Length; i++) {
			Console.WriteLine(myTable[i]);
			Console.WriteLine();
		}
	}

}