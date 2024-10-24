using UnityEngine;

[CreateAssetMenu(fileName = "Uhhh scriptable?", menuName = "Test/Cory shigma???")]
public class Item : ScriptableObject
{
    [Header("Variables")]
    public string ItemHeader;
    public Sprite Icon;
    public string ItemDescription;
    
    [Header("ToolTips")]
    public string TooltipDescription;
}
