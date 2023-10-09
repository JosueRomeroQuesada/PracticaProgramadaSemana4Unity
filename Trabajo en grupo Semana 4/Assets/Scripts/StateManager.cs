using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    string _name;
    float _prize;

    public string getName() 
    {
        return _name;
    }

    public void setName(string newName) 
    {
        _name = newName;
    
    }

    public float getPrize() 
    {
        return _prize;
    }
    public void setPrize(float newPrize) 
    {
        _prize = newPrize;
    }
}










