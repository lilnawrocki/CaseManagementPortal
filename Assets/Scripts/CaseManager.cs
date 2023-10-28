using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaseManager : MonoBehaviour
{
    [Header ("Support Case Creation")]
    [SerializeField] private Button createSupportCase;
    [SerializeField] private Button submitSupportCase;
    
    [SerializeField] private GameObject startScreenPanel;

    private void Awake()
    {
        
    }
}
