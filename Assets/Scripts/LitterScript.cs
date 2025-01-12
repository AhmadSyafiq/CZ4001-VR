using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitterScript : MonoBehaviour
{

    [SerializeField] private GameObject litter;
    [SerializeField] private GameObject moreLitter;

    private int litterLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        UpdateLitterShown();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateLitterShown()
    {
        switch (litterLevel)
        {
            case 0:
                litter.SetActive(false);
                moreLitter.SetActive(false);
                break;
            case 1:
                litter.SetActive(true);
                moreLitter.SetActive(false);
                break;
            case 2:
                litter.SetActive(true);
                moreLitter.SetActive(true);
                break;
            default:
                litter.SetActive(true);
                moreLitter.SetActive(true);
                break;
        }       
    }

    public void SetLitterLevel(float level)
    {
        litterLevel = Mathf.RoundToInt(level);
        UpdateLitterShown();
    }
}
