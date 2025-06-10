using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview; 

// classe pour representer un dictionnaire et des revisions
public class Dico {

  // Creation d'un dictionnaire de capitales
  public static Dictionary<string, string> dicoCapitales(){
    Dictionary<string, string> capitales = new Dictionary<string, string>();
    capitales.Add("Paris", "France");
    capitales.Add("Sydney", "Australie");
    capitales.Add("Auckland", "New-Zealand");
    capitales.Add("Londres", "Royaume-Uni");
    capitales.Add("Tokyo", "Japon");
    capitales.Add("Seoul", "Corée du Sud");
    capitales.Add("Pékin", "Chine");
    capitales.Add("Moscou", "Russie");
    capitales.Add("Berlin", "Allemagne");
    capitales.Add("Madrid", "Espagne");
    capitales.Add("Rome", "Italie");
    capitales.Add("Copenhague", "Danemark");
    capitales.Add("Helsinki", "Finlande");
    capitales.Add("Stockholm", "Suède");
    capitales.Add("Oslo", "Norvège");
    capitales.Add("Ottawa", "Canada");
    capitales.Add("Washington", "États-Unis");
    capitales.Add("Mexico", "Mexique");
    capitales.Add("Buenos Aires", "Argentine");
    capitales.Add("Rio de Janeiro", "Brésil");
    capitales.Add("Taipei", "Taïwan");
    capitales.Add("Bangkok", "Thaïlande");
    capitales.Add("Manille", "Philippines");
    
    return capitales;
  }

  // Afficher le dictionnaire
  public static void displayDico(Dictionary<string, string> dico) {
    foreach (KeyValuePair<string, string> capitale in dico) {
        Console.WriteLine($"Pays : {capitale.Key} / Capitale : {capitale.Value}");
    }
  }

  // Afficher le dictionnaire generique
  public static void displayNoTypeDico<TKey, TValue>(Dictionary<TKey, TValue> dico) {
    foreach (KeyValuePair<TKey, TValue> item in dico) {
        Console.WriteLine($"Key : {item.Key} / Value : {item.Value}");
    }
  }

  // Rechercher la capitale d'un pays
  public static string searchPaysByCapitale(Dictionary<string, string> dico, string capitale) {
    if (dico.ContainsKey(capitale)) {
        return dico[capitale];
    } else {
        return "Pays non trouvé.";
    }
  }
    // Rechercher le pays d'une capitale
  public static string searchCapitaleByPays(Dictionary<string, string> dico, string pays) {
    if (dico.ContainsValue(pays)) {
      // string capitale = "";
      // if(dico.TryGetValue(pays, out capitale)){
      //  return capitale;
      //}
        return dico.FirstOrDefault(x => x.Value == pays).Key;
    } else {
        return "Capitale non trouvée.";
    }
  }

    // Compter le nombre d'occurences de chaque mot dans une phrase
  public static Dictionary<string, int> countWords(string words) {
    string[] wordsArray = words.ToLower().Split(' ');
    Dictionary<string, int> wordCount = new Dictionary<string, int>();
    foreach (string word in wordsArray) {
        if (wordCount.ContainsKey(word)) {
            wordCount[word]++;
        } else {
            wordCount[word] = 1;
        }
    }
    return wordCount;
  }

    // Creation d'un dictionnaire de prix
    public static Dictionary<string, double> dicoPrices() {
      Dictionary<string, double> dicoPrices = new Dictionary<string, double>();
        dicoPrices.Add("Brioche", 1.5);
        dicoPrices.Add("Croissant", 1.2);
        dicoPrices.Add("Chocolat", 1.8);
        dicoPrices.Add("Steak", 1.0);
        dicoPrices.Add("Poulet", 1.0);
        dicoPrices.Add("Camembert", 1.3);
        dicoPrices.Add("Yaourt", 1.6);
        dicoPrices.Add("Emmental", 1.4);
        dicoPrices.Add("Riz", 0.7);
        dicoPrices.Add("Pâtes", 0.8);
        Console.WriteLine("Dictionnaire des prix : ");
        return dicoPrices;
    }

