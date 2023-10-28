using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportCase
{
    public string Summary;
    public string Description;
    public enum Priority
    {
        Standard=0,
        High=1,
        Urgent=2
    }
}
