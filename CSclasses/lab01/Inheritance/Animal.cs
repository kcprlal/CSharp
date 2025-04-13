using System;
using System.Data;

public class Animal{
    public string m_name; 
    protected int m_weight;
    private int m_age=111;
    //Sokro tutaj age jest private to klasy dziedziczące nie
    //mają dostępu do tego pola
    public Animal(string name, int weight){
        m_name = name;
        m_weight = weight;
    }

    public Animal(){
        m_name = "unknown";
        m_weight = 999;
    }
}