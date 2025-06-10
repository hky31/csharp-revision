using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReview; 

// classe pour representer un noeud d'un arbre binaire
public class Node
{
    public int Value;
    public Node? Left;
    public Node? Right;

    public Node(int value)
    {
        Value = value;
    }
}

public class BinarySearchTree
{
    public Node? Root;

    // Insertion récursive
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private Node InsertRecursive(Node? node, int value)
    {
        if (node == null)
            return new Node(value);

        if (value < node.Value)
            node.Left = InsertRecursive(node.Left, value);
        else if (value > node.Value)
            node.Right = InsertRecursive(node.Right, value);

        return node;
    }

    // Parcours In-Order (gauche - racine - droite)
    public void InOrder()
    {
        InOrderRecursive(Root);
        Console.WriteLine();
    }

    private void InOrderRecursive(Node? node)
    {
        if (node == null) return;
        InOrderRecursive(node.Left);
        Console.Write(node.Value + " ");
        InOrderRecursive(node.Right);
    }

    // Recherche
    public bool Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(Node? node, int value)
    {
        if (node == null) return false;
        if (node.Value == value) return true;
        return value < node.Value
            ? SearchRecursive(node.Left, value)
            : SearchRecursive(node.Right, value);
    }

    // Affichage graphique de l’arbre
    public void PrintTree()
    {
        PrintRecursive(Root, "", true, isRoot: true); // Indique qu’on part de la racine
    }


    private void PrintRecursive(Node? node, string indent, bool isRight, bool isRoot = false)
    {
        if (node == null) return;

        if (!isRoot)
        {
            Console.Write(indent);
            Console.Write(isRight ? "└── " : "├── ");
        }

        Console.WriteLine(node.Value);

        indent += isRoot ? "" : (isRight ? "    " : "│   ");

        PrintRecursive(node.Left, indent, false);
        PrintRecursive(node.Right, indent, true);
    }

    // Calcul du nombre de feuilles d'un arbre binaire
    public int CountLeaves()
    {
        return CountLeavesRecursive(Root);
    }

    private int CountLeavesRecursive(Node? node)
    {
        if (node == null)
            return 0;

        if (node.Left == null && node.Right == null)
            return 1;

        return CountLeavesRecursive(node.Left) + CountLeavesRecursive(node.Right);
    }

    // Calcul de la hauteur de l’arbre binaire
    public int GetHeight()
    {
        return GetHeightRecursive(Root);
    }

    private int GetHeightRecursive(Node? node)
    {
        if (node == null)
            return 0;

        int leftHeight = GetHeightRecursive(node.Left);
        int rightHeight = GetHeightRecursive(node.Right);

        return 1 + Math.Max(leftHeight, rightHeight);
    }


}
/* test inside main program
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
  */