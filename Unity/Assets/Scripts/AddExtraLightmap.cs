using UnityEngine;

public class AddExtraLightmap : MonoBehaviour
{
    public Texture2D extraLightmapTexture; // Assign your new lightmap texture (Lightmap 33)
    public int targetLightmapIndex = 33; // Set the new lightmap index (e.g., 33)
    public Renderer targetObject; // The object that will use the new lightmap

    void Start()
    {
        // Ensure the lightmap index doesn't exceed the available lightmaps array size
        if (LightmapSettings.lightmaps.Length > targetLightmapIndex)
        {
            Debug.LogWarning("This lightmap index is already in use. Please select a different one.");
            return;
        }

        // Step 1: Add the new lightmap texture to the LightmapSettings
        LightmapData[] currentLightmaps = LightmapSettings.lightmaps;

        // Create a new array with one more slot for the new lightmap
        LightmapData[] newLightmaps = new LightmapData[currentLightmaps.Length + 1];

        // Copy the existing lightmaps into the new array
        for (int i = 0; i < currentLightmaps.Length; i++)
        {
            newLightmaps[i] = currentLightmaps[i];
        }

        // Step 2: Create a new LightmapData and assign the new texture
        LightmapData newLightmapData = new LightmapData();
        newLightmapData.lightmapColor = extraLightmapTexture; // Set the lightmap texture (e.g., Lightmap 33)

        // Add the new LightmapData to the new array
        newLightmaps[newLightmaps.Length - 1] = newLightmapData;

        // Step 3: Update the LightmapSettings with the new lightmaps array
        LightmapSettings.lightmaps = newLightmaps;

        // Step 4: Assign the new lightmap to the target object
        if (targetObject != null)
        {
            targetObject.lightmapIndex = targetLightmapIndex;
        }
    }
}
