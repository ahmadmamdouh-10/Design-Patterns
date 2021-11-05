using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}


#region Design Patterns
/*
    * What is Design Patterns: 
    * ------------------------
    * - Best Practice to solve common software problems.
    * - Solutions in the form of templates that may be applied to real-world problems
    * - loosely coupled to make your software classes less dependent on each others.
    * - to practice with design patterns you need to know SOLID Principles.
    * 
    * 
    * - What is SOLID Principles?
    * 
    * - [S] --> Single Responsibility principle 
    *           [the class should solve only one problem it should have a single reason to change.]
    * 
    * - [O] --> Open/Closed principle
    *           [the class should be open for extension, closed for modifications]
    *           
    * - [L] --> Liskof Substitution Principle 
    *           [If you substitute any type with one of its subtypes, the behavior should not change]
    * 
    * - [I] --> Interface Segregation Principle 
    *           [Avoid making general interface contains all methods]
    *
    * - [D] --> Dependency Inversion Principle
    *           [Higher level Classes should not know the implementation of low level classes but 
    *            but depends on abstraction]
    *        
    *  The 23 Gang of Four (GoF) patterns are generally considered the foundation for all other patterns. 
    *  They are categorized in three groups: Creational, Structural, and Behavioral 
    *  (for a complete list see below). This reference provides source code for each of the 23 GoF patterns.
    *            
    *            
    *            
    * (A) Creational Design Patterns
    * 
    * 1- Abstract Factory : Creates an instance of several families of classes.
    * 2- Builder : Separates object construction from its representation
    * 3- Factory Method: Creates an instance of several derived classes
    * 4- Prototype: A fully initialized instance to be copied or cloned.
    * 5- Singleton: A class of which only a single instance can exist
    * 
    * 
    * 
    * (B) Structural Design Patterns
    * 
    * 1- Adapter: Match interfaces of different classes.
    * 2- Bridge: Separates an object's interface from its implementation.
    * 3- Composite: A tree structure of simple and composite objects.
    * 4- Decorator: Add responsibilities to objects dynamically.
    * 5- Facade: A single Class that represents an entire subsystem.
    * 6- Flyweight: A fine-grained instance used for efficient sharing 
    * 7- Proxy : An object representing another object.
    * 
    * (C) Behavioral Design Patterns
    * 
    * 
    */
#endregion

#region SOLID Principles


#region Single Responsibility Principle: (SRP)
/* 
    * - [S]-- > Single Responsibility principle
    *           [the class should solve only one problem it should have a single reason to change.]
    *
    * -Do one thing and do it well.
    * there should never be more than one reason for a class to change.
    *
   */
//this example of Class violates single responsibility:-  
//public class PaymentProcessor
//{
//    public void Charge(decimal amount)
//    {
//        //initialize bank data                             1
//        //second request to the bank
//    }

//    public string CreateReport()
//    {
//        //format a report                                   2
//        return string.Empty;
//    }

//    public void PrintReport()
//    {
//        //send a printing command                            3 
//    }

//    public void SavePayment()
//    {
//        //saving to DB                                       4 
//    }
//}

//this example of Function violates single responsibility:-  

//public string CustomerSalesReport(int customerID)
//{
//    //get customer data   //1
//    var customer = GetCustomerData(customerID);
//    // get customer Sales   //2
//    var sales = GetSalesByCustomerId(customerID);

//    //create report data  //3

//    string reportTitle = $"Sales Report For {customer.Name}";
//    string reportData = $"Report Time: {DateTime.Now}";
//    reportData = reportData + "Total Sales: {sales.Sum()}";
//    reportData = reportData + "Credit Balance: {sales.Sum(x=> x.Total) - sales.Sum(x=>x.Payment)}";

//    return reportData;
//}


// to solve it is to separate every functionality to a separate different classes.

#endregion

#region Open/Closed Principle: (OCP)
// the Open/Closed Principle states that software entities (classes, modules, functions, etc.)
// should be open for extension, but closed for modification.

// any new functionality should be done by adding new classes instead of changing existing one.

// How to implement OCP
//- One may achieve this by adding new functionality to derived class
//- or allow client to access the original class with abstract interface. 
#endregion

#region Liskov Substitution Principle: (LSP)

//If you have class B inherits from class A then class A should be replaceable by class B without any changes.
// it is the same as Polymorphism in OOP
#endregion

#region Interface Segregation Principle(ISP)

//Clients should not be forced to depend on methods they do not use.
// Agile Principles, Patterns and Practices in C#. Name of Book


// you need to divided your fat interface to mini separated interfaces that contains specific
// prototypes of methods or properties just for specific Class needs to implement from.


//1- Avoid fat Interface 
//2- Client must not implement unnecessary methods.
#endregion

#region Dependency Inversion Principle(DIP)

// High level modules should not depend upon low level modules.Both should depend upon abstractions.

// To make your software is loosely coupled. 

// Dependency Inversion to code it we will make a dependency Injection 

//  Dependency Injection is the practical coding use of Dependency Inversion.

// Dependency Injection considers as design pattern that I use to achieve dependency Inversion.

// There is three ways to use dependency injection: 
// 1- Constructor Injection:
// Use Class Constructor to pass your interface and equal it with the variable member of interface.
// 2- Method Injection:
//  
// 3- Property Injection:
//



#endregion



//What a good approach to create a solid design ? 
// 1- Each Class should have a single responsibility 
// 2- Each Class should be open to extension while closed to modification
// 3- Each Class Should be support Liskov substitution.
// 4- Each Class Should have segregated interfaces.
// 5- Each Class should be dependent on Abstractions.








#endregion

#region Monolothic
// Monolothic: 
#endregion

#region Microservices
//Microservices:

#endregion

#region Dependency Injection
// Dependency Injection is the practical coding use of Dependency Inversion.

// Dependency Injection considers as design pattern that I use to achieve dependency Inversion.

// There is three ways to use dependency injection: 
// 1- Constructor Injection:
// Use Class Constructor to pass your interface and equal it with the variable member of interface.
// 2- Method Injection:
//  
// 3- Property Injection:
//
#endregion

