using UnityEngine;

public class SupportCase
{
    public int caseId;
    public string summary;
    public string description;
    public enum priority
    {
        Standard=0,
        High=1,
        Urgent=2
    }
    public priority casePriority;
    public string firstName;
    public string lastName;
    public string emailAddress;
    public string dateTime;

    public SupportCase() { }

    public SupportCase(int caseId, string summary, string description, priority priority,
        string firstName, string lastName, string emailAddress, string dateTime)
    {
        this.caseId = caseId;
        this.summary = summary;
        this.description = description;
        this.casePriority = priority;
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateTime = dateTime;
    }

}
