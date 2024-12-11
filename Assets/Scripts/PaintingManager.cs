using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;
using System;

public class PaintingManager : MonoBehaviour
{
    [SerializeField] ImageTargetBehaviour m_ImageTarget;
    [SerializeField] GameObject m_PaintingPlane;
    [SerializeField] TextMeshProUGUI m_PaintingName;
    [SerializeField] TextMeshProUGUI m_PaintingCreator;
    [SerializeField] Painting[] paintings;
    int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        //m_Painting = paintings[currentIndex];
        SetPainting(paintings[currentIndex]);
        
    }

    private void SetPainting(Painting m_Painting)
    {
        m_PaintingPlane.GetComponent<MeshRenderer>().material = m_Painting.p_Material;
        m_PaintingName.text = m_Painting.p_Name;
        m_PaintingCreator.text = m_Painting.p_Creator;
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
