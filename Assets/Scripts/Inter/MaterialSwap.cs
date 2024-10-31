using UnityEngine;

public class MaterialSwap : MonoBehaviour
{

    public Material newMaterial;

    bool isNewMaterialActive = false;
    Material oldMaterial;



    
    void Start()
    {
        oldMaterial = GetComponent<MeshRenderer>().material;
    }

   
    public void SwapMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        isNewMaterialActive = !isNewMaterialActive;

        if (isNewMaterialActive)
            meshRenderer.material = newMaterial;
        else
            meshRenderer.material = oldMaterial;
    }
}
