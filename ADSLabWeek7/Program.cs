// See https://aka.ms/new-console-template for more information

//PART 1

// string [,] data =  ReadFile.readCSV();
// Console.WriteLine("Col : "+data.GetLength(1));
// ReadFile.printArray(data);


//Linear Probing
// Console.WriteLine("::Linear Hashing::");
// string [] myTable = new String [5];

// Collision_LinearProbing.insert(5, "Mazwan", myTable);
// Collision_LinearProbing.insert(12, "Jilani", myTable);
// Collision_LinearProbing.insert(9, "Zairul", myTable);
// Collision_LinearProbing.insert(15, "Rania", myTable);
// Collision_LinearProbing.insert(11, "Mehmet", myTable);
	
// Collision_LinearProbing.printData(myTable);	



//Double Hashing
// Console.WriteLine("::Double Hashing::");
// string [] myTable2 = new String [5];
// Collision_DoubleHashing.insert(9, "Zairul", myTable2); //9%5 = 4
// Collision_DoubleHashing.insert(5, "Mazwan", myTable2); //5%5 = 0
// Collision_DoubleHashing.insert(12, "Jilani", myTable2); //12%5 = 2
// Collision_DoubleHashing.insert(15, "Rania", myTable2);//iter 0 : 15%5 = 0, iter 1 :  (1*3)%5 = 3
// Collision_DoubleHashing.insert(23, "Mehmet", myTable2); //iter 0 : 23%5 = 3, iter 1: (4*1)%5 = 4, iter 2 : (5*1)%5 = 0, iter 3 : (6*1)%5 = 1, iter 4: (7*1)%5 = 2
		
// Collision_DoubleHashing.printData(myTable2);	


//------------------------------------------------------------------------
//PART 2

DoublyLinkedList [] myTable = new DoublyLinkedList [5];
Collision.insert(9, "Zairul", myTable); 
Collision.insert(5, "Mazwan", myTable);  
Collision.insert(15, "Rania", myTable);
Collision.insert(16, "John", myTable);
Collision.insert(21, "Mariam", myTable);
		
Collision.printData (myTable);
Console.WriteLine("\nFind a user with id 21 "+Collision.findNode(21, myTable));
