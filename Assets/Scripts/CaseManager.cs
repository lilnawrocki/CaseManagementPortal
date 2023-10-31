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

    [SerializeField] private TMP_InputField caseSummaryTMP;
    [SerializeField] private TMP_InputField caseDescriptionTMP;
    [SerializeField] private TMP_InputField firstNameTMP;
    [SerializeField] private TMP_InputField lastNameTMP;
    [SerializeField] private TMP_InputField emailAddressTMP;

    [SerializeField] private TMP_Dropdown casePriorityTMP;

    [Header ("Preview Support Case")]
    [SerializeField] private TMP_InputField previewCaseSummaryTMP;
    [SerializeField] private TMP_InputField previewCaseDescriptionTMP;
    [SerializeField] private TMP_InputField previewFirstNameTMP;
    [SerializeField] private TMP_InputField previewLastNameTMP;
    [SerializeField] private TMP_InputField previewEmailAddressTMP;
    [SerializeField] private TMP_InputField previewcasePriorityTMP;

    [Header("Instantiate")]
    [SerializeField] private GameObject detailsCasePanelPrefab;
    [SerializeField] private GameObject instantiateContentParent;

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

    public void SubmitCase()
    {

        if (firstNameTMP != null && lastNameTMP != null && emailAddressTMP != null && caseSummaryTMP != null && caseDescriptionTMP != null)
        {
            SupportCase newSupportCase = new SupportCase(openCases.Count, caseSummaryTMP.text, caseDescriptionTMP.text,
                (SupportCase.priority)casePriorityTMP.value, firstNameTMP.text, lastNameTMP.text, emailAddressTMP.text, System.DateTime.Now.ToString());

            openCases.Add(newSupportCase);
        }  

        HidePanel(newCasePanel);

        Debug.Log($"{System.DateTime.Now}");

        addCaseDetailsPanel();

    }

    private void clearInputField(TMP_InputField tMP_InputField)
    {
        if (tMP_InputField != null)
            tMP_InputField.text.Equals("");
    }

    private void addCaseDetailsPanel()
    {
        GameObject newCaseDetailsPanel = Instantiate(detailsCasePanelPrefab, instantiateContentParent.transform);
    }

    public void LoadCaseData(int caseId)
    {
        if (previewFirstNameTMP != null && previewLastNameTMP != null && previewEmailAddressTMP != null &&
            previewCaseSummaryTMP != null && previewCaseDescriptionTMP != null && previewcasePriorityTMP != null)
        {
            previewFirstNameTMP.text = openCases[caseId].firstName;
            previewLastNameTMP.text = openCases[caseId].lastName;
            previewEmailAddressTMP.text = openCases[caseId].emailAddress;
            previewCaseSummaryTMP.text = openCases[caseId].summary;
            previewCaseDescriptionTMP.text = openCases[caseId].description;
            previewcasePriorityTMP.text = openCases[caseId].casePriority.ToString();
        }

            
    }


}
