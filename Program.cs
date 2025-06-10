using System;

namespace CSharpReview;

 public class Program {
    

    public static void Main (string[] args) {
      Console.WriteLine ("Hello World, let's review CSharp !");
      // multiplyTable(15);
      // checkOddNumber();
      // convertToFahrenheit(4);
      // getSquares(10);
      /*
      Person p = new Person("John", 25);
      p.SayHello();
      BankAccount ba = new BankAccount("123456789", 1000, p);
      ba.DisplayAccountInfo();
      ba.Deposit(500);
      ba.DisplayAccountInfo();
      ba.Withdraw(1200);
      ba.DisplayAccountInfo();
      */
      /*
      Person.displayListPerson(Person.createListPerson());
      Console.WriteLine("----------------------------------------");
      Person.displayListPersonByLetter(Person.createListPerson(), 'H');
      Console.WriteLine("----------------------------------------");
      Person.displayListPersonUnderAge(Person.createListPerson(), 30);
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("The average age of this group is : {0}",                 Person.averageAge(Person.createListPerson()));
      */
      /*
      int[] tab = {1,2,3,4,5,6,7,8,9,10};
      for(int i = 0; i < tab.Length; i++){
        Console.Write("{0} / ", tab[i].ToString());
      }
      Console.WriteLine();
      Array.Reverse(tab);
      for(int i = 0; i < tab.Length; i++){
        Console.Write("{0} / ", tab[i].ToString());
      }
      */
      Console.WriteLine();
      // string[] tabString = {"Horty", "Lyegaia", "Ultia", "Trivia", "Clara", "Kyria", "Pelerine"};
      // Reviews.displayTabInfo(tabString);
      // Array.Reverse(tabString);
      // displayTabInfo(tabString);
      // Array.Sort(tabString);
      // displayTabInfo(tabString);
      // int[] tabInt = {41,23,35,42,51,26,17,8,89,10};
      // Console.WriteLine("max : {0}", Reviews.findMax(tabInt));
      // Console.WriteLine("min : {0}", Reviews.findMin(tabInt));
      // Console.WriteLine("index max : {0}", Reviews.findMaxIndex(tabInt));
      // Console.WriteLine("index min : {0}", Reviews.findMinIndex(tabInt));
      // int[] tabInt = {1,5,3,9,5,6,6,8,9,1};
      // Reviews.displayTabInfo(tabInt);
      // int[] tabNoDupe = Reviews.removeDuplicates(tabInt);
      // Reviews.displayTabInfo(tabNoDupe);
      // string[] tabString = {"Horty", "Lyegaia", "Ultia", "Horty", "Clara", "Trivia", "Ultia", "Clara"};
      // Reviews.displayTabInfo(tabString);
      //string[] tabStringNoDupe = Reviews.removeDuplicates(tabString);
      //Reviews.displayTabInfo(tabStringNoDupe);
      // string[] tabStringSortedNoDupe = Reviews.sortAndRemoveDuplicates(tabString);
      // Reviews.displayTabInfo(tabStringSortedNoDupe);
      //string[] tabLongestString = Reviews.displayLongestString(tabString);
      //Reviews.displayTabInfo(tabLongestString);
      // string[] tabLongestStringOptimized = Reviews.displayLongestStringsOptimized(tabString);
      // Reviews.displayTabInfo(tabLongestStringOptimized);
      var bst = new BinarySearchTree();

      // Insertion de valeurs
      int[] values = { 50, 30, 70, 20, 40, 60, 80, 25, 35, 65, 75, 85 };
      foreach (var v in values)
          bst.Insert(v);

      // Affichage In-Order
      Console.WriteLine("Arbre en ordre croissant :");
      bst.InOrder();  // Résultat attendu : 20 30 40 50 60 70 80

      // Recherche
      Console.WriteLine("Recherche de 60 : " + (bst.Search(60) ? "Trouvé" : "Non trouvé"));
      Console.WriteLine("Recherche de 15 : " + (bst.Search(15) ? "Trouvé" : "Non trouvé"));
      Console.WriteLine();
      Console.WriteLine("Affichage graphique de l’arbre :");
      bst.PrintTree();
    }
  }
