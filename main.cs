using System;
using System.Collections;
using System.Collections.Generic; 

class School {
  public static void Main(string[] args){
    Console.WriteLine("Which School do you want to see?");
	 string ChosenSchool = Console.ReadLine();
   switch(ChosenSchool){
     case "Fire": Console.WriteLine("Your chosen school was: " + ChosenSchool);
     break;
     case "Water": Console.WriteLine("Your chosen school was: " + ChosenSchool);
     break;
     case "Earth": Console.WriteLine("Your chosen school was: " + ChosenSchool);
     break;
     case "Wind": Console.WriteLine("Your chosen school was: " + ChosenSchool);
     break;
   };
  } 
}
/*
class Program {
  public static void Main (string[] args) {
	ArrayList Schools = new ArrayList {"Fire", "Water", "Earth", "Wind"};
	 //This variable stores the School
	 string School;
	 Console.WriteLine("Which School do you want to see?");
	 School = Console.ReadLine();

	 int[] school_No = new int[4];
	 school_No = new int[] {1, 2, 3, 4};
	 switch(School){
		 case "Fire":
		 break;
		 case "Water":
		 break;
		 case "Earth":
		 break;
		 case "Wind":
		 break;
		 default: Console.WriteLine("Unknown");
		 break;
	 };
	 
	 /*
	 if (Schools == no.)
	 Console.WriteLine("Oh, so you choose " + School + " so interesting..."); 
	 */