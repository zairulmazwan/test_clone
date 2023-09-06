public class Collision_LinearProbing
{
    public static int hashFunction (int key, string [] myTable) {
		int index = -1;
		index = key % myTable.Length;		
		return index;
	}
	
	public static void insert (int key, String name, string [] myTable) {
		//get the index to store the name using hash function
		int index = hashFunction(key, myTable);
		int i = 1;
		while (collision(index, myTable)==true) {
			index = probLinear (key, i, myTable);
			i++;
		}
		myTable [index] = name; 
	}
	
	public static int probLinear (int key, int i, string [] myTable) {
		int index = (key+i) % myTable.Length;
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