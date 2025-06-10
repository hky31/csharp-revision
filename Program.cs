using System;
using System.Collections.Generic;

namespace CSharpReview;

 public class Program {

    public static void Main (string[] args) {
        Console.WriteLine ("Hello World, let's review CSharp !");
        Console.WriteLine();
        Dictionary<string, List<double>> studentNotes = Dico.dicoNotes();
        Dico.displayDicoNotes(studentNotes);
        Console.WriteLine();
        Dictionary<string, double> averageNotes = Dico.calculateAverageGrades(studentNotes);
        Dico.displayNoTypeDico(averageNotes);
        Console.WriteLine();
    }
  }
