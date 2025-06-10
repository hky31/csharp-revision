using System;

namespace CSharpReview; 

// classe pour representer un compte bancaire
public class BankAccount {
  private string accountNumber;
  private double balance;
  private Person owner;

  // constructeur par defaut
  public BankAccount(string accountNumber, double balance, Person owner) {
    this.accountNumber = accountNumber;
    this.balance = balance;
    this.owner = owner;
  }

  // getters et setters
  public string AccountNumber {
    get => accountNumber;
    set => accountNumber = value;
  }
  public double Balance {
    get => balance;
    set => balance = value;
  }
  public Person Owner {
      get => owner;
      set => owner = value;
  }

  // methodes pour gerer le compte bancaire
  public void Deposit(double amount) {
    this.balance += amount;
  }
  public void Withdraw(double amount) {
    if(this.balance > amount)
    this.balance -= amount;
  }
  public void DisplayAccountInfo() {
    Console.WriteLine("Account Number: {0}, Balance: {1}, Owner: {2}", this.accountNumber, this.balance, this.owner.Name);
  }
}