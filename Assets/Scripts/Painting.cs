using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName = "New Painting",menuName ="Custom Items/Paintings")]
public class Painting : ScriptableObject
{
    public string p_Name;
    public Material p_Material;
    public string p_Creator;
    [TextArea(3,30)]
    public string p_Description;
}
