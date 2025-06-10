using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview; 

// classe pour representer des personnes
public class Person {
  private string name;
  private int age;

// constructeur par defaut
  public Person(string name, int age){
    this.name = name;
    this.age = age;
  }

    // getters et setters
  public string Name {
      get => name;
      set => name = value;
  }

  public int Age
  {
      get => age;
      set
      {
          if ((value > 0) && (value < 100))
          {
              age = value;
          }
      }
  }

    // methode pour afficher les infos d'une personne
  public void SayHello(){
    Console.WriteLine("Hello, my name is {0} and I am {1} years old", this.name, this.age);
  }

    // methode pour creer une liste de personnes
    public static List<Person> createListPerson(){
      List<Person> listPerson = new List<Person>();
      listPerson.Add(new Person("Horty", 27));
      listPerson.Add(new Person("Ponce", 33));
      listPerson.Add(new Person("Zera", 35));
      listPerson.Add(new Person("HugoDecrypt", 31));
      listPerson.Add(new Person("P-A", 31));
      listPerson.Add(new Person("Ana", 28));
      listPerson.Add(new Person("Lye", 29));
      listPerson.Add(new Person("LittleBigWhale", 30));
      listPerson.Add(new Person("Hiuugs", 38));
      listPerson.Add(new Person("Laam", 42));
      return listPerson;
    }

    // methode pour afficher une liste de personnes
    public static void displayListPerson(List<Person> listPerson) {
     foreach(Person p in listPerson) {
       p.SayHello();
     }
    }

    // methode pour afficher une liste de personnes commencant par 1 lettre
    public static void displayListPersonByLetter(List<Person> listPerson, char letter) {
        List<Person> sortedListPerson = listPerson.OrderBy(p => p.Name).ToList();
          List<Person> listPersonDisplayed = new List<Person>();
        foreach (Person p in sortedListPerson) {
            if (p.Name.StartsWith(letter)) {
                listPersonDisplayed.Add(p);
            }
        }
        if(listPersonDisplayed.Count > 0) {
            displayListPerson(listPersonDisplayed);
        }
        else {
            Console.WriteLine("No person found with the letter {0}", letter);
        }
    }

    // methode pour afficher une liste de personnes en dessous d'un certain age
    public static void displayListPersonUnderAge(List<Person> listPerson, int age) {
       List<Person> listPersonDisplayed = new List<Person>();
        List<Person> sortedListPerson = listPerson.OrderBy(p => p.Age).ToList();
        foreach (Person p in sortedListPerson) {
            if(p.Age < age) {
                listPersonDisplayed.Add(p);
            }
        }
        if (listPersonDisplayed.Count > 0) {
            displayListPerson(listPersonDisplayed);
        }
        else {
            Console.WriteLine("No person found under the age of {0}", age);
        }
    }

    // methode pour calculer l'age moyen d'une liste de personnes
    public static int averageAge(List<Person> listPerson) {
        int avgAge = 0;
        foreach (Person p in listPerson) {
            avgAge += p.Age;
        }
        return avgAge / listPerson.Count;
    }
}


  /*
  Person.displayListPerson(Person.createListPerson());
  Console.WriteLine("----------------------------------------");
  Person.displayListPersonByLetter(Person.createListPerson(), 'H');
  Console.WriteLine("----------------------------------------");
  Person.displayListPersonUnderAge(Person.createListPerson(), 30);
  Console.WriteLine("----------------------------------------");
  Console.WriteLine("The average age of this group is : {0}",                 Person.averageAge(Person.createListPerson()));
  */