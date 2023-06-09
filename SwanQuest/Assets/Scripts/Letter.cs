using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : IInventoryItem
{
    public IInventoryItemInfo info { get; }
    public IInventoryItemState state { get; }

    public Type type => GetType();


    public Letter(IInventoryItemInfo info)
    {
        this.info = info;
        state = new InventoryItemState();
    }
    public IInventoryItem clone()
    {
        var clonedLetter = new Letter(info);
        clonedLetter.state.amount = state.amount;
        return clonedLetter;
        
    }
}
