using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SizeSelection : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public Material selectedMaterial;
    [SerializeField] public Material defaultMaterial;

    public Transform originalSize;
    public void OnSelect(Transform selection)
    {
        originalSize = selection.GetComponent<Transform>();
        var size = selection.GetComponent<Transform>();
        size.localScale *= .5f;
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.selectedMaterial;
        }

    }

    public void OnDeselect(Transform selection)
    {
        var size = selection.GetComponent<Transform>();
        size.localScale *= 2f;

        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = this.defaultMaterial;
        }
    }
}
