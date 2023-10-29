using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class CaseManager : MonoBehaviour
{
    [Header ("Support Case Creation")]
    [SerializeField] private Button createSupportCase;
    [SerializeField] private Button submitSupportCase;
    
    [SerializeField] private GameObject startScreenPanel;
    [SerializeField] private GameObject newCasePanel;

    [SerializeField] private TMP_InputField caseSummary;
    [SerializeField] private TMP_InputField caseDescription;
    [SerializeField] private TMP_InputField firstName;
    [SerializeField] private TMP_InputField lastName;
    [SerializeField] private TMP_InputField emailAddress;

    [SerializeField] private TMP_Dropdown casePriority;

    private SupportCase newSupportCase = new SupportCase();

    public List<SupportCase> openCases = new List<SupportCase>();
    public List<SupportCase> closedCases = new List<SupportCase>();

    private void Awake()
    {
        //if (casePriority != null)
        //    casePriority.onValueChanged.AddListener(delegate { SelectCasePriority(casePriority, newSupportCase); });
    }

    public void DisplayPanel(GameObject panel)
    {
        if (panel != null) panel.SetActive(true);
    }

    public void HidePanel(GameObject panel)
    {
        if (panel != null) panel.SetActive(false);
    }

    public void SelectCasePriority ()
    {
        newSupportCase.CasePriority = (SupportCase.Priority)casePriority.value;
    }

    public void SubmitCase()
    {

        if (firstName != null) newSupportCase.FirstName = firstName.text;
        if (lastName != null) newSupportCase.LastName = lastName.text;
        if (emailAddress != null) newSupportCase.EmailAddress = emailAddress.text;
        if (caseSummary != null) newSupportCase.Summary = caseSummary.text;
        if (caseDescription != null) newSupportCase.Description = caseDescription.text;
        //if (casePriority != null) newSupportCase.CasePriority = (SupportCase.Priority)casePriority.value;


        openCases.Add(newSupportCase);

        Debug.Log($"List of support cases: " +
            $"{newSupportCase.FirstName}" +
            $"{newSupportCase.LastName} " +
            $"{newSupportCase.EmailAddress} " +
            $"{newSupportCase.Summary} " +
            $"{newSupportCase.Description} " +
            $"{newSupportCase.CasePriority} ");

    }


}
