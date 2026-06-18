using UnityEngine;

public class LightmapSwapper : MonoBehaviour
{
    public Renderer targetObject; // Drag the object in the Inspector.
    public int newLightmapIndex; // Assign the desired lightmap index here.
    public Vector4 newLightmapScaleOffset; // Assign the new lightmap scale and offset here.

    // Call this method to swap the lightmap
    public void SwapLightmap()
    {
        if (targetObject != null)
        {
            // Set the new lightmap index
            targetObject.lightmapIndex = newLightmapIndex;

            // Set the new lightmap scale and offset
            targetObject.lightmapScaleOffset = newLightmapScaleOffset;

            Debug.Log($"Lightmap for {targetObject.name} swapped to index {newLightmapIndex}");
        }
        else
        {
            Debug.LogWarning("Target object not assigned!");
        }
    }
}
