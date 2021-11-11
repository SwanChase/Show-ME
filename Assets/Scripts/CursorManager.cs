using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D globalCursor;
    public Texture2D shopCursor;

    void Start()
    {
        Cursor.SetCursor(globalCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void OnMouseEnter()
    {
        
    }

}