    // Creation d'un dictionnaire d'etudiants et leurs notes
    public static Dictionary<string, List<double>> dicoNotes() {
        Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
        List<double> gradeA = new List<double> { 12.5, 15.0, 13.5 };
        List<double> gradeB = new List<double> { 14.0, 16.0, 14.5 };
        List<double> gradeC = new List<double> { 10.0, 11.0, 12.0 };
        List<double> gradeD = new List<double> { 18.0, 19.0, 17.5 };
        List<double> gradeE = new List<double> { 9.0, 8.5, 10.5 };
        studentGrades.Add("Alice", gradeA);
        studentGrades.Add("Bob", gradeB);
        studentGrades.Add("Charlie", gradeC);
        studentGrades.Add("David", gradeD);
        studentGrades.Add("Eve", gradeE);
        return studentGrades;
    }
    // Calculer la moyenne des notes d'un dictionnaire des etudiants
    public static Dictionary<string, double> calculateAverageGrades(Dictionary<string, List<double>> dicoNotes) {
        Dictionary<string, double> averageGrades = new Dictionary<string, double>();
        foreach (KeyValuePair<string, List<double>> student in dicoNotes) {
            double average = student.Value.Average();
            averageGrades.Add(student.Key, Math.Round(average,2));
        }
        return averageGrades;
    }
    // ajoute une note a un etudiant
    public static Dictionary<string, double> addGrade(Dictionary<string, List<double>> dicoNotes, string student, double grade) {
        if (dicoNotes.ContainsKey(student)) {
            dicoNotes[student].Add(grade);
        }
        return dicoNotes;
    }
    // ajoute une liste de notes et un etudiant au dictionnaire
    public static Dictionary<string, double> addStudentGrades(Dictionary<string, List<double>> dicoNotes, string student, List<double> grades) {
        dicoNotes.Add(student, grades);
        return dicoNotes;
    }
    // affiche le dictionnaire des etudiants et leurs notes
    public static void displayDicoNotes(Dictionary<string, List<double>> dicoNotes) {
        foreach (KeyValuePair<string, List<double>> student in dicoNotes) {
            Console.WriteLine($"Student : {student.Key} / Notes : [  {string.Join(", ", student.Value)} ]");
        }
    }
}


  /* test inside main program
    Dictionary<string, string> capitales = Dico.dicoCapitales();
  Dico.displayDico(capitales);
    //Dico.displayNoTypeDico(capitales);

  Console.Write("Entrez un pays : ");
  string inputPays = Console.ReadLine();

  if (string.IsNullOrEmpty(inputPays))
  {
      Console.WriteLine("Vous n'avez rien saisi.");
  }
  else
  {
      string capitale = Dico.searchCapitaleByPays(capitales, inputPays);
      Console.WriteLine($"La capitale de {inputPays} est : {capitale} !");
  }

  Console.Write("Entrez une capitale : ");
  string inputCapitale = Console.ReadLine();

  if (string.IsNullOrEmpty(inputCapitale))
  {
      Console.WriteLine("Vous n'avez rien saisi.");
  }
  else
  {
      string pays = Dico.searchPaysByCapitale(capitales, inputCapitale);
      Console.WriteLine($"{inputCapitale} est la capitale de {pays} !");
  }
    */
    /*string words = "Bonjour tout le monde, bonjour le monde, bonjour toute la classe";
    Console.WriteLine(words.ToLower());
    Console.Write("Entrez une phrase : ");
    string inputPhrase = Console.ReadLine();
    Dictionary<string, int> wordCount = Dico.countWords(inputPhrase);
    Dico.displayNoTypeDico(wordCount);*/

/*Dictionary<string, double> dicoPrices = Dico.dicoPrices();
Dico.displayNoTypeDico(dicoPrices);
Console.WriteLine();
dicoPrices.Add("Chips", 1.3);
Dico.displayNoTypeDico(dicoPrices);
Console.WriteLine();
dicoPrices.Remove("Pâtes");
Dico.displayNoTypeDico(dicoPrices);
Console.WriteLine();
dicoPrices["Brioche"] = 1.6;
Dico.displayNoTypeDico(dicoPrices);
Console.WriteLine();*/


