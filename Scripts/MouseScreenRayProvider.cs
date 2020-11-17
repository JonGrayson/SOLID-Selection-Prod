using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Ray CreateRay()
    {
        return Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, .5f));
    }
}