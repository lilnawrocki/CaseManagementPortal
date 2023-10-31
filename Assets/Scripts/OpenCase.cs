using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenCase : MonoBehaviour
{
    [Header("Support Case Details")]
    [SerializeField] private TMP_Text detailsCaseIdTMP;
    [SerializeField] private TMP_Text detailsCaseSummaryTMP;
    [SerializeField] private TMP_Text detailsCaseDateTimeTMP;

    [Header("Controls")]
    [SerializeField] private Button viewCaseButton;

    private int _caseId;
    private string _caseSummary;
    private string _dateTime;

    public void SetCaseId(int caseId)
    {
        _caseId = caseId;
        if (detailsCaseIdTMP != null)
            detailsCaseIdTMP.text = caseId.ToString();
    }

    public void SetCaseSummary (string caseSummary)
    {
        _caseSummary = caseSummary;
        if (detailsCaseSummaryTMP != null)
            detailsCaseSummaryTMP.text = caseSummary;
    }

    public void SetCaseDateTime (string dateTime)
    {
        _dateTime = dateTime;
        if (detailsCaseDateTimeTMP != null)
            detailsCaseDateTimeTMP.text = dateTime;
    }

    public Button GetViewCaseButton()
    {
        return viewCaseButton;
    }

    public int GetCaseId()
    {
        return _caseId;
    }
}
