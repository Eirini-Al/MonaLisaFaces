using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PaintingManager : MonoBehaviour
{
    [Header("Painting Elements")]
    //[SerializeField] ImageTargetBehaviour m_ImageTarget;
    [SerializeField] GameObject m_PaintingPlane;
    [SerializeField] TextMeshProUGUI m_PaintingName;
    [SerializeField] TextMeshProUGUI m_PaintingCreator;
    [SerializeField] Painting[] paintings;
    [Space]
    [Header("Info Panel Elements")]
    [SerializeField] GameObject infoPanel;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] Button openInfoButton;
    [SerializeField] Button closeInfoButton;
    int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        CloseInfo();
        //m_Painting = paintings[currentIndex];
        SetPainting(paintings[currentIndex]);
        openInfoButton.onClick.AddListener(ShowInfo);
        closeInfoButton.onClick.AddListener(CloseInfo);
        
    }

    private void CloseInfo()
    {
        infoPanel.SetActive(false);
        openInfoButton.gameObject.SetActive(true);
        closeInfoButton.gameObject.SetActive(false);
    }

    private void ShowInfo()
    {
        infoPanel.SetActive(true);
        openInfoButton.gameObject.SetActive(false);
        closeInfoButton.gameObject.SetActive(true);
    }

    private void SetPainting(Painting m_Painting)
    {
        m_PaintingPlane.GetComponent<MeshRenderer>().material = m_Painting.p_Material;
        m_PaintingName.text = m_Painting.p_Name;
        m_PaintingCreator.text = m_Painting.p_Creator;
        infoText.text = m_Painting.p_Description;
    }


    public void MoveAlong(bool isForward)
    {
        if (isForward==true)
        {
            if (currentIndex < paintings.Length - 1) currentIndex++;
            else currentIndex = 0;
        }
        else
        {
            if (currentIndex > 0) currentIndex--;
            else currentIndex = paintings.Length - 1;
        }
        SetPainting(paintings[currentIndex]);
    }

}
