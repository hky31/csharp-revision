using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview; 

// classe pour les methodes de revision
public class Reviews {

   // methode pour afficher la table de multiplication d'un nombre
  public static void multiplyTable(int num){
      for(int i = 1; i <= 10; i++) {
        Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
      }  
    }

    // methode pour verifier si un nombre est pair ou impair
    public static void checkOddNumber(){
      Console.WriteLine("enter a number :");
      var key = Console.ReadKey(true).KeyChar;
      if(char.IsDigit(key)){
        Console.WriteLine("the input key is : {0}", key.ToString());
        var num = int.Parse(key.ToString());
        if(num % 2 == 0){
          Console.WriteLine("the number is odd");
        }
        else {
          Console.WriteLine("the number is even");
        }
      }
      else {
        Console.WriteLine("the key is not a number");
      }
    }

    // methode pour convertir une temperature de celsius a fahrenheit
    public static void convertToFahrenheit(double temp) {
      double fahrenheit = (temp * 9 / 5) + 32;
      Console.WriteLine("{0} Celsius converted to Farenheit is : {1}", temp.ToString(),fahrenheit.ToString());
    }

  // methode pour afficher les carres des nombres de 1 a max  
    public static void getSquares(int max) {
      int[] tabSquares = new int[max];
      for(int i = 0; i < max; i++){
        tabSquares[i] = (int)Math.Pow(i+1,2);
        Console.WriteLine(tabSquares[i]);
      }
    }

   // methode pour afficher tout type d'elements d'un tableau
    public static void displayTabInfo<T>(T[] tabInfo){
      for (int i = 0; i < tabInfo.Length-1; i++) {
        Console.Write(tabInfo[i] + " | ");
      }
      Console.WriteLine(tabInfo[tabInfo.Length-1]);
      Console.WriteLine();
    }

   // methode pour definir le plus grand element d'un tableau
    public static int findMax(int[] tab) {
      int max = tab[0];
      for(int i = 1; i < tab.Length; i++) {
        if(tab[i] > max) {
          max = tab[i];
        }
      }
      return max;
    }

   // methode pour definir le plus petit element d'un tableau
   public static int findMin(int[] tab) {
     int min = tab[0];
     for(int i = 1; i < tab.Length; i++) {
       if(tab[i] < min) {
         min = tab[i];
       }
     }
     return min;
   }

  // methode pour definir l'index du plus grand element d'un tableau
    public static int findMaxIndex(int[] tab) {
      int indexMax = 0;
      for(int i = 1; i < tab.Length; i++) {
        if(tab[i] > tab[indexMax]) {
          indexMax = i;
        }
      }
      return indexMax;
    }
  
  // methode pour definir l'index du plus petit element d'un tableau 
   public static int findMinIndex(int[] tab) {
     int indexMin = 0;
     for(int i = 1; i < tab.Length; i++) {
       if(tab[i] < tab[indexMin]) {
         indexMin = i;
       }
     }
     return indexMin;
   }

  // methode pour enlever les doublons d'un tableau
  public static T[] removeDuplicates<T>(T[] tab) {
    List<T> listNoDuplicates = new List<T>();
    foreach(T i in tab){
      if(!listNoDuplicates.Contains(i)) {
        listNoDuplicates.Add(i);
      }
    }
    return listNoDuplicates.ToArray();
  }

  // methode pour trier un tableau et enlever les doublons
  public static T[] sortAndRemoveDuplicates<T>(T[] tab) {
    List<T> listNoDuplicates = new List<T>();
    foreach(T i in tab){
      if(!listNoDuplicates.Contains(i)) {
        listNoDuplicates.Add(i);
      }
    }
    T[] tabNoDuplicates = listNoDuplicates.ToArray();
    Array.Sort(tabNoDuplicates);
    return tabNoDuplicates;
  }

  // methode pour afficher les chaines de caracteres les plus longues d'un tableau
  public static string[] displayLongestString(string[] tab) {
    List<string> listLongestString = new List<string>();
    string longestString = tab[0];
    for(int i = 1; i < tab.Length; i++) {
      if(tab[i].Length > longestString.Length) {
        longestString = tab[i];
      }
    }
    for (int i = 0; i < tab.Length; i++) {
      if(tab[i].Length == longestString.Length) {
        listLongestString.Add(tab[i]);
      }
    }
    string[] tabLongestString = listLongestString.ToArray();
    Array.Sort(tabLongestString);
    return tabLongestString;
  }
  // methode pour afficher les chaines de caracteres les plus longues d'un tableau (version optimisee)
  public static string[] displayLongestStringsOptimized(string[] tab)
  {
      List<string> result = new List<string>();
      int maxLength = 0;

      foreach (var str in tab)
      {
          if (str.Length > maxLength)
          {
              maxLength = str.Length;
              result.Clear();
              result.Add(str);
          }
          else if (str.Length == maxLength)
          {
              result.Add(str);
          }
      }

      result.Sort(); // tri alphabétique
      return result.ToArray();
  }

  
}