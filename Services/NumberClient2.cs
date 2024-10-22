using System;
using DependInj2.Services;
using Microsoft.AspNetCore.Http.HttpResults;

public class NumberClient2 : INumberService{
    public int random2=new Random().Next(20,30);
    public int GenerateNumber(){
      //  var tt=Guid.NewGuid();
        Console.WriteLine("This is the Numberclient 2 another implementation of the interface");
        
        return random2;
    }
}